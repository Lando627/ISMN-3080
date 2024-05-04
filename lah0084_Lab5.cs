//Landon Holloway (lah0084)
//ISMN 3080 Fall 2023 Lab 5

using system;

namespace payCalc
{
    class labFive
    {
        const int baseHours = 40;
        const double OT_Multi = 1.5;

        static void Main(string[] args)
        {
            const int numEmployees = 5;

            int[] hoursWorked = new int[5];
            double[] payRate = new double[5];
            int[] grossPay = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Employee {i + 1}, enter hours worked:");
                hoursWorked[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Employee {i + 1}, enter hourly pay rate:");
                payRate[i] = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Employee {i + 1}:");

                if (hoursWorked[i] > baseHours)
                {
                    calGrossWithOT(hoursWorked[i], payRate[i], OT_Multi);
                }

                else
                {
                    calGrossWithoutOT(hoursWorked[i], payRate[i]);
                }

            }

        }

        static void calGrossWithOT(int hoursWorked, double payRate, double OT_Multi)
        {
            double OTHrs = hoursWorked - baseHours;
            double OTPay = OTHrs * payRate * OT_Multi;
            double pay = baseHours * payRate + OTPay;
            Console.WriteLine($"Gross Pay with OT: {Math.Round(pay, 2)}");


        }

        static void calGrossWithoutOT(int hoursWorked, double payRate)
        {
            double pay = hoursWorked * payRate;
            Console.WriteLine($"Gross pay is: ${Math.Round(pay, 2)}");

        }

    }

}