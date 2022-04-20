using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ZBOZI_PRODUKT
{
    internal class Zbozi
    {
        protected string nazev;
        protected int cena;
        protected DateTime datum;
        protected int miniTrvani;


        public Zbozi(string nazev, int cena, DateTime datum, int miniTrvani)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datum = datum;
            this.miniTrvani = miniTrvani;
        }

        public bool Splnuje()
        {
            TimeSpan datum1 = DateTime.Now - datum;
            if (datum1.Days < miniTrvani)
            {
                return true;
            }
            return false;
        }

        public virtual double CenasDPH()
        {
            return cena * 1.21;
        }

        public override string ToString()
        {
            return string.Format(" Nazev zbozi: {0}\n Cena zbozi je: {1}\n Datum vyroby je: {2}\n Minimalni trvanlivost je: {3} \n Splnuje trvanlivost: {4}\n Cena s DPH: {5}", nazev, cena, datum, miniTrvani, Splnuje() ? "ANO, splnuje. " : "NE, nesplnuje. ", CenasDPH());
        }
    }
}
