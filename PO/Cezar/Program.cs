namespace Cezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");
            string userInput = Console.ReadLine();
            Console.Write("Podaj przesunięcie: ");
            int userShift = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cezar.Szyfruj(userInput, userShift));
        }
    }
}