import type { ErrorMessage, RentData } from "../App";

export default function Card({
  data,
}: {
  data: RentData | ErrorMessage | null;
}) {
  if (!data)
    return (
      <div>
        <p className="p-5 text-dark">
          Wybierz samochód i terminy, a następnie oblicz koszt.
        </p>
      </div>
    );
  if (Object.hasOwn(data, "message"))
    return (
      <>
        <div className="card bg-danger-subtle border-danger p-3 fs-3">
          {(data as ErrorMessage).message}
        </div>
      </>
    );

  const displayData = data as RentData;

  return (
    <div className="card w-50 p-3 shadow">
      <h3>{displayData.car}</h3>
      <p>Cena: {displayData.pricePerDay} zł / doba</p>
      <p>Liczba Dni: {displayData.days}</p>
      <p>Dodatki: {displayData.addonsPrice.toFixed(2)} zł</p>
      <p>Rabat: {displayData.discount * 100}%</p>
      <h2 className="text-success fw-bold">
        RAZEM: {displayData.total.toFixed(2)} zł
      </h2>
    </div>
  );
}
