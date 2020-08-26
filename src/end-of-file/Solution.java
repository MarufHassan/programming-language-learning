import java.util.Scanner;

public class Solution{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lineno = 1;
        while (scanner.hasNextLine()) {
            System.out.println(lineno + " " + scanner.nextLine());
            lineno++;
        }
        scanner.close();
    }
}