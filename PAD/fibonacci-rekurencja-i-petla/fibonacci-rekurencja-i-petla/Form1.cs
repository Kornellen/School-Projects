using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Diagnostics;

namespace fibonacci_rekurencja_i_petla
{
    public partial class Form1 : Form
    {
        private int steps;
        private Stopwatch timer = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            steps = 0;
        }

        private void recursionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                historyRTBox.Text += "Użyto wersji rekurencyjnej\n\n";
                steps = 0;

                int inputValue = int.Parse(inputTBox.Text);

                if (inputValue >= 30)
                {
                    throw new Exception("Zbyt Duża liczba na rekurencję...\nProszę o Podanie mniejszej liczby");
                }

                BigInteger result = PerformCalculations(inputValue, FibRecursion);

                historyRTBox.Text += $"Time: {timer.ElapsedMilliseconds}ms\n";
                historyRTBox.Text += "--------------------------------------\n";
                resultLbl.Text = $"F({inputValue}) = {result}";
            }
            catch (Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void iterationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                steps = 0;

                historyRTBox.Text += "Użyto Wersji Iteracyjnej (Poprzez pętlę)\n\n";

                int inputValue = int.Parse(inputTBox.Text);

                BigInteger result = PerformCalculations(inputValue, FibIteration);

                resultLbl.Text = $"F({inputValue}) = {result}";

                historyRTBox.Text += $"Time: {timer.ElapsedMilliseconds}ms\n";
                historyRTBox.Text += "--------------------------------------\n";
            }
            catch (Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Control[] controls = { historyRTBox, inputTBox, resultLbl };

            foreach (Control control in controls)
            {
                control.Text = String.Empty;
            }
        }

        private BigInteger FibRecursion(int n)
        {
            steps++;
            historyRTBox.Text += $"Step: {steps}\n";

            BigInteger result = BigInteger.Zero;

            if (n == 0)
            {
                return BigInteger.Zero;
            }
            if (n == 1)
            {
                return BigInteger.One;
            }

            result = FibRecursion(n - 1) + FibRecursion(n - 2);

            return result;
        }

        private BigInteger FibIteration(int n)
        {
            if (n == 0) { steps = 0; return 0; }
            if (n == 1) { steps = 0; return 1; }
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 0;

            for (int i = 2; i < n + 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
                steps++;
                historyRTBox.Text += $"Step: {steps}\n";
            }
            return b;
        }

        private void Log_Error(Exception ex)
        {
            historyRTBox.Text += "---------- Błąd --------\n";
            historyRTBox.Text += ex.Message + "\n";
            historyRTBox.Text += "--------------------------\n";
            resultLbl.Text = ex.Message;
        }

        private BigInteger PerformCalculations(int n, Func<int, BigInteger> callback)
        {
            timer.Restart();
            timer.Start();
            BigInteger result = callback(n);
            timer.Stop();

            return result;
        }
    }
}
