import requests


def main():
    try:
        country = input("Enter country name: ")

        if len(country) == 0:
            raise ValueError("User didn't provide name of country!")

        url = f"https://restcountries.com/v3.1/name/{country}"

        res = requests.get(url)

        if res.status_code == 404:
            raise requests.HTTPError("Country not found!")

        if res.status_code != 200:
            raise requests.HTTPError()

        parsedRes = res.json()[0]
        print(
            f"Name: {parsedRes["name"]["common"]} - {parsedRes["name"]["official"]} - {[parsedRes["name"]["nativeName"][lang]["official"] for lang in parsedRes["name"]["nativeName"]][0]}"
        )
        print(f"Capital: {" ".join(parsedRes["capital"])}")
        print(f"Area: {parsedRes["area"]}")
        print(f"Population: {parsedRes["population"]}")
        print(
            f"Languages: {", ".join(parsedRes["languages"][f'{key}'] for key in parsedRes["languages"])}"
        )
    except ValueError as vex:
        print(vex)
    except requests.HTTPError as httpex:
        print(httpex)


if __name__ == "__main__":
    main()
