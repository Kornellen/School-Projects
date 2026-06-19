import { useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.css";

type FormData = { www: string; login: string; password: string };

function App() {
  const [isPasswordGenerated, setIsPasswordGenerate] = useState<boolean>(true);
  const [formData, setFormData] = useState<FormData>({
    login: "",
    password: "",
    www: "",
  });
  const [isFormSubmitted, setIsFormSubmitted] = useState<boolean>(false);

  /**
   * nazwa funkcji: handleChange
   * opis funkcji: Funkcja obsługująca zdarzenie wprowadzania tekstu do pola edycyjnego
   * parametry:
   *          e - Parametr będący odwołaniem do elementu, wywołującego zdarzenie. Przechowuje on odwołanie do wydarzenia, które zostało wywołane, oraz właściwości elementu na którym został wywołany, lub został mu przekazany
   * zwracany typ i opis: brak
   * autor: ...
   */
  const handleChange = (e: React.ChangeEvent<HTMLInputElement>): void => {
    setIsFormSubmitted(false);

    setFormData(
      (prev): FormData => ({
        ...prev,
        [e.target.id]: e.target.value,
      }),
    );
  };

  return (
    <>
      <section>
        <h1>Menedżer haseł - wykonał</h1>
        <form
          onSubmit={(e: React.SubmitEvent) => {
            e.preventDefault();

            setIsFormSubmitted(true);
          }}
        >
          <div className="form-group m-4">
            <label htmlFor="www">Adres WWW:</label>
            <input
              type="text"
              className="form-control"
              id="www"
              placeholder="Adres Strony WWW"
              onChange={handleChange}
            />
          </div>
          <div className="form-group m-4">
            <label htmlFor="login">Login:</label>
            <input
              type="text"
              className="form-control"
              id="login"
              placeholder="Twój login"
              onChange={handleChange}
            />
          </div>
          <div className="form-group m-4">
            <input
              type="checkbox"
              name="isPasswordGeneratedChbx"
              checked={isPasswordGenerated}
              onChange={() => {
                setIsPasswordGenerate((prev) => !prev);
              }}
            />{" "}
            Wygeneruj hasło
          </div>
          <div className="form-group m-4">
            <label htmlFor="password">Hasło:</label>
            <input
              type="password"
              className="form-control"
              id="password"
              disabled={isPasswordGenerated}
              onChange={handleChange}
            />
          </div>
          <button type="submit" className="btn btn-primary m-2">
            Zapisz
          </button>
        </form>
      </section>
      <section>
        <p className="p-2 text-primary">
          Adres: {isFormSubmitted && formData.www}
        </p>
        <p className="p-2">Login: {isFormSubmitted && formData.login}</p>
        <p className="p-2">
          Hasło:{" "}
          {isFormSubmitted && isPasswordGenerated
            ? "Hasło automatycznie generowane"
            : formData.password}
        </p>
      </section>
    </>
  );
}

export default App;
