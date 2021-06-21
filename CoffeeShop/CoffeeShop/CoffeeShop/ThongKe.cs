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

namespace CoffeeShop
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        
        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadState();
        }
        void LoadState()
        {

            LoadDateTimePickerBill();

        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(int billID, int discount, float totalPrice)
        {
            
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }
    }
}
