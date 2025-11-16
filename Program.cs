using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone Iphone = new Iphone(numero: "7890", modelo: "modelo 2", imei: "22222", memoria: 128);
Iphone.ReceberLigacao();
Nokia.InstalarAplicativo("Telegram");

