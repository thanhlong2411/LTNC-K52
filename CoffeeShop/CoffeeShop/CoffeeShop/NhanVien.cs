using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class NhanVien : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True");
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }
        void LoadData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Employee", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
            con.Close();
        }

    
        byte[] ImageToByteArray(Image img1)
        {
            MemoryStream m = new MemoryStream();
            img1.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void btnAddAcc_Click_1(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Employee values(@HoTen,@NgaySinh,@GioiTinh,@ChucVu,@DiaChi,@HinhAnh)", con);
           // cmd.Parameters.Add("@IdNhanVien", txt1.Text);
            cmd.Parameters.Add("@HoTen", textBox2.Text);
            cmd.Parameters.Add("@NgaySinh", time.Value);
            cmd.Parameters.Add("@GioiTinh", textBox3.Text);
            cmd.Parameters.Add("@ChucVu", textBox4.Text);
            cmd.Parameters.Add("@DiaChi", textBox5.Text);
            cmd.Parameters.Add("@HinhAnh", b);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Lưu về cơ sở dư liệu đã thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Image ImageToByteArray(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            txt1.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            textBox2.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            time.Value = DateTime.Parse(dgvNhanVien.Rows[r].Cells[2].Value.ToString());
            textBox3.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            textBox4.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            textBox5.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            byte[] b = (byte[])dgvNhanVien.Rows[r].Cells[6].Value;
            pictureBox1.Image = ImageToByteArray(b);
        }

        private void btnViewAcc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            con.Open(); 
            SqlCommand cmd = new SqlCommand("Update  Employee SET HoTen = @HoTen,NgaySinh = @NgaySinh,GioiTinh=@GioiTinh,ChucVu=@ChucVu,DiaChi=@DiaChi,HinhAnh=@HinhAnh ", con);
            cmd.Parameters.Add("@HoTen", textBox2.Text);
            cmd.Parameters.Add("@NgaySinh", time.Value);
            cmd.Parameters.Add("@GioiTinh", textBox3.Text);
            cmd.Parameters.Add("@ChucVu", textBox4.Text);
            cmd.Parameters.Add("@DiaChi", textBox5.Text);
            cmd.Parameters.Add("@HinhAnh", b);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Cập Nhập về cơ sở dư liệu đã thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                byte[] b = ImageToByteArray(pictureBox1.Image);
                string SQL;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True");
                SQL = " Delete from Employee  where IdNhanVien = N'" + txt1.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                LoadData();
            }
        }
    }
}
