using System;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestProfessorConstructors();
            TestProfessorToString();
            TestProfessorPropertyGetters();
            TestProfessorPropertySetters();
        }

        static void TestProfessorConstructors()
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor("L12345678", "Tony", "White", "English");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting: L12345678, Tony, White, English " + p2.ToString());
            Console.WriteLine();
        }

        static void TestProfessorToString()
        {
            Professor p1 = new Professor("L12345678", "Tony", "White", "English");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting: L12345678, Tony, White, English " + p1.ToString());
            Console.WriteLine("Expecting: L12345678, Tony, White, English  " + p1);
            Console.WriteLine();
        }

        static void TestProfessorPropertyGetters()
        {
            Professor p1 = new Professor("L12345678", "Tony", "White", "English");

            Console.WriteLine("Testing getters");
            Console.WriteLine("Lnumber.  Expecting L12345678. " + p1.LNumber);
            Console.WriteLine("First name.  Expecting Tony. " + p1.FirstName);
            Console.WriteLine("Last name.  Expecting White. " + p1.LastName);
            Console.WriteLine("Department.  Expecting English. " + p1.Department);
            Console.WriteLine();
        }

        static void TestProfessorPropertySetters()
        {
            Professor p1 = new Professor("L12345678", "Tony", "White", "English");

            Console.WriteLine("Testing setters");
            p1.LNumber = "L87654321";
            p1.FirstName = "Quentin";
            p1.LastName = "Jackson";
            p1.Department = "Computer Science";

            Console.WriteLine("Expecting L87654321, Quentin, Jackson, Computer Science" + p1);
            Console.WriteLine();
        }

    }
}