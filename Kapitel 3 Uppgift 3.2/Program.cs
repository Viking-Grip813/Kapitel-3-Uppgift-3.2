using System;
namespace Uppgift3_2
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Hej! Har du gått ut gymnasiet?");
            Console.WriteLine("Svara J för ja och N för nej.");
            string J = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 22)
            {
                Console.WriteLine("Vi letar tyvär efter anna personal just nu.");
            }
            else
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            
        }
    }
}
