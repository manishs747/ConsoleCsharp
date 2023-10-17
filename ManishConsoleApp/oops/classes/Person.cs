using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.oops.classes
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
     
    }

    //classes - reference types
    public class Employee : IPerson
    {




        public static void Main()
        {
            Employee e = new Employee("Matt", "Milner", 75)
            {
                StartDate = new DateOnly(2021, 1, 15)
            };

            Console.WriteLine($"From {e.FirstName}  id {e.Id}, hello world");
        }

        public Employee()
        {
            Id = 5;
        }

        public Employee(string firstName, string lastName,
            int empId = 0)
        {
            LastName = lastName;
            FirstName = firstName;
            EmployeeId = empId;
            ShiftStartTime = TimeOnly.MaxValue;
        }
        public string LastName { get; set; }
        public int Id { get; set; }
       
        public string FirstName { get; set; }

        //employee properties
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get;private set; } //CancellationToken be set from within class only
        public TimeOnly ShiftStartTime { get; init; } // can be set only during initialization
    }

    public class Manager : Employee, IPerson
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        { }
        public int NumberOfDirectReports { get; set; }
    }
}
