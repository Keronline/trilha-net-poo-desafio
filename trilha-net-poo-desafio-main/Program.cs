using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia("11922222623", "Modelo 5.4", "dfg45415", 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("Qual é seu novo número de celular?");
nokia.Numero = Console.ReadLine();
Console.WriteLine($"Seu número de celular foi alterado para: {nokia.Numero}");
Console.WriteLine("");

Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone("11922224444", "Modelo 5.4", "dfg45415", 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Wase");