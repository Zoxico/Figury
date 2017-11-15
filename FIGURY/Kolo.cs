using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 

namespace FIGURY
{
    class Kolo : Figura
    {
        public double dPromien = 1.0;
        new string sNazwa = "koło";

        public override string sWyswietl()
        {
            return sNazwa;
        }

        public double dPole()
        {
            return (Math.PI * dPromien * dPromien);
        }
        
        public Kolo(double dPrzekPromien, string sNazwa) : base (sNazwa)
        {
            dPromien = dPrzekPromien;
            this.sNazwa = sNazwa;

            //sNazwa = "koło";
        }

        public Kolo(string sNazwa) : base (sNazwa)
        {
            //sNazwa = "koło";
            this.sNazwa = sNazwa;
        }
    }
}
