"use server";

const API_KEY = process.env.API_KEY;

export async function getWeather(city: string) {
  try {
    if (!API_KEY) throw new Error("API_KEY NOT FOUND");

    const res = await fetch(
      `https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=${API_KEY}&units=metric`,
    );
    if (!res.ok || !res.body) return null;
    const data = await res.json();
    return data;
  } catch (error) {
    console.error(error);
  }
}
