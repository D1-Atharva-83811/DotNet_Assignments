using System;
using System.Runtime.InteropServices;

namespace Assignment4
{
    public class Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
            
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Std = std;
            this.Div = div;
            this.Marks = marks;
        }

        public string Name { get => name;  set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public int Std { get => std; set => std = value; }
        public char Div { get => div; set => div = value; }
        public double Marks { get => marks; set => marks = value; }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender(Female/Male): ");
            if (Console.ReadLine()=="Female")
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std: ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter div: ");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name);
            if(gender)
            {
                Console.WriteLine("Gender: Female");
            }
            else
            {
                Console.WriteLine("Gender: Male");
            }
            Console.WriteLine("Age: " + age);
            Console.WriteLine("std: " + std);
            Console.WriteLine("div: " + div);
            Console.WriteLine("Marks: " + marks);
        }
    }
}
