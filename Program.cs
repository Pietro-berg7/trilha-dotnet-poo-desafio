using DesafioPOO.Models;
using System.Reflection;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "1", modelo: "Nokia", imei: "qwerty123", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Smartphone iphone = new Iphone(numero: "2", modelo: "Iphone", imei: "qwerty321", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");