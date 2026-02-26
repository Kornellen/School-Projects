namespace Ciagi_kolekcja_2d
{
    internal class Program
    {
        static int[,]? result;
        static void Main(string[] args)
        {
            Console.WriteLine("Ciąg Arytmetyczny:\n");
            PrintString(CreateStrings(4, 'a'));
            Console.WriteLine();
            Console.WriteLine("Ciąg Geometryczny:\n");
            PrintString(CreateStrings(7, 'g'));
            Console.WriteLine();
        }

        static int[,] CreateStrings(int size, char typeOfString)
        {
            try
            {
                result = new int[size + 1, size + 1];

                if (result is null)
                    throw new Exception("Result Matrix initialization error");

                switch (typeOfString)
                {
                    case 'a':
                        PopulateMatrix((int i, int j) => result[i, j] = result[i, 0] + result[i, j - 1]);
                        break;
                    case 'g':
                        PopulateMatrix((int i, int j) => result[i, j] = result[i, j - 1] * result[i, 0]);
                        break;
                    default:
                        throw new Exception("This type is not supported");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw;
            }
        }

        static void PopulateMatrix(Action<int, int> callback)
        {
            if (result is null)
                throw new Exception("Result Matrix is null");

            for (int i = 0; i <= result.GetLength(0) - 1; i++)
            {
                result[i, 0] = i;

                for (int j = 1; j <= result.GetLength(1) - 1; j++)
                    callback(i, j);
            }
        }

        static void PrintDivider(int size)
        {
            for (int k = 1; k < size; k++)
                Console.Write("|---------------");
        }
        static void PrintString(int[,] strings)
        {
            int size = strings.GetLength(0);
            for (int i = 1; i < size; i++)
            {

                PrintDivider(size);

                Console.WriteLine("|");

                for (int j = 0; j < strings.GetLength(1) - 1; j++)
                {
                    if (j == 0)
                        Console.Write("|");

                    if (i - 1 == j)
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.Write($"\t{strings[i, j]}\t");

                    Console.ResetColor();

                    Console.Write("|");
                }
                Console.WriteLine();
            }
            PrintDivider(size);

            Console.WriteLine("|");
        }
    }
}
