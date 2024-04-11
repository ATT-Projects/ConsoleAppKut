using System.Text.RegularExpressions;




public class Tasks1 { 
public void task1_1() {
    int fst = 10;
    int snd = 20;
    Console.WriteLine(fst - snd);
}

public void task1_2() {
    double l;
    l = Convert.ToDouble(Console.ReadLine());
    double s, r;
    r = l / (2 * 3.14);
    s = 3.14 * r * r;
    Console.WriteLine("S={0}  ", s);
}

public void task2() { 
    int fst = 10;
    int snd = 20;
    Console.WriteLine((Math.Sqrt(fst) + Math.Sqrt(snd))/2);
}

public void task2_2() { 
    int S = 10;
    Console.WriteLine(Math.PI * 2 * Math.Sqrt(S));
}

public void task3_1() {
    double v = 0.1;
    double u = 0.1;
    int t1 = 0;
    int t2 = 0;
    if (u < v)
    {
        Console.WriteLine($"S = {v * t1 + (v - u) * t2}");
    }
    else {
        Console.WriteLine("не правмльные данные");
    }
}

public void task3_2() {
    int a = 0;
    int b= 0;
    int alpha = 0;
    if (a > b)
    {
        Console.WriteLine($"S = {(a + b) * (a - b) / 4 * Math.Tan(alpha)}");
    }
    else {

        Console.WriteLine("Не правильные данные");
    }
}

public void task4_1() {
    int v1 = 0;
    int v2 = 0;
    int s = 0;
    int t = 0;
    int s1 = s + v1 * t;
    int s2 = v2 * t;
    Console.WriteLine($"S = {Math.Sqrt((s1-s2)*(s1-s2))}");
}

public void task4_2() { 
    int a = 0 , b = 0;
    int alpha = 0;
    double h = (a - b) * Math.Tan(alpha);
    double S = (a + b) / 2 * h;
    double P = a + b + h * (1 / Math.Cos(alpha)) + h * (1 / Math.Sin(alpha));
    Console.WriteLine($"S = {S}");
    Console.WriteLine($"P = {P}");
}


public void task5_1() {
    int v1 = 0;
    int v2 = 0;
    int s = 0;
    int t = 0;
    int s1 = s + v1 * t;
    int s2 = v2 * t;
    Console.WriteLine($"S = {Math.Sqrt((s1 - s2) * (s1 - s2))}");
}

public void task5_2() {
    double x1 = 0;
    double y1 = 0;
    double x2 = 0;
    double y2 = 0;
    Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2) + (Math.Pow(y2 - y1,2))));
}

public void task6_1() {
    int a = 0;
    int b = 0;
    double S = a * b / 2;
    double P = a + b + Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5);
    Console.WriteLine($"P = {P}");
}

public void tasl6_2() {

    double x1 = Convert.ToDouble(Console.ReadLine());
    double y1 = Convert.ToDouble(Console.ReadLine());

    double x2 = Convert.ToDouble(Console.ReadLine());
    double y2 = Convert.ToDouble(Console.ReadLine());

    double x3 = Convert.ToDouble(Console.ReadLine());
    double y3 = Convert.ToDouble(Console.ReadLine());

    double sideAB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double sideBC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
    double sideCA = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

    double perimeter = sideAB + sideBC + sideCA;

    double semiPerimeter = perimeter / 2;
    double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideAB) * (semiPerimeter - sideBC) * (semiPerimeter - sideCA));

    Console.WriteLine($"Периметр треугольника: {perimeter}");
    Console.WriteLine($"Площадь треугольника: {area}");

}

public void task7_1() {

    double a = double.Parse(Console.ReadLine());

    double square = Math.Pow(a, 2);
    double surfaceArea = 6 * square; 
    double volume = Math.Pow(a, 3); 

    Console.WriteLine("Площадь грани куба: " + square);
    Console.WriteLine("Площадь полной поверхности куба: " + surfaceArea);
    Console.WriteLine("Объем куба: " + volume);
}

public void task7_2() {
    double A, B, C;

    A = Convert.ToDouble(Console.ReadLine());


    B = Convert.ToDouble(Console.ReadLine());

 
    C = Convert.ToDouble(Console.ReadLine());

    double discriminant = B * B - 4 * A * C;

    if (discriminant >= 0)
    {
        double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
        double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);

        Console.WriteLine("Первый корень: " + x1);
        Console.WriteLine("Второй корень: " + x2);
    }
    else
    {
        Console.WriteLine("Корней нет");
    }

}

public void task8_1()
{
    double r = 10;
    Console.WriteLine(2*Math.PI*r);

}

