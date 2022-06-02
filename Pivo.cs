using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Pivo:Alkohol
    {
        private int stupen;
        public Pivo(int cena, string znacka, double objem, int stupen) : base(cena, znacka, objem)
        {
            this.stupen = stupen;
        }
        public override string ToString()
        {
            return base.ToString() + "\nStupeň piva je: " + stupen + "°";
        }
    }
}
