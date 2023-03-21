package ConcertAttendance.main;

import ConcertAttendance.data.Person;

import java.util.LinkedList;
import java.util.Scanner;

public class main {
    public static void main(String[] args) {
        LinkedList<Person> cola = new LinkedList<>();
        Scanner sc = new Scanner(System.in);
        String name;
        int age = 0;

        do {
            System.out.println("Name:");
            name = sc.nextLine();
            if (!name.equals("")) {
                System.out.println("Age:");
                age = sc.nextInt();
                sc.nextLine();
                cola.add(new Person(name, age));
            }
        }while(!name.equals(""));

        System.out.println("Adult People");
        for(Person p : cola) {
            if (p.getAge() > 18)
                System.out.println(p);
        }
    }
}

