using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Kut
{
    internal class Lession4
    {
        public static void task1_1() {
            int a = 1;
            if (a > 0) {
                a++;
            } Console.WriteLine(a);
        }
        public static void task1_2()
        {
            int a = 1;
            int b = 2;
            if(a>b) { 
                b = a; 
            } else if(b>a)
            {
                a= b;
            } else
            {
                b = 0;
                a = b;
            }
            Console.WriteLine(a + " " + b);
        }
        public static void task1_3()
        {

        }
        public static void task2_1() {
            int a = 1;
            if (a > 0)
            {
                a++;
            }
            else {
                a -= 2;
            }
            Console.WriteLine(a);
        }
        public static void task2_2()
        {
            int a = 1;
            int b = 4;
            int c = 3;
            if (a > b && a > c) {
                Console.WriteLine(a);
            }else if(b>a && b>c) { 
            Console.WriteLine(b);
            } else Console.WriteLine(c);
        }
        public static void task2_3()
        {

        }
        public static void task3_1() {
            int a = 1;
            if (a > 0)
            {
                a++;
            }
            else if (a == 0)
            {
                a = 10;
            }
            else
            {
                a -= 2;
            }
            Console.WriteLine(a);
        }
        public static void task3_2()
        {
            int a = 1;
            int b = 4;
            int c = 3;
            int abss = 0;
            if (a > b && a > c)
            {
                if (c > b) { abss = c; } else { abss = b; }
            }
            else if(b>c && b>a)
            {
                if (c > a) { abss = c; } else { abss = a; }

            } else {

                if (b > a) { abss = a; } else { abss = b; }
                
            }
            Console.WriteLine(abss);
        }
        public static void task3_3() { }
        public static void task4_1() { }
        public static void task4_2() {
            int a = 1;
            int b = 4;
            int c = 3;
            int min = 0;
            int max = 0;
            if (a > b && a > c)
            {
                max = a;
                if (b < c)
                {
                    min = b;
                }
                else min = c;
            }
            else if (b > c && b > a)
            {
                max = b;
                if (a > c)
                {
                    min = c;
                }
                else min = a;
            }
            else
            {
                max = c;
                if (b > a) { max = b; } else max = a;
            }
            Console.WriteLine($"min {min} max {max}");
        }
        public static void task4_3() { }
        public static void task5_1() { }
        public static void task5_2() { }
        public static void task5_3() { }
        public static void task6_1() { }
        public static void task6_2() { }
        public static void task6_3() { }
        public static void task7_1() { }
        public static void task7_2() { }
        public static void task7_3() { }
        public static void task8_1() { }
        public static void task8_2() { }
        public static void task8_3() { }
        public static void task9_1() { }
        public static void task9_2() { }
        public static void task9_3() { }
        public static void task10_1() { }
        public static void task10_2() { }
        public static void task10_3() { }

    }
}
