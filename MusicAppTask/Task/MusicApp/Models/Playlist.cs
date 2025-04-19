namespace MusicApp.Models;

public class Playlist
{
    private static int _idCounter;
    public int PlaylistId { get; set; }

    public string PlaylistName { get; set; }

    public List<Song> Songs { get; set; } = [];

    public Playlist(string playlistName)
    {
        _idCounter++;
        PlaylistId = _idCounter;
        PlaylistName = playlistName;
    }

    public override string ToString()
    {
        string songs = "";
        foreach (var s in Songs)
        {
            songs += s + "\n";
        }

        return $"---------\nId: {PlaylistId}\nName: {PlaylistName}\nSongs: {songs}\n---------";
    }
}