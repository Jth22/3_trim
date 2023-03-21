package VideoGame.Data;

public class Company {
    private String name;
    private int foundationYear;

    public Company(String n, int y)
    {
        name = n;
        foundationYear = y;
    }

    public String getName() { return name; }

    public void setName(String n) { name = n; }

    public int getFoundationYear() { return foundationYear; }

    public void setFoundationYear(int y) { foundationYear = y; }
}
