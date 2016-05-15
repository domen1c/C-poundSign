using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Student
    {
        // Private variables (fields) to store the data for the class
        private int idNumber;
        private string firstName;
        private double testScore;

        public double TestScore
        {
            get { return testScore; }
            set
            {
                if (value < 0)
                    testScore = 0;
                else if (value > 100)
                    testScore = 100;
                else
                    testScore = value;
            }
        }

        // Public property - to give access to the private variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        // Automatic property - private variables are system generated
        public string LastName { get; set; }

        // Read-only property (no "set" method)
        public string Grade
        {
            get { return GetGrade(); }
        }

        public void DisplayStudentType()
        {
            Console.WriteLine("I am a student");
        }

        // Not accessible outside the class
        private string GetGrade()
        {
            string grade;

            if (testScore < 60)
                grade = "F";
            else if (testScore < 70)
                grade = "D";
            else if (testScore < 80)
                grade = "C";
            else if (testScore < 90)
                grade = "B";
            else
                grade = "A";

            return grade;
        }

        public static void DisplayStaticValue()
        {
            Console.WriteLine("This is the  value from a static method");
        }
    }
}
