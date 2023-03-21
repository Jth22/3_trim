package VideoGame.Main;

import java.util.Comparator;
import VideoGame.Data.VideoGame;

public class VideoGameComparator implements Comparator<VideoGame>
{

    @Override
    public int compare(VideoGame v1, VideoGame v2)
    {
        return Float.compare(v1.getPrice(), v2.getPrice());
    }
}
