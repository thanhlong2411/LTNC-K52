using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class fTable : Form
    {
        public fTable()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTable_Load(object sender, EventArgs e)
        {
            CoffeeShop.Tang1 fr = new CoffeeShop.Tang1();
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
        }

        private void tầng1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoffeeShop.Tang1 fr = new CoffeeShop.Tang1();
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
        }

        private void tầng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 805;
            this.Height = 646;
            CoffeeShop.Tang2 fr = new CoffeeShop.Tang2();
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            
            
        }

        private void menuPersonalInfo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
