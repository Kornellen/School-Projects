export type WeatherDTO = {
  country: string;
  name: string;
  temp: number;
  weather: string;
  feelsLike: number;
  humidity: number;
  windSpeed: number;
};

export type dtoMapper<T, R> = (val: T) => R;
