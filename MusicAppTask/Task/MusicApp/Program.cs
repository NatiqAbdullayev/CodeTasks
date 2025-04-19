using MusicApp.Enums;
using MusicApp.Models;
using MusicApp.Services;

namespace MusicApp;

class Program
{
    static void Main(string[] args)
    {
        SongService songService = new SongService();
        PlaylistService playlistService = new PlaylistService();

        Song mySong = new Song("Teze mahni", GenreEnum.ROCK, 321, new List<String> { "Natiq" });
        Song mySong2 = new Song("Teze mahni", GenreEnum.ROCK, 321, new List<String> { "Natiq,NPC" });
        Song mySong3 = new Song("Teze mahni", GenreEnum.METAL, 321, new List<String> { "Natiq" });
        Song mySong4 = new Song("Teze mahni", GenreEnum.JAZ, 321, new List<String> { "Natiq,Fazil" });

        // songService.AddSong(mySong);
        // songService.AddSong(mySong2);
        // songService.AddSong(mySong3);
        // songService.AddSong(mySong4);
        //
        // songService.DeleteSong(4);
        // Console.WriteLine(songService.GetSongById(4));


        Playlist myPlaylist = new Playlist("Yeni Playlist");
        playlistService.AddPlaylist(myPlaylist);
        playlistService.AddSongToPlaylist(1,mySong);
        Console.WriteLine(playlistService.GetPlaylistById(1));
    }
}