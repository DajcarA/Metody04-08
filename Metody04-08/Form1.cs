using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Mocnina_Click(object sender, EventArgs e)
        {
            int z = int.Parse(textBox1.Text);
            int exp = int.Parse(textBox2.Text);
            int vysledek = CelaCisla.Mocnina(z, exp);
            MessageBox.Show(vysledek.ToString());
        }

        private void button2Faktorial_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int vysledek = CelaCisla.Faktorial(a);
            MessageBox.Show(vysledek.ToString());
        }

        private void button3CifLichSoucet_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox4.Text);
            int vysledek = CelaCisla.CifLichSoucet(cislo);
            MessageBox.Show(vysledek.ToString());
        }

        private void button4JePrvocislo_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox5.Text);
            bool jePrvocislo = CelaCisla.JePrvocislo(cislo);
            if (jePrvocislo) MessageBox.Show("Číslo " + cislo + " je prvočíslo");
            else MessageBox.Show("Číslo " + cislo + " není prvočíslo");
        }

        private void button5PocetDeliteluSud_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox6.Text);
            int pocetSudDel = CelaCisla.PocetDeliteluSud(cislo);

            MessageBox.Show("Počet sudých dělitelů je " + pocetSudDel);
        }

        private void button1NSD_Click(object sender, EventArgs e)
        {
            int cisla1 = int.Parse(textBox7.Text);
            int cisla2 = int.Parse(textBox8.Text);

            MessageBox.Show("Největší společný dělitel je " + CelaCisla.nsd(cisla1, cisla2));
        }
    }
}
