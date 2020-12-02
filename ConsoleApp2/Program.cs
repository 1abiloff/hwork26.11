using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1

            Console.WriteLine("2 3 4");

            Console.WriteLine(" ");

            //#2

            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");

            Console.WriteLine(" ");

            //#3

            Console.WriteLine("Введите число в см: ");
            int num;

            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В метрах: " + num / 100);

            Console.WriteLine(" ");

            //4

            int moment = 234;
            Console.WriteLine("В неделях: " + 234 / 7);

            Console.WriteLine(" ");


            //5
            int num2, firstNum, lastNum, totalNum, multiNum;

            Console.WriteLine("Введите двузначное число: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            firstNum = num2 / 10;
            lastNum = num2 % 10;
            totalNum = firstNum + lastNum;
            multiNum = firstNum * lastNum;

            Console.WriteLine("Десятки: " + firstNum);
            Console.WriteLine("Единицы: " + lastNum);
            Console.WriteLine("Сумма: " + totalNum);
            Console.WriteLine("Произведение: " + multiNum);

            Console.WriteLine(" ");


            // #6]

            bool a = true, b = false, c = false;

            Console.WriteLine(a || b);
            Console.WriteLine(a && b);
            Console.WriteLine(b || c);

            Console.WriteLine(" ");

            //#7
            int radius, side;

            Console.WriteLine("Введите радиус круга: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата: ");
            side = Convert.ToInt32(Console.ReadLine());

            if (3.14 * radius * radius > side * side)
            {
                Console.WriteLine("Круг больше");

            }

            else if (3.14 * radius * radius == side * side)
            {
                Console.WriteLine("Одинаковы");
            }

            else
            {
                Console.WriteLine("Квадрат больше");
            }

            Console.WriteLine(" ");

            //#8

            int volume1, volume2, weight1, weight2, density1, density2;

            Console.WriteLine("Введите объем 1 тела: ");
            volume1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите массу 1 тела: ");
            weight1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите объем 2 тела: ");
            volume2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите массу 2 тела: ");
            weight2 = Convert.ToInt32(Console.ReadLine());

            density1 = volume1 * weight1;
            density2 = volume2 * weight2;

            if(density1 > density2)
            {
                Console.WriteLine("1 тело больше ");
            }

            else if(density2 == density1)
            {
                Console.WriteLine("одинаковы");
            }

            else
            {
                Console.WriteLine("2 тело больше");
            }

            //#9

            int u1, u2, r1, r2, i1, i2;

            Console.WriteLine("Введите напряжение 1 тока: ");
            u1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите напряжение 2 тока: ");
            u2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сопротивление 1 тока: ");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сопротивление 2 тока: ");
            r2 = Convert.ToInt32(Console.ReadLine());

            i1 = u1 * r1;
            i2 = u2 * r2;

            if(i1 > i2)
            {
                Console.WriteLine("В перовой цепи сила тока больше");
            }

            else if(i1 < i2)
            {
                Console.WriteLine("Во второй цепи сила тока больше");
            }

            else
            {
                Console.WriteLine("одинаковы");
            }

            //#10
            // a

            for(int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }

            // b
            int bb;
            Console.WriteLine("Введите значение b:");
            bb = Convert.ToInt32(Console.ReadLine());

            for(int i = 10; i < bb; i++)
            {
                Console.WriteLine(i * i);
            }

            //c

            int l;
            Console.WriteLine("Введите значение а: ");
            l = Convert.ToInt32(Console.ReadLine());

            for(int i = l; i < 50; i++)
            {
                Console.WriteLine(i * i * i);
            }

            //d

            int n1, n2;
            Console.WriteLine("Введите значение а: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            for(int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }






























        }
    }
}
