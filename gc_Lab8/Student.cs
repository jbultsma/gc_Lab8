using System;
using System.Collections.Generic;
using System.Text;

namespace gc_Lab8
{
    class Student
    {
        public string Name;
        public string Hometown;
        public string Food;

        public Student(string name, string homeTown, string favoriteFood)
        {
            Name = name;
            Hometown = homeTown;
            Food = favoriteFood;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHometown()
        {
            return Hometown;
        }

        public string GetFood()
        {
            return Food;
        }
    }
}
