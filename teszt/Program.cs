using System;

class Program
{
    static void Main()
    {
        // Kérjük be a felhasználótól két számot
        Console.Write("Kérem, adjon meg egy számot: ");
        double szam1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adjon meg még egy számot: ");
        double szam2 = Convert.ToDouble(Console.ReadLine());

        // Ellenőrizzük, hogy az első szám osztója-e a másodiknak
        if (szam2 != 0 && szam1 % szam2 == 0)
        {
            Console.WriteLine($"{szam1} osztója {szam2}-nek.");
            Console.WriteLine($"Az osztás eredménye: {szam1 / szam2}");
        }
        else
        {
            Console.WriteLine($"{szam1} nem osztója {szam2}-nek, vagy {szam2} értéke 0.");
        }

        Console.ReadKey();
    }
}
