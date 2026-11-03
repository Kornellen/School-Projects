namespace Cezar
{
    public class Cezar
    {
        public static string Szyfruj(string raw, int shift)
        {
            string encrypted = "";

            foreach (char c in raw)
            {
                if (c != ' ')
                {
                    int normalizedShift = ((shift % 26) + 26) % 26;
                    int newLetter = 97 + (((int)c - 97 + normalizedShift) % 26);

                    encrypted += (char)newLetter;
                } 
                else 
                    encrypted += c; 
            }

            return encrypted;
        }
    }
}
