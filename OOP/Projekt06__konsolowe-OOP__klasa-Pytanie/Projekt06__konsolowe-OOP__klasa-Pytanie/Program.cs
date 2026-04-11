namespace Projekt06__konsolowe_OOP__klasa_Pytanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pytanie pyt = new Pytanie("", "");
            
            Console.Write("Podaj treść pytania: ");
            string question = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Podaj ścieżkę do pliki ze zdjęciem: ");
            string imagePath = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Podaj odpowiedź A: ");
            string answerA = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Podaj odpowiedź B: ");
            string answerB = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Podaj odpowiedź C: ");
            string answerC = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Podaj poprawną odpowiedź: ");
            string correctAnswer = Console.ReadLine();
            Console.WriteLine();

            PytanieZamkniete pytanieZamkniete= new PytanieZamkniete(question, imagePath, answerA, answerB, answerC, correctAnswer[0]);

            Console.Write("Podaj swoją odpowiedź: ");
            string userAnswer = Console.ReadLine();
            
            if (pytanieZamkniete.CheckAnswer(userAnswer[0])) 
                Console.WriteLine("Odpowiedź prawidłowa"); 
            else
                Console.WriteLine("Odpowiedź nieprawidłowa");
        }
    }
}

