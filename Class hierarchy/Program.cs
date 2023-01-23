using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///#########################################################################
            Console.WriteLine("###############################################################");
            Person person = new Person("Pavel", 18);
            person.Speak();
            person.Action();
            person.Info();
            Console.WriteLine("###############################################################");
            ///#########################################################################
            Employee employee = new Employee(20, "Robert", 0, "Bachelour");
            employee.Speak();
            employee.Action();
            employee.Info();
            Console.WriteLine("###############################################################");
            ///#########################################################################
            Engineer engineer = new Engineer(28, 1, "Mihaylo", "Bachelour", 5, "Construction");
            engineer.Speak();
            engineer.Action();
            engineer.Info();
            Console.WriteLine("###############################################################");
            ///#########################################################################
            Console.ReadKey();
        }
    }
}
