import java.util.Stack;
public class ReversedFigure{
    public static void main(String[] agrs){
        Stack<String> stack = new Stack<String>();
        int rows = 4;
        int columns = 7;
        for (int i = rows; i >= 1; i--) {
            StringBuilder linea = new StringBuilder();
            for (int j = 1; j <= columns; j++) {
                if (j >= i && j <= columns - i + 1) {
                    linea.append("*");
                } else {
                   linea.append(" ");
                }
            }
            stack.push(linea.toString());
        }
        while (!stack.empty()) {
            System.out.println(stack.pop());
        }
    }
}
