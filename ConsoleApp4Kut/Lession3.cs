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
            char[] bukvi = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ч', 'ш', 'щ' };
            char c = 'а';
            bool isGlas = true;
            for (int i = 0; i < bukvi.Length - 1 ; i++) { 
            if (c.Equals(bukvi[i]))
            {
                isGlas = false;
                break;
            }
        }
            if (isGlas)
            {
                Console.WriteLine("Гласная");
            }
            else {
                Console.WriteLine("Согласная");
            }

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
            char c = 'f';
            if (char.IsDigit(c))
            {
                Console.WriteLine("Цифра");
            }
            else if (char.IsLetter(c))
            {
                Console.WriteLine("Буква");
            }
            else
            {
                Console.WriteLine("Специальный символ");
            }
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
            int year = 1999;
            int vek = (year / 100) + 1;
            if (vek == 20)
            {
                Console.WriteLine("XX ВЕК");
            } else if (vek == 21) {
                Console.WriteLine("XXI ВЕК");
            } else
            {
                Console.WriteLine("Какой-то другой век");
            }

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
            char c = 'а';
            switch (c)
            {
                case char a when(a >= 'A' && a <= 'Я'): 
                    Console.WriteLine("Заглавная"); 
                    break;
                case char a when (a >= 'а' && a <= 'я'):
                    Console.WriteLine("строчная");
                    break;
            }
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
        public void task17(int day, int year, int month) {
            DateOnly date = new DateOnly(year, month, day);
            switch (date.DayOfWeek) { 
                case DayOfWeek.Monday:
                        Console.WriteLine("Понедельник");
                        break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье");
                     break;
            }
        
        }
        public void task18() {
            int month = 10;
            int year = 2005;
            if (month > 0 && year > 0) { 
            switch (month)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        Console.WriteLine(31);
                        break;
                    case 2:
                        if ((year % 4 == 0) && ((year % 100 == 0) && (year % 400 == 0))) {
                            Console.WriteLine(28);
                            break;
                        } else {
                            Console.WriteLine(29);
                            break; 
                        }
                    case 4: case 6: case 9: case 11:
                        Console.WriteLine(30);
                        break;
                }
            }
        }
        public void task19() {
            int time = 15;
            switch(time)
            {
                case int n when(n>= 0 && n <=3):
                        Console.WriteLine("Ночь");
                        break;
                case int n when (n >= 4 && n <= 9):
                    Console.WriteLine("Утро");
                    break;
                case int n when (n >= 10 && n <= 15):
                    Console.WriteLine("День");
                    break;
                case int n when (n >= 16 && n <= 21):
                    Console.WriteLine("Вечер");
                    break;
                case int n when (n >= 22 && n <= 24):
                    Console.WriteLine("Вечер");
                    break;
                default:
                    Console.WriteLine("Вне диапазона");
                    break;
            }
        }
        public void task20() {
            int year = 2000;
            if (year % 100 == 0)
            {
                Console.WriteLine("Вековой");
            }
            else Console.WriteLine("Не вековой");
        }
        
    }
}
