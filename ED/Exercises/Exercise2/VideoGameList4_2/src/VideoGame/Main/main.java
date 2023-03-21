/* Exercise 1 Go back to Exercise 1 of this document.
Replace the video game array in main method with a generic ArrayList.
Then, add some video games to the list (either VideoGame or PCVideoGame objects),
explore and show the list with a for and ask the user to:
 . Search video games by title: the user will type a title and then the program
   will show all the video games whose title contains the typed text (ignoring case).
 . Remove a video game from the list: the user will type the index of the video game to be removed,
   and if the index is valid, the video game in that index will be removed.
*/
package VideoGame.Main;

import VideoGame.Data.*;

import java.util.*;

public class main {
    public static final int MAX_VIDEOGAMES = 5;
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        List<VideoGame> listVideo = new ArrayList<>();
        int chosenCompany, chosenType;

        // Pre-defined array of companies

        Company[] companies = new Company[3];
        companies[0] = new Company("Capcom", 1987);
        companies[1] = new Company("UbiSoft", 1998);
        companies[2] = new Company("EA Sports", 1990);

        for(int i = 0; i < MAX_VIDEOGAMES; i++)
        {
            System.out.println("Choose the game type (1. VideoGame, 2. PC VideoGame)");
            System.out.print("? ");
            chosenType = sc.nextInt();
            sc.nextLine();

            switch(chosenType)
            {
                case 2:
                    listVideo.add(new PCVideoGame());
                    break;
                default:
                    listVideo.add(new VideoGame());
                    break;
            }

            System.out.println("Enter title for videogame " + (i+1) + ":");
            String title = sc.nextLine().toLowerCase();
            listVideo.get(i).setTitle(title);

            System.out.println("Enter genre for videogame " + (i+1) + ":");
            listVideo.get(i).setGenre(sc.nextLine());

            System.out.println("Enter price for videogame " + (i+1) + ":");
            listVideo.get(i).setPrice(sc.nextFloat());

            // Add company to the video game

            for (int j = 0; j < companies.length; j++)
            {
                System.out.println((j+1) + ". " + companies[j].getName());
            }
            System.out.println("Choose a company from the list (1 - " +
                    companies.length + "):");
            chosenCompany = sc.nextInt();
            sc.nextLine();
            listVideo.get(i).setCompany(companies[chosenCompany - 1]);

            if (chosenType == 2)
            {
                System.out.println("Choose the minimum RAM:");
                ((PCVideoGame)listVideo.get(i)).setMinimumRAM(sc.nextInt());
                System.out.println("Choose the minimum HD:");
                ((PCVideoGame)listVideo.get(i)).setMinimumHD(sc.nextInt());
            }
        }

        int cantidad = listVideo.size();

        System.out.println("Enter a title to search:");
        String tit = sc.nextLine().toLowerCase();

        for(int i = 0 ; i < cantidad ; i++){
            if (listVideo.get(i).getTitle().contains(tit)){
                System.out.println("Videogame "+(i+1)+ ":");
                System.out.println("Title: "+ listVideo.get(i).getTitle());
                System.out.println("Genre: "+ listVideo.get(i).getGenre());
                System.out.println("Price: "+ listVideo.get(i).getPrice());
                System.out.println("Company: "+ listVideo.get(i).getCompany().getName());
                System.out.println();
            }

        }
        System.out.println("Lsita de viddeojuegos:");
        for(VideoGame v : listVideo)
            System.out.println(v.getTitle());
        System.out.println();
        System.out.println("Enter the index of the video game to remove:");
        int pos = sc.nextInt()-1;
        if (pos > 0 && pos <= listVideo.size()){
            listVideo.remove(pos);
            System.out.println("Video game removed successfully.");
        } else{
            System.out.println("Invalid index.");
        }

        Collections.sort(listVideo, new VideoGameComparator() );
        System.out.println();
        System.out.println("Sorted list;");
        for (int i = 0; i < listVideo.size(); i++) {
            System.out.println(listVideo.get(i).getTitle()+", "
                    + listVideo.get(i).getPrice());
        }
    }
}