public void task8_2()
{
    double A1, C1, B1;
    double A2, C2, B2;
    A1 = Convert.ToDouble(Console.ReadLine());
    C1 = Convert.ToDouble(Console.ReadLine());
    B1 = Convert.ToDouble(Console.ReadLine());
    A2 = Convert.ToDouble(Console.ReadLine());
    C2 = Convert.ToDouble(Console.ReadLine());
    B2 = Convert.ToDouble(Console.ReadLine());

    double detA = A1 * B2 - A2 * B1;
    double detAx = C1 * B2 - C2 * B1;
    double detAy = A1 * C2 - A2 * C1;

    double x = detAx / detA;
    double y = detAy / detA;

    Console.WriteLine($"{x} , {y}");


}


public void task9_1()
{
    double r1 = 5;
    double r2 = 10; 

    double area = Math.PI * (r2 * r2 - r1 * r1); 

    Console.WriteLine(area); 

}


public void task9_2()
{
    int number = 1234;
    int sum = 0;

    sum += number % 10;
    number = number / 10; 

    sum += number % 10;
    number = number / 10;

    sum += number % 10;
    number = number / 10;

    sum += number % 10;

    Console.WriteLine(sum);

}


public void task10_1()
{
    double side = 10;

    double area = (Math.Pow(side, 2) * Math.Sqrt(3)) / 4;

    
    double inRadius = side * Math.Sqrt(3) / 6;

    double circumRadius = side * Math.Sqrt(3) / 3;

    Console.WriteLine("Площадь треугольника: " + area);
    Console.WriteLine("Радиус вписанной окружности: " + inRadius);
    Console.WriteLine("Радиус описанной окружности: " + circumRadius);

}

public void task10_2()
{
    int number = 1234;
    int sum = 1;

    sum *= number % 10;
    number = number / 10;

    sum *= number % 10;
    number = number / 10;

    sum *= number % 10;
    number = number / 10;

    sum *= number % 10;

    Console.WriteLine(sum);

}           
}

public class Task2 {

    public void task1_1() {
        int l = 1000;
        int l2 = l / 100;
        Console.WriteLine(l2);
    
    }
    public void task1_2()
    {
        int number = 123;
        int ing = 1;
        int sum = 0;

        ing *= number % 10;
        number = number / 10;

        ing *= number % 10;
        number = number / 10;

        ing *= number % 10;
        number = number / 10;

        sum += number % 10;
        number = number / 10;

        sum += number % 10;
        number = number / 10;

        sum += number % 10;
        number = number / 10;

        sum += number % 10;


        Console.WriteLine($"произведение {ing} сумма {sum}");

    }
    public void task1_3()
    {
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        int secondsInLastMinute = totalSeconds % 60;

        Console.WriteLine("Количество секунд, прошедших с начала последней минуты: " + secondsInLastMinute);
    }
    public void task2_1()
    {
        int m = 10;
        Console.WriteLine(m/1000);
    }

