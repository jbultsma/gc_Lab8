using System;
using System.Collections.Generic;
using System.Linq;

// Lab 9 - Refactored Lab 8
namespace gc_Lab8
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool isRunAgain = false;

            do
            {
                GetStudent();

                Console.Write("Would you like to learn about another student? (y/n): ");                
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "y")
                {
                    isRunAgain = true;
                }

                else { isRunAgain = false; }
            }
            while (isRunAgain == true);
            
        }            

        static void GetStudent()
        {
            Student s0 = new Student("Joshua", "Grand Rapids, MI", "Cheese Tortellini", "The Black Key's");
            Student s1 = new Student("Dakota", "Kent City, MI", "Pho", "Led Zeppelin");
            Student s2 = new Student("Tommy", "Raleigh, NC", "Indian Style Chicken Curry", "Tom Petty");
            Student s3 = new Student("James", "Grand Rapids, MI", "Cheeseburgers", "Shania Twain");
            Student s4 = new Student("Maricela", "Morelia, Mexcio", "Tacos","Young the Giant");
            Student s5 = new Student("KimVy", "Grand Rapids, MI", "Sushi", "A Tribe Called Quest");
            Student s6 = new Student("Sam", "Grand Rapids, MI", "Tacos", "Cher");
            Student s7 = new Student("Cody", "Lawton, MI", "Potato Soup", "The Strokes");
            Student s8 = new Student("Flakamahmuti", "Pristina, Kosovo", "Thai", "Dua Lipa");
            Student s9 = new Student("Mahruchirhee", "Teaneck, NJ", "Chicken Wings", "NWA");
            Student s10 = new Student("Manik", "Cox'sBazar, Bangladesh", "Spicy Beef Curry", "Lady Gaga");
            Student s11 = new Student("Moise", "Grand Rapids, MI", "Lasagna", "Kelly Clarkson");
            Student s12 = new Student("Liz", "Planet Earth, The Solar System", "Smoked Salmon", "The Wonder Years");
            Student s13 = new Student("Jason", "Holland, MI", "Burgers", "Kanye");
            Student s14 = new Student("Robert", "Detroit, MI", "Burgers", "Lynyrd Skynyrd");

            List<Student> students = new List<Student>();
            students.Add(s0);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            students.Add(s11);
            students.Add(s12);
            students.Add(s13);
            students.Add(s14);

            students = students.OrderBy(x => x.Name).ToList();

            Console.Write("Welcome to our C# class. Which student would you like to learn about today? (enter a number between 0-14): ");
            
            int pick = 0;

            try
            {
                string input = Console.ReadLine();
                pick = int.Parse(input);
            }

            catch (FormatException e)
            {
                Console.WriteLine("A valid input was not given");
            }
            
            Student s;
            try
            {
                s = students[pick];
            }

            catch (IndexOutOfRangeException c)
            {
                Console.WriteLine("Incorrect input, i'm assuming you want the person at index 0");
                s = students[0];
            }
                
            string name = s.GetName();
            string home = s.GetHometown();
            string food = s.GetFood();
            string band = s.GetBand();

            Console.WriteLine();
            Console.WriteLine("That student is " + name + ". \nWhat would like to learn about them? \n\nEnter 1 for hometown, 2 for favorite food, or 3 for favorite band.");
            Console.WriteLine();

            int choice;
            string decision = Console.ReadLine().ToLower().Trim();
            int.TryParse(decision, out choice);

            if (choice == 1)
            {
                Console.WriteLine(name + "'s Hometown is: " + home);
            }

            else if (choice == 2)
            {
                Console.WriteLine(name + "'s Favorite food is: " + food);
            }

            else if (choice == 3)
            {
                Console.WriteLine(name + "'s Favorite Band is: " + band);
            }

            else { Console.WriteLine("invalid input"); }

            bool isContinue = false;

            Console.Write("\nWould you like to know more? (y/n): ");
            string response = Console.ReadLine();

            if (response == "y")
            {
                isContinue = true;
            }

            else
            {
                isContinue = false;
            }

            if (isContinue == true)
            {
                do
                {
                    Console.WriteLine("What would you like to learn about " + name + " now?");

                    int choiceTwo;
                    string decisionTwo = Console.ReadLine().ToLower().Trim();
                    int.TryParse(decisionTwo, out choiceTwo);

                    if (choiceTwo == 1)
                    {
                        Console.WriteLine(name + "'s Hometown is: " + home);
                    }

                    else if (choiceTwo == 2)
                    {
                        Console.WriteLine(name + "'s Favorite food is: " + food);
                    }

                    else if (choiceTwo == 3)
                    {
                        Console.WriteLine(name + "'s Favorite band is: " + band);
                    }

                    else { Console.WriteLine("Invalid input please try again"); }

                    Console.Write("\nWould you like to know more? (y/n): ");
                    string response1 = Console.ReadLine();

                    if (response1 == "y")
                    {
                        isContinue = true;
                    }

                    else if (response1 == " ")
                    {
                        Console.WriteLine("Invalid input, please try again");
                        
                    }

                    else
                    {
                        isContinue = false;
                    }
                }
                while (isContinue == true);
            }
        }
    }
}
