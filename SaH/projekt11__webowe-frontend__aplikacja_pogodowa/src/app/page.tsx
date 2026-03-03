"use client";
import { useState } from "react";
import CityInfo from "./_components/CityInfo";
import { WeatherDTO } from "./api/weather/[city]/weather.type";

export default function Home() {
  const [city, setCity] = useState<string>("");
  const [weather, setWeather] = useState<WeatherDTO | null>(null);
  const [hasRequestBeenSend, setHasRequestBeenSend] = useState<boolean>(false);

  async function handleSubmit(e: React.SubmitEvent<HTMLFormElement>) {
    e.preventDefault();

    const url = `/api/weather/${city}`;
    const res = await fetch(url, { method: "GET" });
    const data = await res.json();
    setHasRequestBeenSend(true);
    setWeather(data);
  }

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) =>
    setCity(e.target.value);

  return (
    <div className="grid grid-cols-1 grid-rows-4 h-screen font-sans bg-[url(/background_image.png)] bg-no-repeat bg-center bg-size-[160em]">
      <nav className="col-span-1 row-span-1 flex justify-center items-center h-1/3">
        <form action="" onSubmit={handleSubmit}>
          <input
            id="location"
            className="w-70 bg-[#ffffee28] backdrop-blur-md shadow-md shadow-[#ffffee28] border border-white placeholder:text-[#ebebeb] p-2 rounded-2xl focus:outline focus:outline-sky-200"
            onChange={handleChange}
            placeholder="Enter location"
          />
        </form>
      </nav>
      <CityInfo weather={weather} hasRequestBeenSend={hasRequestBeenSend} />
    </div>
  );
}
