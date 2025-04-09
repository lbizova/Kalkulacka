using System;

class Program
{
    static void Main(string[] args)
    {
        Kalkulacka kalk = new Kalkulacka();

        Console.WriteLine("Zadej první číslo:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Zadej druhé číslo:");
        double b = Convert.ToDouble(Console.ReadLine());

        double soucet = kalk.Secti(a, b);
        double rozdil = kalk.Odecitani(a, b);
        double soucin = kalk.Nasobeni(a, b);
        double podil = kalk.Deleni(a, b);

        Console.WriteLine($"Součet: {soucet}");
        Console.WriteLine($"Rozdíl: {rozdil}"); 
        Console.WriteLine($"Součin: {soucin}");
        Console.WriteLine($"Podíl: {podil}");
    }
}
