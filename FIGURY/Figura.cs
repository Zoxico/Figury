using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURY
{
    public class Figura
    {
        public string sNazwa = "figura geometryczna";

        public virtual string sWyswietl()
        {
            return sNazwa;
        }

        public Figura (string sPrzekNazwa)
        {
            sNazwa = sPrzekNazwa;
        }

        public Figura()
        {
           
        }

    }
}
