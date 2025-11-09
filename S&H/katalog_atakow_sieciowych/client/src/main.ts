const attacksListElem: HTMLUListElement =
  document.querySelector(".attacks-list")!;

// Definiowanie stałej jako klasy Tailwind dla Buttonów

const BUTTON_CLASS =
  "bg-slate-500 m-7 p-2 rounded-lg text-lg text-gray-200 shadow-lg hover:bg-slate-600 w-64";

/**
 * Promise którego zadaniem jest pobranie listy wszystkich ataków
 * i późniejsze ich wyswietlenie w liście `ul`.attacks-list
 *
 * Promise ten tworzy także Buttony, które są Childrenami elementów `li` listy .attacks-list
 *
 * Promise ten jest wykonywany zaraz po załadowaniu strony, celem przygotowania listy
 */

async function loadAttacksList(): Promise<void> {
  try {
    const response = await fetch("http://localhost:5175/api/attacks");
    const data = await response.json();

    if (!response.ok)
      throw new FetchError(response.status, response.statusText);

    const attacks = data.attacks;

    attacks.forEach((attack: string): void => {
      const listElem: HTMLLIElement = document.createElement("li");
      const buttonElem: HTMLButtonElement = document.createElement("button");
      buttonElem.textContent = attack;
      buttonElem.classList = BUTTON_CLASS;

      buttonElem.onclick = () => getAttackInfo(attack);

      listElem.appendChild(buttonElem);
      attacksListElem.appendChild(listElem);
    });
  } catch (error) {
    if (error instanceof FetchError) alert(error.alertMessage);
    else alert(error);
  }
}

/**
 * Promise będący EventHandlerem zarazem.
 *
 * Jego zadaniem jest pobranie informacji dot. wybranego przez użytkownika Ataku Sieciowego
 *
 * @param attackName - Parametr będący nazwą wybranego ataku
 *
 * @returns `void` - Promise ten nie zwraca nic
 *
 * Swoje działanie kończy wyświetlając odpowiedni `alert`
 */

async function getAttackInfo(attackName: string): Promise<void> {
  try {
    const response = await fetch(
      `http://localhost:5175/api/attack?attackName=${attackName}`,
      {
        headers: {
          "Content-Type": "application/json",
        },
      }
    );

    if (!response.ok)
      throw new FetchError(response.status, response.statusText);

    const data = await response.json();

    const ALERT_MESSAGE = `
${data.icon}
Nazwa Ataku: ${attackName}
Skrót: ${data.shortname !== undefined ? data.shortname : "Brak Skrótu"}
Krótki Opis:\n${data.description}
    `;

    alert(ALERT_MESSAGE);
  } catch (error) {
    if (error instanceof FetchError) alert(error.alertMessage);
    else alert(error);
  }
}

loadAttacksList();

/**
 * Obiekt dziedzicący pod klasie Error
 * stanowi on rozszerzenie klasycznego Errora
 *
 * Jest on ukierunkowany na obsługę zdarzeń czysto Fetchingowych
 */
class FetchError extends Error {
  statusCode: number;
  alertMessage: string;
  constructor(statusCode: number, message: string) {
    super(message);

    console.error(message);

    this.statusCode = statusCode;

    this.alertMessage = `Kod Błędu: ${statusCode}\nBłąd: ${message}`;
  }
}

/**
 * EventListener zajmujący się zmianą tytułu wyświetlanego na karcie
 */

document.addEventListener(
  "visibilitychange",
  () =>
    (document.title = `${
      document.hidden ? "📁" : "📂"
    } Katalog Ataków Sieciowych`)
);
