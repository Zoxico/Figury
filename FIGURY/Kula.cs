using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURY
{
    class Kula : Kolo
    {
        public double _dPoleKuli = 1;
        public double _dObjetoscKuli = 1;
        public double dPoleKuli()
        {
            return (4 * Math.PI * this.dPole());
        }

        public double dObjetoscKuli()
        {
            return (dPoleKuli() / 3);
        }

        public Kula(double dPrzekPromien, string sNazwa) : base (dPrzekPromien, sNazwa)
        {
            dPromien = dPrzekPromien;
            sNazwa = "kula";
            _dObjetoscKuli = dObjetoscKuli();
            _dPoleKuli = dPoleKuli();
        }

        public Kula(string sNazwa) : base(sNazwa)
        {
            sNazwa = "kula";
            _dObjetoscKuli = dObjetoscKuli();
            _dPoleKuli = dPoleKuli();
        }
    }
}
