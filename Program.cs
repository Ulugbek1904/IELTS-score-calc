using System;

namespace IELTSscoreCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("\t\t\t Welcome to IELTS score calculator");

            System.Console.WriteLine("Fill in the following accordingly");

            System.Console.Write("Enter Listening Score :");
            double Listening = double.Parse(Console.ReadLine());

            System.Console.Write("Enter Reading Score :");
            double Reading = double.Parse(Console.ReadLine());

            System.Console.Write("Enter Speaking Score :");
            double Speaking = double.Parse(Console.ReadLine());

            System.Console.Write("Enter Writing Score :");
            double Writing = double.Parse(Console.ReadLine());

            double overAll = OverAll(Listening,Reading,Speaking,Writing);

            System.Console.Write(overAll + " - ");   
            // Candidate ning overAll idan uning qanday user ekanlligini aniqlash
            switch (overAll)
            {
                case 9: 
                    System.Console.WriteLine("ExpertUser");
                    break;
                case 8: 
                    System.Console.WriteLine("Very Good");
                    break;
                case 8.5: 
                    System.Console.WriteLine("Very Good");
                    break;
                case 7.5: 
                    System.Console.WriteLine("Good");
                    break;
                case 7: 
                    System.Console.WriteLine("Good");
                    break;
                case 6.5: 
                    System.Console.WriteLine("Competent");
                    break;
                case 6: 
                    System.Console.WriteLine("Competent");
                    break;
                case 5.5: 
                    System.Console.WriteLine("Modest");
                    break;
                case 5: 
                    System.Console.WriteLine("Modest");
                    break;
                default:
                    System.Console.WriteLine("Below or above that range is Invalid");
                    break;
            }         
        }
        // overAll ni hisoblab beruvchi Method
        public static double OverAll(double l, double r, double w, double s)
        {
            double overAll = (l + r + s + w) /  4.0;

            // 2 ga ko'paytirganimiz bu .25 va .75 larni to'g'ri hisoblash ya'ni ularni 0.5 ga tenglashdir.
            double roundedScore = Math.Round(overAll * 2,MidpointRounding.AwayFromZero) / 2;

            return roundedScore;
        }
    }
}
