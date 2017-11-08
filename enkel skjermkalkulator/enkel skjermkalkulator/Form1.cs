using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enkel_skjermkalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Nullsjekk og variabler
        // Variables
        decimal tall1 = 0;
        string regOp = "";
        bool doneMath = false;

        private void checkZero()
        {
            if ((outBx.Text == "0") || (doneMath))
            {
                outBx.Text = "";
                doneMath = false;
            }
        }
#endregion

        #region Talltaster

        private void bt0_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            checkZero();
            outBx.Text += bt9.Text;
        }

        #endregion

        #region Lik-knapp

        // Er lik knapp
        private void btEq_Click(object sender, EventArgs e)
        {
            decimal tall2 = Convert.ToDecimal(outBx.Text);
            decimal res = 0;
            
            switch (regOp)
            {
                case "+":
                    res = tall1 + tall2;
                    break;
                case "-":
                    res = tall1 - tall2;
                    break;
                case "*":
                    res = tall1 * tall2;
                    break;
                case "/":
                    if (tall2 != 0)
                    {
                        res = tall1 / tall2;
                    }else if (tall1 == 0 && tall2 == 0) {
                        res = 1;
                    }                   
                    break;
                case "":
                    res = tall2;
                    break;
                default:
                    res = 0;
                    break;

            }

            outBx.Text = "";
            Task.Delay(50).Wait();
            if (tall2 == 0 && tall1 != 0 && regOp == "/")
            {
                outBx.Text = "NaN";
            }
            else
            {
                outBx.Text = Convert.ToString(res);
            }
            doneMath = true;
        }
#endregion

        #region Funksjonstaster

        private void btPlu_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(outBx.Text);
            regOp = "+";
            outBx.Text = "";
            Task.Delay(50).Wait();
            outBx.Text = "0";
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(outBx.Text);
            regOp = "-";
            outBx.Text = "";
            Task.Delay(50).Wait();
            outBx.Text = "0";
        }

        private void btTi_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(outBx.Text);
            regOp = "*";
            outBx.Text = "";
            Task.Delay(50).Wait();
            outBx.Text = "0";
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(outBx.Text);
            regOp = "/";
            outBx.Text = "";
            Task.Delay(50).Wait();
            outBx.Text = "0";
        }

        private void btCle_Click(object sender, EventArgs e)
        {
            tall1 = 0;
            regOp = "";
            outBx.Text = "";
            Task.Delay(50).Wait();
            outBx.Text = "0";
            doneMath = false;
            regOp = "";
        }

        private void btCom_Click(object sender, EventArgs e)
        {
            if (doneMath)
            {
                outBx.Text = "0,";
            }else if (!outBx.Text.Contains(","))
            {
                outBx.Text += btCom.Text;
            }
        }

        private void btPM_Click(object sender, EventArgs e)
        {
            outBx.Text = Convert.ToString(-1 * Convert.ToDecimal(outBx.Text));
        }

        #endregion


    }
}
