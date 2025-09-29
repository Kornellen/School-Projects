using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytm_Euklidesa_odejmowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Restowanie koloru wyniku
                resultLbl.ForeColor = Color.Black;

                // Pobieranie wartości z formualrza i ich parsowanie na INT oraz uzyskiwanie ich wartości bezwględnych
                int numA = Math.Abs(int.Parse(numATBox.Text));
                int numB = Math.Abs(int.Parse(numBTBox.Text));

                // Metoda mająca za zadanie walidację wprowadzonych danych
                ValidateInputs(numA, numB);

                resultTitleLbl.Text = $"Wynik NWD({numA}, {numB}): ";

                // Główna logika Algorytmu euklidesowskiego
                CalculateGCD(numA, numB);

            }
            catch (Exception ex)
            {
                // Dodawanie do listy errora
                historyLBox.Items.Add(ex.Message);

                // Zmiana koloru wyniku na czerwony
                resultLbl.ForeColor = Color.Red;

                // Wyświetlenie erroru
                resultLbl.Text = ex.Message;
            }
        }

        private void ValidateInputs(int numA, int numB)
        {
            // Sprawdzanie czy podane wartości są równe 0
            if (numA == 0 && numB == 0)
            {
                // Jeśli obydwie wartości są równe 0, rzucamy wyjątek mówiący o tym, że nie można określi NWD
                throw new Exception("Nie można określić NWD!");
            }
            // Jeśli wartość A jest równa 0, zwracamy wartość B (wartości bezwględne wartości zostały wcześniej ustalone)
            if (numA == 0 && numB != 0)
            {
                resultLbl.Text = numB.ToString();
                return;
            }
            // Jeśli wartość B jest równa 0, zwracamy wartość A
            if (numA != 0 && numB == 0)
            {
                resultLbl.Text = numA.ToString();
                return;
            }
        }

        private void CalculateGCD(int numA, int numB)
        {
            // Liczba kroków
            int step = 0;

            historyLBox.Items.Add($"-----------NWD({numA}, {numB})----------------");

            // Właściwy Algorytm Euklidesa
            while (numA != numB)
            {
                historyLBox.Items.Add($"numA = {numA}        numB = {numB}");
                if (numA > numB)
                {
                    historyLBox.Items.Add($"Krok {step + 1}: numA = numA - numB");
                    numA = numA - numB;
                }
                else if (numA < numB)
                {
                    historyLBox.Items.Add($"Krok {step + 1}: numB = numB - numA");
                    numB = numB - numA;
                }

                step++;
            }

            historyLBox.Items.Add("----------------------------------------------");

            // Wyświetlenie wyniku

            resultLbl.Text = numA.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Kolekcja wszystkich kontrolek do czyszczenia
            Control[] controls = { numATBox, numBTBox, resultLbl };

            // Iterowanie po kolekcji kontrolek i ich czyszczenie
            foreach (Control control in controls)
            {
                control.Text = string.Empty;
            }

            // Czyszczenie historii ostatnich operacji
            historyLBox.Items.Clear();

            resultTitleLbl.Text = "Wynik";
        }
    }
}
