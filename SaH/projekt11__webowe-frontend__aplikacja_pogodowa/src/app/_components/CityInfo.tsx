import { WeatherDTO } from "../api/weather/[city]/weather.type";
import AdditionalInfo from "./AdditionalInfo";

export default function CityInfo({
  weather,
  hasRequestBeenSend,
}: {
  weather: WeatherDTO | null;
  hasRequestBeenSend: boolean;
}) {
  if (hasRequestBeenSend && weather === null)
    return (
      <main className="col-span-1 flex items-center justify-center m-5 p-4 row-span-2 h-2/3">
        <div className="flex items-center justify-center text-7xl m-5 p-4 w-full h-40 rounded-xl backdrop-blur-md shadow-md shadow-[#ffffee28] bg-[#ffffee28]">
          <p className="w-full text-center">City Not Found</p>
        </div>
      </main>
    );

  if (weather === null) return;

  return (
    <>
      <main className="col-span-1 flex m-5 p-4 row-span-2 h-2/3">
        <div className="w-12/12">
          <h1 className="">
            {weather.name} {`(${weather.country})`}
          </h1>
          <h1 className="mt-4 text-5xl">{Math.ceil(weather.temp)}℃</h1>
        </div>
        <h1 className="-rotate-90 h-20 w-20">{weather.weather}</h1>
      </main>
      <AdditionalInfo
        feels={weather.feelsLike}
        humidity={weather.humidity}
        winds={weather.windSpeed}
      />
    </>
  );
}
