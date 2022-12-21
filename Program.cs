using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_polimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            Person b = new Person();
            a.Name = "Ivo";
            a.Surename = "Ivić";
            a.Age = 13;
            b.Name = "Iva";
            b.Surename = "Ivić";
            b.Age = 14;
            if(string.Equals(a.Name, b.Name)==true && string.Equals(a.Surename, b.Surename)==true && string.Equals(a.Age, b.Age)==true)
            {
                Console.WriteLine("Osobe su iste.");

            }
            Console.ReadKey();
        }
        class Person
        {
            

            string name, surename;
            int age;

            public Person()
            {
            }

            public Person(string name, string surename, int age)
            {
                this.name = name;
                this.surename = surename;
                this.age = age;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public string Surename { get; internal set; }

            public override string ToString()
            {
                return base.ToString();
            }
            
        }
    }
}
