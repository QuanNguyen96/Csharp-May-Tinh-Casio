using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class TinhgiatriBT
    {
        public static int kiemtra(char c)
        {
            if (c == '(' || c == ')') return 0;
            if (c == '+' || c == '-') return 1;
            if (c == '*' || c == '/') return 2;
            if (c == '^') return 3;
            if (c == '!') return 4;
            if (c == 's' || c == 'c' || c == 't' || c == 'n' || c == 'g' ) return 5;
            else return 6;

        }
        public static int kiemtratoantu(string a)
        {
            if (string.Compare(a, "sin") == 0) return 0;
            if (string.Compare(a, "cos") == 0) return 1;
            if (string.Compare(a, "tan") == 0) return 2;
            if (string.Compare(a, "ln") == 0) return 3;
            if (string.Compare(a, "log") == 0) return 4;
            return 5;
        }
        public static string chuyentutrungtosanghauto(string str)
        {
            string chuoi = "";
            Stack s = new Stack();
            int i = 0, dodai = str.Length;
            char kitu;
            string d = "";
            string dthe = "";
            int biendem = 0;
            while (i < dodai)
            {
                kitu = str[i];
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    d = string.Concat(d, str[i]);
                    if (str[i + 1] < 'a' || str[i + 1] > 'z')
                    {
                        int kt = kiemtratoantu(d);
                        if (kt == 5)
                        {
                            if (kt == 0) s.Push('s');   // ham sin
                            if (kt == 1) s.Push('c');   // ham cos
                            if (kt == 2) s.Push('t');   // ham tan
                            if (kt == 3) s.Push('n');   // ham ln
                            if (kt == 4) s.Push('g');   // ham log
                        }
                        d = string.Copy(dthe);
                    }
                }
                else
                {
                    if ((str[i] >= '0' && str[i] <= '9') || kitu == ',' || kitu == '.')  // la toan hang (cac so hang )
                    {
                        if (str[i] >= '0' && str[i] <= '9')
                        {
                            chuoi = string.Concat(chuoi, kitu);
                        }
                        else
                        {
                            chuoi = string.Concat(chuoi, ",");
                        }
                    }
                    else
                    {
                        if (kitu == '(')
                        {
                            if (str[i + 1] == '+' || str[i + 1] == '-')
                            {
                                chuoi = string.Concat(chuoi, "0");
                            }
                            s.Push(kitu);
                        }
                        else
                        {
                            if (kitu == ')')
                            {
                                while ((char)s.Peek() != '(')
                                {
                                    chuoi = string.Concat(chuoi, " ");
                                    chuoi = string.Concat(chuoi, s.Peek()); ;   // ham s.top() la ham lay 1 phan tu tren cung cua ngan xep ra de su dung
                                    s.Pop();                         // ham s.pop() la ham dung de xoa 1 phan tu tren cung cua stack
                                }
                                if ((char)s.Peek() == '(')
                                {
                                    s.Pop();     // truong hop giua hai ngoac la 1 so
                                }
                            }
                            else                       // la toan tu (cac phep tinh cong tru nhan chia lay phan nguyen phep chia va luy thua
                            {
                                if (kitu == '+' || kitu == '-')
                                {
                                    if (kitu == '-')
                                    {
                                        biendem++;
                                    }
                                    if (str[i + 1] != '+' && str[i + 1] != '-')
                                    {
                                        chuoi = string.Concat(chuoi, " ");
                                        if (biendem % 2 == 0)
                                        {
                                            while (s.Count != 0 && kiemtra((char)s.Peek()) >= 1)
                                            {
                                                chuoi = string.Concat(chuoi, s.Peek());
                                                chuoi = string.Concat(chuoi, " ");
                                                s.Pop();
                                            }
                                            s.Push('+');
                                        }
                                        else
                                        {
                                            while (s.Count != 0 && kiemtra((char)s.Peek()) >= 1)
                                            {
                                                chuoi = string.Concat(chuoi, s.Peek());
                                                chuoi = string.Concat(chuoi, " ");
                                                s.Pop();
                                            }
                                            s.Push('-');
                                        }
                                        biendem = 0;
                                    }
                                }
                                if (kitu == '*' || kitu == '/' || kitu == '^' || kitu == '!')
                                {
                                    chuoi = string.Concat(chuoi, " ");
                                    while ((s.Count != 0) && (kiemtra((char)s.Peek()) >= kiemtra(kitu)))
                                    {
                                        chuoi = string.Concat(chuoi, s.Peek());
                                        chuoi = string.Concat(chuoi, " ");
                                        s.Pop();
                                    }
                                    s.Push(kitu);
                                }
                            }
                        }
                    }
                }
                i++;
            }
            while (s.Count != 0)
            {
                if ((char)s.Peek() != '(')
                {
                    chuoi = string.Concat(chuoi, " ");
                    chuoi = string.Concat(chuoi, s.Peek());
                    s.Pop();
                }
                else
                {
                    s.Pop();
                }
            }
            chuoi = string.Concat(chuoi, " ");
            return chuoi;
        }
        public static float xacdinhsothuc(int phannguyen, int phanthapphan, int k)
        {
            float kq;
            int b = -k;
            kq = phannguyen + phanthapphan * (float)Math.Pow(10, b);
            return kq;
        }
        public static long tinhgiaithua(int n)
        {
            long gt = 1;
            int i = 0;
            if (n >= 1)
            {
                for (i = 1; i <= n; i++)
                {
                    gt = gt * i;
                }
            }
            return gt;
        }
        public static bool kiemtrasothucnguyen(string str)
        {
            bool e = true;
            int dodai = str.Length;
            int i, biendem = 0;
            for (i = 0; i < dodai; i++)
            {
                if (str[i] == ',' || str[i] == '.')
                {
                    biendem++;
                }
            }
            if (biendem != 0) e = false;
            return e;
        }
        public static double tinhgiatribieuthuc(string str)
        {
            Stack s = new Stack();
            int i = 0;
            float a, b;
            int dodai = str.Length;
            int bienthe = 0;
            int k = 0;
            int biendem = 0;
            int phannguyen = 0;
            float bienthegia;
            while (i < dodai)
            {
                if (str[i] != ' ')
                {
                    if ((str[i] - '0' >= 0 && str[i] - '0' <= 9) || str[i] == ',')
                    {
                        if (str[i] != ',')
                        {
                            bienthe = bienthe * 10 + str[i] - '0';
                        }

                        int t = str[i + 1] - '0';
                        if (str[i] == ',')
                        {
                            biendem++;
                            k = i;
                            phannguyen = bienthe;
                            bienthe = 0;

                        }
                        if ((str[i + 1] < '0' || str[i + 1] > '9') && str[i + 1] != ',')
                        {
                            if (biendem != 0)
                            {
                                bienthegia = xacdinhsothuc(phannguyen, bienthe, i - k);
                                biendem--;
                            }
                            else
                            {
                                bienthegia = bienthe;
                            }
                            s.Push(bienthegia);
                            bienthe = 0;
                        }
                    }
                    else
                    {
                        string topstack = string.Concat("", s.Peek());
                        b = float.Parse(topstack);
                        s.Pop();
                        if (str[i] >= 'a' && str[i] <= 'z')
                        {
                            if (str[i] == 's') s.Push(Math.Sin(b));
                            if (str[i] == 'c') s.Push(Math.Cos(b));
                            if (str[i] == 't') s.Push(Math.Tan(b));
                            if (str[i] == 'n') s.Push(Math.Log(b));
                            if (str[i] == 'g') s.Push(Math.Log10(b));
                        }
                        else
                        {
                            if (str[i] == '+' || str[i] == '-')
                            {
                                if (s.Count != 0)
                                {
                                    string topstack1 = string.Concat("", s.Peek());
                                    a = float.Parse(topstack1);
                                    s.Pop();
                                }
                                else
                                {
                                    a = 0;
                                }
                                if (str[i] == '+') s.Push(a + b);
                                if (str[i] == '-') s.Push(a - b);
                            }
                            else
                            {
                                if (str[i] == '!' && s.Count == 0)
                                {
                                    if (kiemtrasothucnguyen(topstack) == true)
                                    {
                                        s.Push(tinhgiaithua(int.Parse(topstack)));
                                    }
                                }
                                else
                                {
                                    string topstack3 = string.Concat("", s.Peek());
                                    a = float.Parse(topstack3);
                                    s.Pop();
                                    if (str[i] == '*') s.Push(a * b);
                                    if (str[i] == '/') s.Push(a / b);
                                    if (str[i] == '^') s.Push((float)Math.Pow(a, b));
                                }
                            }
                        }
                    }
                }
                i++;
            }
            double kq = double.Parse(s.Peek().ToString());
            s.Pop();
            return kq;
        }
        public static double tinhgiatribt(string str)
        {
            string chuoimoi = chuyentutrungtosanghauto(str);
            double kq = tinhgiatribieuthuc(chuoimoi);
            return kq;
        }
        public static double x, x1, x2;
        public static string x4;

    }
}
