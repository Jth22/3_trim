package store.main;

import store.data.Book;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Library {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        final int CAPACITY = 3;
        Map<String, Book> mybooks = new HashMap<String, Book>();
        for(int i = 0 ; i < CAPACITY; i++){
            System.out.println("id:");
            String id = sc.nextLine();
            System.out.println("Title:");
            String tit = sc.nextLine();
            System.out.println("Author:");
            String author = sc.nextLine();
            mybooks.put(id, new Book(id,tit,author));
        }

        for(String id : mybooks.keySet()){
            System.out.println(mybooks.get(id).toString());
        }
    }
}
