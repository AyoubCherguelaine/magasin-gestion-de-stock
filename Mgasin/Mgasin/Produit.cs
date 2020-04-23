using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Mgasin
{
    public class Produit
    {

        public void decalID()
        {
            id--;
        }
        private string name;
        private string Marque;
        private int id;
        private LinkedList<Date_ex> Date_ex;
        private double prix;
        private int Qua;
    //    private string text1;
      //  private string text2;
    //    private LinkedList<Date_ex> n;

        public DateTime getNext_date()
        {
            return Date_ex.First.Value.getEx();
        }
        

        public void changePrix(double New_Prix)
        {
            this.prix = New_Prix;
        }

        public double getPrix()
        {
            return prix;
        }

        public Produit(string name ,string marque,int id,LinkedList<Date_ex> x, double Prix )
        {
            this.prix = Prix;
            this.name = name;
            this.Marque = marque;
            this.id = id;
            Date_ex = x;
        Date_ex[] xd=    Date_ex.ToArray();
           for (int  i=0;i< x.Count; i++)
            {
                Qua += xd[i].getQuantite();
            }
           
        }
        public Produit(string name, string marque, int id, LinkedList<Date_ex> x)
        {
            this.name = name;
            this.Marque = marque;
            this.id = Stock.num + 1 ;
            Date_ex = x;
            Date_ex[] xd = Date_ex.ToArray();
            for (int i = 0; i < x.Count; i++)
            {
                Qua += xd[i].getQuantite();
            }

        }

       
      //  public Produit(string text1, string text2, LinkedList<Date_ex> n)
       // {
        //    this.text1 = text1;
          //  this.text2 = text2;
            //this.n = n;
        //}

        public int getQua()
        {
            return Qua;
        }

        public string getName()
        {
            return name;

        }

        public string getMarque()
        {
            return Marque;
        }

        public int getId()
        {
            return id;
        }

        public bool sell()
        {
            if(Date_ex.Count == 0)
            {
                Stock.remove(this);
                return false;
            }
            else
            {
                if(Date_ex.First.Value.getQuantite() > 0)
                {
                    Date_ex.First.Value.autodecri();
                    Qua--;
                    if(Date_ex.First.Value.getQuantite() == 0)
                    {
                        Date_ex.RemoveFirst();
                    }
                }
            }
            return true;
        }

       

        public void chargePrduit(int qu,DateTime x)
        {
            Date_ex n = new Date_ex(qu, x);
            Date_ex.AddLast(n);
            Qua += qu;
          
        }

       

    

      
    }
}