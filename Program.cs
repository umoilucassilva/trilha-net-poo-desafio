using DesafioPOO.Models;

// TODO: Testes feitos
Iphone iphone = new Iphone(numero: "12345", modelo: "modelo1", imei: "1111111", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("/n");

Nokia nokia = new Nokia(numero: "6789", modelo: "modelo2", imei: "22222222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Youtube");