using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(number: "123456", model: "Model 01", imei: "1111111", memory: 32);
nokia.TurnOn();
nokia.InstallApp("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(number: "654321", model: "Model 02", imei: "2222222", memory: 16);
iphone.TurnOn();
iphone.InstallApp("Telegram");