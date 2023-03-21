package data;

import java.util.Objects;

public class FairyTale {
    private String title;
    private int numPages;

    public FairyTale(String title, int numPages) {
        this.title = title;
        this.numPages = numPages;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public int getNumPages() {
        return numPages;
    }

    public void setNumPages(int numPages) {
        this.numPages = numPages;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof FairyTale)) return false;
        FairyTale fairyTale = (FairyTale) o;
        return Objects.equals(title, fairyTale.title);
    }

    @Override
    public int hashCode() {
        return Objects.hash(title);
    }

    @Override
    public String toString() {
        return "FairyTale{" +
                "title='" + title + '\'' +
                ", numPages=" + numPages +
                '}';
    }
}
