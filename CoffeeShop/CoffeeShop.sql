CREATE DATABASE CoffeeShop
GO

USE CoffeeShop
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL DEFAULT 0	-- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	discount INT DEFAULT 0,
	TotalPrice FLOAT DEFAULT 0

	FOREIGN KEY (idTable) REFERENCES TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES Food(id)
)
GO

INSERT INTO dbo.Account (UserName, DisplayName, PassWord, Type)
VALUES 
	(N'TRONGHIEU', N'TRONG HIEU', N'123', 1),
	(N'THIHA', N'THI HA', N'123', 1),
	(N'STAFF', N'STAFF', N'123', 0)
SELECT * FROM dbo.Account
GO

CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username
END
GO

EXEC USP_GetAccountByUserName @userName = N'TRONGHIEU'
GO

CREATE PROC USP_Login
@userName NVARCHAR(100),
@password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @password
END
GO

EXEC USP_Login @userName = N'TRONGHIEU', @password = N'123'

------------------------------ CHẠY CỤM NÀY ĐỂ TẠO BÀN NHANH ---------------------------------
DECLARE @i INT = 1
WHILE @i <= 17
BEGIN
	INSERT TableFood(name) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO
----------------------------------------------------------------------------------------------

SELECT * FROM TableFood
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM TableFood
GO

EXEC USP_GetTableList
GO

INSERT FoodCategory(name) 
VALUES
	(N'Hải sản'),
	(N'Đồ nướng'),
	(N'Nước ngọt')

INSERT Food(name, idCategory, price)
VALUES
	(N'Ốc nhồi thịt', 1, 30000),
	(N'Nghêu hấp xả', 1, 20000),
	(N'Mực một nắng nướng sa tế', 2, 120000),
	(N'Heo rừng nướng muối ớt', 2, 50000),
	(N'Coca', 3, 10000),
	(N'Pepsi', 3, 10000),
	(N'7Up', 3, 10000)

INSERT Bill(DateCheckIn, DateCheckOut, idTable, status)
VALUES 
	(GETDATE(), NULL, 1, 0),
	(GETDATE(), NULL, 2, 0),
	(GETDATE(), GETDATE(), 2, 1)	

INSERT BillInfo(idBill, idFood, count)
VALUES 
	(1, 1, 2),
	(1, 3, 4),
	(1, 5, 1),
	(2, 1, 2),
	(2, 6, 3),
	(3, 1, 2),
	(3, 5, 1)

SELECT * FROM Bill
SELECT * FROM BillInfo
SELECT * FROM Food
SELECT * FROM FoodCategory
GO

CREATE PROC USP_GetUncheckBillsByTableID
@tableID INT
AS
BEGIN
	SELECT * FROM Bill WHERE idTable = @tableID AND status = 0
END
GO

EXEC USP_GetUncheckBillsByTableID 1
GO

CREATE PROC USP_GetBillInfosByBillID
@billID INT
AS
BEGIN
	SELECT * FROM BillInfo WHERE idBill = @billID
END
GO

EXEC USP_GetBillInfosByBillID 2
GO

CREATE PROC USP_GetMenuByBillID
@billID INT
AS
BEGIN
	SELECT Food.name, Food.price, BillInfo.count FROM BillInfo
	JOIN Bill ON BillInfo.idBill = Bill.id
	JOIN Food ON BillInfo.idFood = Food.id
	WHERE BillInfo.idBill = @billID
END
GO

EXEC USP_GetMenuByBillID 2
GO

CREATE PROC USP_GetAllCategory
AS SELECT * FROM FoodCategory
GO

EXEC USP_GetAllCategory
GO

CREATE PROC USP_GetFoodByCategoryID
@catID INT
AS
BEGIN
	SELECT * FROM Food WHERE Food.idCategory = @catID
END
GO

EXEC USP_GetFoodByCategoryID 3
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	IF (NOT EXISTS(SELECT * FROM Bill WHERE idTable = @idTable AND status = 0))
	BEGIN
		INSERT Bill(DateCheckIn, DateCheckOut, idTable, status, discount)
		VALUES (GETDATE(), NULL, @idTable, 0, 0)
	END
END
GO

EXEC USP_InsertBill 1
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistsBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExistsBillInfo = id, @foodCount = count FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExistsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE BillInfo
			SET count = @newCount
			WHERE idBill = @idBill AND idFood = @idFood
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT BillInfo(idBill, idFood, count)
		VALUES (@idBill, @idFood, @count)
	END
END
GO

EXEC USP_InsertBillInfo 1, 1, 1
GO

CREATE PROC USP_CheckoutBill
@billID INT, @discount INT, @totalPrice FLOAT
AS
BEGIN
	UPDATE Bill
	SET status = 1, discount = @discount, DateCheckOut = GETDATE(), TotalPrice = @totalPrice
	WHERE id = @billID
END
GO

EXEC USP_CheckoutBill 1
GO