    public void task2_2()
    {
        int number = 123;

        int reverseNumber = 0;

        reverseNumber += number % 10 * 100; 
        number /= 10;

        reverseNumber += number % 10 * 10; 
        number /= 10; 

        reverseNumber += number % 10; 

        Console.WriteLine("Число, полученное при прочтении исходного числа справа налево: " + reverseNumber);
    }
    public void task2_3()
    {
        Console.Write("Введите количество секунд, прошедших с начала суток: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        int secondsInHour = 3600;
        int secondsFromLastHour = totalSeconds % secondsInHour;

        Console.WriteLine("С начала последнего часа прошло " + secondsFromLastHour + " секунд.");

    }
    public void task3_1()
    {
        int fileSizeBytes = 5000; 

        int fileSizeKB = fileSizeBytes / 1024; 

        Console.WriteLine(fileSizeKB);
    }
    public void task3_2()
    {
        int number = 345;
        int result = number % 100 * 10 + number / 100;
        Console.WriteLine(result);
    }
    public void task3_3()
    {
        Console.Write("Введите количество секунд: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int fullMinutes = (N / 60) % 60;

        Console.WriteLine(fullMinutes);
    }

    public void task4_1()
    {
        int A, B;

        Console.Write("Введите число A: ");
        A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число B: ");
        B = Convert.ToInt32(Console.ReadLine());

        int count = A / B;

        Console.WriteLine("Количество отрезков длины B, размещенных на отрезке A: " + count);
    }

    public void task4_2()
    {
        int number = 345;
        int newNumber = (number % 10) * 100 + (number / 10);

        Console.WriteLine(newNumber);
    }

    public void task4_3()
    {
        int K = Convert.ToInt32(Console.ReadLine());

        int dayOfWeek = (K + 0) % 7;

        switch (dayOfWeek)
        {
            case 0:
                Console.WriteLine("Воскресенье", K);
                break;
            case 1:
                Console.WriteLine("Понедельник", K);
                break;
            case 2:
                Console.WriteLine("Вторник", K);
                break;
            case 3:
                Console.WriteLine("Среда", K);
                break;
            case 4:
                Console.WriteLine("Четверг", K);
                break;
            case 5:
                Console.WriteLine("Пятница", K);
                break;
            case 6:
                Console.WriteLine("Суббота", K);
                break;
        }

    }

    public void task5_1()
    {
        int A = 10;
        int B = 3;

        int remainder = A % B;

        Console.WriteLine("Длина незанятой части отрезка A: " + remainder);
    }
    public void task5_2()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Число должно быть трехзначным.");
        }
        else
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            int newNumber = tens * 100 + hundreds * 10 + units;
            Console.WriteLine("Число после перестановки цифр сотен и десятков: " + newNumber);
        }
    }
    public void task5_3()
    {
        int K = int.Parse(Console.ReadLine());

        int dayOfWeek = (K + 3) % 7;

        switch (dayOfWeek)
        {
            case 0:
                Console.WriteLine("Воскресенье");
                break;
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
        }
    }

    public void task6_1()
    {
        int a = 12;
        Console.WriteLine("" + a % 10 + a / 10);
    }

    public void task6_2()
    {
        int a = 123;
        int b = a / 100;
        int c = a % 100 / 10;
        int d = a % 10;
        Console.WriteLine("" + b + d + c);
    }
    public void task6_3()
    {
        int k = 100;

        int dayOfWeek = (k + 1) % 7;

        switch (dayOfWeek)
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
            case 0:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Некорректное значение");
                break;
        }
    }

    public void task7_1()
    {
        int a =  12;
        Console.WriteLine(a % 10 + a / 10);
    }
    public void task7_2()
    {
        int a = 1000;
        Console.WriteLine(a / 100 % 10);
    }
    public void task7_3()
    {
        int K = int.Parse(Console.ReadLine());

        int dayOfWeek = (K + 5) % 7;

        switch (dayOfWeek)
        {
            case 0:
                Console.WriteLine("Понедельник");
                break;
            case 1:
                Console.WriteLine("Вторник");
                break;
            case 2:
                Console.WriteLine("Среда");
                break;
            case 3:
                Console.WriteLine("Четверг");
                break;
            case 4:
                Console.WriteLine("Пятница");
                break;
            case 5:
                Console.WriteLine("Суббота");
                break;
            case 6:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }

    public void task8_1()
    {
        int a = 12;
        Console.WriteLine("" + a % 10 + a / 10);
    }
    public void task8_2()
    {
        int a = 1000;
        Console.WriteLine(a / 1000 % 10);
    }
    public void task8_3()
    {
        int K = 100;
        int N = 3;

        int dayOfWeek = (K + N - 1) % 7;

        switch (dayOfWeek)
        {
            case 0:
                Console.WriteLine("Понедельник");
                break;
            case 1:
                Console.WriteLine("Вторник");
                break;
            case 2:
                Console.WriteLine("Среда");
                break;
            case 3:
                Console.WriteLine("Четверг");
                break;
            case 4:
                Console.WriteLine("Пятница");
                break;
            case 5:
                Console.WriteLine("Суббота");
                break;
            case 6:
                Console.WriteLine("Воскресенье");
                break;
        }
    }

    public void task9_1()
    {
        int a = 100;
        Console.WriteLine(a / 100);
    }

    public void task9_2()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        int minutes = N / 60;

        Console.WriteLine(minutes);
    }
    public void task9_3()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int numSquares = (A / C) * (B / C);
        int areaUnoccupied = A * B - numSquares * C * C;

        Console.WriteLine("Количество квадратов: " + numSquares);
        Console.WriteLine("Площадь незанятой части прямоугольника: " + areaUnoccupied);
    }

    public void task10_1()
    {
        int a = 123;
        Console.WriteLine("" + a % 10 + a % 100 / 10);
    }

    public void task10_2()
    {
        int seconds = Convert.ToInt32(Console.ReadLine());

        int hours = seconds / 3600;

        Console.WriteLine(hours);
    }
    public void task10_3()
    {
        int year = int.Parse(Console.ReadLine());

        int century = (year - 1) / 100 + 1;

        Console.WriteLine($"Номер столетия: {century}");
    }
}