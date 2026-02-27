import sys


class Player:
    def __init__(self, id, name, age, club):
        self.id = id
        self.name = name
        self.age = age
        self.club = club

def main():
    try:
        players: list[Player] = [
            Player(1, "Paulo", 20, "FC Potato"),
            Player(2, "Karl", 30, "FC Tomato"),
            Player(3, "Grzegorz", 25, "FC Polako"),
            Player(4, "John", 24, "FC Uralto"),
            Player(5, "Fabiano", 22, "FC Utarto"),
        ]

        fileName: str

        if len(sys.argv) < 2:
            fileName = input(
                "Podaj nazwe pliku do ktorego chcesz zapisac dane (z .txt): "
            )
        else:
            fileName = sys.argv[1]

        with open(fileName, "w") as f:
            for player in players:
                f.write(f"Gracz o ID: {player.id}\n")
                f.write(f"{player.name}\n")
                f.write(f"{player.age}\n")                
                f.write(f"{player.club}\n")                
                f.write("\n")
    except Exception as ex:
        print(ex)


if __name__ == "__main__":
    main()
