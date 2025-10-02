import java.util.Scanner;


public class Main {
    public final static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        try {
            System.out.printf("Witaj w Kantor-App!\n");

            ConsoleOutput.listCurrencies();

            System.out.printf("Wybierz na jaką walutę chcesz zamienić Złotego (PLN): ");
            int userInput = Integer.parseInt(input.nextLine());

            Exchange.selectOption(userInput);

        } catch (Exception e) {
            if (e instanceof java.lang.NumberFormatException) {
                System.out.println("Niepoprawny format wprowadzonych danych!");
            } else {
                System.out.println(e.getMessage());
            }
            System.exit(1);
        }
    }
}