namespace Projekt06__konsolowe_OOP__klasa_Pytanie
{
    abstract class Pytanie
    {
        protected string question;
        protected string imagePath;
        protected bool isAnswerCorrect;

        public Pytanie(string question, string imagePath) {
            this.question = question;
            this.imagePath = imagePath;
            this.isAnswerCorrect = false;
        }

        public abstract bool CheckAnswer(char answerLetter);
    }

    class PytanieZamkniete : Pytanie
    {
        private string answerA;
        private string answerB;
        private string answerC;
        private char correctAnswer;

        public PytanieZamkniete(string question, string imagePath, string answerA, string answerB, string answerC, char correctAnswer) : base(question, imagePath)
        {
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.correctAnswer = correctAnswer;
        }

        public override bool CheckAnswer(char answerLetter) => answerLetter == correctAnswer;
    }
}