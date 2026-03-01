#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <sstream>
#include <algorithm>
#include <filesystem>

using namespace std;
namespace fs = std::filesystem;

int main(int argc, char *argv[])
{
    std::vector<char> vowels = {'a', 'e', 'i', 'y', 'o', 'u', 'A', 'E', 'I', 'O', 'Y', 'U'};
    try
    {
        string fileName;
        if (argc >= 2)
            fileName = argv[1];
        else
        {
            cout << "Podaj sciezke do pliku: ";
            getline(std::cin, fileName);
        }

        {
            if (fileName.length() == 0 || fileName.empty())
                throw 400;

            if (!fs::exists(fileName))
                throw 404;

            string line;
            ifstream File(fileName);

            int charsCount = 0;
            int linesCount = 0;
            int vowelsCount = 0;
            int consonantsCount = 0;
            int wordsCount = 0;

            while (getline(File, line))
            {
                ++linesCount;

                stringstream ss(line);
                string word;

                while (ss >> word)
                    ++wordsCount;

                for (char c : line)
                {
                    ++charsCount;

                    if (std::find(vowels.begin(), vowels.end(), c) != vowels.end())
                        vowelsCount++;
                    else if (c != ' ')
                        consonantsCount++;
                }
            }

            cout << "size of file: " << fs::file_size(fileName) << " bytes" << endl;

            cout << "count of words: " << wordsCount << endl;
            cout << "count of lines: " << linesCount << endl;
            cout << "count of characters (including spacebars): " << charsCount << endl;

            cout << "------------------------" << endl;
            cout << "Without spacebars!" << endl;
            cout << "------------------------" << endl;

            cout << "count of vowels: " << vowelsCount << endl;
            cout << "count of consonants: " << consonantsCount << endl;

            File.close();
        }

        return 0;
    }
    catch (const int &e)
    {
        if (e == 400)
            cerr << "File name was not provide" << endl;
        if (e == 404)
            cerr << "File Not Exist!" << endl;
    }
}