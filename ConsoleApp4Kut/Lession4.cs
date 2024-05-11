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
            Console.WriteLine("Введите координаты точки (x y):");
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
    
            if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("3");
            }
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
            Console.Write("Введите координату X: ");
            double x = double.Parse(Console.ReadLine());
    
            Console.Write("Введите координату Y: ");
            double y = double.Parse(Console.ReadLine());
    
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в первой координатной четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во второй координатной четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьей координатной четверти");
            }
            else
            {
                Console.WriteLine("Точка находится в четвертой координатной четверти");
            }

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
        public static void task3_3() { 
            Console.Write(" x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
    
            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
    
            Console.Write("x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
    
            int x4, y4;
    
            if (x1 == x2)
            {
                x4 = x3;
            }
            else if (x1 == x3)
            {
                x4 = x2;
            }
            else
            {
                x4 = x1;
            }
    
            if (y1 == y2)
            {
                y4 = y3;
            }
            else if (y1 == y3)
            {
                y4 = y2;
            }
            else
            {
                y4 = y1;
            }
            Console.WriteLine($"Координаты: ({x4}, {y4})");
        }
    }
        public static void task4_1() { 
            Console.WriteLine("Введите три целых числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
    
            int count = 0;
    
            if (num1 > 0)
            {
                count++;
            }
            if (num2 > 0)
            {
                count++;
            }
            if (num3 > 0)
            {
                count++;
            }
    
            Console.WriteLine("Количество положительных чисел: " + count);
            }
        }
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
        public static void task4_3() { 
            Console.Write("Введите номер года: ");
            int year = Convert.ToInt32(Console.ReadLine());
    
            int days;
            
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                days = 366;
            }
            else
            {
                days = 365;
            }
    
            Console.WriteLine($"Количество дней в году {year}: {days}");
            }
        public static void task5_1() {   
            int num1, num2, num3;
            int positiveCount = 0;
            int negativeCount = 0;
    
            Console.WriteLine("Enter three integers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
    
            if (num1 > 0)
                positiveCount++;
            else if (num1 < 0)
                negativeCount++;
    
            if (num2 > 0)
                positiveCount++;
            else if (num2 < 0)
                negativeCount++;
    
            if (num3 > 0)
                positiveCount++;
            else if (num3 < 0)
                negativeCount++;

        Console.WriteLine($"Number of positive integers: {positiveCount}");
        Console.WriteLine($"Number of negative integers: {negativeCount}");
            
        }
        public static void task5_2() { 
            int a = 10;
            int b = 15;
            int c = 5;
              int sum;
            if (a >= b && a >= c) {
                sum = a;
                if (b >= c) {
                    sum += b;
                } else {
                    sum += c;
                }
            } else if (b >= a && b >= c) {
                sum = b;
                if (a >= c) {
                    sum += a;
                } else {
                    sum += c;
                }
            } else {
                sum = c;
                if (a >= b) {
                    sum += a;
                } else {
                    sum += b;
                }
            }
            Console.WriteLine(sum);
            
        }
        public static void task5_3() {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
    
            if (number == 0)
            {
                Console.WriteLine("Нулевое число");
            }
            else if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Положительное четное число");
                }
                else
                {
                    Console.WriteLine("Положительное нечетное число");
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Отрицательное четное число");
                }
                else
                {
                    Console.WriteLine("Отрицательное нечетное число");
                }
            }
        }
        public static void task6_1() { 
            int a = 0;
            int b = 1;
            if(a>b){
                Console.WriteLine(a);
            } else Console.WriteLine(b);
        }
        public static void task6_2() {
            double A, B, C;

            Console.WriteLine("Введите значение переменной A:");
            A = double.Parse(Console.ReadLine());
    
            Console.WriteLine("Введите значение переменной B:");
            B = double.Parse(Console.ReadLine());
    
            Console.WriteLine("Введите значение переменной C:");
            C = double.Parse(Console.ReadLine());
    
            if (A < B && B < C)
            {
                A *= 2;
                B *= 2;
                C *= 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            Console.WriteLine("Новые значения переменных:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
        }
        public static void task6_3() {
             Console.Write("Введите целое число от 1 до 999: ");
            int number = int.Parse(Console.ReadLine());
    
            if (number >= 1 && number <= 9)
            {
                Console.WriteLine("Однозначное число");
            }
            else if (number >= 10 && number <= 99)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Четное двузначное число");
                }
                else
                {
                    Console.WriteLine("Нечетное двузначное число");
                }
            }
            else if (number >= 100 && number <= 999)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Четное трехзначное число");
                }
                else
                {
                    Console.WriteLine("Нечетное трехзначное число");
                }
            }
        }
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
