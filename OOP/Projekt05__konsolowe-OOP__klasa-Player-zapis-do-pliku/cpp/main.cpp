#include <iostream>
#include <fstream>
#include <string>
#include <cstdio>

using namespace std;

class Player
{
public:
    unsigned int id;
    string name;
    unsigned int age;
    string club;

    Player(unsigned int id, string name, unsigned int age, string club)
    {
        this->id = id;
        this->name = name;
        this->age = age;
        this->club = club;
    }
};

int main(const int argc, const char *argv[])
{
    Player players[5] = {Player(1, "Paulo", 20, "FC Potato"), Player(2, "Karl", 30, "FC Tomato"), Player(3, "Grzegorz", 25, "FC Polako"), Player(4, "John", 24, "FC Uralto"), Player(5, "Fabiano", 22, "FC Utarto")};
    string fileName;

    if (argc < 2)
    {
        cout << "Nazwe mozna przekazac jako parametr programu: app.exe <fileName>" << endl;
        cout << "Podaj nazwe pliku do ktorego chcesz zapisac dane (z .txt): ";
        cin >> fileName;
    }
    else
        fileName = argv[1];

    try
    {
        ofstream File(fileName);
        for (int i = 0; i < 5; i++)
        {
            Player player = players[i];

            File << "Gracz o ID: " << player.id << endl;
            File << player.name << endl;
            File << player.age << endl;
            File << player.club << endl;
            File << endl;
        }
    }
    catch (exception &ex)
    {
        cout << ex.what() << endl;
    }

    return 0;
}