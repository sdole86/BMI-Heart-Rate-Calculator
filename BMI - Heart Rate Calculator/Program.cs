using System;

namespace BMI_and_Karvonen_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI and Karvonen Calculator");
            Console.WriteLine();
            Console.Write("Please enter your height in inches: ");
            string height = Console.ReadLine();
            Console.Write("Please enter your weight in pounds: ");
            string weight = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Please enter your resting heart rate: ");
            string rhr = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Results . . .");
            Console.WriteLine();


            double BMI = (Convert.ToDouble(weight)/2.205) / Math.Pow((Convert.ToDouble(height)/39.37),2);
            string categoryBMI = null;

            switch (BMI)
            {
                case double n when n >= 30:
                    categoryBMI = "Obese";
                    break;

                case double n when n >= 25:
                    categoryBMI = "Overweight";
                    break;

                case double n when n >= 18.5:
                    categoryBMI = "Normal weight";
                    break;

                case double n when n >= 0:
                    categoryBMI = "Underweight";
                    break;
            }

            Console.WriteLine("Your BMI is " + Math.Round(BMI, 2) + " -- " + categoryBMI);
            double tr = 50;
            double mhr, hrr, mtz, ttz;

            Console.WriteLine();
            Console.WriteLine("Exercise Intensity Heart Rates:");
            Console.WriteLine("Intensity       Max Heart Rate");
            Console.WriteLine();


            while (tr != 100)
            {
                ttz = (((220 - Convert.ToDouble(age)) - Convert.ToDouble(rhr)) * (tr / 100)) + Convert.ToDouble(rhr);
                Console.WriteLine(tr + "%     --     " + ttz);
                tr += 5;

            }
        }
    }
}
