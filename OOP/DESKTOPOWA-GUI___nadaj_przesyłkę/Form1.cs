using DESKTOPOWA_GUI___nadaj_przesyłkę.Properties;

namespace DESKTOPOWA_GUI___nadaj_przesyłkę
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sprawdzCeneBtn_Click(object sender, EventArgs e)
        {
            if (pocztowkaRBtn.Checked)
            {
                ikonaImage.Image = Resources.pocztowka;
                cenaLbl.Text = "Cena: 1 zł";
            }
            else if (listRBtn.Checked)
            {
                ikonaImage.Image = Resources.list;
                cenaLbl.Text = "Cena: 1.5 zł";
            }
            else
            {
                ikonaImage.Image = Resources.paczka;
                cenaLbl.Text = "Cena: 10 zł";
            }
        }

        private void zatwierdzBtn_Click(object sender, EventArgs e)
        {
            string kodPocztowy = kodPocztowyTBox.Text;

            if (kodPocztowy.Length < 6 || kodPocztowy.Length > 6)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }

            foreach (char character in kodPocztowy)
            {
                if (char.IsDigit(character) || character == '-') continue;
                else { MessageBox.Show("Kod powinien składać się z samych cyfr"); return; }
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone");
        }
    }
}
