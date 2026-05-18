using Projekt09__mobilne__quiz.Models;

namespace Projekt09__mobilne__quiz.Helpers
{
    internal class QuestionHelper
    {
        private int questionIdx = 0;

        private MainPage mainPage;
        private static QuestionHelper instance;

        private PytanieZamkniete[] questions = {
            new("Które to schronisko?", "zad1.jpg", ["Na Rysiance.", "Na Wielkiej Raczy.", "Na Wielkiej Rycerzowej."], Convert.ToChar(1)),
            new("Zwierzę na zdjęciu to", "zad2.jpg", ["Owczarek.", "Wilk.", "Kozica."], Convert.ToChar(0)),
            new("W oddali są widoczne", "zad3.jpg", ["Himalaje", "Alpy.", "Tatry."], Convert.ToChar(2))
        };

        private QuestionHelper(MainPage mainPage)
        {
            this.mainPage = mainPage;
        }

        public static QuestionHelper getInstance(MainPage mainPage)
        {
            if (QuestionHelper.instance is null)
                QuestionHelper.instance = new QuestionHelper(mainPage);
            return QuestionHelper.instance;
        }

        public void SetQuestion(int questionIdx)
        {
            PytanieZamkniete question = questions[questionIdx];
            mainPage.questionImage.Source = question.Image;
            mainPage.questionText.Text = question.Question;

            SetAnswer(mainPage.answA, question, 0);
            SetAnswer(mainPage.answB, question, 1);
            SetAnswer(mainPage.answC, question, 2);
        }

        private void SetAnswer(RadioButton answ, PytanieZamkniete question, int answIdx)
        {
            answ.Content = question.Answers[answIdx];
            answ.Value = answIdx;
            answ.IsChecked = false;
        }

        public bool CheckAnswer(char answer)
        {
            bool result = false;
            if (questions[questionIdx].CheckAnswer(answer))
                result = true;

            if (questionIdx < 2)
                SetQuestion(questionIdx += 1);
            else
            {
                questionIdx = 0;
                SetQuestion(questionIdx);
            }

            return result;
        }
    }
}
