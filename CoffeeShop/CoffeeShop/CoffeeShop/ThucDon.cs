using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.DAO;
using CoffeeShop.DTO;
using System.IO;
using System.Data.SqlClient;


namespace CoffeeShop
{
	public partial class ThucDon : UserControl
	{
		BindingSource foodList = new BindingSource();
		//SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True");
		public ThucDon()
		{
			InitializeComponent();
			
		}

		//void LoadData()
		//{
		//	con.Open();
		//	SqlCommand cmd = new SqlCommand("Select * From Food2", con);
		//	DataTable dt = new DataTable();
		//	SqlDataAdapter da = new SqlDataAdapter(cmd);
		//	da.Fill(dt);
		//	dgvFood.DataSource = dt;
		//	con.Close();
		//}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
			openFile.FilterIndex = 1;
			openFile.RestoreDirectory = true;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFile.FileName);
				this.Text = openFile.FileName;
			}
		}
		//byte[] ImageToByteArray(Image img1)
		//{
		//	MemoryStream m = new MemoryStream();
		//	img1.Save(m, System.Drawing.Imaging.ImageFormat.Png);
		//	return m.ToArray();
		//}
		//Image ImageToByteArray(byte[] b)
		//{
		//	MemoryStream m = new MemoryStream(b);
		//	return Image.FromStream(m);
		//}

		private void ThucDon_Load(object sender, EventArgs e)
		{
			LoadState();
			//LoadData();
			//LoadCategoryIntoCombobox(cbFoodCategory);
		}
        void LoadState()
        {
            dgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
        }
            void LoadCategoryIntoCombobox(ComboBox cb)
		{
			cb.DataSource = CategoryDAO.Instance.GetListCategory();
			cb.DisplayMember = "Name";
			cb.ValueMember = "ID";
		}
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            // DataSourceUpdateMode.Never: đi 1 luồng, one way binding
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtFoodId.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            cbFoodCategory.DataBindings.Add(new Binding("SelectedValue", dgvFood.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));

        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
			LoadListFood();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            #region image
            //byte[] b = ImageToByteArray(pictureBox1.Image);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Food values(@name,@idCategory,@price,@image )", con);
            //cmd.Parameters.Add("@id", txtFoodId.Text);
            //cmd.Parameters.Add("@name", txtFoodName.Text);
            //cmd.Parameters.Add("@idCategory", cbFoodCategory.Text);
            //cmd.Parameters.Add("@price", nmFoodPrice.Text);
            //cmd.Parameters.Add("@image", b);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //LoadData();
            //MessageBox.Show("Lưu về cơ sở dư liệu đã thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
            string name = txtFoodName.Text;
            int categoryID = (int)cbFoodCategory.SelectedValue;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                insertFood?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryID = (int)cbFoodCategory.SelectedValue;
            float price = (float)nmFoodPrice.Value;
            int foodID = int.Parse(txtFoodId.Text);

            if (FoodDAO.Instance.UpdateFood(foodID, name, categoryID, price))
            {
                MessageBox.Show("Cập nhật món thành công");
                LoadListFood();
                updateFood?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật món");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int foodID = int.Parse(txtFoodId.Text);

            if (FoodDAO.Instance.Delete(foodID))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                deleteFood?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
        }
    }
}
