import sys
import os
import string


def main():
    try:
        VOWELS = ["a", "e", "i", "y", "o", "u", "A", "E", "I", "O", "Y", "U"]

        fileName: str

        if len(sys.argv) >= 2:
            fileName = sys.argv[1]
        else:
            fileName = input("Podaj sciezke do pliku: ")

        if len(fileName) == 0:
            raise Exception("File name was not provide!")

        charsCount: int = 0
        linesCount: int = 0
        vowelsCount: int = 0
        cononantsCount: int = 0
        wordsCount = 0

        with open(fileName, "r") as f:
            for line in f.readlines():
                linesCount += 1
                words = [word for word in line.split(" ") if word not in ["\n", ""]]

                wordsCount += len(words)

                for char in line:
                    if char != "\n":
                        charsCount += 1
                    if char in VOWELS:
                        vowelsCount += 1
                    elif char not in string.whitespace:
                        cononantsCount += 1

        print(f"size of file: {os.stat(fileName).st_size} bytes")
        print(f"count of words: {wordsCount}")
        print(f"count of lines: {linesCount}")
        print(f"count of characters (with spaces): {charsCount}")

        print("------------------------")
        print("Without whitespaces!")
        print("------------------------")

        print(f"count of vowels: {vowelsCount}")
        print(f"count of consonants: {cononantsCount}")

    except FileExistsError:
        print("[ERROR]: File not exist!")
    except FileNotFoundError:
        print("[ERROR]: File not found!")
    except Exception as ex:
        print(f"[ERROR]: {ex}")


if __name__ == "__main__":
    main()
