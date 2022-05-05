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
        //konstruktor
        public Rum(int cena, string znacka, double objem,bool kelimekZaRum): base(cena,znacka,objem)
        {
            this.kelimekNaRum = kelimekZaRum;
        }
        //get

        public bool GetKelimekNaRum()
        {
            return kelimekNaRum;
        }
        //set

        public void SetKelimekNaRum(bool kelimekNaRum)
        {
            this.kelimekNaRum = kelimekNaRum;
        }
        //override

        public override void Nalit(int kolikNalit)
        {
            SetKelimekNaRum(true);
            base.Nalit(kolikNalit);
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
