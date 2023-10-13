using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Telefone Nokia: ");
Nokia nokia = new Nokia("099877","Asha","0999312415",32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook Message");
nokia.ChecarIMEI();
nokia.ChecarQtdArmazenamento();

Console.WriteLine("\n");

Console.WriteLine("Telefone Nokia: ");
Iphone iphone = new Iphone("5787721", "Iphone 8", "312412511", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Snapchat");
iphone.ChecarIMEI();
iphone.ChecarQtdArmazenamento();
