using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_hierarchy
{
    internal class Engineer : Employee
    {
        private int work_experience;
        private string work_enviroment;

        public Engineer(int age, int id, string name, string education, int work_experience, string work_enviroment)
            : base(age, name, id, education)
        {
            this.work_experience = work_experience;
            this.work_enviroment = work_enviroment;
        }

        public int WorkExperience
        {
            get { return work_experience; }
            set { work_experience = value; }
        }
        public string WorkEnviroment
        {
            get { return work_enviroment; }
            set { work_enviroment = value; }
        }
        override public void Speak()
        {
            Console.WriteLine("\nHi, i'm *Engineer*:" + Name);
        }
        override public void Action()
        {
            Console.WriteLine("Engineer: Draws a drawing");
        }
        public override void Info()
        {
            Console.WriteLine("Name:" + Name + "\n" + "Age:" + Age + " years old" + "\n" + "Id:" + Id + "\n" + "Education:" + Education + "\n"
                + "Work Experience:" + work_experience + " years" + "\n" + "Work Enviroment:" + work_enviroment + "\n");
        }
        ~Engineer()
        {
            Console.WriteLine("Person object is destroyed");
        }
    }
}
