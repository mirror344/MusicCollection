Song faint = new Song("  Faint   ", "   Linkin Park  ", "  Meteora  ", -2003);
Song photograph = new Song("Photograph", "Def Leppard", "", 1983);
Song window_shopper = new Song("Window Shopper", "   ", "Get Rich or Die Tryin'", 2005);

Console.WriteLine("Первая песня:");
Console.WriteLine(faint.GetInfo());

Console.WriteLine("Вторая песня:");
Console.WriteLine(photograph.GetInfo());


Console.WriteLine("Третья песня:");
Console.WriteLine(window_shopper.GetInfo());


faint.ChangeYear(2015);
Console.WriteLine($"Новый год: {faint.Year}");

photograph.ChangeYear(3000);
Console.WriteLine($"После неправильного года: {photograph.Year}");
faint.NewLike();


Console.WriteLine($"Лайки первой песни: {faint.Likes}");
