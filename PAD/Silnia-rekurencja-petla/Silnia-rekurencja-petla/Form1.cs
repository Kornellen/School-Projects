using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;

namespace Silnia_rekurencja_petla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int number = 0;
        private Stopwatch timer = new Stopwatch();
        private int counter = 0;
        private void recursionBtn_Click(object sender, EventArgs e)
        {
            counter = 0;
            try
            {
                GetUserInput();

                ValidateInput(2000);

                AddTextToRTBox("Liczba Wywołań Funkcji", SilniaByRecursion);
            }
            catch (Exception ex)
            {
                resultLbl.Text = ex.Message;
            }
        }

        private void LoopBtn_Click(object sender, EventArgs e)
        {
            counter = 0;
            try
            {
                GetUserInput();

                ValidateInput(100);

                AddTextToRTBox("Liczba Mnożeń", SilniaByLoop);
            }
            catch (Exception ex)
            {
                resultLbl.Text = ex.Message;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Control[] controls = { resultLbl, stepHistoryRTBox, numTBox };

            foreach (Control control in controls)
            {
                control.Text = string.Empty;
            }
        }

        private void ValidateInput(int max)
        {
            if (number < 0)
            {
                throw new Exception("Podaj liczbę całkowitą nieujemną!");
            }

            if (number >= max)
            {
                throw new StackOverflowException("Troszeczkę za duża liczba... 👉👈");
            }
        }

        private void GetUserInput()
        {
            number = int.Parse(numTBox.Text);
        }

        private void AddTextToRTBox(string headerMsg, Func<int, BigInteger> Callback)
        {
            stepHistoryRTBox.Text += $"\n------- {headerMsg} -----\n";

            timer.Start();
            resultLbl.Text = Callback(number).ToString();
            timer.Stop();

            stepHistoryRTBox.Text += "Czas wykonywania obliczeń: " + timer.ElapsedMilliseconds + "ms\n";
            stepHistoryRTBox.Text += "-----------------------------------------";
        }

        public BigInteger SilniaByRecursion(int n)
        {
            counter++;
            stepHistoryRTBox.Text += "Wywołanie nr. " + counter.ToString() + "\n";

            if (n == 0) return 1;
            return n * SilniaByRecursion(n - 1);
        }
        public BigInteger SilniaByLoop(int n)
        {
            BigInteger result = 1;
            for (int i = n; i > -1; i--)
            {
                counter++;
                stepHistoryRTBox.Text += "Mnożenie nr. " + counter.ToString() + "\n";
                if (i == 0) return result *= 1;
                result *= i;
            }

            return result;
        }
    }
}
