using System;

class Program
{
    static void Main(string[] args) //metoda Main je vstupní bod programu
    {
        Kalkulacka kalk = new Kalkulacka();
        
        //použití ověřování vstupů
        double a = ZadejCislo("Zadej první číslo:");
        double b = ZadejCislo("Zadej druhé číslo:");

        double soucet = kalk.Secti(a, b);
        double rozdil = kalk.Odecitani(a, b);
        double soucin = kalk.Nasobeni(a, b);
        double podil = kalk.Deleni(a, b);

        Console.WriteLine($"Součet: {soucet}");
        Console.WriteLine($"Rozdíl: {rozdil}"); 
        Console.WriteLine($"Součin: {soucin}");
        Console.WriteLine($"Podíl: {podil}");
    }
    static double ZadejCislo(string vyzva)// metoda pro zadání čísla a kontrolu vstupu
{
    double cislo;
    while (true)
    {
        Console.Write(vyzva + " ");
        string vstup = Console.ReadLine();

        if (double.TryParse(vstup, out cislo))
        {
            return cislo;
        }
        else
        {
            Console.WriteLine("Neplatné číslo, zkus to znovu.");
        }
    }
}
}
