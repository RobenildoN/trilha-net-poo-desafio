using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone iphone = new Iphone("99999-9999", "iPhone 14", "123456789012345", 128);
        Smartphone nokia = new Nokia("88888-8888", "Nokia Tijolão", "987654321098765", 32);

        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine();

        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}
