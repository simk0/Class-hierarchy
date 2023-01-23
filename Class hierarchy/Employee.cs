using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_hierarchy
{
    public class Employee : Person
    {
        private int id;
        private string education;


        public Employee(int age, string name, int id, string education) : base(name, age)
        {
            this.id = id;
            this.education = education;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        override public void Speak()
        {
            Console.WriteLine("\nHi, i'm *Employee*:" + Name);
        }
        override public void Action()
        {
            Console.WriteLine("Employee: Reading a magazine");
        }
        public override void Info()
        {
            Console.WriteLine("Name:" + Name + "\n" + "Age:" + Age + " years old" + "\n" + "Id:" + Id + "\n" + "Education:" + Education + "\n");
        }

        ~Employee()
        {
            Console.WriteLine("Person object is destroyed");
        }


    }
}
