namespace Mobilna_galeria_zdjec
{
    public partial class MainPage : ContentPage
    {
        private int count = 1;
        public MainPage()
        {
            InitializeComponent();


        }
        private void prevBtn_Clicked(object sender, EventArgs e)
        {
            count--;

            if (count < 1) count = 4;

            catImg.Source = $"kot{count}.jpg";
        }

        private void nextBtn_Clicked(object sender, EventArgs e)
        {
            count++;

            if (count > 4) count = 1;

            catImg.Source = $"kot{count}.jpg";
        }

        private void imgEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (imgEntry.Text == "")
                {
                    return;
                }


                count = Math.Abs(int.Parse(imgEntry.Text));

                if (count > 4)
                {
                    count = 4;
                }

                catImg.Source = $"kot{count}.jpg";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
            }
        }

        private void backgColSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (backgColSwitch.IsToggled)
            {
                container.BackgroundColor = Color.FromArgb("#1565c0");
            }
            else
            {
                container.BackgroundColor = Color.FromArgb("#00796B");
            }
        }
    }
}
