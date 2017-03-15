using System;

namespace _4ClassvsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            if (T >= 1 && T <= 4)
            {
                for (int i = 0; i < T; i++)
                {
                    int age = int.Parse(Console.In.ReadLine());
                    if (age >= -5 && age <= 30)
                    {
                        Person p = new Person(age);
                        p.amIOld();
                        for (int j = 0; j < 3; j++)
                        {
                            p.yearPasses();
                        }
                        p.amIOld();
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}

class Person
{
    public int age;

    public Person(int initialAge)
    {
        // Add some more code to run some checks on initialAge
        if (initialAge < 0)
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        else
        {
            age = initialAge;
        }
    }

    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 
        if (this.age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        this.age = this.age + 1;
    }
}

