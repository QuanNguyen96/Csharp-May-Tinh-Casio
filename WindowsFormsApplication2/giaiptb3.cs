using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class giaiptb3
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public giaiptb3(double athe, double bthe, double cthe, double dthe)
        {
            a = athe;
            b = bthe;
            c = cthe;
            d = dthe;
        }
        public double x1, x2, x3;
        public int dem = 0;
        public double denta;
        public void giaiptbac3()
        {

            denta = Math.Pow(b, 2) - 3 * a * c;
            double k = (9 * a * b * c - 2 * Math.Pow(b, 3) - 27 * a * a * d) / (2 * (Math.Sqrt(Math.Abs(Math.Pow(denta, 3)))));
            if (denta == 0)
            {
                dem = 1;

                if (Math.Pow(b, 3) - 27 * a * a * d == 0)
                {
                    x1= (-b / (3 * a));
                }
                else
                {
                    if (Math.Pow(b, 3) - 27 * a * a * d >= 0)
                    {
                        x1= ((-b + Math.Pow(Math.Pow(b, 3) - 27 * a * a * d, (double)1 / 3)) / (3 * a));
                    }
                    else
                    {
                        x1= ((-b - Math.Pow(-(Math.Pow(b, 3) - 27 * a * a * d), (double)1 / 3)) / (3 * a));
                    }
                }
            }
            else
            {
                if (denta > 0)
                {
                    if (Math.Abs(k) <= 1)
                    {
                        dem = 3;
                        x1 = (2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3) - b) / (3 * a);
                        x2 = (2 * Math.Sqrt(denta) * Math.Cos((Math.Acos(k) / 3 - 2 * Math.PI / 3)) - b) / (3 * a);
                        x3 = (2 * Math.Sqrt(denta) * Math.Cos((Math.Acos(k) / 3 + 2 * Math.PI / 3)) - b) / (3 * a);
                    }
                    else
                    {
                        dem = 1;
                        x1 = (Math.Sqrt(denta) * Math.Abs(k)) / (3 * a * k) * (Math.Pow(Math.Abs(k) + Math.Sqrt(k * k - 1), (double)1 / 3) + Math.Pow(Math.Abs(k) - Math.Sqrt(k * k - 1), (double)1 / 3)) - (b / (3 * a));
                       
                    }
                }
                else
                {
                    dem = 1;
                    x1 = (Math.Sqrt(Math.Abs(denta)) / (3 * a) * (Math.Pow(k + Math.Sqrt(k * k + 1), (double)1 / 3) - Math.Pow(-(k - Math.Sqrt(k * k + 1)), (double)1 / 3))) - (b / (3 * a));
                    
                }
            }
        }
    }
}

