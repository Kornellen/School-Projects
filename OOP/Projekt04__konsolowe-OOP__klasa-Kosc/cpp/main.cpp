#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>

using namespace std;

class Kosc
{
public:
    static unsigned int instanceCount;

public:
    string imageFiles[7] = {"kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"};
    unsigned int throwedNumber;
    int imageIndex;
    bool isKoscAvailble;

    Kosc(unsigned int userValue)
    {
        if (userValue > 6)
        {
            this->throwedNumber = 0;
            this->imageIndex = 0;
        }
        else
        {
            this->throwedNumber = userValue;
            this->imageIndex = userValue;
        };

        this->isKoscAvailble = true;
        Kosc::instanceCount += 1;
    };

    Kosc()
    {
        unsigned int value = (rand() % 6) + 1;
        this->imageIndex = value;
        this->throwedNumber = value;
        this->isKoscAvailble = true;
        Kosc::instanceCount += 1;
    }

    void throwKosc()
    {
        if (!this->isKoscAvailble)
            return;

        unsigned int value = (rand() % 6) + 1;
        this->imageIndex = value;
        this->throwedNumber = value;
        this->isKoscAvailble = true;
    }

    void blockKosc()
    {
        this->isKoscAvailble = false;
    }

    string valueMapper()
    {
        string mappedValues[7] = {"zero", "jeden", "dwa", "trzy", "cztery", "piec", "szesc"};

        return mappedValues[this->throwedNumber];
    }
};

unsigned int Kosc::instanceCount = 0;

void printInfo(Kosc &kosc)
{
    cout
        << "-------------------------------------" << endl;
    cout << "Liczba utworzonych instancji: " << kosc.instanceCount << endl;
    cout << "Wyrzucono: " << kosc.throwedNumber << " (" << kosc.valueMapper() << ")" << endl;
    cout << "Plik zdjeciowy: " << kosc.imageFiles[kosc.imageIndex] << endl;
}

int main()
{
    srand(time(0));

    unsigned int koscValue;

    cout << "Podaj wartosc nowej kosci: ";
    cin >> koscValue;

    Kosc k1(koscValue);
    printInfo(k1);

    Kosc k2;
    printInfo(k2);

    return 0;
}
