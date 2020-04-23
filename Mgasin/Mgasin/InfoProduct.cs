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
    public partial class InfoProduct : Form
    {
        public InfoProduct(Produit p)
        {
            InitializeComponent();
            Name_Pro.Text = p.getName();
            Marque_Pro.Text = p.getMarque();
            ID_Pro.Text =Convert.ToString( p.getId());
            Prix_Pro.Text = Convert.ToString(p.getPrix());
            Quantite.Text = Convert.ToString(p.getQua());
            Last_Date.Text = Convert.ToString(p.getNext_date());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
