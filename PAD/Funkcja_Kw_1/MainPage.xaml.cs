namespace Funkcja_Kw_1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private double CalculateQuadric(double x) => 3 * Math.Pow(x, 2) - 2 * x + 2;

        private void calculateBtn_Clicked(object sender, EventArgs e)
        {
            double xValue = 0.7d;

            resultLbl.Text = $"Wynik: {CalculateQuadric(xValue)}";
        }
    }
}
