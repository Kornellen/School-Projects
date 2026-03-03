# Weather Apka

Prosta aplikacja pogodowa. Korzysta z API OpenWeatherMap. Wykonana w Next.js

Celem uniknięcia wycieku klucza API, wykorzystuje komponenty serwerowe (SSR - Server Side Rendering), Backend dostarczany przez Next.js, TypeScript oraz Tailwind

Klucz API przechowywany jest w pliku `.env`. Wystarczy skopiowac zawartość pliku `.env.template` i uzupełnić odpowiednim kluczem ze strony `https://openweathermap.org/`

Aby uruchomić aplikacje wystarczy w folderze aplikacji użyć polecenia `npm run dev` (Tryb deweloperski Next). Aplikacja będzie dostępna na Lokalnym hoście na porcie 3000
