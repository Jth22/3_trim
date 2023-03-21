package main;


import java.util.Scanner;
import java.util.Stack;

public class Main {
    public static void main(String[] agrs){
        Scanner sc = new Scanner(System.in);
        Stack<String> cola = new Stack<>();
        String dato;
        do{
            System.out.println("Dime un dato");
            dato = sc.nextLine();
            if (!dato.equals("")){
                cola.push(dato);
            }
        }while(!dato.equals(""));

        while(!cola.empty()){
            String s = cola.pop();
            System.out.println(s);
        }

    }
}
