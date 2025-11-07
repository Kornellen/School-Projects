namespace DESKTOPOWA_GUI___dodaj_pracownika_generowanie_hasła
{
    public partial class Form1 : Form
    {
        private static string UPPER_LETTERS = "ABCDEFGHIJKLMNOPRSTUQWXYZ";
        private static string LOWER_LETTERS = UPPER_LETTERS.ToLower();

        private static string DIGITS = "0123456789";
        private static string SYMBOLS = "!@#$%^&*()_+-=";


        private Random rng = new Random();

        private string generatedPasswd = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void genPasswdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                generatedPasswd = string.Empty;

                uint passwdLenght = uint.Parse(passwdLengthTB.Text);
                string availableCharacters = "";

                if (isUpperLowerLetters.Checked) availableCharacters += UPPER_LETTERS + LOWER_LETTERS;
                if (isDigits.Checked) availableCharacters += DIGITS;
                if (isSpecialChars.Checked) availableCharacters += SYMBOLS;

                for (int i = 0; i < passwdLenght; i++)
                    generatedPasswd += availableCharacters[rng.Next(availableCharacters.Length - 1)];


                MessageBox.Show(generatedPasswd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;
            string stanowisko = stanowiskoCBox.Text;

            MessageBox.Show($"Dane pracownika: {firstName} {lastName} {stanowisko} Hasło: {generatedPasswd}");
        }
    }
}
