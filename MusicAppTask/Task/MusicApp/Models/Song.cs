using MusicApp.Enums;

namespace MusicApp.Models;

public class Song
{
    private static int _idCounter;
    public int SongId { get; set; }

    public string Name { get; set; }

    public List<string> Artists { get; set; } 

    public GenreEnum Genre { get; set; }

    public int Duration { get; set; }

    public Song(string name, GenreEnum genre, int duration,List<string> artists)
    {
        _idCounter++;
        SongId = _idCounter;
        Name = name;
        Genre = genre;
        Duration = duration;
        Artists = artists;
    }

    public override string ToString()
    {
        string artists = "";
        foreach (var name in Artists)
        {
            artists += name + "\n";
        }
        return $"---------\nId:{SongId}\nName:{Name}\nGenre:{Genre}\nDuration:{Duration}\nArtists:{artists}\n---------";
    }
}