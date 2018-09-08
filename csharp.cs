using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";
            

            if (sample2 != sample1)
            {
                Console.WriteLine("The samples are not equal.");
            }
            else
            {
                Console.WriteLine("The samplpes are equal.");
            }

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart Rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart Rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            var force = mass * acceleration;
            Console.WriteLine("Force = {0}", force);

            Console.WriteLine("{0} is the distance.", distance);

            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.WriteLine("{0} is an integral", integral);

            for (int i = 5; i < 11; i = i+1)
            {
                Console.WriteLine("i = {0}", i);
            }

            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age = age + 1;
            }

            Console.WriteLine("{0} {1}", greeting, name);

            Console.ReadLine();
        }
            
    }
}
