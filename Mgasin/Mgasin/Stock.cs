using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Mgasin
{
   static public class Stock 
    {
        static public List<Produit> x;
       // public static Array d;
        public static int num = 0;
        public static double moneyCase = 0;

        public static event EventHandler ChangeMoney;
     
       public static void remove(Produit pro)
        {
            int id = pro.getId();
            string s = getPro(id - 1);
            x.Remove(pro);
            l.removeItems(s);
            sss.chargerItems(s);
            num--;
            for (int i = id-1; i < x.Count; i++)
            {
                x[i].decalID();
            }
          //  s.chargerItems();
           // l.iniItems();
        }

        public static void Addchr(Produit pro)
        {
            
            int i = pro.getId()-1;
           
            x[i] = pro;
            
          

        }

        public static void DeleteProduct(Produit y)
        {
            object dd = (object)y;
            x.Remove(y);
            num--;
        }

        static public void activeEvent()
        {
           EventHandler x = ChangeMoney;
            if(x != null)
            
               x(null, EventArgs.Empty);
            

        }

        static public void addToMoneyCase(double x)
        {
            moneyCase += x;
            activeEvent();
        }

        static public void __ToMoneyCase(double x)
        {
            moneyCase -= x;
            activeEvent();
        }

        //   public static event EventHandler Sell;
        // public static event  EventHandler Charge;
        public static void add(Produit Pro)
        { 
            if(num == 0)
            {
                x = new List<Produit>();
            }
        
            try {
                object d = (object)Pro;
             //   x.Add(d);
               x.Insert(num, Pro);
                num++;
            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
            
            
            }
       public static Produit get(int index)
        {
          
            return (Produit)x[index];
        }

        public static string getPro(int ind)
        {
            Produit dx = (Produit)x[ind];

            return dx.getName() + "    /     " + dx.getMarque() + "    /     " + dx.getPrix();
        }

        public static System.Windows.Forms.ListBox list;
       public static   StockUI sss;
      public  static Sell l;
        
        public static bool sell(int i)
        {
            if(i < x.Count)
         return  x[i].sell();
            else
            {
                return false;
            }
        }
    }
}