using System;
using System.Collections.Generic;
using System.Text;

namespace Konwerter_Dec_Bin
{
    internal class Converters
    {
        public static int convertToDec(string value)
        {
            int sum = 0;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                int binVal = value[i] - '0';

                sum += binVal * (int)Math.Pow(2, (value.Length - 1) - i);
            }

            return sum;
        }


        public static string convertToBin(int value)
        {
            if (value == 0) return "0000";

            List<int> binaryValues = new List<int>();

            while (value != 0)
            {
                binaryValues.Add(value % 2);

                value = value / 2;
            }

            if (binaryValues.Count % 4 != 0)
                for (int i = 0; i < binaryValues.Count % 4; i++)
                    binaryValues.Add(0);

            binaryValues.Reverse();


            return formatBinOutput(string.Join("", binaryValues));
        }

        private static string formatBinOutput(string unformattedBinValue)
        {
            List<string> outputParts = new List<string>();

            for (int i = 0; i < unformattedBinValue.Length; i += 4)
                outputParts.Add(unformattedBinValue.Substring(i, 4));

            return string.Join(" ", outputParts);
        }
    }
}
