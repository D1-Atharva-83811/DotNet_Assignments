using System;

namespace Assignment5
{
    internal class Program
    {
        static Student[] s1;
        static void Main(string[] args)
        {
            int size;
            int choice;
            
            Console.WriteLine("Enter size of array: ");
            
            size = Convert.ToInt32(Console.ReadLine());
            
            CreateArray(size);

            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Accept Info");
                Console.WriteLine("2.Print Info");
                Console.WriteLine("3.Reverse Info");
                Console.WriteLine("Enter Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    case 1:
                        AcceptInfo();
                        break;

                    case 2:
                        if (s1.Length == 0)
                        {
                            Console.WriteLine("Array Empty!!");
                        }
                        else
                        {
                        PrintInfo();
                        }
                        break;

                    case 3:
                        Student[] reversed = ReverseArray();
                        Console.WriteLine("Reversed Student Information:");
                        foreach (Student s in reversed)
                        {
                            Console.WriteLine("Name: "+ s.Name);
                            Console.WriteLine("Std: "+ s.Std);
                            Console.WriteLine("Marks: "+ s.Marks);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Input!!");
                        break;
                }

            } while (choice != 0);
        }

        public static void CreateArray(int size)
        {
            s1 = new Student[size];
        }
        public static void AcceptInfo()
        {
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = new Student();
                Console.WriteLine("Enter Student name: ");
                s1[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Student std: ");
                s1[i].Std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student marks: ");
                s1[i].Marks = Convert.ToDouble(Console.ReadLine());
            }
        }
        public static void PrintInfo()
        {
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine("Student name: " + s1[i].Name);
                Console.WriteLine("Student std: "+s1[i].Std);
                Console.WriteLine("Student marks: "+ s1[i].Marks);
            }
        }
        public static Student[] ReverseArray()
        {
            Student[] s2 = new Student[s1.Length];
            for(int i = 0; i < s1.Length; i++)
            {
                s2[s1.Length - 1 - i] = s1[i];
            }
            s1 = s2;
            return s1;
        }
    }
}