-- Khi thêm mới hoặc cập nhật billInfo thì thay đổi trạng thái của bàn
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status = 0

	UPDATE TableFood SET status = N'Có người' WHERE id = @idTable
END
GO	

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM Bill WHERE idTable = @idTable AND status = 0

	IF (@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable
END
GO 

SELECT * FROM Bill

CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT TableFood.name AS [Tên bàn], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá], TotalPrice AS [Tổng tiền]
	FROM Bill 
	JOIN TableFood ON Bill.idTable = TableFood.id
	WHERE Bill.status = 1 AND Bill.DateCheckIn >= @checkIn AND Bill.DateCheckOut <= @checkOut
END
GO

EXEC USP_GetAccountByUserName N'TrongHieu'
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName AND Password = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
			UPDATE Account SET DisplayName = @displayName WHERE Username = @userName
		ELSE
			UPDATE Account SET DisplayName = @displayName, Password = @newPassword WHERE Username = @userName
	END
END
GO

CREATE PROC USP_GetAllFood
AS SELECT * FROM Food
GO

-- EXEC USP_GetAllFood
-- GO

CREATE PROC USP_GetCategoryByID
@id INT
AS
BEGIN
	SELECT * FROM FoodCategory WHERE id = @id
END
GO

-- EXEC USP_GetCategoryByID 1
-- GO

CREATE PROC USP_InsertFood
@name NVARCHAR(100), @idCategory INT, @price FLOAT
AS
BEGIN
	IF (EXISTS (SELECT * FROM FoodCategory WHERE id = @idCategory))
	BEGIN
		INSERT Food(name, idCategory, price)
		VALUES (@name, @idCategory, @price)
	END
END
GO

CREATE PROC USP_UpdateFood
@id INT, @name NVARCHAR(100), @idCategory INT, @price FLOAT
AS
BEGIN
	IF (EXISTS (SELECT * FROM FoodCategory WHERE id = @idCategory))
	BEGIN
		UPDATE Food
		SET name = @name, idCategory = @idCategory, price = @price
		WHERE id = @id
	END
END
GO

CREATE PROC USP_DeleteBillInfoByFoodID
@foodID INT
AS
BEGIN
	DELETE BillInfo WHERE idFood = @foodID
END
GO

-- EXEC USP_DeleteBillInfoByFoodID 1
-- GO

CREATE PROC USP_DeleteFood
@id INT
AS
BEGIN
	EXEC USP_DeleteBillInfoByFoodID @id
	DELETE Food WHERE id = @id
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = deleted.idBill FROM deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM BillInfo 
								JOIN Bill ON Bill.id = BillInfo.idBill
								WHERE Bill.id = @idBill AND status = 0
	IF (@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE PROC USP_SearchFoodByName
@name NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Food WHERE dbo.fuConvertToUnsign1(name) LIKE '%'+ dbo.fuConvertToUnsign1(@name) +'%'
END
GO 

CREATE PROC USP_GetAllAccount
AS
BEGIN
	SELECT UserName, DisplayName, Type FROM Account
END
GO

CREATE PROC USP_CreateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @type INT
AS
BEGIN
	IF (NOT EXISTS(SELECT * FROM Account WHERE UserName = @userName))
	BEGIN
		INSERT Account(UserName, DisplayName, Type, PassWord)
		VALUES (@userName, @displayName, @type, 'password')
	END
END
GO

CREATE PROC USP_UpdateAccountAdmin
@userName NVARCHAR(100), @displayName NVARCHAR(100), @type INT
AS
BEGIN
		UPDATE Account 
		SET DisplayName = @displayName, Type = @type
		WHERE UserName = @userName
END
GO

CREATE PROC USP_DeleteAccount
@userName NVARCHAR(100)
AS
BEGIN
	DELETE Account WHERE UserName = @userName
END
GO

CREATE PROC USP_ResetPassword
@userName NVARCHAR(100)
AS
BEGIN
	UPDATE Account
	SET PassWord = 'password'
	WHERE UserName = @userName
END 
GO

CREATE PROC USP_CategoryInsert
@name NVARCHAR(100)
AS
BEGIN
	IF (NOT EXISTS (SELECT * FROM FoodCategory WHERE name = @name))
		INSERT FoodCategory(name) VALUES (@name)
END
GO

CREATE PROC USP_CategoryUpdate
@id INT, @name NVARCHAR(100)
AS
BEGIN
	UPDATE FoodCategory
	SET name = @name
	WHERE id = @id
END
GO

CREATE PROC USP_TableInsert
@name NVARCHAR(100)
AS
BEGIN
	IF (NOT EXISTS(SELECT * FROM TableFood WHERE name = @name))
		INSERT TableFood(name) VALUES (@name)
END
GO

CREATE PROC USP_TableUpdate
@id INT, @name NVARCHAR(100), @status NVARCHAR(100)
AS
BEGIN
	UPDATE TableFood
	SET name = @name, status = @status
	WHERE id = @id
END
GO