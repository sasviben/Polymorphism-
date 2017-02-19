using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Primjer polimorfizma

namespace Polymorphism
{
     class Employee
    {
         public string firstName = "FirstName";
         public string lastName = "LastName";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " -Full Time");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " -Part Time");
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[3];
            e[0] = new Employee();
            e[1] = new FullTimeEmployee();
            e[2] = new PartTimeEmployee();
            
            foreach(Employee em in e)
            {
                em.PrintFullName();
            }
        }
    }
}
/*
    Polimorfizam omogućava poziv metode izvedene klase koriteci referencu bazne klase u runtime-u.
    Metoda u baznoj klasi mora biti virtualna, a meotda u izvedenoj klasi override-a metodu iz bazne klase

*/