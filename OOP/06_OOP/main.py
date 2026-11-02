from modules.Warehouse import Warehouse

warehouse = Warehouse()

path = input("Podaj sciezke do pliku: ")

warehouse.load_file(path)
warehouse.save_file("./magazyn.copy.csv")
while True:
    try:
        print("""
            1) Wyswietl wszystkie produkty
            2) Dodaj Produkt
            3) Sprzedaj Produkt
            4) Wartosc Magazynu i Kategorii
            5) Produkty ponizej prog
            6) Zapisz i wyjdz
            """)

        user_input = int(input("Wybor: "))

        match user_input:
            case 1:
                warehouse.print_products()
            case 2:
                print("--------- Dodawanie Produktu ---------")
                name = input("Podaj nazwe: ")
                category = input("Podaj kategorie: ")
                price = float(input("Podaj cene: "))
                quantity = int(input("Podaj ilosc: "))

                warehouse.add_product(name, category, price, quantity)
            case 3:
                print("-------- Sprzedawanie Produktu -------")
                prod_id = int(input("Podaj Id produktu: "))
                warehouse.sell(prod_id)
            case 4:
                warehouse.value()
            case 5:
                user_input = int(input("Podaj prog: "))
                warehouse.products_under_stock(user_input)
            case 6:
                warehouse.save_file()
                break
    except ValueError:
        print("There was an error!")
    except KeyboardInterrupt:
        print("User Ended program!")
        break
