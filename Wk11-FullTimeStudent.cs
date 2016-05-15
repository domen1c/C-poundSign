using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgramming
{
    class FullTimeStudent : Student
    {
        // Extending the class by adding another property
        public string EyeColor { get; set; }

        // Polymorphism
        // This hides the implementation of the method in the base class
        public new void DisplayStudentType()
        {
            base.DisplayStudentType();  // This accesses the method in the base class
            Console.WriteLine("I am a FULLTIME student");
        }
    }
}
