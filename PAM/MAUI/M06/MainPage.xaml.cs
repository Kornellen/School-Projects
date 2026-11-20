namespace M06
{
    internal class Rachunek
    {
        public double amount;
        public double tipPercent;
        public int numberOfPeople;
        public bool isCeil;

        public double Tip() {
            return amount * tipPercent;
        }
        public double Total() {
            return amount + Tip();
        }
        public double PerPerson() {
            if (isCeil) return Math.Ceiling(Total() / numberOfPeople);
            
            return Total() / numberOfPeople;
        }
    }

    public partial class MainPage : ContentPage
    {
        private Rachunek rachunek = new();
        private int DEFAULT_PEOPLE = 2;
        public MainPage()
        {
            InitializeComponent();

            peoplesLbl.Text = Convert.ToString(DEFAULT_PEOPLE);
            rachunek.numberOfPeople = DEFAULT_PEOPLE;
        }

        private void tipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            rachunek.tipPercent = Math.Floor(e.NewValue) / 100;
            tipLblSlider.Text = $"Napiwek: {Math.Floor(e.NewValue)}%";
            UpdateView();
        }

        private void UpdateView()
        {
            tipLbl.Text = $"{rachunek.Tip():F2}";
            totalLbl.Text = $"{rachunek.Total():F2}";
            perPersonLbl.Text = $"{rachunek.PerPerson():F2}";
        }

        private void amoutEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(e.NewTextValue)) return; 
                rachunek.amount = Convert.ToDouble(e.NewTextValue);
                UpdateView();
            }
            catch (Exception)
            {
            }
        }

        private void isCeiledCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            rachunek.isCeil = e.Value;

            UpdateView();
        }

        private void incrementBtn_Clicked(object sender, EventArgs e)
        {
            if (rachunek.numberOfPeople < 20) rachunek.numberOfPeople++;
            peoplesLbl.Text = Convert.ToString(rachunek.numberOfPeople);
            
            UpdateView();
        }

        private void decrementBtn_Clicked(object sender, EventArgs e)
        {
            if (rachunek.numberOfPeople > 1) rachunek.numberOfPeople--;
            peoplesLbl.Text = Convert.ToString(rachunek.numberOfPeople);

            UpdateView();
        }
    }
}
