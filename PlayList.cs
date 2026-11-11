public class Playlist {

    private List<Song> _songs = new List<Song>();
    public string Name { get; private set; }
    

    public int SongsCount {
        get { return _songs.Count; }
    }

    public Playlist(string name) {
        Name = name;
    }

    public bool AddSong(Song song) {
        if (FindSongByNameAndPerformer(song.Name, song.Performer) != null) {
            return false;    
        }

        _songs.Add(song);
        return true;
    }

    public bool RemoveSong(string name, string performer) {
        Song? song = FindSongByNameAndPerformer(name, performer);
        if (song == null) {
            return false;
        }
        return _songs.Remove(song);
    }

    public Song? FindSongByNameAndPerformer(string name, string performer) {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(performer)) {
            return null;
        }

        string searchName = name.Trim();
        string searchPerformer = performer.Trim();
        foreach (Song song in _songs) {
            if (string.Equals(song.Name, searchName, StringComparison.OrdinalIgnoreCase) 
                && string.Equals(song.Performer, searchPerformer, StringComparison.OrdinalIgnoreCase)) {
                return song;
            }
        }
        return null;
    }

    public List<Song> GetPlayList() {
        List<Song> newList = new List<Song>();
        foreach (Song song in _songs) {
            newList.Add(song);
        }
        return newList;
    }

    public int CountSongPerformer(string performer) {
        int countSongs = 0;
        if (string.IsNullOrWhiteSpace(performer) == false) {
            string searchPerformer = performer.Trim();
            foreach (Song song in _songs) {
                if (string.Equals(song.Performer, searchPerformer, StringComparison.OrdinalIgnoreCase)) {
                    countSongs++;
                }
            }
        }
        return countSongs;
    }
}
