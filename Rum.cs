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
        public bool GetKelimekZaRum()
        {
            return kelimekNaRum;
        }
        public void SetKelimekZaRum(bool kelimekNaRum)
        {
            this.kelimekNaRum = kelimekNaRum;
        }
    }
}
