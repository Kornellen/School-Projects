namespace KONSOLA___aplikacja_rzuty_kostkami
{
    internal class Program
    {
        static uint numberOfCubes;

        static List<int> results = new List<int>();

        static Random rng = new Random();

        static string usrAnswer = "";

        static int sumOfPoints = 0;

        static void Main(string[] args)
        {
            GetResults();
        }

        static void AskUser()
        {
            Console.WriteLine("Ile kostek chcesz rzucić? (3-10):");
            numberOfCubes = uint.Parse(Console.ReadLine());
            if (numberOfCubes < 3 || numberOfCubes > 10) Console.WriteLine("Podana wartość jest niepoprawna. Spróbuj wartośc z przedziału od 3 do 10");
        }

        static void sumPoints()
        {
            sumOfPoints = 0;
            for (int i = 0; i < results.Count; i++)
                if (results.Count(x => x == results[i]) >= 2) sumOfPoints += results[i];
        }

        static void GetResults()
        {
            numberOfCubes = 0;
            results.Clear();

            while (numberOfCubes < 3 || numberOfCubes > 10)
                AskUser();

            for (int i = 0; i < numberOfCubes; i++) results.Add(rng.Next(1, 7));

            for (int i = 0; i < results.Count; i++) Console.WriteLine($"Kostka {i + 1}: {results[i]}");

            sumPoints();
            Console.WriteLine($"Liczba uzyskanych punktów: {sumOfPoints}");

            Console.WriteLine("Jeszcze raz? (t/n)");

            usrAnswer = Console.ReadLine();



            if (usrAnswer == "t") GetResults();
            else return;
        }
    }
}
