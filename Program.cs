Song faint = new Song("  Faint   ", "   Linkin Park  ", "  Meteora  ", 2003);
Song photograph = new Song("Photograph", "Def Leppard", "", 1983);
Song window_shopper = new Song("Window Shopper", "   ", "Get Rich or Die Tryin'", 2005);
Song false_alarm = new Song("False Alarm", "The Weeknd", "Starboy", 2016);

Playlist playlist = new Playlist("Любимые");
playlist.Songs.Add(faint);
playlist.Songs.Add(photograph);
playlist.Songs.Add(window_shopper);
playlist.Songs.Add(false_alarm);


playlist.Songs[0].NewLike();
playlist.Songs[3].NewLike();

Console.WriteLine($"{playlist.Name}");
Console.WriteLine($"Количество песен: {playlist.Songs.Count}");

if (playlist.Songs.Count > 0) {
    Console.WriteLine($"Первая: {playlist.Songs[0].Name}");
    Console.WriteLine($"Последняя: {playlist.Songs[playlist.Songs.Count - 1].Name}");
}

Console.WriteLine();

foreach(Song song in playlist.Songs) {
    Console.WriteLine(song.GetInfo());
    Console.WriteLine();
}

int yearCount = 0;
foreach(Song song in playlist.Songs) {
    if (song.Year >= 2000) {
        yearCount++;
    }
}

Console.WriteLine($"Песен, выпущенных после 2000 года: {yearCount}");
