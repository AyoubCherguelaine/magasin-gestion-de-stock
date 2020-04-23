using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mgasin
{
    public partial class Sell : UserControl
    {
        public Sell()
        {
            InitializeComponent();
            iniItems();
        }

       
        public void showN()
        {
            iniItems();
            this.Show();
        }

        public void removeItems(string s)
        {
            Listb.Items.Remove(s);
        }

      public   void   iniItems()
        {

            if (Stock.num != 0)
                if(Listb.Items.Count != Stock.x.Count)
                for (int i = 0; i < Stock.x.Count; i++)
                  this.Listb.Items.Add(Stock.getPro(i));

          

        }

        private void Sell_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Y)
            {
                
            }
      

        }

        private void Sell_KeyPress(object sender, KeyPressEventArgs e)
        {

            //   this.OnKeyDown(e);
        
        }

        private void Sell_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.E)
            {
                MessageBox.Show("hello World");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private double num = 0;

        private void showNum(Produit pr)
        {
            if (pr != null)
            {
                num += pr.getPrix();
                Money.Text = Convert.ToString(num);
            }
            else
            {
                num = 0;
                Money.Text = Convert.ToString(num);
            }
        }


        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Listb.SelectedIndex >= 0)
            {
              bool dd=  Stock.sell(Listb.SelectedIndex);
                if (dd)
                {
                    showNum(Stock.get(Listb.SelectedIndex));
                    ShowLab.Text = "you sell  " + Stock.x[Listb.SelectedIndex].getName() + "   :    " + Stock.x[Listb.SelectedIndex].getMarque();

                }
                else
                {
                    ShowLab.Text = " no item";
                }

            }
            else
            {
                ShowLab.Text = " no item selected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showNum(null);
            ShowLab.Text = " client change";
        }

        private void Listb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.N)
            {
                button2_Click(this,EventArgs.Empty);
            }
            else
            {
                if (e.KeyCode == Keys.B)
                {
                    button1_Click_1(this, EventArgs.Empty);
                }

                }
        }
    }
}
