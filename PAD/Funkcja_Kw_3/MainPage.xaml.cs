namespace Funkcja_Kw_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calculateBtn_Clicked(object sender, EventArgs e)
        {

            try
            {
                // Pobieranie wartości od Usera wg. wzoru ax² + bx + c
                double a = Convert.ToDouble(aValueEty.Text);
                double b = Convert.ToDouble(bValueEty.Text);
                double c = Convert.ToDouble(cValueEty.Text);


                // Obsługa wyjątku, gdy a = 0, czyli f(x) = bx + c, co nie jest f. kw
                if (a == 0) throw new Exception("Podana Funkcja to nie funkcja kwadratowa (a = 0)");


                // Ustalanie pozycji wierzchołka
                double xFuncTop = -b / (2 * a);
                double yFuncTop = (a * Math.Pow(xFuncTop, 2)) + (b * xFuncTop) + c;

                // Obliczanie Δ ze wzoru b² - 4ac
                double Δ = Math.Pow(b, 2) - 4 * a * c;

                // Obsługa sytuacji Δ < 0
                if (Δ < 0) throw new Exception("Δ jest ujemna! Funkcja nie ma miejsc zerowych");

                // tablica na miejsca zerowe
                double[] results = new double[2];

                // Obsługa sytuacji Δ == 0
                if (Δ == 0)
                {
                    results[0] = -b / (2 * a);

                    zeroPlaces.Text = $"Δ jest równa 0. Miejsce zerowe to x = {results[0]}";

                    return;
                }

                // Obsługa sytuacji Δ > 0

                results[0] = (-b + Math.Sqrt(Δ)) / (2 * a);
                results[1] = (-b - Math.Sqrt(Δ)) / (2 * a);


                zeroPlaces.Text = $"Miejsca Zerowe: x ∊ {{{results.Min()}; {results.Max()}}}";
            }
            catch (Exception ex)
            {
                zeroPlaces.Text = ex.Message;
            }
        }
    }
}
