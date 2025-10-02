enum Currencies {
    USD,
    GBP,
    CHF,
    JPY,
    EUR
}

public class Exchange {
    private static void ExchangePLN(float currencyPrice, String currency) {
        System.out.printf("Ilość pieniędzy do zamiany: ");

        double userMoneyInput = Double.parseDouble(Main.input.nextLine());

        System.out.println("Dane na dzień: 02/10/2025, godzina: 20:45");
        System.out.println("Aktualny kurs 1 " + currency + " na PLN: " + currencyPrice + "zł" );
        System.out.println("[PLN => "+ currency +"]: " + (Math.round((userMoneyInput / currencyPrice) * 100.0) / 100.0) + " " + currency);
    }

    public static void selectOption(int userInput) {
        switch (userInput) {
            case 1:
                ExchangePLN(3.63f, Currencies.USD.toString());
                break;
            case 2:
                ExchangePLN(4.89f, Currencies.GBP.toString());
                break;
            case 3:
                ExchangePLN(4.55f, Currencies.CHF.toString());
                break;
            case 4:
                ExchangePLN(0.025f, Currencies.JPY.toString());
                break;
            case 5:
                ExchangePLN(4.26f, Currencies.EUR.toString());
                break;
            default:
                System.out.println("Nie znaleziono takiej waluty!");
                System.exit(1);
                break;
        }
    }
}
