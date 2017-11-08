using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepulatorV2
{
    public partial class pepulator : Form
    {
        public pepulator()
        {
            InitializeComponent();
        }

        bool doneMath = false;
        decimal tall1 = 0;
        decimal tall2 = 0;
        string regOp = "";

        private void DoMath()
        {
            tall2 = Convert.ToDecimal(outBx.Text);
            decimal res = 0;

            switch (regOp)
            {
                case "+": res = tall1 + tall2; break;
                case "-": res = tall1 - tall2; break;
                case "*": res = tall1 * tall2; break;
                case "/":
                    if (tall2 != 0)
                    {
                        res = tall1 / tall2;
                    }
                    else if (tall1 == 0 && tall2 == 0)
                    {
                        res = 1;
                    }
                    break;
                case "": res = tall2; break;
                default: res = 0; break;

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

        private void bt_Click(object sender, EventArgs e)
        {
            btEq.Focus();
            Button b = sender as Button;

            switch (b.Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    if ((outBx.Text == "0") || (doneMath))
                    {
                        outBx.Text = "";
                        doneMath = false;
                    }
                    outBx.Text += b.Text;
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                    tall1 = Convert.ToDecimal(outBx.Text);
                    doneMath = true;
                    outBx.Text = "";
                    Task.Delay(50).Wait();
                    outBx.Text = Convert.ToString(tall1);
                    regOp = b.Text;
                    break;
                case ",":
                    if (!outBx.Text.Contains(","))
                    {
                        outBx.Text += b.Text;
                    }
                    break;
                case "C":
                    tall1 = 0;
                    tall2 = 0;
                    doneMath = false;
                    regOp = "";
                    outBx.Text = "";
                    Task.Delay(50).Wait();
                    outBx.Text = "0";
                    break;
                case "←":
                    if (!doneMath)
                    {
                        outBx.Text = outBx.Text.Remove(outBx.Text.Length - 1);
                    }
                    if (outBx.Text == "")
                    {
                        outBx.Text = "0";
                    }
                    break;
                case "=":
                    DoMath();
                    break;
            }
            
        }

        private void key_Down(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D0 | Keys.Shift: btEq.PerformClick(); break; 
                case Keys.D1: bt1.PerformClick(); break;
                case Keys.D2: bt2.PerformClick(); break;
                case Keys.D3: bt3.PerformClick(); break;
                case Keys.D4: bt4.PerformClick(); break;
                case Keys.D5: bt5.PerformClick(); break;
                case Keys.D6: bt6.PerformClick(); break;
                case Keys.D7: bt7.PerformClick(); break;
                case Keys.D8: bt8.PerformClick(); break;
                case Keys.D9: bt9.PerformClick(); break;
                case Keys.D0: bt0.PerformClick(); break;

                case Keys.P:
                case Keys.Oemplus: btPlu.PerformClick(); break;
                case Keys.OemMinus: btMin.PerformClick(); break;
                case Keys.OemQuestion | Keys.Shift:
                case Keys.M: btTi.PerformClick(); break;
                case Keys.D7 | Keys.Shift:
                case Keys.D: btDiv.PerformClick(); break;

                case Keys.OemPeriod: btCom.PerformClick(); break;
                case Keys.Escape: btCle.PerformClick(); break;
                case Keys.Enter: btEq.PerformClick(); break;
                case Keys.Back: btBack.PerformClick(); break;
            }
        }
    }
}
