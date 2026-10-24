Song faint = new Song("Faint", "Linkin Park", "Meteora", 2003);
Song photograph = new Song("Photograph", "Def Leppard", "Pyromania", 1983);
Song window_shopper = new Song("Window Shopper", "50 Cent", "Get Rich or Die Tryin'", 2005);

faint.Likes = 100;


Console.WriteLine("Песня 1");
Console.WriteLine($"Название: {faint.Name}");
Console.WriteLine($"Исполнитель: {faint.Performer}");
Console.WriteLine($"Альбом: {faint.Album}");
Console.WriteLine($"Год выхода: {faint.Year}");
Console.WriteLine($"Лайки: {faint.Likes}");

Console.WriteLine();

Console.WriteLine("Песня 2");
Console.WriteLine($"Название: {photograph.Name}");
Console.WriteLine($"Исполнитель: {photograph.Performer}");
Console.WriteLine($"Альбом: {photograph.Album}");
Console.WriteLine($"Год выхода: {photograph.Year}");
Console.WriteLine($"Лайки: {photograph.Likes}");

Console.WriteLine();

Console.WriteLine("Песня 3");
Console.WriteLine($"Название: {window_shopper.Name}");
Console.WriteLine($"Исполнитель: {window_shopper.Performer}");
Console.WriteLine($"Альбом: {window_shopper.Album}");
Console.WriteLine($"Год выхода: {window_shopper.Year}");
Console.WriteLine($"Лайки: {window_shopper.Likes}");

