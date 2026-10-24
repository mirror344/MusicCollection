public class Song {
    public string Name;
    public string Performer;
    public string Album;
    public int Year;
    public int Likes;

    public Song(string name, string performer, string album, int year) {
        Name = name;
        Performer = performer;
        Album = album;
        Year = year;
        Likes = 0;
    }
}