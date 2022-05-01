using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Rum : Pivo
    {
        private bool kelimekNaRum = false;
        public Rum(int cena, string znacka, double objem,bool kelimekZaRum): base(cena,znacka,objem)
        {
            this.kelimekNaRum = kelimekZaRum;
        }
        public bool GetKelimekNaRum()
        {
            return kelimekNaRum;
        }
        public void SetKelimekNaRum(bool kelimekNaRum)
        {
            this.kelimekNaRum = kelimekNaRum;
        }
    }
}
