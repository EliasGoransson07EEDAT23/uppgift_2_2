using System;
namespace uppgift_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej längdhoppsdomaren. Jag har en fråga. Jag vill veta hur långt Elin och Alma hoppade förra tävlingen.");
            Console.WriteLine("Börja med att skriva Elins längd i meter här nedan;");
            float elin = float.Parse(Console.ReadLine());
            Console.WriteLine("Okej, tack. Skriv nu Almas längd i meter här nedan;");
            float alma = float.Parse(Console.ReadLine());
            float minus = elin - alma;
            Console.WriteLine("Okej, det betyder att Elin har hoppat " + minus + " meter längre än Alma!");
            Console.ReadKey();
        }
    }
}