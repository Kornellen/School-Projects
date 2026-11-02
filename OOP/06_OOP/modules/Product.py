class Product:

    def __init__(self, name: str, category: str, price: float, quantity: int):
        self.name = name
        self.category = category
        self.price = price
        self.quantity = quantity

    def value(self):
        return self.price * self.quantity

    def __str__(self):
        return f"{self.name}    {self.category} {self.price} {self.quantity}  {self.value()}"

    def save(self):
        return f"{self.name};{self.category};{self.price};{self.quantity}\n"
