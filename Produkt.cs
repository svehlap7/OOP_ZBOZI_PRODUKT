using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ZBOZI_PRODUKT
{
    internal class Produkt : Zbozi
    {
        private bool lze;

        public Produkt(string nazev, int cena, DateTime datum, int miniTrvani, bool lze) : base(nazev, cena, datum, miniTrvani)
        {
            this.lze = lze;
        }

        public override double CenasDPH()
        {
            if (lze && !Splnuje())
            {
                return base.CenasDPH() * 0.6;
            }
            return base.CenasDPH();
        }
    }
}
