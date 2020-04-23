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
    public partial class StockUI : UserControl
    {
        public StockUI()
        {
            InitializeComponent();
        
            chargerItems();
        }



        public void chargerItems(int i)
        {

            if (Stock.num != 0)
            {

              
                    for (; i < Stock.x.Count; i++)
                        listBox1.Items.Add(Stock.getPro(i));
            }
        }
        public void chargerItems()
        {

            if (Stock.num != 0)
            {
             
                for (int i = 0; i < Stock.x.Count; i++)
                    listBox1.Items.Add(Stock.getPro(i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                // show info

                Produit dd = (Produit)Stock.x[listBox1.SelectedIndex];

                InfoProduct ed = new InfoProduct(dd);
               ed.Show();

           }
        }

        public void  save_List(){

            Stock.list = this.listBox1;
            }

        private void button1_Click(object sender, EventArgs e)
        {
        
                ChargeProduit x = new ChargeProduit(this,Stock.num);
                x.Show();
               // this.chargerItems();
            
        }

      static  private void Funct(EventHandler sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          //  ChangePrix.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          //  ChangePrix.Show();
        }

        private void ChangePrix_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0 )
            {

                changePri x = new changePri(Stock.x[listBox1.SelectedIndex]);
                x.Show();
            }
        }

        public void chargerItems(string s)
        {
            listBox1.Items.Remove(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Produit dd = (Produit)Stock.x[listBox1.SelectedIndex];

                AddCharge ed = new AddCharge(dd);
                ed.Show();
            }
            //this.chargerItems();
        }
    }
}
