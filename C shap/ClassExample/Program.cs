using System;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();
            human1.Age = 100;
            human1.height = 200.0f;
            human1.gender = 'M';
            human2.Age = 50;
            human2.height = 150.0f;
            human2.gender = 'w';
            human1.SayAge();
            human2.SayAge();

        }
    }
    class Human
    {
        public int Age;
        public float height;
        public char gender;
        public void SayAge()
        {
            Console.WriteLine(Age);
        }
    }
    
}
