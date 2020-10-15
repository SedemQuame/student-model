using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Model
{
    abstract class Person
    {
        String name;
        double caffeineCapacity;
        double energyLevel;

        public Person(string name, double caffeineCapacity, double energyLevel)
        {
            this.name = name;
            this.caffeineCapacity = caffeineCapacity;
            this.energyLevel = energyLevel;
        }

        protected Person()
        {
        }

        public string Name { get => name; set => name = value; }
        public double CaffeineCapacity { get => caffeineCapacity; set => caffeineCapacity = value; }
        public double EnergyLevel { get => energyLevel; set => energyLevel = value; }

        //UYsing the abstract class
        //abstract public double Rating();

        public virtual double Rating()
        {
            return 0;
        }


    }
}
