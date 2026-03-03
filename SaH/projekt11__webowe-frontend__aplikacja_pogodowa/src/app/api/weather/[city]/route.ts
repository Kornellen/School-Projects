import { getWeather } from "@/lib/getWheather.action";
import { NextRequest } from "next/server";
import { dtoMapper, WeatherDTO } from "./weather.type";

export async function GET(
  _req: NextRequest,
  ctx: RouteContext<"/api/weather/[city]">,
) {
  try {
    const { city } = await ctx.params;

    const weather = await getWeather(city);

    if (weather === null || weather.cod !== 200) return Response.json(null);

    const mappedWheater: dtoMapper<typeof weather, WeatherDTO> = (
      weather,
    ): WeatherDTO => ({
      country: weather.sys.country,
      name: weather.name,
      temp: weather.main.temp,
      weather: weather.weather[0].main,
      feelsLike: weather.main.feels_like,
      humidity: weather.main.humidity,
      windSpeed: weather.wind.speed,
    });

    return Response.json(mappedWheater(weather));
  } catch (error) {
    if (error instanceof Error) console.error(error.message);
    console.log(error);

    return Response.json({ code: 500, msg: "There was an error!" });
  }
}
