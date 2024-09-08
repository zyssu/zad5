using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Employee
    {
        public string Name;
        public int Age;
        public string Job;
        public int Experience;
        public string Education;

        public Employee(string name, int age, string job, int experience, string education)
        {
            Name = name;
            Age = age;
            Job = job;
            Experience = experience;
            Education = education;
        }

        public double CalculateSalary()
        {
            double baseSalary = 0;

            if (Job == "Driver")
            {
                baseSalary = 6000;
            }
            else if (Job == "Mechanic")
            {
                baseSalary = 5000;
            }
            else if (Job == "Personnel")
            {
                baseSalary = 4000;
            }

            double finalSalary = baseSalary * 1.1 * Age;

            double experienceMultiplier = 1 + (Experience * 0.05);
            finalSalary *= experienceMultiplier;

            if (Education == "Secondary")
            {
                finalSalary *= 1.10;
            }
            else if (Education == "Higher")
            {
                finalSalary *= 1.20;
            }

            return finalSalary;
        }
    }
}

