using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"91085713", modelo:"14", imei:"1234", memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero:"74001936", modelo:"13c", imei:"4321", memoria:128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");