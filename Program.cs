using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "6569-5502", modelo:"NK-15", imei:"55555555", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4589-2525", modelo:"Iphone 14", imei:"8888888888", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

