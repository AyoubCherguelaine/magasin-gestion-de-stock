using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mgasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stockUI1.Hide();
            sell1.Hide();
            Stock.sss = stockUI1;
            Stock.l = sell1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stockUI1_Load(object sender, EventArgs e)
        {

        }

        private void test()
        {
            stockUI1.Hide();
            sell1.Hide();
        }

        private void Stock_button_Click(object sender, EventArgs e)
        {
            test();
            stockUI1.Show();
        }

        private void Sell_button_Click(object sender, EventArgs e)
        {
            test();
            stockUI1.save_List();
            sell1.showN();
        }
    }
}
