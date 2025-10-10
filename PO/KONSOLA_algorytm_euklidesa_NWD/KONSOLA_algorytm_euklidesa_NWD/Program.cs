namespace KONSOLA_algorytm_euklidesa_NWD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj Pierwszą Liczbę: ");
                uint a = uint.Parse(Console.ReadLine());

                Console.Write("\nPodaj Drugą Liczbę: ");

                uint b = uint.Parse(Console.ReadLine());

                Console.WriteLine($"\nNWD({a}, {b}): {LiczNWD(a, b)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nPodana wartość nie jest poprawna");
            }
        }

        static uint LiczNWD(uint a, uint b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }

            return a;
        }
    }
}
