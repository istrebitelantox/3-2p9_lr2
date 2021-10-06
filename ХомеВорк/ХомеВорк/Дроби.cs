using System;
using System.Collections.Generic;
using System.Text;

namespace ХомеВорк
{
    class Drob
    {
        int c;
        int z;
        public Drob(int ch, int zn)
        {
            c = ch;
            z = zn;
        }
        public Drob(int chislichko)
        {
            c = chislichko;
            z = 1;
        }
        public Drob(int celoe, int chi, int zna)
        {
            c = celoe * zna + chi;
            z = zna;
        }
        public double Des()
        {
            return (double)(c) / z;
        }
        public static Drob operator *(Drob odin, Drob dva)
        {
            return new Drob(odin.c * dva.c, odin.z * dva.z);
        }
        public bool Znak
        {
            get
            {
                bool a = c >= 0;
                bool b = z >= 0;
                return a==b;
            }
        }
        public delegate void ras(Drob saw, int znach);

    }
}
