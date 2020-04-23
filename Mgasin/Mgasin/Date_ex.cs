using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mgasin
{
    public class Date_ex
    {

        private int Qu;
        private DateTime Ex;

       


        public Date_ex(int q,DateTime Ex)
        {
            Qu = q;
            this.Ex = Ex;
         
        }

      

        public int getQuantite()
        {
            return Qu;
        }
        public DateTime getEx()
        {
            return Ex;

        }

        public void autodecri()
        {
            Qu--;
        }


    }
}