using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Pivo
    {
        protected int cena;
        protected int cenaCelkem = 0;
        protected string znacka;
        private double celkemNalito = 0;
        private int pocetKusu = 0;
        public double Objem { get; }
        public string Znacka
        {
            get
            {
                return znacka;
            }
            set //hlídá název alkoholu, aby vždy začínal na velké písmeno
            {
                string s = value;
                char prvniPismeno = s[0];
                prvniPismeno = char.ToUpper(prvniPismeno);
                s = s.Replace(s[0], prvniPismeno);
                znacka = s;
            }
        }
        //konstruktor
        public Pivo(int cena, string znacka, double objem)
        {
            this.cena = cena;
            Znacka = znacka;
            Objem = objem;
        }
        //přičte cenu, počet kusů a kolik bylo nalito
        public void Nalit(int kolikNalit)
        {
            pocetKusu += kolikNalit;
            cenaCelkem += cena;
            celkemNalito += Objem;
        }
        //vrací hodnotu kolik se má zaplatit
        public int KolikZaplatit()
        {
            return cenaCelkem;
        }
        //zaplatí 
        public int Zaplatit(int kolikZaplatit)
        {
            if (cenaCelkem != 0)
            {
                if ((cenaCelkem - kolikZaplatit) >= 0)
                {
                    cenaCelkem -= kolikZaplatit;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Platíte více než je třeba, zaplaťte míň");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nemusíte nic platit!");
            }
            return cenaCelkem;
        }       
        public override string ToString()
        {
            string s = "\nCena za jeden kus: " + cena + "\nZnačka alkoholu: " + Znacka + "\nObjem jednoho kusu: " + Objem + "\nKolik zaplatit: " + KolikZaplatit() + "\nKolik bylo nalito: " + pocetKusu + "\nNalitý objem: " + celkemNalito;

            return base.ToString() + s;
        }
    }
}
