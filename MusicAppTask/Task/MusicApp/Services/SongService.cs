using MusicApp.CustomExceptions;
using MusicApp.Enums;
using MusicApp.Models;

namespace MusicApp.Services;

public class SongService
{
    private static List<Song> SongList { get; } = [];

    public void AddSong(Song song)
    {
        if (song is null)
        {
            throw new SongException("Song is cannot be null");
        }

        SongList.Add(song);
        Console.WriteLine($"Song added");
    }

    public Song GetSongById(int id)
    {
        foreach (var song in SongList)
        {
            if (song.SongId == id)
            {
                return song;
            }
        }

        throw new SongException($"Song does not exist with id: {id}");
    }

    public Song GetSongByArtist(string artist)
    {
        foreach (var song in SongList)
        {
            foreach (var artistName in song.Artists)
            {
                if (artistName.Equals(artist))
                {
                    return song;
                }
            }
        }

        // foreach (var artis in song.Artists)
        // {
        //     if (artis.Equals(artist))
        //     {
        //         return song;
        //     }
        // }
        throw new SongException($"Song does not exist with artis name: {artist}");
    }

    public Song GetSongByName(string name)
    {
        foreach (var song in SongList)
        {
            if (song.Name.Equals(name))
            {
                return song;
            }
        }
        throw new SongException($"Song does not exist with name: {name}");
    }

    public Song GetSongByGenre(GenreEnum genre)
    {
        foreach (var song in SongList)
        {
            if (song.Genre==genre)
            {
                return song;
            }
        }
        throw new SongException($"Song does not exist with genre: {genre}");
    }


    public List<Song> GetAllSongs()
    {
        if (SongList.Count == 0)
        {
            throw new SongException("There are not songs yet");
        }

        return SongList;
    }

    public void UpdateSong(int id, Song newSong)
    {
        if (newSong is null)
        {
            throw new SongException("Song is cannot be null");
        }

        foreach (Song song in SongList)
        {
            if (song.SongId == id)
            {
                song.Artists = newSong.Artists;
                song.Name = newSong.Name;
                song.Genre = newSong.Genre;
                song.Duration = newSong.Duration;
                Console.WriteLine($"Song updated successfully");
                return;
            }
        }
    }

    public void DeleteSong(int id)
    {
        foreach (var song in SongList)
        {
            if (song.SongId == id)
            {
                SongList.Remove(song);
                Console.WriteLine($"Song deleted successfully");
                return;
            }
        }
    }
}