import { useState } from "react";
import Form from "./components/Form";
import Card from "./components/Card";

export type RentData = {
  car: string;
  pricePerDay: number;
  days: number;
  addonsPrice: number;
  discount: number;
  total: number;
};

const carMap = (carCode: string) => {
  switch (carCode) {
    case "skf":
      return { carName: "Skoda Fabia", price: 120 };
    case "toy":
      return { carName: "Toyota Yaris", price: 140 };
    case "opa":
      return { carName: "Opel Astra", price: 170 };
    case "vop":
      return { carName: "Volksawagen Passat", price: 230 };
    default:
      return { carName: "", price: 0 };
  }
};

const discountCalc = (days: number) => {
  if (days >= 3 && days <= 6) return 0.05;
  if (days >= 7 && days <= 13) return 0.1;
  if (days >= 14) return 0.15;
  else return 0;
};

export type ErrorMessage = { message: string };

function App() {
  const [rentData, setRentData] = useState<RentData | ErrorMessage | null>(
    null,
  );

  const handleSubmit = (e: React.SubmitEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);

    const carCode = formData.get("car")!.toString();
    const from = Number(new Date(formData.get("from") as string));
    const to = Number(new Date(formData.get("to") as string));
    const kidSeat = formData.get("kid") == "on" ? true : false;
    const gps = formData.get("gps") == "on" ? true : false;
    const insurence = formData.get("insurence") == "on" ? true : false;

    if (!from || !to) return;

    const timeDiff = (from - to) / (24 * 60 * 60 * 1000);
    if (timeDiff > 0) {
      setRentData({
        message: `Data "do" nie może być wcześniejsza niż data "od".`,
      });
      return;
    }

    const car = carMap(carCode);

    const days = (to - from) / (24 * 60 * 60 * 1000) + 1;
    const KID_SEAT_PRICE = 10 * days;
    const GPS_PRICE = 15 * days;
    const INSURENCE_PRICE = 25 * days;
    let addons = 0;

    if (kidSeat) addons += KID_SEAT_PRICE;
    if (gps) addons += GPS_PRICE;
    if (insurence) addons += INSURENCE_PRICE;

    const discount = discountCalc(days);
    const total = car.price * days * (1 - discount) + addons;

    setRentData({
      car: car.carName,
      pricePerDay: car.price,
      addonsPrice: addons,
      days: days,
      discount,
      total,
    });
  };

  return (
    <main className="">
      <h1 className="">Wypożyczalnia AutoPlus</h1>
      <section className="d-flex w-100">
        <section className="w-50 fs-2">
          <Form handleSubmit={handleSubmit} />
        </section>
        <section className="w-50 fs-5">
          <Card data={rentData} />
        </section>
      </section>
    </main>
  );
}

export default App;
