using System;
using System.Collections.Generic;

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

                Console.Write("Would you like to learn about another student? (y/n): " );
                string answer = Console.ReadLine();

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
            Student s0 = new Student("Joshua", "Grand Rapids, MI", "Cheese Tortellini");
            Student s1 = new Student("Dakota", "Kent City, MI", "Pho");
            Student s2 = new Student("Tommy", "Raleigh, NC", "Indian Style Chicken Curry");
            Student s3 = new Student("James", "Grand Rapids, MI", "Cheeseburgers");
            Student s4 = new Student("Maricela", "Morelia, Mexcio", "Tacos");
            Student s5 = new Student("KimVy", "Grand Rapids, MI", "Sushi");
            Student s6 = new Student("Sam", "Grand Rapids, MI", "Tacos");
            Student s7 = new Student("Cody", "Lawton, MI", "Potato Soup");
            Student s8 = new Student("Flakamahmuti", "Pristina, Kosovo", "Thai");
            Student s9 = new Student("Mahruchirhee", "Teaneck, NJ", "Chicken Wings");
            Student s10 = new Student("Manik", "Cox'sBazar, Bangladesh", "Spicy Beef Curry");
            Student s11 = new Student("Moise", "Grand Rapids, MI", "Lasagna");
            Student s12 = new Student("Liz", "Planet Earth, The Solar System", "Smoked Salmon");
            Student s13 = new Student("Jason", "Holland, MI", "Burgers");
            Student s14 = new Student("Robert", "Detroit, MI", "Burgers");

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

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn about today? (enter a number between 0-14)");

                int pick = 0;

                try
                {
                    Console.WriteLine();
                    string input = Console.ReadLine();
                    pick = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("A valid input was not given");
                }

                Student s = students[pick];
                string name = s.GetName();
                string home = s.GetHometown();
                string food = s.GetFood();

                Console.WriteLine();
                Console.WriteLine("That student is " + name + ". What would like to learn about them? \n\nEnter 1 for hometown, or 2 for favorite food.");
                Console.WriteLine();

                int choice;
                string decision = Console.ReadLine();
                int.TryParse(decision, out choice);

                if (choice == 1)
                {
                    Console.WriteLine(name + "'s Hometown is: " + home);
                }

                else if (choice == 2)
                {
                    Console.WriteLine(name + "'s Favorite food is: " + food);
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

                while (isContinue == true)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine(name + "'s Favorite food is: " + food);
                    }

                    else if (choice == 2)
                    {
                        Console.WriteLine(name + "'s Hometown is: " + home);
                    }
                    break;
                }
            
        }
    }
}
