Song faint = new Song("Faint", "Linkin Park", "Meteora", 2003);
Song photograph = new Song("Photograph", "Def Leppard", "Pyromania", 1983);
Song window_shopper = new Song("Window Shopper", "50 Cent", "Get Rich or Die Tryin'", 2005);


Console.WriteLine("Песня 1");
Console.WriteLine(faint.GetInfo());

Console.WriteLine();

Console.WriteLine("Песня 2");
Console.WriteLine(photograph.GetInfo());

Console.WriteLine();

Console.WriteLine("Песня 3");
Console.WriteLine(window_shopper.GetInfo());

Console.WriteLine();

Console.WriteLine($"До изменения: {faint.Likes}");
faint.NewLike();
Console.WriteLine($"После изменения: {faint.Likes}");

Console.WriteLine();
Console.WriteLine($"Год выхода до изменений: {window_shopper.Year}");
window_shopper.ChangeYear(2003);
Console.WriteLine($"Год выхода после изменений: {window_shopper.Year}");

Console.WriteLine();
faint.ChangeYear(900);
Console.WriteLine($"Недопустимое значение: {faint.Year}");
faint.ChangeYear(2077);
Console.WriteLine($"Недопустимое значение: {faint.Year}");