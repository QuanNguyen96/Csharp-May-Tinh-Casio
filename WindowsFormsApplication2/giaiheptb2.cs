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
    public partial class giaiheptb2 : Form
    {
        public giaiheptb2()
        {
            InitializeComponent();
        }

        private void buttontinh_Click(object sender, EventArgs e)
        {
            giaihept2an();
        }

        private void giaihept2an()
        {
            try
            {
                double a1, b1, c1, a2, b2, c2;
                double D, Dx, Dy, x, y;
                a1 = double.Parse(x1.Text);
                b1 = double.Parse(y1.Text);
                c1 = double.Parse(k1.Text);
                a2 = double.Parse(x2.Text);
                b2 = double.Parse(y2.Text);
                c2 = double.Parse(k2.Text);
                D = a1 * b2 - a2 * b1;
                Dx = c1 * b2 - c2 * b1;
                Dy = a1 * c2 - a2 * c1;
                if (D == 0)
                {
                    if (Dx + Dy == 0)
                        txtkq.Text = "Hệ phương trình có vô số nghiệm";
                    else
                        txtkq.Text = "hệ phương trình vô nghiệm";
                }
                else
                {
                    x = Dx / D;
                    y = Dy / D;
                    txtkq.Text = "Hệ phương trình có nghiệm  (x, y) = (" + x + "," + y + ")";
                }
            }
            catch
            {
                txtkq.Text = "chương trình hoặc số liệu gặp lỗi , xin vui lòng kiểm tra lại!";
            }
        }
        

        private void HePhuongTrinh2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            X.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;

        }
    }
}
