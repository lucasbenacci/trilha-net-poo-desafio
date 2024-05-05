using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i = new Iphone("24993251445", "45", "15 pro max", 512);

Console.WriteLine($"{i.Numero}");
i.Numero = "2499255634";

Console.WriteLine($"{i.Numero}");
Console.WriteLine($"i.InstalarAplicativo("Whatsapp")");
