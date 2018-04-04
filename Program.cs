using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgeIsPrivate
{
    class Program
    {
        class Person
        {
            //Create a privately accessed variable
            private int age;
            //Constructor for the person
            public Person(string name)
            {
                Console.WriteLine("Hello my name is {0}.", name);
            }
            //Getter and setter for private property age 
            public int Age
            {
                //Read private field
                get
                {
                    return age;
                }
                //Write to private field
                set
                {
                    age = value;
                }
            }
        }

        static void Main(string[] args)
        {
            //Ask for the name of the person
            Console.WriteLine("Let's create some Person objects. . .");
            Console.WriteLine("Give me a name:");
            string name = Console.ReadLine();
            Person person = new Person(name)
                ;
            //Change the privately accessed variable
            Console.WriteLine("Give me an age to change:");
            int age = Convert.ToInt32(Console.ReadLine());
            person.Age = age;

            //Display the age property on the person object
            Console.WriteLine(person.Age);

            //Keep program from exiting
            Console.ReadLine();
        }
    }
}
