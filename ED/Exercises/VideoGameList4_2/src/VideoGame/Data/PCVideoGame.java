package VideoGame.Data;

public class PCVideoGame extends VideoGame
{
    private int minimumRAM;
    private int minimumHD;

    public PCVideoGame() {}

    public PCVideoGame(String title, String genre,int price, Company company,
                       int minimumRAM, int minimumHD)
    {
        super(title, genre, price, company);
        this.minimumRAM = minimumRAM;
        this.minimumHD = minimumHD;
    }

    public int getMinimumRAM()
    {
        return minimumRAM;
    }

    public void setMinimumRAM(int minimumRAM)
    {
        this.minimumRAM = minimumRAM;
    }

    public int getMinimumHD()
    {
        return minimumHD;
    }

    public void setMinimumHD(int minimumHD)
    {
        this.minimumHD = minimumHD;
    }

    // Overriding toString method and using "super" to call parent's
    // toString

    @Override
    public String toString()
    {
        return super.toString() + " " + minimumRAM + "GB, " + minimumHD + "MB";
    }
}
