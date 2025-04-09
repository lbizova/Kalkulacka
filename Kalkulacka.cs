using System;

public class Kalkulacka
{
    public double Secti(double a, double b)
    {
        return a + b;
    }

    public double Odecitani(double a, double b)
    {
        return a - b;
    }
public double Nasobeni(double a, double b)
{
    return a * b;
}

public double Deleni(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Chyba: nelze dělit nulou.");
        return double.NaN; // nebo můžeš vyhodit výjimku
    }
    return a / b;
}
    // Později můžeme přidat třeba Mocniny atd.
}
