package main;

import data.FairyTale;

import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

public class Main {
    public static void main(String[] args) {
        Set<FairyTale> fairyTaleSet = new HashSet<>();

        // add some fairy tales to the set
        fairyTaleSet.add(new FairyTale("Cinderella", 20));
        fairyTaleSet.add(new FairyTale("Little Red Riding Hood", 15));
        fairyTaleSet.add(new FairyTale("The Three Little Pigs", 25));
        fairyTaleSet.add(new FairyTale("Cinderella", 30)); // adding a fairy tale with the same title

        System.out.println("Number of fairy tales in the set: " + fairyTaleSet.size());

        // iterate over the set and print the fairy tales
        Iterator<FairyTale> iterator = fairyTaleSet.iterator();
        while (iterator.hasNext()) {
            System.out.println(iterator.next());
        }
    }
}
