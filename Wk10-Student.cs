using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgram//inheritance 
{
    class Student//no static void .DLL
    {
        //private variables-fields to store the data for the class

        private int idNumber;//need create a public property to have access to this variable
        private string firstName;//refractor, encapsulate field
        // Public property - to give access to the private variables
        private double testScore;//refractor...

        public double TestScore
        {
            get { return testScore; } //get and set = read and write
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
        //public property - to give access to the private variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int IdNumber // this is a property;ie background color, put in UpperCase, blue word is a reserve
        {
            get { return idNumber; }//to access idNumber
            set { idNumber = value; }

        }

        // Automatic property - private variables are system generated
        public string LastName { get; set; }//auto property does the same as top 3 lines, this is how its done in visual studio!!

        public string Grade//get = returns a value, Read-only property (no "set" method)
        {
            get { return GetGrade(); }
        }
        
		//this a method
        public void DisplayStudentType()
        {
            Console.WriteLine("I am a student");//void because it has no value
        }

        //private method = not accessible outside the class
        private string GetGrade()
        {//this is a method
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
            Console.WriteLine("This is the value from a static method");// a member is either static or nonstatic
        }
    }
}
