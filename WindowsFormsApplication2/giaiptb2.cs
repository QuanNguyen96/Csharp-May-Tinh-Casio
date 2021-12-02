using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public struct sophuc
    {
        public double phannguyen;
        public double phanthuc;
    }
    class giaiptb2
    {
        public double a;
        public double b;
        public double c;
        //public static double A
        //{
        //    get{ return a; }
        //    set { a = A; }
        //}
        //public static double B
        //{
        //    get { return b; }
        //    set { b = B; }
        //}
        //public static double C
        //{
        //    get { return c; }
        //    set { c = C; }
        //}
        public giaiptb2(double athe,double bthe,double cthe)
        {
            a = athe;
            b = bthe;
            c = cthe;
        }
        public double x1, x2;
        public string vsn = null;
        public  string vn = null;
        public void gptb2r()
        {
            if(a==0)
            {
                if(b==0)
                {
                    if(c==0)
                    {
                        vsn = "vô số nghiệm";
                    }
                    else
                    {
                        vn = "vô nghiệm";
                    }
                }
                else
                {
                    x1 = -c / b;
                    x2 = x1;
                }
            }
            else
            {
                double denta = b * b - 4 * a * c;
                if(denta==0)
                {
                    x1 = -b / 2 * a;
                    x2 = x1;
                }
                else
                {
                    if(denta>0)
                    {
                        x1 = (-b - Math.Sqrt(denta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(denta)) / (2 * a);
                    }
                    else
                    {
                        vn = "vô nghiệm";
                    }
                }
            }
        }
        public sophuc spa = new sophuc();
        public sophuc spb = new sophuc();
        public void gptb2i()
        {
            if(a!=0)
            {
                double denta = b * b - 4 * a * c;
                if (denta == 0)
                {
                    x1 = -b / 2 * a;
                    x2 = x1;
                }
                else
                {
                    if (denta > 0)
                    {
                        x1 = (-b - Math.Sqrt(denta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(denta)) / (2 * a);
                    }
                    else
                    {
                        spa.phannguyen = -b / (2 * a);
                        spa.phanthuc = (1 * Math.Sqrt(-denta)) / (2 * a);
                        spb.phannguyen = spa.phannguyen;
                        spb.phanthuc = -spa.phanthuc;
                    }
                }
            }
        }
    }
}
