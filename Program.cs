Song faint = new Song("  Faint   ", "   Linkin Park  ", "  Meteora  ", 2003);
Song photograph = new Song("Photograph", "Def Leppard", "", 1983);
Song window_shopper = new Song("Window Shopper", "   ", "Get Rich or Die Tryin'", 2005);
Song false_alarm = new Song("False Alarm", "The Weeknd", "Starboy", 2016);
Song starboy = new Song("Starboy", "The Weeknd", "Starboy", 2016);

Playlist playlist = new Playlist("Любимые");
playlist.AddSong(faint);
playlist.AddSong(photograph);
playlist.AddSong(window_shopper);
playlist.AddSong(false_alarm);
playlist.AddSong(starboy);


faint.NewLike();

List<Song> favorite = playlist.GetPlayList();


Console.WriteLine($"{playlist.Name}");
Console.WriteLine($"Количество песен: {playlist.SongsCount}");

if (favorite.Count > 0) {
    Console.WriteLine($"Первая: {favorite[0].Name}");
    Console.WriteLine($"Последняя: {favorite[favorite.Count - 1].Name}");
}

Console.WriteLine();

foreach(Song song in favorite) {
    Console.WriteLine(song.GetInfo());
    Console.WriteLine();
}


Song? found = playlist.FindSongByNameAndPerformer(" FAiNt ", " LinKin PArk ");
if (found != null) {
    Console.WriteLine($"Найдено по запросу «  FAiNt ,  LinKin PArk »: {found.Name} {found.Performer}");
}
else {
    Console.WriteLine("Ничего не найдено!");
}

Console.WriteLine($"Дупликат принят: {playlist.AddSong(faint)}");
Console.WriteLine($"Удаление песни: {playlist.RemoveSong("Photograph", "Def Leppard")}");

Console.WriteLine();


Console.WriteLine($"Количество песен «The Weeknd»: {playlist.CountSongPerformer("The Weeknd")}");



