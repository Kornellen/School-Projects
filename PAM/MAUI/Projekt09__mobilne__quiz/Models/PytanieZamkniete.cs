namespace Projekt09__mobilne__quiz.Models
{
    class PytanieZamkniete : Pytanie
    {
        private string[] _answers;
        private char correctAnswerIdx;

        public string[] Answers { get => _answers; set => _answers = value; }
        public string Image { get => base.imagePath; }
        public string Question { get => base.question; }

        public PytanieZamkniete(string question, string imagePath, string[] answers, char correctAnswerIdx) : base(question, imagePath)
        {
            this.Answers = answers;
            this.correctAnswerIdx = correctAnswerIdx;
        }

        public override bool CheckAnswer(char answerIdx) => answerIdx == correctAnswerIdx;
    }
}
