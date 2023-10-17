using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1
{
    internal class Tree
    {
        // Поля класу
        string name;
        double height;
        int age;

        public Tree(string name, double height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }


        public Tree(string name, double height)
        {
            this.name = name;
            this.height = height;
            this.age = 0;
        }

        public Tree(string name, int age)
        {
            this.name = name;
            this.height = 0;
            this.age = age;
        }

        public Tree(int age, double height)
        {
            this.name = "";
            this.age = age;
            this.height = height;
        }

        public Tree()
        {
            this.name = "";
            this.age = 0;
            this.height = 0;
        }



        public double CalculateAverageGrowthPerYear()
        {
            if (age == 0)
            {
                return 0.0;
            }

            return height / age;
        }

       
    }

}

