// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

bool is_valid(string input, string soustava)
{
    return false;
}


{
    Console.WriteLine("Ahoj!Vás vitá převaděč");
    while (true)
    {
        string[] soustavy = { "2", "8", "16" };
        Console.Write("zadej cislo soustavy: ");
        string soustava = Console.ReadLine();

        if (!soustavy.Contains(soustava))
        {
            // spatna soustava
            Console.WriteLine("Spatna soustava");
            break;
        }

        Console.Write("zadej hodnotu soustavy: ");
        string hodnota = Console.ReadLine();


        try
        {
            Console.WriteLine("vložene číslo {0} v {1} soustavě = {2} desítkově", hodnota, soustava,( Convert.ToInt64(hodnota, Int32.Parse(soustava))));
        }
        catch
        {
            //  spatna hodnota
            Console.WriteLine("Spatna hodnota");
            break;
        }
    }  
}
