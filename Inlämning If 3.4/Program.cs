using System;
using System.ComponentModel.Design;
namespace inlämning3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är låten du vill spela? (svara endast med en siffra)");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekudner ytterliggare är låten? (svara endast med en siffra)");
            int sekunder = int.Parse(Console.ReadLine());

            if (minuter * 60 + sekunder < 165)
            {
                Console.WriteLine("Låten är för kort för att spelas på radion.");
            }
            else if (minuter * 60 + sekunder > 165 && minuter * 60 + sekunder < 260)
            {
                Console.WriteLine("Låten är perfekt för radion");
            }
            else
            {
                Console.WriteLine("Låten är för lång för att spelas på radion.");
            }
        }
    }
}
