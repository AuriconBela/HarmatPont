using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Harmatpont számológép");
        Console.WriteLine("=====================");
        Console.WriteLine();

        bool folytat = true;
        
        while (folytat)
        {
            // Hőmérséklet bekérése
            double homerseklet = HomersekletBekeres();

            // Páratartalom bekérése
            double paratartalom = ParatartalomBekeres();

            // Harmatpont számítása
            double harmatpont = Harmatpont(homerseklet, paratartalom);

            // Eredmény kiírása
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"A harmatpont {harmatpont:F2} °C");
            Console.ResetColor();
            Console.WriteLine();
            
            // Újabb számítás kérdése
            folytat = UjabbSzamitas();
            
            if (folytat)
            {
                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");

        try
        {
            Console.ReadKey();
        }
        catch (InvalidOperationException)
        {
            // Ha a konzol bemenet átirányított, akkor ne várjunk billentyűnyomásra
        }
    }

    static double HomersekletBekeres()
    {
        while (true)
        {
            Console.Write("Adja meg a levegő hőmérsékletét (°C): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();
            if (!string.IsNullOrWhiteSpace(input) &&
                double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double homerseklet))
            {
                return homerseklet;
            }

            Console.WriteLine("Hibás formátum! Kérem adjon meg egy érvényes számot.");
        }
    }

    static double ParatartalomBekeres()
    {
        while (true)
        {
            Console.Write("Adja meg a relatív páratartalmat (%): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();
            if (!string.IsNullOrWhiteSpace(input) &&
                double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double paratartalom))
            {
                if (paratartalom > 0 && paratartalom <= 100)
                {
                    return paratartalom;
                }
                else
                {
                    Console.WriteLine("A páratartalom értéke 0 és 100 között kell legyen!");
                }
            }
            else
            {
                Console.WriteLine("Hibás formátum! Kérem adjon meg egy érvényes számot.");
            }
        }
    }

    static double Harmatpont(double homerseklet, double paratartalom)
    {
        const double a = 17.62;
        const double b = 243.12;

        var alpha = ((a * homerseklet) / (b + homerseklet)) + Math.Log(paratartalom / 100.0);
        return (b * alpha) / (a - alpha);
    }

    static bool UjabbSzamitas()
    {
        while (true)
        {
            Console.Write("Szeretne újabb számítást végezni? (i/n): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                string valasz = input.Trim().ToLower();
                if (valasz == "i" || valasz == "igen")
                {
                    return true;
                }
                else if (valasz == "n" || valasz == "nem")
                {
                    return false;
                }
            }
            
            Console.WriteLine("Kérem válaszoljon 'i' (igen) vagy 'n' (nem) betűvel!");
        }
    }
}
