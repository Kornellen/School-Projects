namespace MOBILNA___aplikacja_greetings
{
    public partial class MainPage : ContentPage
    {
        private int counter = 0;

        private string[] greetings = { "Dzień dobry", "Good morning", "Buenos dias" };
        public MainPage()
        {
            InitializeComponent();
            greetingLbl.Text = greetings[0];

        }

        private void sizeSld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int size = (int)sizeSld.Value;

            if (size == 0) greetingLbl.IsVisible = false;
            else greetingLbl.IsVisible = true;

            greetingLbl.FontSize = size;

            sizeLbl.Text = $"Rozmiar: {size}";
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            counter++;

            if (counter >= greetings.Length) counter = 0;

            greetingLbl.Text = greetings[counter];
        }
    }
}
