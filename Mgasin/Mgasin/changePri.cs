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
    public partial class changePri : Form
    {
        public changePri(Produit p)
        {
            InitializeComponent();
            Name_Pro.Text = p.getName();
            Marque_Pro.Text = p.getMarque();
            ID_Pro.Text = Convert.ToString(p.getId());
            Prix_Pro.Text = Convert.ToString(p.getPrix());
            //   Quantite.Text = Convert.ToString(p.getQua());
            // Last_Date.Text = Convert.ToString(p.getNext_date());
            pro = p;
        }

        private void Name_Pro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextPrix.BackColor = Color.White;
            try
            {
                double x = Convert.ToDouble(TextPrix.Text);
            }
            catch (Exception ed)
            {
                Exception edd = ed;
                if (TextPrix.Text.Length != 0)
                    TextPrix.BackColor = Color.Red;
            }
        }
        Produit pro;
        private void button2_Click(object sender, EventArgs e)
        {
            if (TextPrix.BackColor != Color.Red)
                Stock.x[pro.getId() - 1].changePrix(Convert.ToDouble(TextPrix.Text));
            else
            {
                MessageBox.Show("no Price changed !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
