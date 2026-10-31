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

    public void NewLike() {
        Likes += 1;
    }

    public void ChangeYear(int year_new) {
        if (year_new < 1600 || year_new > 2026) {
            return;
        }

        Year = year_new;
    }
}