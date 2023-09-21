using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma instância de Nokia
            var nokia = new Nokia(numero:"12345", modelo: "Nokia 3310", imei: "123456789", memoria: 16);

            // Criar uma instância de Iphone
            var iphone = new Iphone(numero:"67890", modelo:"iPhone 12", imei:"987654321", memoria: 128);                      

            // Realizar ações com os smartphones
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");
            Console.WriteLine("*****************************");
            Console.WriteLine("\n");

            iphone.Ligar(); 
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadKey();
        }
    }
}