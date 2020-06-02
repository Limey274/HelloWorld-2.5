using System;

namespace HelloWorld_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // greeting
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine();

            //rectangle
            double length, width, area;
            Console.WriteLine("Enter length of rectangle : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter width of rectangle : ");
            width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            Console.WriteLine();
            Console.WriteLine("Area of rectangle: " + area);
            Console.WriteLine();

            //MPG finder
            double miles, gallons, MPG;
            Console.WriteLine("Enter miles driven : ");
            miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter gallons used : ");
            gallons = Convert.ToDouble(Console.ReadLine());
            MPG = miles/gallons;
            Console.WriteLine();
            Console.WriteLine("Your miles per gallons are: " + MPG);
            Console.WriteLine();

            //string manipulation
            Console.WriteLine("Choose a word below to remove from the sentence... ");
            Console.WriteLine();
            
            string wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            
            Console.WriteLine(wonderland);
            string input = Console.ReadLine();
            int strInd =  wonderland.IndexOf(input);
           
                if (wonderland.IndexOf(input) != -1)
                {
                Console.WriteLine();   
                //Console.WriteLine("true");

                string beforeChange= wonderland.Substring(0, strInd);
                string afterChange = wonderland.Substring(strInd + input.Length);
                Console.WriteLine(beforeChange + afterChange);
                }
              


        }
    }
}
