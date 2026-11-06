public class Song {
    private string _name = "Неизветсно";
    public string Name {
        get {
            return _name;
        }
        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Неизветсно";
                return;
            }
            _name = value.Trim();
        }
    }
    private string _performer = "Неизветсно";
    public string Performer {
        get {
            return _performer;
        }
        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _performer = "Неизветсно";
                return;
            }
            _performer = value.Trim();
        }
    }
    private string _album = "Нет";
    public string Album {
        get {
            return _album;
        }
        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _album = "Нет";
                return;
            }
            _album = value.Trim();
        }
    }
    public int Year { get; private set; }
    public int Likes { get; private set; }

    public Song(string name, string performer, string album, int year) {
        Name = name;
        Performer = performer;
        Album = album;
        Year = year;
        if (year < 1600) {
            Year = 1600;
        }
        if (year > 2026) {
            year = 2026;
        }
        Likes = 0;
    }

    public void NewLike() {
        if (Likes >= 2147483647 ) {
            return;
        }

        Likes += 1;
    }

    public void ChangeYear(int year_new) {
        if (year_new < 1600 || year_new > 2026) {
            return;
        }

        Year = year_new;
    }

    public string GetInfo() {
        return $"Название: {Name}\n" +
               $"Исполнитель: {Performer}\n" +
               $"Альбом: {Album}\n" +
               $"Год выхода: {Year}\n" +
               $"Лайки: {Likes}\n";
    }
}