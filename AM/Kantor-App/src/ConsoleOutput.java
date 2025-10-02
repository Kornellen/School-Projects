public class ConsoleOutput {
    public static void listCurrencies() {
        String[] currencies = {"Dolar Amerykański (USD)", "Funt Brytyjski (GBP)", "Frank Szwajcarski (CHF)", "Yen Japoński (JPY)", "Euro (EUR)"};
        System.out.println("Dostępne waluty:");
        for (int i=0; i < currencies.length; i++) {
            System.out.println((i + 1) + ") " + currencies[i]);
        }
    }
}
