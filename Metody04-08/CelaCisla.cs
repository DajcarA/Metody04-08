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
    }
}
