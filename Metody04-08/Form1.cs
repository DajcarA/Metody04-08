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
    }
}
