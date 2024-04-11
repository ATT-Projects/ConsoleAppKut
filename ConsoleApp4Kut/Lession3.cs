using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Kut
{
    internal class Lession3
    {
        public void task1() {
            int a = 10;
            if (a == 0)
            {
                Console.WriteLine("0");
            }
            else if (a > 1)
            {
                Console.WriteLine("положительное");
            }
            else {
                Console.WriteLine("отрицательно");
            }
         
        }

        public void task2()
        {
            int age = 1900;
            if (age % 4 == 0 && age % 100 != 0 || age % 400 == 0)
            {
                Console.WriteLine("Високосный");
            }
            else
            {
                Console.WriteLine("Не високосный");
            }
        }
        public void task3()
        {

        }
        public void task4()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int min;
            if (a > b && c > b)
            {
                min = b;
            }
            else if (b > c && c < a)
            {
                min = c;
            }
            else {
                min = a;
            }
            Console.WriteLine(min);
        }
        public void task5()
        {
            int age = 1900;
            if (age % 4 == 0 && age % 100 != 0 || age%400 == 0)
            {
                Console.WriteLine("Високосный");
            }
            else {
                Console.WriteLine("Не високосный");
            }
        }
        public void task6()
        {
            int a = 9;
            if (a < 10 && a > 1)
            {
                Console.WriteLine("принадлежит");
            }
            else {
                Console.WriteLine("не принадлежит");
            }
        }
        public void task7() {
        
        }
        public void task8()
        {
            int m = 4;
            switch (m)
            {
                case 1: Console.WriteLine("Зима");
                    break;
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                    Console.WriteLine("Весна");
                    break;
                case 4:
                    Console.WriteLine("Весна");
                    break;
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                    Console.WriteLine("Лето");
                    break;
                case 7:
                    Console.WriteLine("Лето");
                    break;
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                    Console.WriteLine("Осень");
                    break;
                case 10:
                    Console.WriteLine("Осень");
                    break;
                case 11:
                    Console.WriteLine("Осень");
                    break;
                case 12:
                    Console.WriteLine("Зима");
                    break;
            }
        }
        public void task9()
        {

        }
        public void task10()
        {
            int a = 2;
            if (a % 2 == 0 || a == 0) {
                Console.WriteLine("Четное");
            } else {
                Console.WriteLine("Не чет");
              }

        }
        public void task11()
        {

        }
        public void task12() {
            int m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("1");
                    break;
                case 3:
                    Console.WriteLine("1");
                    break;
                case 4:
                    Console.WriteLine("1");
                    break;
                case 5:
                    Console.WriteLine("2");
                    break;
                case 6:
                    Console.WriteLine("2");
                    break;
                case 7:
                    Console.WriteLine("2");
                    break;
                case 8:
                    Console.WriteLine("2");
                    break;
                case 9:
                    Console.WriteLine("3");
                    break;
                case 10:
                    Console.WriteLine("3");
                    break;
                case 11:
                    Console.WriteLine("3");
                    break;
                case 12:
                    Console.WriteLine("3");
                    break;
            }
        }
        public void task13() {
            int m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("29");
                    break;
                case 3:
                    Console.WriteLine("31");
                    break;
                case 4:
                    Console.WriteLine("30");
                    break;
                case 5:
                    Console.WriteLine("31");
                    break;
                case 6:
                    Console.WriteLine("30");
                    break;
                case 7:
                    Console.WriteLine("31");
                    break;
                case 8:
                    Console.WriteLine("31");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("30");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("31");
                    break;
            }
        }
        public void task14() {
            int m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
            }
        }
        public void task15() {
            int m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("Зима");
                    break;
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                    Console.WriteLine("Весна");
                    break;
                case 4:
                    Console.WriteLine("Весна");
                    break;
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                    Console.WriteLine("Лето");
                    break;
                case 7:
                    Console.WriteLine("Лето");
                    break;
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                    Console.WriteLine("Осень");
                    break;
                case 10:
                    Console.WriteLine("Осень");
                    break;
                case 11:
                    Console.WriteLine("Осень");
                    break;
                case 12:
                    Console.WriteLine("Зима");
                    break;
            }
        }
        public void task16()
        {
            int m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Восткресенье");
                    break;
            }
        }
        public void task17() { }
        public void task18() { }
        public void task19() { }
        public void task20() { }

    }
}
