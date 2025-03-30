using DesafioPOOAbstract.Models;

Iphone cel = new Iphone("123", "i13", "valor", 120);
cel.ReceberLigacao();
cel.InstalarAplicativo("instagram");

Nokia cel2 = new Nokia("321", "N5", "a", 128);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("facebook");
Console.WriteLine(cel2.Memoria);
cel2.Ligar();