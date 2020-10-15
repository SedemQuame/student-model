using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Student_Model
{
    public delegate void TimerDelegate(DateTime startTime, DateTime endTime);

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Testing From Main 😒

            //Creating delegates for the timer constructor.

            TimerDelegate newTimerDelegate = writeAlert;

            Timer timer = new Timer(newTimerDelegate);
            //Timer timer = new Timer("Timer started");

            //Getting input from the console.mini 
            Console.WriteLine("Count of arguments passed from terminal: {0}", args.Length);
            int size = Int32.Parse(args[0]);
            //Creating an array of students.
            Person [] listOfPersons = new Person[size];
            String [] names = { "Sedem", "Quame", "Merra", "Kwabe", "Andam", "Kwesi" };
            String [] subjects = { "Math   ", "English", "Bras   ", "Music  ", "Poetry ", "Art    " };
            int [] caffaineLevel = { 45, 78, 90, 100, 86, 40 };


            double[] grades = { };
            for (int i = 0; i < size; i++)
            {
                if ((i % 2) == 0)
                    listOfPersons[i] = new Student(names[i], subjects[i], caffaineLevel[i], 0.00, "turntabl university", grades);
                else
                    listOfPersons[i] = new Instructor(names[i], subjects[i], caffaineLevel[i], 0.00, "turntabl university", grades);

            }
            //Student sedem = new Student("sedem", "math", 100.0, 0.00, "turntabl university", grades);

            //Object methods
            //sedem.attendLecture();
            //sedem.listen();
            //sedem.takeTest();

            //Object accessors
            //Console.WriteLine("My name is {0}", sedem.Name);
            //Console.WriteLine("My preferred subject is {0}", sedem.PreferredSubject);
            //Console.WriteLine("My energy level is {0}", sedem.EnergyLevel);
            //Console.WriteLine("that's because my caffaine level is at {0}", sedem.CaffeineCapacity);
            //Console.WriteLine("I got to {0}", sedem.School);

            //Print each student's info
            Console.WriteLine("=============================================================================================================================");
            Console.WriteLine("|        Name            Preferred Subject        Energy Level            Caffaine           School                Type      |");
            Console.WriteLine("=============================================================================================================================");
            PrintStudentList(listOfPersons);

            Console.WriteLine("----------------------------------------------------SORTING-------------------------------------------------------------------\n");
            Array.Sort(listOfPersons);
            Console.WriteLine("\n-------------------------------------------------AFTER SORTING--------------------------------------------------------------");

            PrintStudentList(listOfPersons);

            //Get input from user
            Console.Write("\n\nSearch String: ");
            string searchName = Console.ReadLine();

            //Implementing Binary Search
            //int index = Array.BinarySearch(listOfPersons, searchName);

            //Console.WriteLine("Found student ...");
            //Console.WriteLine($"Student found at index: {index}");

            //Swapping student position
            Swap(ref listOfPersons[0], ref listOfPersons[1]);
            PrintStudentList(listOfPersons);

            timer.Dispose();
        }

        

        static void Swap( ref Person student1, ref Person student2)/*
*/        {
            Person temp = student1;
            student1 = student2;
            student2 = temp;
        }

        static void PrintStudentList(Person [] listOfPersons)
        {
            foreach (var person in listOfPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }

        static public void writeAlert(DateTime startTime, DateTime endTime)
        {
            TimeSpan timeSpan = (startTime - endTime);
            Console.Error.WriteLine($"Interval format [hh:mm:ss:fffff] for application: {timeSpan.ToString()}");
            Console.Error.WriteLine($"Interval format [fffff] for application: {timeSpan.TotalMilliseconds}");
        }

    }

}
