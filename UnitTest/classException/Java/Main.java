import java.util.Scanner;
public class Main 
{
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        try {
            System.out.println("Первое число: ");
            double a = in.nextDouble();

            System.out.println("Второе число: ");
            double b = in.nextDouble();

            if(b == 0){
                throw new Exception("Деление на 0 невозможно");
            }

            double res = a / b;
            System.out.print("Результат: ");
            System.out.println(res);
        }
        catch(Exception error){
            System.out.println("Деление на 0 невозможно");
        }
        finally{
            System.out.println("Программа завершена");
        }
    }
}