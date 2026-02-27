import random


class Kosc:
    instanceCount: int = 0

    def __init__(self, userValue: int = 0) -> None:
        self.imageFiles = [f"kosc{i}.png" for i in range(7)]
        if userValue == 0:
            value = random.randint(1, 6)
            self.imageIdx: int = value
            self.throwedValue: int = value
        elif userValue > 6:
            self.throwedValue: int = 0
            self.imageIdx: int = 0
        else:
            self.throwedValue: int = userValue
            self.imageIdx: int = userValue
        self.isKoscAvailble: bool = True
        Kosc.instanceCount += 1

    def throw(self) -> None:
        if not self.isKoscAvailble:
            return

        value = random.randint(1, 6)

        self.imageIdx = value
        self.throwedValue = value
        self.isKoscAvailble = True

    def block(self) -> None:
        self.isKoscAvailble = False

    def valueMapper(self) -> str:
        values = ["zero", "jeden", "dwa", "trzy", "cztery", "piec", "szesc"]

        return values[self.throwedValue]


def printKosc(kosc: Kosc) -> None:
    print("-------------------------------------")
    print(f"Liczba utworzonych instancji: {kosc.instanceCount}")
    print(f"Wyrzucono: {kosc.throwedValue} ({kosc.valueMapper()})")
    print(f"Plik zdjęciowy: {kosc.imageFiles[kosc.imageIdx]}")


def main():
    koscValue = int(input("Podaj wartosc nowej kosci: "))

    k1 = Kosc(koscValue)
    printKosc(k1)
    k2 = Kosc()
    printKosc(k2)


if __name__ == "__main__":
    main()
