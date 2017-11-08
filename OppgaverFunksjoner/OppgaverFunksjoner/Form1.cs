using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OppgaverFunksjoner
{
    public partial class OppgaverFunksjoner : Form
    {
        public OppgaverFunksjoner()
        {
            InitializeComponent();

            // TextBoxArray for Oppgave 3
            tb = new TextBox[6] { arr1, arr2, arr3, arr4, arr5, arr6 };

        }

        #region Oppgave 1

        int a_1 = 4;
        int b_1 = 3;
        int c_1 = 5;
        int sum_1;

        private void Sum1()
        {
            sum_1 = a_1 + b_1;
            textOppg1a.Text = Convert.ToString(sum_1);
        }

        private void Sum1(int a, int b)
        {
            sum_1 = a + b;
            textOppg1b.Text = Convert.ToString(sum_1);
        }

        private int Sum1Ret()
        {
            return a_1 + b_1;
        }

        private int Sum1Ret(int a, int b)
        {
            return a + b;
        }

        private void Oppg1()
        {
            Sum1();
            Sum1(a_1, b_1);
            textOppg1c.Text = Convert.ToString(Sum1Ret());
            textOppg1d.Text = Convert.ToString(Sum1Ret(a_1, b_1));
            textOppg1g.Text = Convert.ToString(Sum1Ret(a_1, Sum1Ret(b_1, c_1)));
            intsOppg1.Text = "Variabler: a = " + a_1 + ", b = " + b_1 + ", c = " + c_1;
        }

        #endregion

        #region Oppgave 2

        #region Oppg a
        private double InchToCm(double inch)
        {
            return 2.54 * inch;
        }

        private void btInch_Click(object sender, EventArgs e)
        {
            textCm.Text = Convert.ToString(InchToCm(Convert.ToDouble(textInch.Text))) + " cm";
        }
        #endregion

        #region Oppg b
        private bool Between(int a, int min, int max)
        {
            if (a >= min && a <= max)
                return true;
            else
                return false;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (Between(Convert.ToInt32(textBetA.Text), Convert.ToInt32(textBetB.Text), Convert.ToInt32(textBetC.Text)))
                textBetRet.Text = "YES";
            else
                textBetRet.Text = "NO";
        }
        #endregion

        #region Oppg c

        Random rand = new Random();

        private int random(int min, int max)
        {
            return rand.Next(min, max);
        }

        private void btRand_Click(object sender, EventArgs e)
        {
            textRand.Text = Convert.ToString(random(Convert.ToInt32(textRanMin.Text), Convert.ToInt32(textRanMax.Text)));
        }

        #endregion

        #region Oppg d

        private decimal Snitt(decimal a, decimal b)
        {
            decimal s = (a + b) / 2;
            return s;
        }

        private void btSnitt_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(textSnittA.Text) && IsDigitsOnly(textSnittB.Text))
                textSnitt.Text = Convert.ToString(Snitt(Convert.ToDecimal(textSnittA.Text), Convert.ToDecimal(textSnittB.Text)));
        }

        #endregion

        #region Oppg e

        private bool EvenNum(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        private void btEven_Click(object sender, EventArgs e)
        {
            if (EvenNum(Convert.ToInt32(textEvenIn.Text.Substring(textEvenIn.Text.Length - 1))))
                textEven.Text = "EVEN";
            else
                textEven.Text = "ODD";
        }

        #endregion

        #endregion

        #region Oppgave 3

        TextBox[] tb;
        
        private void btArray_Click(object sender, EventArgs e)
        {
            int[] vars = new int[6];

            for (int i = 0; i < tb.Length; i++)
            {
                if (IsDigitsOnly(tb[i].Text) && tb[i].Text != "")
                    vars[i] = Convert.ToInt32(tb[i].Text);
                else
                {
                    tb[i].Text = "0";
                    vars[i] = 0;
                }
                
            }

            arrSum.Text = Convert.ToString(SumArr(vars));
            arrAv.Text = Convert.ToString(AveArr(vars));
            arrMax.Text = Convert.ToString(MaxArr(vars));
        }

        #region Oppgave 3a

        private int SumArr(int[] arr)
        {
            int s = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }

            return s;
        }

        #endregion

        #region Oppgave 3b

        private decimal AveArr(int[] arr)
        {
            return Convert.ToDecimal(SumArr(arr)) / arr.Length; ;
        }

        #endregion

        #region Oppgave 3c

        private int MaxArr(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[max] < arr[i])
                {
                    max = i;
                }
            }

            return arr[max];
        }

        #endregion

        #endregion

        #region Oppgave 4

        private void tbDClick(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            ClearTB(tb);
        }

        private void ClearTB(TextBox tb)
        {
            tb.Text = "";
        }

        #endregion

        #region Egen Contains

        private void btCont_Click(object sender, EventArgs e)
        {
            if (tbStr.Text.Length > 0 && tbCheck.Text.Length > 0)
                tbContRet.Text = "" + Inneholder(tbStr.Text, tbCheck.Text);
            else
                tbContRet.Text = "Error";
            
        }

        private bool Inneholder(String str, String check)
        {
            int i = 0;
            foreach (char ch in str)
            {
                if (check[i] == ch)
                {
                    i++;
                    if (i >= check.Length)
                        return true;
                }
                else
                    i = 0;
            }
            return false;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Oppg1();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        
    }
}
