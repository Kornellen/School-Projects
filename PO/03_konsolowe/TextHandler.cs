namespace _03_konsolowe;

internal class TextHandler
{
    /*
        nazwa funkcji: Clear
        opis funkcji: Czyści podany tekst z białych znaków
        parametry: string text - podany tekst
        zwracany typ i opis: string - czysty tekst
        autor: 00000000000
    */
    public string Clear(string text)
    {
        string clearedText = "";

        foreach (char ch in text)
        {
            if (!char.IsWhiteSpace(ch))
                clearedText += ch;
        }

        return clearedText;
    }

    /*
        nazwa funkcji: IsPalindrome
        opis funkcji: Metoda sprawdzająca czy zdanie/wyraz to palindrom
        parametry: string text - jw.
        zwracany typ i opis: bool - Czy Palindrom - wartość True/False
        autor: 00000000000
    */
    public bool IsPalindrome(string text)
    {
        string clearedText = Clear(text).ToLower();
        string reversedText = "";

        for (int i = clearedText.Length - 1; i > -1; i--)
            reversedText += clearedText[i];

        return clearedText == reversedText;
    }

    /*
        nazwa funkcji: GetLettersCount
        opis funkcji: Ustala liczbę pojedynczych literek w wyrażeniu
        parametry: string text - jw.
        zwracany typ i opis: List<KeyValuePair<char, int>> - Lista literek z ich ilością w formacie literka: jej_ilosc
        autor: 00000000000
    */
    private List<KeyValuePair<char, int>> GetLettersCount(string text)
    {
        string formattedTextA = Clear(text);

        List<KeyValuePair<char, int>> charsCount = new();

        foreach (char ch in formattedTextA)
        {
            int index = charsCount.FindIndex(pair => pair.Key == ch);

            if (index == -1)
                charsCount.Add(new KeyValuePair<char, int>(ch, 1));
            else
                charsCount[index] = new KeyValuePair<char, int>(ch, charsCount[index].Value + 1);
        }

        return charsCount;
    }

    /*
        nazwa funkcji: WordCount
        opis funkcji: Ustala liczbę słów w wyrażeniu
        parametry: string text - jw.
        zwracany typ i opis: int - ilość słów
        autor: 00000000000
    */
    public int WordCount(string text)
    {
        string[] sentenceSplit = text.Split(" ");

        return sentenceSplit.Length;
    }

    /*
        nazwa funkcji: LettersFreq
        opis funkcji: Korzystajć z metody GetLettersCount(string text) ustala ilość konkretnych literek i sortuje jest od najczęstszej
        parametry: string text - jw.
        zwracany typ i opis: string - ciąg znaków, zawierający przekształconą, posortowaną listę ilości literek
        autor: 00000000000
    */
    public string LettersFreq(string text)
    {
        List<KeyValuePair<char, int>> letters = GetLettersCount(text);
        KeyValuePair<char, int>[] sortedLetters = letters.ToArray();

        for (int i = 0; i < sortedLetters.Length; i++)
        for (int j = i + 1; j < sortedLetters.Length - 1; j++)
        {
            if (sortedLetters[i].Value < sortedLetters[j].Value)
                (sortedLetters[i], sortedLetters[j]) = (sortedLetters[j], sortedLetters[i]);

            if (sortedLetters[i].Value == sortedLetters[j].Value)
                if (sortedLetters[i].Key > sortedLetters[j].Key)
                    (sortedLetters[i], sortedLetters[j]) = (sortedLetters[j], sortedLetters[i]);
        }

        string output = "{ ";

        foreach (KeyValuePair<char, int> pair in sortedLetters)
            output += $"{pair.Key}: {pair.Value}, ";

        output += " }";

        return output;
    }

    /*
        nazwa funkcji: LongestWord
        opis funkcji: Ustala najdłuższe słowo w wyrażeniu
        parametry: string text - jw.
        zwracany typ i opis: string - najdłusze słowo
        autor: 00000000000
    */
    public string LongestWord(string text)
    {
        string[] sentenceSplit = text.Split(" ");
        string longestWord = sentenceSplit[0];

        foreach (string word in sentenceSplit)
            if (word.Length > longestWord.Length)
                longestWord = word;

        return longestWord;
    }

    /*
        nazwa funkcji: IsAnagram
        opis funkcji: Ustala czy podane dwa wyrazy to Anagramy
        parametry: string textA, string textB - podane teksty
        zwracany typ i opis: bool - Czy anagram? True/False
        autor: 00000000000
    */
    public bool IsAnagram(string textA, string textB)
    {
        List<KeyValuePair<char, int>> charsCountTextA = GetLettersCount(textA);
        List<KeyValuePair<char, int>> charsCountTextB = GetLettersCount(textB);

        bool isAnagram = charsCountTextA.Count == charsCountTextB.Count;

        foreach (KeyValuePair<char, int> item in charsCountTextA)
        {
            int index = charsCountTextB.FindIndex(pair => pair.Key == item.Key);

            if (index == -1 || item.Value != charsCountTextB[index].Value)
            {
                isAnagram = false;
                break;
            }
        }
        return isAnagram;
    }
}
