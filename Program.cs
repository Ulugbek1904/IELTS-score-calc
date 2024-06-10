using System;

namespace IELTSscoreCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                try
                {
                    Console.WriteLine("\t\t\tWelcome to IELTS score calculator");
                    Console.WriteLine("Fill in the following accordingly");

                    Console.Write("Enter Listening Score: ");
                    double Listening = double.Parse(Console.ReadLine());
                    Console.WriteLine("Converting . . . \n");

                    Console.Write("Enter Reading Score: ");
                    double Reading = double.Parse(Console.ReadLine());
                    Console.WriteLine("Converting . . . \n");

                    Console.Write("Enter Speaking Score: ");
                    double Speaking = double.Parse(Console.ReadLine());
                    Console.WriteLine("Converting . . . \n");

                    Console.Write("Enter Writing Score: ");
                    double Writing = double.Parse(Console.ReadLine());
                    Console.WriteLine("Converting . . . \n");

                    double overAll = OverAll(Listening, Reading, Speaking, Writing);

                    Console.Write(overAll + " - ");
                    // Determine the user's category based on the overall score
                    switch (overAll)
                    {
                        case 9:
                            Console.WriteLine("Expert User");
                            break;
                        case 8.5:
                        case 8:
                            Console.WriteLine("Very Good");
                            break;
                        case 7.5:
                        case 7:
                            Console.WriteLine("Good");
                            break;
                        case 6.5:
                        case 6:
                            Console.WriteLine("Competent");
                            break;
                        case 5.5:
                        case 5:
                            Console.WriteLine("Modest");
                            break;
                        default:
                            Console.WriteLine("Below or above that range is Invalid");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter numeric values for scores. Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.WriteLine("Do you want to continue? Yes (y) / No (n)");
                string response = Console.ReadLine().ToLower();
                if (response != "yes" && response != "y")
                {
                    continueProgram = false;
                }
            }
        }

        // Method to calculate the overall score
        public static double OverAll(double l, double r, double w, double s)
        {
            if (l > 9 || l < 0 || s > 9 || s < 0 || r > 9 || r < 0 || w > 9 || w < 0 )
            {
                throw new Exception("your input must be in range from 9 to 0.5");
            }
            else
            {
                double overAll = (l + r + s + w) / 4.0;

                // Rounding to the nearest half-band
                double roundedScore = Math.Round(overAll * 2, MidpointRounding.AwayFromZero) / 2;

                return roundedScore;
            }
            
        }
    }

}
