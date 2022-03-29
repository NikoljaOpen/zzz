using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaLiney
{
    public class Liney
    {
        public double x;

        public Liney(double a, double b)
        {
            if (a != 0)
            {
                x = -b / a;
            }
            else if (a == 0 && b == 0)
            {
                x = 0;
            }
            else if (a == 0 && b != 0)
            {
                x = -b;
            }
        }
    }
}
