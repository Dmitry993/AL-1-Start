using System;
using System.Collections.Generic;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Random random = new Random();
            var array = new Figure[3, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[0, j] = new Circle(random.Next(1, 10));
                    array[1, j] = new Square(random.Next(1, 10));
                    array[2, j] = (new Triangle(random.Next(1, 10),
                                                random.Next(1, 10)));
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(Math.Round(array[i,j].CalcArea(), 2) + "\t");
                }

                Console.WriteLine();
            }
        }

        class Figure
        {
            public virtual double CalcArea()
            {
                throw new NotImplementedException();
            }
        }

        class Circle : Figure
        {
            private int rad;

            public Circle(int rad)
            {
                this.rad = rad;
            }

            public override double CalcArea()
            {
                return Math.PI * rad * rad;
            }
        }

        class Square : Figure
        {
            private int a;

            public Square(int a)
            {
                this.a = a;
            }

            public override double CalcArea()
            {
                return a * a;
            }
        }

        class Triangle : Figure
        {
            private int height;
            private int b;

            public Triangle(int height, int b)
            {
                this.height = height;
                this.b = b;
            }

            public override double CalcArea()
            {
                return (double) b * height / 2;
            }
        }

        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
        }
    }
}
