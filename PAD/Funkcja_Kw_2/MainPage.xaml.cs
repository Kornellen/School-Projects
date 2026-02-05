namespace Funkcja_Kw_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private double CalculateQuadric(double a, double b, double c, double x) => a * Math.Pow(x, 2) + b * x + c;
        private void calculateBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(aValueEty.Text);
                double b = Convert.ToDouble(bValueEty.Text);
                double c = Convert.ToDouble(cValueEty.Text);
                double x = Convert.ToDouble(xValueEty.Text);

                // ax² + bx + c
                formattedFunc.Text = $"f(x) = {(a != 1 ? a : "")}x² {(b < 0 ? "" : "+")} {b}x {(c < 0 ? "" : "+")} {c}";
                resultLbl.Text = $"Wynik: {CalculateQuadric(a, b, c, x)}";
            }
            catch (Exception)
            {
                resultLbl.Text = "Wprowadź poprawne dane!";
            }
        }
    }
}
