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
        private int priplatekZaKelimek = 0;
        public Rum(int cena, string znacka, double objem,bool kelimekZaRum): base(cena,znacka,objem)
        {
            this.kelimekNaRum = kelimekZaRum;
        }
        //get
        public int GetPriplatekZaKelimek()
        {
            return priplatekZaKelimek;
        }
        public bool GetKelimekNaRum()
        {
            return kelimekNaRum;
        }
        //set
        public void SetPriplatekZaKelimek(int priplatekZaKelimek)
        {
            this.priplatekZaKelimek = priplatekZaKelimek;
        }
        public void SetKelimekNaRum(bool kelimekNaRum)
        {
            this.kelimekNaRum = kelimekNaRum;
        }

        public override string ToString()
        {
            string s = "\nNemáte kelímek na rum";
            if (GetKelimekNaRum())
            {
                 s = "\nMáte kelímek na rum";
            }
            return base.ToString() +s;
        }
    }
}
