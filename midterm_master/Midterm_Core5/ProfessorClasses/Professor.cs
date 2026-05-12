using System;
using System;


/* Assume that you've been asked to write a series of programs for a community college.
 * One of the "components" in the college's system is a Professor. 
 * A Professor has an Lnumber, a first name, a last name and a department.

Design a class that represents a Professor. 
Document your class by creating a class diagram in Visio or Visual Studio or by listing the name of the class, 
the attributes or characteristics of the class and the methods of behaviors of the class. 
Don't forget things like getters and setters (and reasonable error handling in at least one of the setters) or properties, constructors and ToString.

Implement the class in C#. 

Test the class in a C# console application.
*/
namespace ProfessorClasses
{
    public class Professor
    {
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;


        public Professor() { }

        public Professor(string lNum, string fName, string lName, string location)
        {
            lNumber = lNum;
            firstName = fName;
            lastName = lName;
            department = location;

        }

        public string LNumber
        {
            get
            {
                return lNumber;
            }
            set
            {
                lNumber = value;

            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public override string ToString()
        {
            return String.Format("LNumber: {0} FirstName: {1} LastName: {2} Department: {3}", lNumber, firstName, lastName, department);
        }
    }
}



