using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i = new Iphone("24995256445", "45", "15 pro max", 512);

Console.WriteLine($"{i.Numero}");

//Trocando o número.
i.Numero = "2499255634";
Console.WriteLine($"{i.Numero}");

i.InstalarAplicativo("Instagram");

i.Ligar();
i.ReceberLigacao();

Nokia n = new Nokia("24999556568", "76", "G60", 512);

Console.WriteLine($"{i.Numero}");

//Trocando o número.
n.Numero = "2497255734";
Console.WriteLine($"{n.Numero}");

n.InstalarAplicativo("Whatsapp");

n.Ligar();
n.ReceberLigacao();
