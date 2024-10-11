using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PİZZAOTOMASYONU
{
    internal class Siparis



    {

        public override string ToString()
        {
            string spr = "";
            spr += Pizzalar.Ebati.Adi + ","; 
            spr+=Pizzalar.Adi+",";
            spr += Pizzalar.KenarTipi.Adi + ",";
            spr += Adet +" "+"ADET";
            return spr;
        }
        public Pizza Pizzalar { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

    }
}
