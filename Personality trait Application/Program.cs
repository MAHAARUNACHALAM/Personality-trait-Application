using System;
using System.Globalization;

namespace PersonalityTraitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration 1 - Be a Mentalist
            Console.WriteLine("Answer the following questions to find out your personality type:");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("Your Favorite number(1-100) ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("Do you prefer the mountains or the beach? ");
            string preference = Console.ReadLine();

            string personalityType = "";

            if (num < 30)
            {
                if (color.ToLower() == "yellow")
                {
                    personalityType = "Young and charming";
                }
                else
                {
                    personalityType = "Young human being";
                }

            }
            else if (num >= 30 && num <= 60)
            {
                if (color.ToLower() == "yellow")
                {
                    personalityType = "Caring and Lovely";
                }
                else
                {
                    personalityType = "Normal human being";
                }
            }
            else
            {
                personalityType = "Loving";
            }

            Console.WriteLine($"Dear {name}, based on your answers, your personality type is {personalityType}.");

            // Iteration 2 - Mimic Ptolemy
            Console.WriteLine("Please enter your birth month (1-12):");
            int birthMonth = int.Parse(Console.ReadLine());

            // Choose an appropriate partner based on the user's birth month and day
            string partner = "";
            switch (birthMonth)
            {
                case 1:
                    partner = "Dog like character";
                    break;
                case 2:
                    partner = "cat like character";
                    break;
                case 3:
                    partner = "Robotic person";
                    break;
                case 4:
                    partner = "Non Romantic";
                    break;
                case 5:
                    partner = "Great person";
                    break;
                case 6:
                    partner = "Wont get married";
                    break;
                case 7:
                    partner = "Waste Person";
                    break;
                case 8:
                    partner = "BrainLess perosn";
                    break;
                case 9:
                    partner = "Poor Guy to marry a person like you";
                    break;
                case 10:
                    partner = "Wont get married";
                    break;
                case 11:
                    partner = "Single forever";
                    break;
                case 12:
                    partner = "Wont get married";
                    break;
                default:
                    partner = "Wont get married";
                    break;
            }
            Console.WriteLine($"\nYour Partner is{partner}");
/*
            //Iteration 3 Calender man Date Parse error

            Console.WriteLine("Enter your birthdate (MM/DD/YYYY): ");
            string birthdate = Console.ReadLine();

            DateTime birthDateObj = DateTime.ParseExact(birthdate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            int age = today.Year - birthDateObj.Year;
//            if (birthDateObj > today.AddYears(-age))
  //              age--;

            Console.WriteLine($"Your age is: {age}");

            int daysUntilBirthday = (birthDateObj.AddYears(age + 1) - today).Days;

            if (daysUntilBirthday == 0)
            {
                Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                Console.WriteLine($"Your birthday is in {daysUntilBirthday} days.");
            }*/
        }
    }
    
}
