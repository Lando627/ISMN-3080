// Landon Holloway (lah0084) 
// ISMN 3080 Fall 2023 PA2

using System; 

namespace footballTikcet
{
    class ticketCalculator
    {
        // Main argument that shows our cost of all classes of tickets, along with calculations for the totals of everything.
        // It also shows our program output with our Console.WriteLine statements. 

        static void Main(string[] args)
        {
            const int tickRateA = 20;
            const int tickRateB = 15;
            const int tickRateC = 8;

            int inA = getTickA(tickRateA);
            int inB = getTickB(tickRateB);
            int inC = getTickC(tickRateC); 
            int total = (inA + inB + inC);

            Console.WriteLine("The total cost of Class A tickets: $" + inA);
            Console.WriteLine("The total cost of Class B tickets: $" + inB);
            Console.WriteLine("The total cost of Class C tickets: $" + inC);
            Console.WriteLine("The total cost of all tickets: $" + total);


        }

        // This section takes user input for the amount of tickets sold for Class A, B, and C.
        // Each part takes user input and multiples it by ticket price to get our total costs for all ticket classes. 

        static int getTickA(int tickRateA)
        {
            Console.WriteLine("Enter the amount of Class A tickets sold: ");
            int inputA = Convert.ToInt16(Console.ReadLine());
            int inA = tickRateA * inputA;
            return inA;
            


        }

        static int getTickB(int tickRateB)
        {
            Console.WriteLine("Enter the amount of Class B tickets sold: ");
            int inputB = Convert.ToInt16(Console.ReadLine());
            int inB = tickRateB * inputB;
            return inB; 

        }

        static int getTickC(int tickRateC)
        {
            Console.WriteLine("Enter the amount of Class C tickets sold: ");
            int inputC = Convert.ToInt16(Console.ReadLine());
            int inC = tickRateC * inputC;
            return inC;

        }

    }

}    

