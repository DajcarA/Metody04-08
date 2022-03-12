using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08
{
    class CelaCisla
    {
        public static int Mocnina(int zaklad, int exponent)
        {
            bool zapExpo = exponent < 0;
            exponent = Math.Abs(exponent);

            int vysledek = 1;
            for(int i = 0;i < exponent; ++i)
            {
                  vysledek *= zaklad;
            } 

            if (zapExpo)
            {
                vysledek = 1 / vysledek;
                return vysledek;
            }
            else return vysledek;
        }

        public static int Faktorial(int a)
        {
            int fak = 1;
            while (a> 0)
            {
                fak *= a;
                --a;
            }

            return fak;
        }

        public static int CifLichSoucet(int cislo)
        {
            int lichSou = 0;
            int cifra;
            while(cislo > 0)
            {
                cifra = cislo % 10;
                if(cifra % 2 != 0)
                {
                    lichSou += cifra;
                }
                cislo /= 10;
            }
            return lichSou;
        }

        public static bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            for (int i = 2; i < cislo && jePrvocislo; i++)
            {
                if (cislo % i == 0) jePrvocislo = false;
            }
            return jePrvocislo;

        }

        public static int PocetDeliteluSud(int cislo)
        {
            int pocetSudDel = 0;
            for (int i = 1; i <= cislo; i++)
            {
                if ((i % 2 == 0) && (cislo % i == 0)) ++pocetSudDel;
            }

            return pocetSudDel;
        }

        public static int nsd(int cislo1, int cislo2)
        {
            int nejvetsiDel = 1;
            int mensiCislo = cislo1;

            if (cislo1 != cislo2)
            {
                if (cislo1 > cislo2)
                {
                    mensiCislo = cislo2;
                }

                for (int i = 2; i <= mensiCislo; i++)
                {
                    if (cislo1 % i == 0 && cislo2 % i == 0)
                    {
                        nejvetsiDel = i;
                    }
                }
            }
            else
            {
                nejvetsiDel = cislo1;
            }

            return nejvetsiDel;
        }
    }
}
