using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 由基类Animal创建派生类Dog_Cat
{
    class Program
    {
        public class Animal
        {
            private bool m_sex;
            private int m_age;
            public bool Sex
            {
                get
                {
                    return m_sex;
                }
                set
                {
                    this.m_sex = value;
                }
            }
            public Animal()
            {
                Sex = false;
            }
            public int Age
            {
                get
                {
                    return m_age;
                }
                set
                {
                    this.m_age = value;
                }
            }
            public virtual string Introduce()
            {
                if (Sex == true)
                    return "This is a male Animal!";
                else
                    return "This is a female Animal!";
            }
        }
        public class Dog :Animal
        {
            public Dog ()
            {
                this.Sex = true;
            }
            public override string Introduce()
            {
                if (Sex == true)
                    return "This is a male Dog!";
                else
                    return "This is a female Dog!";
            }
        }
        public class Cat:Animal
        {
            public override string Introduce ()
            {
                if (Sex == true)
                    return "This is a male Cat!";
                else
                    return "This is a female Cat!";
            }
        }
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Console.WriteLine(ani.Introduce());
            Dog dog = new Dog();
            Console.WriteLine(dog.Introduce());
            Cat cat = new Cat();
            Console.WriteLine(cat.Introduce());
        }
    }
}
