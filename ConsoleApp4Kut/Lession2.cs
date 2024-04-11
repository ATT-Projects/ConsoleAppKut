using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Kut
{
    internal class Lession2
    {
        public void task1() {
            String name = "Andrey";
            Console.WriteLine($"Hello \n {name}");    
        }
        public void task2() {
            int a = 10;
            int b = 5;
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public void task3()
        {
            int a = 10;
            String s = a.ToString();
        }
        public void task4()
        {
            String s = "10";
            float f = float.Parse( s );
        }
        public void task5() { 
            int a = 10;
            double d = a * 1.8 + 32;
        }
        public void task6()
        {
            int N = 14000;

            int hours = (N / 3600) % 24;
            int minutes = (N % 3600) / 60; 
            int seconds = N % 60; 

            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
        }
    }
}
