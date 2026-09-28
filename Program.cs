using System.Runtime.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Skapa en konsolapplikation som genererar och visar multiplikationstabellen
        //för ett givet tal. Användaren matar in ett tal och programmet skriver ut
        //multiplikationstabellen för det numret från 1 till 10.
        //Instruktioner:
        //• Be användaren att ange ett nummer.
        //• Använd en for-loop för att iterera från 1 till 10.
        //• Inuti loop, multiplicera inmatningstalet med det aktuella iterationsvärdet
        //(loopvariabel).
        //• Skriv ut varje rad i multiplikationstabellen i formatet :
        //[input number] x [current number] = result
            Console.WriteLine("Skriv ett nummer");
            int InputNummer = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($" {InputNummer} x {i} = {InputNummer * i}");
            }
        }
    }
}
