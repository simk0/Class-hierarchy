using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_hierarchy
{
        public class Person
        {

            private string name;
            private int age;


            //конструктор
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 0)
                    {
                        this.age = 0;
                    }
                    else
                    {
                        this.age = value;
                    }
                }
            }

            public virtual void Speak()
            {
                Console.WriteLine("\nHi, i'm *Person*:" + Name);
            }

            public virtual void Action()
            {
                Console.WriteLine("Person: Took a book from the shelf");
            }
            public virtual void Info()
            {
                Console.WriteLine("Name:" + Name + "\n" + "Age:" + Age + " years old" + "\n");
            }
            ~Person()
            {
                Console.WriteLine("Person object is destroyed");
            }


        }
    
}