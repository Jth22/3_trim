import java.util.Scanner;


public class ReversedTriangle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Pedir al usuario que ingrese el número de filas y columnas
        System.out.print("Ingrese el número de filas: ");
        int rows = scanner.nextInt();
        System.out.print("Ingrese el número de columnas: ");
        int columns = scanner.nextInt();

        // Crear la pila y almacenar las líneas del triángulo
        Stack<String> stack = new Stack<String>();
        for (int i = 1; i <= rows; i++) {
            StringBuilder line = new StringBuilder();
            for (int j = 1; j <= columns; j++) {
                if (j >= i && j <= columns - i + 1) {
                    line.append("*");
                } else {
                    line.append(" ");
                }
            }
            stack.push(line.toString());
        }

        // Imprimir las líneas de la pila en orden inverso
        while (!stack.empty()) {
            System.out.println(stack.pop());
        }
    }
}

