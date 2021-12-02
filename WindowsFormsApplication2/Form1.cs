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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '9';
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '.';
        }

        private void btnmuoimu_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "*10^(";
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '+';
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '-';
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '*';
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + '/';
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtstr.Text!="")
            {
                string s = txtstr.Text;
                txtstr.Text=s.Remove(s.Length-1);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtstr.Text = null;
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "sin(";
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "cos(";
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "tan(";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "ln(";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "log(";
        }

        private void btnphay_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + ",";
        }

        private void btnmu_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "( )^( )";
        }

        private void btnngoacmo_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "(";
        }

        private void btnngoacdong_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + ")";
        }

        private void btni_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "i";
        }
        private int i = 10;
        private int demloaipt = 1;
        private string a = "";
        private double at = 0;
        private string b = "";
        private double bt = 0; 
         private string c = "";
        private double ct = 0; 
        private string d = "";
        private double dt = 0; 
        private void btnbang_Click(object sender, EventArgs e)
        {
            if( ktrun=true && ktshift==true )
            {
                txtkq1.Text = "";
                txtkq2.Text = "";
                timer1.Enabled = true;
            }
            if(ktbt==true)
            {
                txtkq2.TextAlign = HorizontalAlignment.Right;
                try
                {
                    if (txtstr.Text != "")
                    {
                        string str = txtstr.Text;
                        txtkq2.Text = ""+ bieuthuc.tinhgiatribt(str).ToString();
                    }
                }
                catch
                {
                    txtkq1.Text="";
                    txtkq2.Text = "Math ERROR.Please try !!";
                }
            }
            if(ktpt==true)
            {
                
                txtkq1.Enabled = false;
                txtkq2.Enabled = false;
                txtkq1.TextAlign = HorizontalAlignment.Right;
                txtkq2.TextAlign = HorizontalAlignment.Right;
                try
                {
                    
                    if (bd == 1 ||bd==2)
                    {
                         a = (txtstr.Text).Remove(0, 4);
                         at = bieuthuc.tinhgiatribt(a);
                         b = (txtkq1.Text).Remove(0, 4);
                        bt = bieuthuc.tinhgiatribt(b);
                      c = (txtkq2.Text).Remove(0, 4);
                         ct = bieuthuc.tinhgiatribt(c);
                        giaiptb2 gt = new giaiptb2(at, bt, ct);
                        txtstr.Text = "(" + gt.a + ")x^2 + (" + gt.b + ")x + (" + gt.c+") = 0";
                        if (bd == 1)
                        {
                            gt.gptb2r();
                            if (gt.vn == "vô nghiệm")
                            {
                                txtkq1.Text = null;
                                txtkq2.Text = "vô nghiệm";
                            }
                            if (gt.vsn == "vô số nghiệm")
                            {
                                txtkq1.Text = null;
                                txtkq2.Text = "vô số nghiệm";
                            }
                            if (gt.vn != "vô nghiệm" && gt.vsn != "vô số nghiệm")
                            {
                                txtkq1.Text = "x1=" + gt.x1.ToString();
                                txtkq2.Text = "x2=" + gt.x2.ToString();
                            }
                        }
                        else
                        {
                            gt.gptb2i();
                            txtkq1.Text = "x1=" + gt.spa.phannguyen + " + " + gt.spa.phanthuc + "i";
                            txtkq2.Text = "x2=" + gt.spb.phannguyen + " + " + gt.spb.phanthuc + "i";
                        }
                    }
                    else
                    {
                        
                            txtkq1.Enabled = false;
                            txtkq2.Enabled = false;
                            txtstr.Enabled = true;
                            
                       
                        
                        if (demloaipt%2==1)
                        {
                            a = (txtstr.Text).Remove(0, 4);
                            at = bieuthuc.tinhgiatribt(a);
                             b = (txtkq1.Text).Remove(0, 4);
                            bt = bieuthuc.tinhgiatribt(b);
                           c = (txtkq2.Text).Remove(0, 4);
                             ct = bieuthuc.tinhgiatribt(c);
                            txtstr.Text = "d = ";
                            txtkq1.Text = "";
                            txtkq2.Text = "";
                            txtkq1.Enabled = false;
                            txtkq2.Enabled = false;
                            txtstr.Enabled = true;
                        }
                        else
                        {
                            
                            d = (txtstr.Text).Remove(0, 4);
                            dt = bieuthuc.tinhgiatribt(d);
                            giaiptb3 ptb3 = new giaiptb3(at,bt,ct,dt);
                            ptb3.giaiptbac3();
                            if (ptb3.dem == 1)
                            {
                                txtkq1.Text = "";
                                txtkq2.Text = "";
                                txtstr.Text = "";
                                txtkq2.Text = "X1 = " + ptb3.x1.ToString();
                            }
                            if (ptb3.dem == 3)
                            {
                                txtkq1.Text = "";
                                txtkq2.Text = "";
                                txtstr.Text = "";
                                txtkq1.TextAlign = HorizontalAlignment.Left;
                                txtkq2.TextAlign = HorizontalAlignment.Left;
                                txtkq1.Text = "X1 = " + ptb3.x1.ToString();
                                txtkq2.Text = "X2 = " + ptb3.x2.ToString();
                                txtstr.Text = "X3 = " + ptb3.x3.ToString();
                                txtstr.Enabled = false;
                            }
                        }
                        

                        demloaipt++;
                    }
                }
                catch
                {
                    txtkq1.Text = "";
                    txtkq2.Text = "Math ERROR.Please try !!";
                }
            }
            if(kttt==true)
            {
                
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "!";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "^2";
        }

        private void btncanbachai_Click(object sender, EventArgs e)
        {
            txtstr.Text = txtstr.Text + "^0,5";
        }

        private void btnans_Click(object sender, EventArgs e)
        {
            if (txtkq2.Text != "")
            {
                txtstr.Text = txtstr.Text + "(" + txtkq2.Text + ")";
            }
            else
            {
                txtstr.Text = txtstr.Text + "0";
            }
        }
        public static bool ktbt=true;
        public static bool ktpt=false;
        public static bool kttt=false;
        private void biểuThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtstr.Location = new Point( panel2.Location.X-10, txtstr.Location.Y);
            txtstr.Text = "";
            txtkq1.Text = "";
            txtkq2.Text = "";
            ktbt = true;
            ktpt = false;
            kttt = false;
            ktshift = false;
            ktrun = false;
            txtkq1.Enabled = false;
            txtkq2.Enabled = false;
            txtstr.Enabled = true;
        }
        public int bd = 1;
        private void trênTậpRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtstr.Location = new Point(panel2.Location.X - 10, txtstr.Location.Y);
            txtkq1.TextAlign = HorizontalAlignment.Left;
            txtkq2.TextAlign = HorizontalAlignment.Left;
            bd = 1;
            ktbt = false;
            ktpt = true;
            kttt = false;
            ktshift = false;
            ktrun = false;
            txtkq1.Enabled = true;
            txtkq2.Enabled = true;
            txtstr.Enabled = true;
            txtstr.Text = "a = ";
            txtkq1.Text = "b = ";
            txtkq2.Text = "c = ";
        }

        private void trênTậpIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtstr.Location = new Point(panel2.Location.X - 10, txtstr.Location.Y);
            txtkq1.TextAlign = HorizontalAlignment.Left;
            txtkq2.TextAlign = HorizontalAlignment.Left;
            bd = 2;
            ktbt = false;
            ktpt = true;
            kttt = false;
            ktshift = false;
            ktrun = false;
            txtkq1.Enabled = true;
            txtkq2.Enabled = true;
            txtstr.Enabled = true;
            txtstr.Text = "a = ";
            txtkq1.Text = "b = ";
            txtkq2.Text = "c = ";
        }

        private void tínhTổngChuỗiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        public static bool ktshift = false;
        public static bool ktrun=false;
        private void btnshift_Click(object sender, EventArgs e)
        {
            ktbt = false;
            ktpt = false;
            kttt = false;
            ktshift = true;
            ktrun = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtstr.Location = new Point(txtstr.Location.X + 20, txtstr.Location.Y);
            if(txtstr.Location.X>=270)
            {
                txtstr.Location = new Point(txtstr.Location.X -270+ 10, txtstr.Location.Y);
            }
            //lbchu.Text = txtstr.Text;
            //lbchu.Location = new Point(lbchu.Location.X + 5, lbchu.Location.Y);
            // or co the viet lbchu.left -=5 thi dich sang trai 5dv +=5 thi dich sang phai 5
            //if (lbchu.Location.X>=270)
            //{
            //    lbchu.Location = new Point(lbchu.Location.X -270+10, lbchu.Location.Y);
            //}
            //else
            //{
            //    lbchu.Location = new Point(lbchu.Location.X + 10, lbchu.Location.Y);
            //}
            //panel1.Left -= 10;
        }
        private void btnrun_Click(object sender, EventArgs e)
        {
            ktshift = false;
            ktrun = true;
        }

        private void ptB3TrenRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtstr.Location = new Point(panel2.Location.X - 10, txtstr.Location.Y);
            txtkq1.TextAlign = HorizontalAlignment.Left;
            txtkq2.TextAlign = HorizontalAlignment.Left;
            bd = 3;
            demloaipt = 1;
            ktbt = false;
            ktpt = true;
            kttt = false;
            ktshift = false;
            ktrun = false;
            txtkq1.Enabled = true;
            txtkq2.Enabled = true;
            txtstr.Enabled = true;
            txtstr.Text = "a = ";
            txtkq1.Text = "b = ";
            txtkq2.Text = "c = ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtstr.Location = new Point(panel2.Location.X - 10, txtstr.Location.Y);
            txtstr.Text = "";
            txtkq1.Text = "";
            txtkq2.Text = "";
            ktbt = true;
            ktpt = false;
            kttt = false;
            ktshift = false;
            ktrun = false;
            txtkq1.Enabled = false;
            txtkq2.Enabled = false;
            txtstr.Enabled = true;
        }

        private void hePt2AnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaiheptb2 frm = new giaiheptb2();
                frm.Show();
        }

        private void tínhBiểuThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ktbt = false;
            ktpt = false;
            ktshift = false;
            ktrun = false;
            kttt = true;
        }

        private void hePt3AnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaiheptb3 frm = new giaiheptb3();
            frm.Show();
        }
    }
}
