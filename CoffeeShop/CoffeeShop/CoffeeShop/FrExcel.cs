using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using xls = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using MathNet.Numerics.LinearRegression;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class FrExcel : Form
    {
        int column;
        int date_col;

        SqlConnection GetConnection;
        #region ketnoicsdl
        private void KetnoiCSDL()
        {
            GetConnection = new SqlConnection(dataConStr);
            GetConnection.Open();
        }
        private void NgatKetNoi()
        {
            GetConnection.Close();
            GetConnection.Dispose();
        }

        public DataTable ExecQuery(string query)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(query, GetConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();

            return dt;
        }
        public void ExecNonQuery(string query)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(query, GetConnection);
            cmd.ExecuteNonQuery();
            NgatKetNoi();
        }
        #endregion
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        //public string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        //public string OLEDB12 = "Microsoft.ACE.OLEDB.12.0";

        string dataConStr = @"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=ThongKeExcel;Integrated Security=True";
        DataTable dt;

        string fileConStr = string.Empty;//chu?i k?t n?i d?n file
        string filepath;//du?ng d?n d?n file
        string extension;//ph?n m? r?ng c?a file
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();//d?i tu?ng luu tr? file Excel
        public FrExcel()
        {
            InitializeComponent();
        }

        private void FrExcel_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            xls.Application xlApp = new xls.Application();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files | *.xls?";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filepath = dlg.FileName;
                xls.Workbook excelBook = xlApp.Workbooks.Open(filepath);
                cbbSheet.Items.Clear();
                int i = 0;
                foreach (xls.Worksheet wSheet in excelBook.Worksheets)
                {
                    cbbSheet.Items.Add(wSheet.Name.ToString());
                    i++;
                }
                extension = Path.GetExtension(filepath);
                textBox1.Text = filepath.ToString();

                switch (extension)
                {
                    case ".xls":
                        fileConStr = string.Format(Excel03ConString, filepath);
                        break;
                    case ".xlsx":
                        fileConStr = string.Format(Excel07ConString, filepath);
                        break;
                }

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OleDbConnection cn = new OleDbConnection(fileConStr))
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from [" + cbbSheet.Text + "$]", cn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dt = new System.Data.DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void btnSaveDb_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Ghi dữ liệu thành công!");
           ExecNonQuery($"DROP TABLE {cbbSheet.Text};" +
           $"SELECT * INTO {cbbSheet.Text} FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0'," +
           $"'Excel 12.0;Database={filepath}'," +
           $"'SELECT * FROM [{cbbSheet.Text}$]')");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            column = e.ColumnIndex;
            var dt = (DataTable)dataGridView1.DataSource;
            label1.Text = dt.Columns[column].ColumnName;
        }

        private void btnRegressionF_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].DataType == typeof(DateTime))
                {
                    date_col = i;
                    break;
                }
            }

            var rootDate = (DateTime)dt.Rows[0][date_col];
            TimeSpan ts = dateTimePicker1.Value - rootDate;
            TimeSpan ts_x;

            var tuples = new List<Tuple<double, double>>();
            double x, y;
            foreach (DataRow row in dt.Rows)
            {
                y = double.Parse(row[column].ToString());
                if (y == 0)
                {
                    continue;
                }
                ts_x = (DateTime)row[date_col] - rootDate;
                x = ts_x.TotalDays;
                tuples.Add(Tuple.Create(x, y));
            }
            Tuple<double, double> result = SimpleRegression.Fit(tuples);
            double forcastvalue = result.Item1 + result.Item2 * ts.TotalDays;
            tbValue.Text = forcastvalue.ToString();
        }
    }
}
