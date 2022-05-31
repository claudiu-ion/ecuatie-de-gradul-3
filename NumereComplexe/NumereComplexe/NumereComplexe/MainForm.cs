using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace NumereComplexe
{
    
    public partial class MainForm : Form
    {
        private static AboutForm aboutForm = new AboutForm();
        private Graphics myDC;  // my device context
        private Bitmap myBmp;   // my bitmap
        private SolidBrush myBrush;

        public const int latBmp = 600;      // latura bitmapului    
        public readonly List<Pixel> bmpPixels = new List<Pixel>() { };
        public const int dimPal = 1024;     // numarul de culori in paleta
        private Color[] paleta = new Color[dimPal];

        public Color PenColor { get; set; }     // culoarea scrisului
        public Color ScreenColor { get; set; }  // culoarea fondului

        private bool isWorking = false;
        public static Complex[] x = new Complex[3];
        public MainForm()
        {
            InitializeComponent();
            
            
            this.picBox.Size = new System.Drawing.Size(latBmp + 1, latBmp + 1);
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Size = new System.Drawing.Size(latBmp + 25, 24);
            this.KeyPreview = true;
            this.startToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = false;
            for (int k = 0; k < dimPal; k++)
            {
                double tcol = 56.123 + 2.0 * Math.PI * k / (double)dimPal;
                int rcol = (int)(128 + 128 * Math.Sin(tcol));
                int gcol = (int)(128 + 128 * Math.Sin(2 * tcol));
                int bcol = (int)(128 + 128 * Math.Cos(3 * tcol));
                paleta[k] = Color.FromArgb(rcol % 256, gcol % 256, bcol % 256);
            }

            //in lista bmpPixels stocam toti Pixel-ii corespunzatori PictureBox-ului picBox

            for (int ii = 0; ii < latBmp; ii++)
            {
                for (int jj = 0; jj < latBmp; jj++)
                {
                    bmpPixels.Add(new Pixel(ii, jj));
                }
            }

            ScreenColor = Color.MediumSpringGreen;
            PenColor = Color.Black;

            writeTitleBar("");
        }
         
        private void ComplexForm_Load(object sender, EventArgs e)
        {
            myBmp = new Bitmap(latBmp, latBmp, PixelFormat.Format24bppRgb);
            myBmp.SetResolution(300F, 300F);
            picBox.Image = myBmp;
            myDC = Graphics.FromImage(myBmp);
            myBrush = new SolidBrush(ScreenColor);
            myDC.FillRectangle(myBrush, 644, 24, latBmp, latBmp);
        }

        private void ComplexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isWorking = false;   //esential: ca sa stopam desenarea 
        }

        public virtual void makeImage()     //trebuie suprascrisa      
        {
            setXminXmaxYminYmax(-10, 10, -10, 10);
            ScreenColor = Color.MediumSpringGreen;
            Complex[] y = new Complex[3];
            y = x;
            foreach (Pixel p in bmpPixels)
            {
                Complex z = getZ(p);
                
                if ((z-y[0]).Ro < 0.2)
                    setPixel(p, Color.Black);
                if ((z-y[1]).Ro < 0.2)
                    setPixel(p, Color.Black);
                if ((z-y[2]).Ro < 0.2)
                    setPixel(p, Color.Black);
            }
            for (int j = 0; j < 3; j++)
                if (y[0] != y[1] && y[0] != y[2] && y[2] != y[1])
                    setTextAt(y[j], "X" + j);
                else
                    setTextAt(y[1], "X");
            setAxis();

        }

        public void setText(params string[] mesaj)
        {
            myBrush.Color = PenColor;
            using (Font font = new Font("Arial", 3.2f))
            {
                for (int k = 0; k < mesaj.Length; k++)
                    myDC.DrawString(mesaj[k], font, myBrush, 0.0F, k * 15.0F);
            }
        }
        public void setTextAt(Complex z, string msg)
        {
            myBrush.Color = PenColor;
            using (Font font = new Font("Arial", 3.2f))
            {
                myDC.DrawString(msg, font, myBrush, getI(z.Re), jmax - getJ(z.Im));
            }
        }
        public void initScreen()
        {
            myBrush.Color = ScreenColor;
            myDC.FillRectangle(myBrush, 0, 0,  latBmp, latBmp);
            picBox.Invalidate();
        }

        public bool resetScreen()
        {
            picBox.Refresh();           //pentru re-pictarea ferestrei
            Application.DoEvents();     //pentru procesarea mesajelor
            return isWorking;           //pentru semnalizarea opririi desenarii
        }


        private void writeTitleBar(string msg)
        {
            this.Text = this.GetType().ToString();
            if (msg != "") this.Text += " (" + msg + ")";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.startToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Enabled = true;

            initScreen();
            isWorking = true;
            writeTitleBar("in lucru");
            makeImage();
            if (isWorking) writeTitleBar("complet");
            else writeTitleBar("oprit");
            isWorking = false;
            this.startToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = false;




        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isWorking = false;
            this.startToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = false;
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isWorking = false;
            this.Close();
        }

       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        private void ComplexForm_KeyPress(object sender, KeyPressEventArgs e)
        {                // tasta <space> lanseaza/opreste desenarea
            if (e.KeyChar != ' ') return;
            e.Handled = true;
            if (!isWorking) startToolStripMenuItem_Click(null, null);
            else stopToolStripMenuItem_Click(null, null);

        }
        public void delaySec(double s)
        {
            if (s <= 0) return;
            if (s > 10) s = 10;
            Thread.Sleep((int)(1000 * s));
        }

        private void btnRezolva_Click(object sender, EventArgs e)
        {
          
                Complex a = 0, b = 0, c = 0, d = 0;
                string z;
            
                try
            {
                
                
                a = a.citire(camp_a.Text);
                

                
                b = b.citire(camp_b.Text);

                
                c = c.citire(camp_c.Text);

                
                d = d.citire(camp_d.Text);
                if (a == 0)
                    throw new Exception();
                if (a != 1)
                    label.Text = "Ecuatia: " + a + " * x^3";
                else
                    label.Text = "Ecuatia: x^3";
                if (b != 0)
                    if (b != 1)
                        label.Text += " + " + b + " * x^2";
                    else
                        label.Text += " + x^2";
                if (c != 0)
                    if (c != 1)
                        label.Text += " + " + c + " * x";
                    else
                        label.Text += " + x";
                if (d != 0)                   
                        label.Text += " + " + d + " = 0 \n";
                    
                Complex p = (3 * a * c - b.rlp(2)) / (3 * a.rlp(2));
                Complex q = (27 * (a).rlp(2) * d - 9 * a * b * c + 2 * (b).rlp(3)) / (27 * (a).rlp(3));
                Complex h = b / (3 * a);
                Complex[] y = new Complex[3];
                //Complex[] x = new Complex[3];
                Complex u = (-q / 2 + (q.rlp(2) / 4 + p.rlp(3) / 27).rlp(1.0 / 2)).rlp(1.0 / 3);
                Complex v = -(q / 2 + (q.rlp(2) / 4 + p.rlp(3) / 27).rlp(1.0 / 2)).rlp(1.0 / 3);
                Complex j1 = Complex.setReIm(-1.0 / 2, Math.Sqrt(3.0) / 2);
                Complex j2 = Complex.setReIm(-1.0 / 2, -Math.Sqrt(3.0) / 2);
                if (p == 0 && q != 0)
                {
                    y[0] = -(q).rlp(1.0 / 3);
                    y[1] = -(q).rlp(1.0 / 3) * j1;
                    y[2] = -(q).rlp(1.0 / 3) * j2;
                    
                }
                else if (p == 0 && q == 0)
                {
                    for (int j = 0; j < 3; j++)
                        y[j] = 0;
                    
                }
                else if (p != 0 && q == 0)
                {
                    y[0] = 0;
                    y[1] = (p / 3).rlp(1.0 / 2) * j1 - (p / 3).rlp(1.0 / 2) * j2;
                    y[2] = (p / 3).rlp(1.0 / 2) * j2 - (p / 3).rlp(1.0 / 2) * j1;
                    
                }
                else if (p != 0 && q != 0)
                {
                    y[0] = u + v;
                    y[1] = u * j1 + v * j2;
                    y[2] = u * j2 + v * j1;
                    
                }

                for (int j = 0; j < 3; j++)
                {
                    x[j] = y[j] - h;
                    
                    
                }
                rez.Text = "Solutiile sunt: \r\n\r\nx1 = " + x[0] + "\r\nx2 = " + x[1] + "\r\nx3 = " + x[2];
                this.startToolStripMenuItem.Enabled = false;
                this.stopToolStripMenuItem.Enabled = true;

                initScreen();
                isWorking = true;
                writeTitleBar("in lucru");
                makeImage();
                if (isWorking) writeTitleBar("complet");
                else writeTitleBar("oprit");
                isWorking = false;
                this.startToolStripMenuItem.Enabled = true;
                this.stopToolStripMenuItem.Enabled = false;

            }
            catch(Exception)
            {
                MessageBox.Show("Verificati valoarea lui a!");
            }
            
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeseneaza_Click(object sender, EventArgs e)
        {
            

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rez_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
