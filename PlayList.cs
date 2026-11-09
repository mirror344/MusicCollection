public class Playlist {
    public string Name { get; private set; }
    public List<Song> Songs { get; private set; } = new List<Song>();

    public Playlist(string name) {
        Name = name;
    }
}
