using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Advanced_Lesson_1_OOP
{
    abstract class Product
    {
        public abstract double Price { get; }
    }

    class Laptop : Product
    {
        private string _cpu;
        private double _diagonal;
        private int _ram;
        private int _dataStorage;

        public Laptop(double price, string cpu, double diagonal, int ram, int dataStorage)
        {
            Price = price;
            _cpu = cpu;
            _diagonal = diagonal;
            _ram = ram;
            _dataStorage = dataStorage;
        }

        public override double Price { get; }

        public static bool operator <(Laptop laptop1, Laptop laptop2)
        {
            return laptop1.Price < laptop2.Price;
        }

        public static bool operator >(Laptop laptop1, Laptop laptop2)
        {
            return laptop1.Price > laptop2.Price;
        }

        public static bool operator ==(Laptop laptop1, Laptop laptop2)
        {
            return Equals(laptop1, laptop2);
        }

        public static bool operator !=(Laptop laptop1, Laptop laptop2)
        {
            return !Equals(laptop1, laptop2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Laptop laptop)
            {
                return Math.Abs(Price - laptop.Price) < 0.01;
            }

            return false;
        }
    }

    class MemoryCard : Product
    {
        private string _type;
        private int _capacity;

        public MemoryCard(double price, string type, int capacity)
        {
            Price = price;
            _type = type;
            _capacity = capacity;
        }

        public override double Price { get; }
    }

    public class Market
    {
        public static void CreateProduct()
        {
            Laptop asus = new Laptop(700, "Intel i7", 15.6, 16, 1000);
            MemoryCard transcend = new MemoryCard(30,"MicroSD", 32);
            Laptop acer = new Laptop(500, "Intel i5", 15.6, 8, 1000);
            Console.WriteLine(asus > acer);
        }
    }
}
