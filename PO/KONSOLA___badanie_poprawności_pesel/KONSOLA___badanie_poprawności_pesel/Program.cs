using System.Text.RegularExpressions;

namespace KONSOLA___badanie_poprawności_pesel
{
    internal class Program
    {
        static string _pesel = "55030101193";
        static string PESEL
        {
            get => _pesel;
            set
            {
                if (Regex.IsMatch(value, @"^\d{11}$")) _pesel = value;
                else
                {
                    Console.WriteLine($"\nPodany Numer PESEL jest niepoprawny.\n\nUżyto domyślnego Numeru PESEL:\n\n{_pesel}\n");
                    _pesel = "55030101193";
                }
            }
        }

        static readonly int[] WEIGHTS = { 1, 3, 7, 9 };

        static void Main(string[] args)
        {
            string gender, peselStatus;

            Console.Write("Podaj numer PESEL: ");
            PESEL = Console.ReadLine() ?? "";

            gender = GetGender(PESEL) == 'K' ? "Kobieta" : "Mężczyzna";
            peselStatus = IsPESELChecksumValid(PESEL) ? "Poprawny" : "Niepoprawny";

            Console.WriteLine($"Płeć: {gender}");

            Console.WriteLine($"Status numeru PESEL: {peselStatus}");
        }


        static char GetGender(string pesel)
        {
            return (pesel[9] - '0') % 2 == 0 ? 'K' : 'M';
        }


        static bool IsPESELChecksumValid(string pesel)
        {
            int sum = 0, moduleOfSum, checksum;

            for (int i = 0; i < pesel.Length - 1; i++)
                sum += (pesel[i] - '0') * WEIGHTS[i % WEIGHTS.Length];


            moduleOfSum = sum % 10;

            checksum = moduleOfSum == 0 ? 0 : 10 - moduleOfSum;

            return checksum == (pesel[10] - '0') ? true : false;
        }
    }
}
