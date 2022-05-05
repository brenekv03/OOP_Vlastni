using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pivo pivo = new Pivo(30, "Plzeň", 0.5);
        Rum rum = new Rum(75, "božkov", 0.2, false);
        private void button1_Click(object sender, EventArgs e)
        {
            rum.Nalit(1);
            // nastaví kelímek na true, protože si kupuje rum 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pivo.Nalit(1); // nalije pivo
        }

        private void button3_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Kolik zaplatit za pivo: " + pivo.KolikZaplatit() + "\nKolik zaplatit za rum: "+rum.KolikZaplatit()); //kolik platím za pivo a rum
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pivo.Zaplatit(50); //platím za pivo
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rum.Zaplatit(75); //platím za rum
        }

        private void button6_Click(object sender, EventArgs e)
        {
                MessageBox.Show(pivo.ToString() + "\n\n" + rum.ToString());
        }
    }
}
