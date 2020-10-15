using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Model
{
    class Instructor : Person
    {
        double[] grades;
        string preferredSubject;
        string school;
        static string personType = "lecture";

        public Instructor(string name, string preferredSubject, double energyLevel, double caffeineCapacity, string school, double[] grades) : base(name, caffeineCapacity, energyLevel)
        {
            this.PreferredSubject = preferredSubject;
            this.School = school;
            this.Grades = grades;

        }

        public double[] Grades { get => grades; set => grades = value; }
        public string PreferredSubject { get => preferredSubject; set => preferredSubject = value; }
        public string School { get => school; set => school = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //using the new keyword
        //public new double Rating()
        public override double Rating()
        {
            double total = 0;
            for (int i = 0; i < this.Grades.Length; i++)
            {
                total += Grades[i];
            }
            return (total / this.Grades.Length);
        }

        public override string ToString()
        {
            return ($"        {this.Name}                  {this.PreferredSubject}                      {this.EnergyLevel}                  {this.CaffeineCapacity}       {this.School}         {Instructor.personType}");
        }

        //Implementing the comparables
        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Person)(obj)).Name);
        }
    }
}
