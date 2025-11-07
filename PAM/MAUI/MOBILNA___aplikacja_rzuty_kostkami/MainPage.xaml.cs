
namespace MOBILNA___aplikacja_rzuty_kostkami
{
    public partial class MainPage : ContentPage
    {
        private List<int> results = new List<int>();

        Random rng = new Random();

        int sumOfPoints = 0;
        int gameResult = 0;

        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                Image newImage = new Image();

                newImage.Margin = 9;
                newImage.HeightRequest = 60;
                newImage.Source = "question.jpg";

                CubesImages.Add(newImage);
            }
        }

        private void ThrowBtn_Clicked(object sender, EventArgs e)
        {
            results.Clear();
            sumOfPoints = 0;

            for (int i = 0; i < 5; i++) results.Add(rng.Next(1, 7));

            for (int i = 0; i < results.Count; i++)
                (CubesImages.Children[i] as Image).Source = $"k{results[i]}.jpg";

            for (int i = 0; i < results.Count; i++)
                if (results.Count(x => x == results[i]) >= 2) sumOfPoints += results[i];

            CurrentLotteryResultLbl.Text = $"Wynik tego losowania: {sumOfPoints}";

            GameResultLbl.Text = $"Wynik gry: {gameResult += sumOfPoints}";

        }

        private void ResetBtn_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                (CubesImages.Children[i] as Image).Source = "question.jpg";

            sumOfPoints = 0;
            gameResult = 0;

            CurrentLotteryResultLbl.Text = $"Wynik tego losowania: {sumOfPoints}";

            GameResultLbl.Text = $"Wynik gry: {gameResult += sumOfPoints}";
        }
    }
}
