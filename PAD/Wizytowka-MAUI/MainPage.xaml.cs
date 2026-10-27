using System.Diagnostics;

namespace Wizytowka_MAUI
{
    public partial class MainPage : ContentPage
    {
        string[] greetings = { "Witaj Świecie!", "Hello World!", "Witam", "Hello" };
        int greetings_idx = 0;



        public MainPage()
        {
            InitializeComponent();
        }

        private void greetings_btn_Clicked(object sender, EventArgs e)
        {
            //Debug.WriteLine(greetings.Length);
            greetings_idx++;
            //Debug.WriteLine(greetings_idx);
            greetings_lbl.Text = greetings[greetings_idx % greetings.Length];
            if (greetings_idx >= greetings.Length - 1) greetings_idx = -1;
        }
    }
}
