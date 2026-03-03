using System.Diagnostics;

namespace Konwerter_Dec_Bin
{
    public partial class MainPage : ContentPage
    {
        private bool isToBin = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private void convertBtnToBin_Clicked(object sender, EventArgs e)
        {
            try
            {
                int userInput = int.Parse(userInputEdit.Text);

                string result = Converters.convertToBin(userInput);

                resultLbl.Text = $"Wynik to: {result}";
            }
            catch (Exception ex)
            {
                resultLbl.Text = "Wystąpił problem!";

                Debug.WriteLine(ex.Message);
            }
        }
        private void convertBtnToDec_Clicked(object sender, EventArgs e)
        {
            try
            {
                string userInput = userInputEdit.Text;

                if (!isValidateBinInput(userInput))
                    throw new Exception("Podana wartość jest nieprawidłowa!");

                resultLbl.Text = $"Wynik to: {Converters.convertToDec(userInput)}";
            }
            catch (Exception ex)
            {
                resultLbl.Text = ex.Message;
            }
        }

        private bool isValidateBinInput(string input) => input.All(c => c == '0' || c == '1');

        private void converterChanger_Clicked(object sender, EventArgs e)
        {
            isToBin = !isToBin;

            if (isToBin)
            {
                convertDirection.Text = "Konwerter DEC -> BIN";
                userInputEdit.Placeholder = "Podaj liczbę dziesiątkową";

                convertBtn.Clicked -= convertBtnToDec_Clicked;
                convertBtn.Clicked += convertBtnToBin_Clicked;
            }
            else
            {
                convertDirection.Text = "Konwerter BIN -> DEC";
                userInputEdit.Placeholder = "Podaj liczbę binarną";
                convertBtn.Clicked -= convertBtnToBin_Clicked;
                convertBtn.Clicked += convertBtnToDec_Clicked;
            }
        }
    }
}
