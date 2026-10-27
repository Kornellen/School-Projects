import { useState } from "react";

function App() {
  const [isPasswdGen, setIsPasswdGen] = useState<boolean>(true);
  const [userData, setUserData] = useState<{
    www: string;
    login: string;
    password: string;
  }>({ www: "", login: "", password: "" });
  const handleSubmit = (e: React.SubmitEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);

    const www = String(formData.get("www"));
    const login = String(formData.get("login"));
    const password = String(formData.get("password"));

    setUserData({ www, login, password });
  };

  return (
    <>
      <section>
        <section>
          <h1>Menedżer haseł - wykonał 00000000000</h1>
          <form onSubmit={handleSubmit}>
            <div className="form-group m-4">
              <label htmlFor="inputWWW">Adres WWW:</label>
              <input
                type="text"
                className="form-control"
                id="inputWWW"
                placeholder="Adres strony WWW"
                name="www"
              />
            </div>
            <div className="form-group m-4">
              <label htmlFor="inputLogin">Login:</label>
              <input
                type="text"
                className="form-control"
                id="inputLogin"
                placeholder="Twój login"
                name="login"
              />
            </div>
            <div className="form-group m-4">
              <input
                type="checkbox"
                onChange={() => setIsPasswdGen(!isPasswdGen)}
                name=""
                id="genPasswd"
                defaultChecked
              />
              <label htmlFor="genPasswd"> Wygeneruj hasło</label>
            </div>
            <div className="form-group m-4">
              <label htmlFor="inputPassword1">Hasło:</label>
              <input
                disabled={isPasswdGen}
                type="password"
                className="form-control"
                id="inputPassword1"
                name="password"
              />
            </div>
            <button type="submit" className="btn btn-primary m-2">
              Zapisz
            </button>
          </form>
        </section>
        <section>
          <p className="text-primary fs-2 p-2">Adres: {userData.www}</p>
          <p className="fs-5 p-2">Login: {userData.login}</p>
          <p className="fs-5 p-2">
            {!isPasswdGen
              ? `Hasło: ${userData.password}`
              : "Hasło automatycznie generowane"}
          </p>
        </section>
      </section>
    </>
  );
}

export default App;
