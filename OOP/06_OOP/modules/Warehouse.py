from modules.Product import Product


class Warehouse:

    def __init__(self):
        self.__products: list[Product] = []

        self.__file_path: str = ""

    def get_products(self):
        return self.__products

    def print_products(self):
        idx = 0
        print("Nr   Nazwa   Kategoria   Cena    Ilosc    Wartosc")
        print("-----------------------------------------------------------")
        for product in self.__products:
            print(f"{idx+1}   {product}")
            print("-----------------------------------------------------------")
            idx = idx + 1

    def save_file(self, path="", products: list[Product] = []):
        try:
            with open(path if path.__len__() > 0 else self.__file_path, "w") as f:
                for product in products if products.__len__() > 0 else self.__products:
                    f.write(product.save())

                f.close()
            print(f"Saved to file: {path}")
        except FileNotFoundError:
            print("File Not Found!")

    def load_file(self, path):
        try:
            self.__file_path = path
            with open(path, "r") as f:
                products = [
                    line.replace("\n", "\t").replace(",", ".").split(";")
                    for line in f.readlines()
                ]
                for product in products:
                    if product.__len__() == 4:
                        self.__products.append(
                            Product(
                                product[0],
                                product[1],
                                float(product[2]),
                                int(product[3]),
                            )
                        )
                f.close()
        except FileNotFoundError:
            print("File not Found!")

    def add_product(self, name: str, category: str, price: float, quantity: int):
        self.__products.append(Product(name, category, price, quantity))
        self.save_file()

    def sell(self, product_id: int):
        try:
            formatted_id = product_id - 1
            if self.__products[formatted_id].quantity <= 0:
                print("You can't sell this product! Quantity is 0")
                return
            self.__products[formatted_id].quantity = (
                self.__products[formatted_id].quantity - 1
            )
            print(
                f"[SYSTEM]: Successfully sold {self.__products[formatted_id].name}. Left {self.__products[formatted_id].quantity}!"
            )

            self.save_file()
        except:
            print("[SYSTEM]: There was an error selling the item!")

    def products_under_stock(self, stock: int):
        print("Nazwa   Kategoria   Cena    Ilosc    Wartosc")
        for product in self.__products:
            if product.quantity <= stock:
                print(product)

    def value(self):
        warhouse_value = 0
        categories_values: dict[str, float] = {}

        for product in self.__products:
            warhouse_value = warhouse_value + product.value()
            categories_values[product.category] = (
                categories_values.get(product.category, 0) + product.value()
            )

        print(f"Wartosc magazynu: {warhouse_value} zl")

        for category in categories_values:
            print(f"{category}: {categories_values[category]} zl")
