namespace Projekt09__mobilne__quiz.Models
{
    abstract class Pytanie
    {
        protected string question;
        protected string imagePath;
        protected bool isAnswerCorrect;

        public Pytanie(string question, string imagePath)
        {
            this.question = question;
            this.imagePath = imagePath;
            this.isAnswerCorrect = false;
        }

        public abstract bool CheckAnswer(char answerLetter);
    }
}
