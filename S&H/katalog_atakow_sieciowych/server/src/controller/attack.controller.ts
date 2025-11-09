import { Request, Response } from "express";
import attacks from "../../attacks.json";
import { Attack } from "./types/attack.type";

export class AttackController {
  constructor() {}

  /**
   *  Metoda zwracająca klientowi tablicę dostępnych ataków sieciowych.
   *
   *  Bazuje ona na kluczach obiektów w pliku JSON `attacks.json`
   *
   * @param req - Parametr typu `Request` dostarczonego przez Express. Obsługuje zapytanie wysłane przez Klienta
   * @param res - Parametr typu `Response` dostarczonego przez Express. Obsługuje zwracanie odpowiedzi do Klienta
   */
  public getAttacks(
    req: Request,
    res: Response
  ): Response<{ attacks: Attack[] }> {
    return res.status(200).json({ attacks: Object.keys(attacks) });
  }

  /**
   *  Metoda zwracająca klientowi dane wybranego przez niego Ataku Sieciowego
   *
   *  Bazuje ona na wartościach z pliku `attacks.json`
   *
   *  Atak zostaje przesłany jako `zapytanie` (query: `?attackName=`) w adresie URL prowadzącym do API
   *
   *  Wartość przesłana w URL zostaje odczytana przy pomocy `req.query`
   *
   * @param req - Parametr typu `Request` dostarczonego przez Express. Obsługuje zapytanie wysłane przez Klienta
   * @param res - Parametr typu `Response` dostarczonego przez Express. Obsługuje zwracanie odpowiedzi do Klienta
   */
  public getAttack(req: Request, res: Response) {
    const { attackName } = req.query;

    if (!attackName) return res.sendStatus(400);

    return res.status(200).json({
      name: attackName,
      ...attacks[attackName as Attack],
    });
  }
}
