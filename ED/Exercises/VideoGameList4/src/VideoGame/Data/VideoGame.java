package VideoGame.Data;

public class VideoGame {
    protected String title;
    protected String genre;
    protected float price;
    protected Company company;

    public VideoGame()
    {
        title = "";
        genre = "";
        price = 0;
    }

    public VideoGame(String t, String g, float p, Company c)
    {
        title = t;
        genre = g;
        price = p;
        company = c;
    }

    public String getTitle()
    {
        return title;
    }

    public void setTitle(String t)
    {
        title = t;
    }

    public String getGenre()
    {
        return genre;
    }

    public void setGenre(String g)
    {
        genre = g;
    }

    public float getPrice()
    {
        return price;
    }

    public void setPrice(float p)
    {
        price = p;
    }

    public Company getCompany()
    {
        return company;
    }

    public void setCompany(Company c)
    {
        company = c;
    }
}
