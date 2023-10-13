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
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Назва дерева не може бути порожньою або null.", nameof(name));
            }
            if (height < 0)
            {
                throw new ArgumentException("Висота дерева не може бути від'ємною.", nameof(height));
            }
            if (age < 0)
            {
                throw new ArgumentException("Вік дерева не може бути від'ємним.", nameof(age));
            }

            this.name = name;
            this.height = height;
            this.age = age;
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

