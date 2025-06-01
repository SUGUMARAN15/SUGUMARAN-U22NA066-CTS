import java.util.Scanner;
public class Calculator {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first number: ");
        double num1 = sc.nextDouble();
        System.out.print("Enter second number: ");
        double num2 = sc.nextDouble();
        System.out.println("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        int choice = sc.nextInt();
        double result = 0;
        switch (choice) {
            case 1: result = num1 + num2; break;
            case 2: result = num1 - num2; break;
            case 3: result = num1 * num2; break;
            case 4: result = num1 / num2; break;
        }
        System.out.println("Result: " + result);
    }
}