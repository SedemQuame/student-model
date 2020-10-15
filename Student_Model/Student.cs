using System;

namespace Student_Model
{
    class Student: Person, IComparable
    {
        string preferredSubject;
        string school;
        double[] grades;
        static string personType = "student";

        public string PreferredSubject { get => preferredSubject; set => preferredSubject = value; }
        public string School { get => school; set => school = value; }
        public double[] Grades { get => grades; set => grades = value; }

        public Student(string name, string preferredSubject, double energyLevel, double caffeineCapacity, string school, double[] grades):base(name, caffeineCapacity, energyLevel)
        {

            this.PreferredSubject = preferredSubject;
            this.School = school;
            this.Grades = grades;
        }

        //Methods
        public void listen()
        {
            Console.WriteLine("Listening for feedback");
        }

        public void takeTest()
        {
            Console.WriteLine("Taking a test");
        }

        public void attendLecture()
        {
            Console.WriteLine("Attending Turntabl lectures");
        }

        //Implementing the comparables
        public int CompareTo(object obj)
        {
                return Name.CompareTo(((Person)(obj)).Name);
        }

        public override double Rating()
        {
            double total = 0;
            for (int i = 0; i < this.grades.Length; i++)
            {
                total += grades[i];
            }
            return (total/this.grades.Length);
        }

        public override string ToString()
        {
           return($"        {this.Name}                  {this.PreferredSubject}                      {this.EnergyLevel}                  {this.CaffeineCapacity}       {this.School}         {Student.personType}");
        }
    }
}
