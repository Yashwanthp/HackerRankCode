﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }
            

            Student s = new Student(firstName, lastName, id, scores);

            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
            
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _id;
        private readonly int[] _scores;
        private int[] testScores;
        /*	
       *   Class Constructor
       *   
       *   Parameters: 
       *   firstName - A string denoting the Person's first name.
       *   lastName - A string denoting the Person's last name.
       *   id - An integer denoting the Person's ID number.
       *   scores - An array of integers denoting the Person's test scores.
       */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores)
            :base(firstName,lastName,id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
            _scores = scores;
        }

       

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here

        public char Calculate()
        {
            var sum = _scores.Sum();
            var a = sum/_scores.Length;

            if (a >= 90 && a <= 100)
            {
                return 'O';
            }

            if (a >= 80 && a <= 90)
            {
                return 'E';
            }
            if (a >= 70 && a <= 80)
            {
                return 'A';
            }
            if (a >= 55 && a <= 70)
            {
                return 'P';
            }
            if (a >= 40 && a <= 55)
            {
                return 'D';

            }
            return 'T';
        }
    }
    
}
