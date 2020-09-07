using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_new
{
    class Program
    {
        public static float side = 0;
        public static string color;
        static void Main(string[] args)
        {
            //Nu kan du teste dit objekt. Opret et Square objekt i din main metode – du bestemmer selv hvor ”stor” a skal være. Herefter, 
            //implementer en metode der ligner den du lavede i trin 4, men denne metode skal beregne arealet på dit kvadrat. Herefter lav flere objekter
            Console.WriteLine("What is the measure of the side ? ");
            Console.WriteLine("what is the color of the square ?");
            try
            {
                side = float.Parse(Console.ReadLine()); //convert string to float.
                color = Console.ReadLine(); 
            }
            catch (Exception)
            {

                Console.WriteLine("You did not type a number");
            }
            CalcSide();
            CalcArea();
            Console.WriteLine($"The perimeter er {CalcSide()}"); //conventerer selv fra string fil tal 
            Console.WriteLine($"The area is {CalcArea()}"); //conventerer selv fra string fil tal 
            Console.WriteLine($"The cubic meter is {CalcCubic()}");  //conventerer selv fra string fil tal
            Console.WriteLine($"The color is {Color()}"); //laver en mere property.
            Console.ReadKey();
        }
        //laver en metode
        //Prøv at kalde metoden som du oprettede i trin 4 og udskriv resultatet til konsollen.
        public static float CalcSide() 
        {
            return side * 4;
        }
        
        public static float CalcArea()
        {
            return side * side;
        }

        public static float CalcCubic()
        {
            return side * 3;
        }

        public static string Color()
        {
            return color;
        }
    }
}
