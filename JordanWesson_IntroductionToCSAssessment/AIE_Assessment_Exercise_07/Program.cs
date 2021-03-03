/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;

namespace AIE_Assessment_Exercise_07
{
    class Person
    {
        public string name = "";
        public int phoneNum = 0;
        public string email = "";

        public Person(string name, int phoneNum, string email)
        {
            this.name = name;
            this.phoneNum = phoneNum;
            this.email = email;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine("Hello, I'm " + name);
        }
    }

    class Doctor : Person
    {
        public int salary = 0;

        public Doctor(string name, int phoneNum, string email, int salary) : base(name, phoneNum, email)
        {
            this.salary = salary;
        }

        public override void SayGreeting()
        {
            Console.WriteLine("Hello, I'm Dr. " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of
            // - A Person and Doctor classes.

            Person p1 = new Person("Bob", 1234567890, "bob@bobmail.com");
            Doctor p2 = new Doctor("Fred", 0987654321, "fred@fredmail.com", 250000);
            Person p3 = new Doctor("Ted", 0123456789, "ted@tedmail.com", 260000);

            // Invoke the "SayGreeting" method on the above instances
            p1.SayGreeting(); // hello I'm Bob
            p2.SayGreeting(); // hello I'm Dr. Fred
            p3.SayGreeting(); // hello I'm Dr. Ted
        }
    }
}
