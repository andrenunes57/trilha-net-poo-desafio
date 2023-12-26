using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia("11980004000", "Lumia", "1111111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone");
var iphone = new Iphone("11970003000", "X10", "2222222222", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");