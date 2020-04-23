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
    public partial class ChargeProduit : Form
    {
      public  int id;
        public ChargeProduit(StockUI Uiver, int ind)
        {
            InitializeComponent();
            Uive = Uiver;
            id = ind;
        }
        private StockUI Uive;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Uive.chargerItems(id);
            this.Close();
           
        }

        private void TextPrix_TextChanged(object sender, EventArgs e)
        {
            TextPrix.BackColor = Color.White;
            try
            {
                double x =Convert.ToDouble( TextPrix.Text);
            }
            catch(Exception ed)
            {
                Exception edd = ed;
                if(TextPrix.Text.Length != 0)
                TextPrix.BackColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TextQua.Text);
            }
            catch (Exception ed)
            {
                Exception edd = ed;
                if(TextQua.Text.Length != 0)
                TextQua.BackColor = Color.Red;
            }
        }

        private void TextYY_TextChanged(object sender, EventArgs e)
        {
            if (TextYY.BackColor == Color.Red)
            {
                TextYY.BackColor = Color.White;
            }
            try
            {

                int x = Convert.ToInt32(TextYY.Text);
               
                if (x >= 2017 && x < 2100)
                {

                }else
                {
                    TextYY.BackColor = Color.Red;
                }

            }
            catch (Exception ed)
            {

                Exception edd = ed;
                if (TextYY.Text.Length != 0)
                    TextYY.BackColor = Color.Red;
            }
        }

        private void TextMM_TextChanged(object sender, EventArgs e)
        {
            if (TextMM.BackColor == Color.Red)
            {
                TextMM.BackColor = Color.White;
            }
            try
            {
                
                int x = Convert.ToInt32(TextMM.Text);
                if (x >= 1 && x <= 12)
                {
                    TextMM.BackColor = Color.White;
                }
                else
                {
                    TextMM.BackColor = Color.Red;
                }
            }
            catch (Exception ed)
            {
                Exception edd = ed;
                if (TextMM.Text.Length != 0)
                    TextMM.BackColor = Color.Red;
            }
        }

        private void TextDD_TextChanged(object sender, EventArgs e)
        {
            if (TextDD.BackColor == Color.Red)
            {
                TextDD.BackColor = Color.White;
            }
            try
            {
                
                int x = Convert.ToInt32(TextDD.Text);
                if (x >= 1 && x <= 31)
                {
                    TextDD.BackColor = Color.White;
                }
                else
                {
                    TextDD.BackColor = Color.Red;
                }
            }
            catch (Exception ed)
            {
                Exception edd = ed;
                if (TextDD.Text.Length != 0)
                    TextDD.BackColor = Color.Red;
            }
        }

        private void ChargeProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void ChargeProduit_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void vider()
        {
            TextName.Text = "";
            TextPrix.Text = "";
            TextMarque.Text = "";
            TextYY.Text = "";
            TextMM.Text = "";
            TextDD.Text = "";
            TextQua.Text = ""
                ;
           
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextYY.Text) != 0 && Convert.ToInt32(TextMM.Text) != 0 && Convert.ToInt32(TextDD.Text) != 00)
            {
                
                    DateTime x = new DateTime(Convert.ToInt32(TextYY.Text), Convert.ToInt32(TextMM.Text), Convert.ToInt32(TextDD.Text));

                    Date_ex y = new Date_ex(Convert.ToInt32(TextQua.Text), x);

                    LinkedList<Date_ex> n = new LinkedList<Date_ex>();

                    n.AddLast(y);

                    Double d = Convert.ToDouble(TextPrix.Text);

                Produit dx;//= new Produit(TextName.Text, TextMarque.Text, n);
                dx = new Produit(TextName.Text, TextMarque.Text,1, n
                    );
                    dx.changePrix(d);
                    Stock.add(dx);
                    vider();

                
            }
        }

        private void ChargeProduit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         //   KeyPreview = Keys.A;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
