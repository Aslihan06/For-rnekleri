using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        // 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        Console.WriteLine(); // Boşluk ekleyelim

        // 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(); // Boşluk ekleyelim

        // 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(); // Boşluk ekleyelim

        // 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int toplam = 0;
        for (int i = 50; i <= 150; i++)
        {
            toplam += i;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

        Console.WriteLine(); // Boşluk ekleyelim

        // 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplam += i;
            }
            else
            {
                tekToplam += i;
            }
        }
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
    }
}
