using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class giaiheptb3 : Form
    {
        public giaiheptb3()
        {
            InitializeComponent();
        }
        class HeSo
        {
            private double a; //a<>0
            private double b;
            private double c;
            private double d;
            public double HeSoA
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }
            public double HeSoB
            {
                get
                {
                    return b;
                }
                set
                {
                    b = value;
                }
            }
            public double HeSoC
            {
                get
                {
                    return c;
                }
                set
                {
                    c = value;
                }
            }
            public double HeSoD
            {
                get
                {
                    return d;
                }
                set
                {
                    d = value;
                }
            }
            public HeSo(double a, double b, double c, double d)
            {
                this.HeSoA = a;
                this.HeSoB = b;
                this.HeSoC = c;
                this.HeSoD = d;
            }
        }
        private void rutgonvematranbacthang(double[,] M, int m, int n)
        {

            double HeSoNhan = 0, tg;
            int i, j, k, l, kt, dong = 0;

            /**
             * Chuyen doi ma tran M ve dang bac thang rut gon
             * Dua tung cot ve dang cot cua ma tran don vi I tuong ung
             */
            for (i = 0; i < n - 1; i++)
            {
                /*
                 * Bien doi theo cot
                 *
                 * Chao doi dong de dua ma tran ve dang co the bien ve so 1
                 * Moi cot chi can chao doi mot lan
                 */
                if (M[i, i] == 0)
                {
                    // Tim dong co cot i khac 0 de chao doi
                    for (k = i + 1; k < m; k++)
                    {
                        if (M[k, i] != 0)
                        {
                            // Chao doi dong k chua phan tu != 0 do voi dong i dang xet
                            for (l = 0; l < n; l++)
                            {
                                tg = M[i, l];
                                M[i, l] = M[k, l];
                                M[k, l] = tg;
                            }

                            break;// dung vong for lai khi da chao doi xong
                        }
                    }
                }// Hoan tat chao doi

                /*
                 * Tien hanh bien doi M[j,i] thanh so 1 va so 0
                 * Chuyen doi lan luot tung dong theo dung loai
                 */
                for (j = 0; j < m; j++)
                {
                    /*
                     * Xac dinh loai can chuyen ve so 0 hay so 1
                     * loai = 2 la truong hop phan tu M[j,i] da o dung vi tri
                     * khong can bien doi gi ca.
                     */
                    int loai = 2;

                    // Neu M[j,i] khong nam tren duong cheo chinh va ban than no khac 0
                    if ((j != i) && (M[j, i] != 0))
                    {
                        // M[j,i] can chuyen ve zero
                        loai = 0;
                    }

                    // Neu M[j,i] nam tren duong cheo chinh va ban than no khac 1
                    if ((j == i) && (M[j, i] != 1))
                    {
                        // M[j,i] can chuyen ve 1 chuan
                        loai = 1;
                    }

                    switch (loai)
                    {
                        // Truong hop can chuyen M[j,i] ve so 0
                        case 0:
                            //Xac dinh he so nhan(HeSoNhan) va dong nhan vao thich hop
                            for (k = 0; k < m; k++)
                            {
                                if (k != j)
                                {
                                    HeSoNhan = 0;
                                    kt = 0;
                                    for (l = 0; l < i; l++) if (M[k, l] != 0) kt = 1;
                                    if ((kt == 0) && (M[k, i] != 0))
                                    {
                                        dong = k;
                                        HeSoNhan = (-1) * M[j, i] / M[dong, i];
                                        break;
                                    }
                                }
                            }
                            //Neu co HeSoNhan thi se chuyen doi neu khong thi giu nguyen
                            if (HeSoNhan != 0)
                            {
                                for (k = 0; k < n; k++)
                                {
                                    M[j, k] = M[j, k] + HeSoNhan * M[dong, k];
                                }
                            }

                            break;

                        // Truong hop can chuyen M[j,i] ve so 0
                        case 1:
                            kt = 0;
                            for (l = 0; l < i; l++)
                            {
                                if (M[j, l] != 0)
                                {
                                    kt = 1;
                                }
                            }

                            HeSoNhan = M[j, i];
                            if ((HeSoNhan != 0) && (kt == 0))
                            {
                                for (l = 0; l < n; l++)
                                {
                                    M[j, l] = M[j, l] / HeSoNhan;
                                }
                            }

                            break;
                    }
                }

            }
        }
        private void bienluannghiem(double[,] M, int m, int n)
        {
            //nBien luan nghiem tu ma tran bac thang rut gon thu duoc:
            int i, j;

            // Tim hang cua ma tran he so A
            int rA = 0;
            int tangHangA;
            for (i = 0; i < m; i++)
            {
                // Mac dinh la khong tang hang
                tangHangA = 0;
                for (j = 0; j < n - 1; j++)
                {
                    // Chi can mot phan tu trong hang khac 0 la tang hang ngay
                    if (M[i, j] != 0)
                    {
                        tangHangA = 1;
                        break;
                    }
                }

                rA += tangHangA;
            }
            //- Hang cua ma tran he so A la rA = %d", rA);

            // Tim hang cua ma tran bo sung M
            int rM = 0;
            int tangHangM;
            for (i = 0; i < m; i++)
            {
                // Mac dinh la khong tang hang
                tangHangM = 0;
                for (j = 0; j < n; j++)
                {
                    // Chi can mot phan tu trong hang khac 0 la tang hang ngay
                    if ((int)M[i, j] != 0)
                    {
                        tangHangM = 1;
                        break;
                    }
                }

                rM += tangHangM;
            }
            // - Hang cua ma tran bo sung M la rM = %d", rM);

            // - So an (n-1) la: %d", n - 1);

            // TH1 HPTTT co nghiem duy nhat Khi rA == rM == n-1(so an):
            if (rA == rM && rA == n - 1)
            {
                txtkq.Text = "He phuong trinh co nghiem duy nhat la: ";
                for (i = 0; i < n - 1; i++)
                {
                    // printf("\n X%d = %lf", i + 1, M[i,n - 1]);
                    txtkq.Text += "\r\n\t\t\tX[" + (i + 1) + "]=" + M[i, n - 1];
                }

                //printf("\n");
            }

            // TH2 HPTTT co vo so nghiem Khi rA == rM < 3(so an):
            if (rA == rM && rA < n - 1)
            {
                txtkq.Text = " He phuong trinh co vo so nghiem.";
            }

            // TH2 HPTTT vo nghiem Khi rA < rM:
            if (rA < rM)
            {
                txtkq.Text = " He phuong trinh vo nghiem. ";
            }

        }

        private void buttontinh_Click_1(object sender, EventArgs e)
        {
            try
            {
                //HeSo hs1 = new HeSo(double.Parse(x1.Text), double.Parse(y1.Text), double.Parse(z1.Text), double.Parse(k1.Text));
                // HeSo hs2 = new HeSo(double.Parse(x1.Text), double.Parse(y2.Text), double.Parse(z2.Text), double.Parse(k2.Text));
                // HeSo hs3 = new HeSo(double.Parse(x1.Text), double.Parse(y2.Text), double.Parse(z3.Text), double.Parse(k3.Text));
                int n = 4; // n la so cot
                int m = 3; // m la so hang;
                double[,] M = new double[,]    { { double.Parse(x1.Text), double.Parse(y1.Text), double.Parse(z1.Text), double.Parse(k1.Text) },
                                                 { double.Parse(x2.Text), double.Parse(y2.Text), double.Parse(z2.Text), double.Parse(k2.Text) },
                                                 { double.Parse(x3.Text), double.Parse(y3.Text), double.Parse(z3.Text), double.Parse(k3.Text) }
                                                };

                rutgonvematranbacthang(M, m, n);
                bienluannghiem(M, m, n);
            }
            catch
            {
                txtkq.Text = "chương trình hoặc số liệu gặp lỗi , xin vui lòng kiểm tra lại!";
            }
        }
    }
}
