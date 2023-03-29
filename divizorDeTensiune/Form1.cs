using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divizorDeTensiune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float fdivizorDeTensiune(float Uvolti, float R1, float R2)
        {
            return Uvolti * (R2 / (R1 + R2));          
        }
        public float calculRezistentaR1(float Uvolti, float UdoritaR1, float R2)
        {
            //5v , 0.7v , 75ohmi
            float s1 = (Uvolti * R2); //75*5=375
            float s2 = (UdoritaR1 * R2); //75 * 0.7 = 52.5
            s1 = s1 - s2; //375 - 52.5 = 322.5
            return s1 / UdoritaR1; // 322.5 / 0.7 = 460.7

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            float R1 = calculRezistentaR1(5.0f, 0.7f, 75.0f);
            Text = R1.ToString();
            Text += " : " + fdivizorDeTensiune(5.0f,R1 , 75.0f).ToString();

            float Rx = calculRezistentaR1(5.0f, 0.23f, 75.0f);
            Text = Rx.ToString();
            Text += " : " + fdivizorDeTensiune(5.0f, Rx, 75.0f).ToString();

        }
    }
}
