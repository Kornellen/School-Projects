using Projekt09__mobilne__quiz.Helpers;
using Projekt09__mobilne__quiz.Models;

namespace Projekt09__mobilne__quiz
{
    public partial class MainPage : ContentPage
    {

        int correctCount = 0;

        public static MainPage mainPage { get; private set; }
        private QuestionHelper questionHelper;

        public MainPage()
        {
            InitializeComponent();

            mainPage = this;
            questionHelper = QuestionHelper.getInstance(mainPage);
            questionHelper.SetQuestion(0);
        }

        private void nextBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                RadioButton? checkedRBtn = answerButtons.Children.First((child) => (child as RadioButton).IsChecked) as RadioButton;

                correctCount += questionHelper.CheckAnswer(Convert.ToChar(checkedRBtn.Value)) ? 1 : 0;
                Console.WriteLine(correctCount);
            }
            catch (Exception ex)
            {
                DisplayAlertAsync("Answer Not Selected", "You didn't select answer", "Ok");
                return;
            }
        }
    }
}
