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
    public partial class AddCharge : Form
    {
        private Produit Items;
        public AddCharge(Produit Item)
        {
InitializeComponent();

            Name_Pro.Text = Item.getName();
            Marque_Pro.Text = Item.getMarque();
            Items = Item;

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextQua.BackColor = Color.White;
            try
            {
                double x = Convert.ToDouble(TextQua.Text);
            }
            catch (Exception ed)
            {
                Exception edd = ed;
                if (TextQua.Text.Length != 0)
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

                }
                else
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

        private void Next_Click(object sender, EventArgs e)
        {

            int yy, mm, dd;
            yy = Convert.ToInt32(TextYY.Text);
            mm = Convert.ToInt32(TextMM.Text);
            dd = Convert.ToInt32(TextDD.Text);
           DateTime dt = new DateTime(yy, mm, dd);
            Items.chargePrduit(Convert.ToInt32(TextQua.Text), dt);
          Stock.Addchr(Items);
            vider();
        }
        private void vider()
        {
            TextQua.Text = "";
            TextDD.Text = "";
            TextMM.Text = "";
            TextYY.Text = "";


        }
        private void TextYY_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Pro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
