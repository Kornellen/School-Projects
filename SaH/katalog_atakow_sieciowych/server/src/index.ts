import express, { Express } from "express";
import attackRouter from "./route/attack.route";
import cors from "cors";

/**
 * Port na jakim operuje API
 */

const APP_PORT: number = 5175;

const app: Express = express();

/**
 *  Dodanie obsługi Middlewares
 *
 *  Middleware `cors` dodaje nagłówek Access-Control-Allow-*
 *  nagłówki te określają, z jakich domen przeglądarka może uzyskać dostęp do zasobów API
 *
 *  Jest on przestrzegany po stronie Przeglądarki
 *
 *  CORS jest szczególnie ważny przy pracy na Localhost (np. jeżeli Frontend działa na localhost:5500, a Backend na localhost:5175)
 */

app.use(
  cors({
    allowedHeaders: ["Content-Type"],
    origin: ["http://localhost:5500", "http://127.0.0.1:5500"],
    methods: ["GET", "POST"],
  })
);

/**
 * Rejestrowanie Głównego Punktu Wejścia dla API
 */

app.use("/api", attackRouter);

/**
 * Uruchomienie API i nasłuchu na konkretnym porcie
 */

app.listen(APP_PORT, () => console.log("App listen on: %d", APP_PORT));
