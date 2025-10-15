namespace KONSOLA_algorytm_sortowania_babelkowago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] nums = new int[100];

            DoAnArrayOperation(100, (int i) => { nums[i] = rng.Next(0, 1000); }, "Wypełnianie tablicy...");

            DoAnArrayOperation(100, (int i) => { Console.WriteLine(nums[i]); }, "Tablica nums - przed sortowaniem:");

            BubbleSort(nums);

            DoAnArrayOperation(100, (int i) => { Console.WriteLine(nums[i]); }, "Tablica nums - po sortowaniu:");
        }

        static void DoAnArrayOperation(int arrayLenght, Action<int> callback, string operationMessage = "")
        {
            Console.WriteLine("\n" + operationMessage);
            for (int i = 0; i < arrayLenght; i++)
                callback(i);
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < 100 - 1; i++)
            {
                for (int j = 0; j < 100 - i - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

    }
}
