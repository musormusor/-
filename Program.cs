using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] ags)
    {
        /*string d = "объём вашего прямоугольника равен ";
        Console.WriteLine("Введите длину");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ширену");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите высоту");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(d + a * b * c);*/

        /*Console.WriteLine("Введите номер месяца");
        int mouth = Convert.ToInt32(Console.ReadLine());

        if (mouth >= 1 && mouth <= 12)
        {
            if (mouth >= 3 && mouth <= 5)
                Console.WriteLine("Весна");
            else if (mouth >= 6 && mouth <= 8)
                Console.WriteLine("Лето");
            else if (mouth >= 9 && mouth <= 11)
                Console.WriteLine("Осень");
            else
                Console.WriteLine("Зима");
        }
        else
            Console.WriteLine("Нет такого месяца!");*/

        /*Console.WriteLine("Введите число");
        double num = Convert.ToDouble(Console.ReadLine());

        {
            if (num > 0)
                Console.WriteLine("ваше чило положительное");
            else if (num < 0)
                Console.WriteLine("ваше чило отрицательное");
            else
                Console.WriteLine("ваше число рано 0");
        }*/

        /*Console.WriteLine("Введите сисло");
        int num1 = Convert.ToInt32(Console.ReadLine());

        {
            if (num1 % 2 == 0)
                Console.WriteLine("Ваше число чётное");
            else
                Console.WriteLine("Ваше число не чётное");
        }*/

        /*{
            for (int i = 1; i > 3; i++)
                Console.WriteLine("privet");


            while (i < 3)

                Console.WriteLine("privet1");
        }*/

        /*Console.WriteLine("Введите положительное число");
        int f1 = Convert.ToInt32(Console.ReadLine());

        while (f1 < 0)
        {
            Console.WriteLine("Введите положительное число");
            f1 = Convert.ToInt32(Console.ReadLine());
        }

        long factorial = 1;

        for (int i = 1; i <= f1; i++)

        {
            factorial = factorial * i;
        }

        Console.WriteLine($"Факториал числа {f1} равен {factorial}");*/

        /*for (int i = 1; i <= 10; i++)
            for (int j = 1; j <= 10; j++)
                Console.WriteLine($"{i}*{j}={i * j}");*/


        /*int[] numbers = { 1, 2, 3, 4, 5, 6 };

        int[] numbers2 = new int[10];

        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine(numbers[i]);*/

        /*Console.WriteLine("vvedite chislo");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int h = Convert.ToInt32(Console.ReadLine());
        string message = ("Elementa net");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == h)
            {
                message =($"element nayden na pozicii {i}");
               
                break;
            }
        }
            Console.WriteLine(message);*/
        /* {
            string x = Convert.ToString(Console.ReadLine());
            string y = x.Substring(1, (x.Length - 2));
            Console.WriteLine(y);
            return
           }*/

        /*Console.WriteLine("Vvedite 10 chisel");
        int x = Convert.ToInt32(Console.ReadLine());
        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int x3 = Convert.ToInt32(Console.ReadLine());
        int x4 = Convert.ToInt32(Console.ReadLine());
        int x5 = Convert.ToInt32(Console.ReadLine());
        int x6 = Convert.ToInt32(Console.ReadLine());
        int x7 = Convert.ToInt32(Console.ReadLine());
        int x8 = Convert.ToInt32(Console.ReadLine());
        int x9 = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        nums[0] = x;
        nums[1] = x1;
        nums[2] = x2;
        nums[3] = x3;
        nums[4] = x4;
        nums[5] = x5;
        nums[6] = x6;
        nums[7] = x7;
        nums[8] = x8;
        nums[9] = x9;
        int y = nums[0] + nums[1] + nums[2] + nums[3] + nums[4] + nums[5] + nums[6] + nums[7] + nums[8] + nums[9];
        Console.WriteLine($"Summa vashih chisel = {y}");*/

        /*{
            Console.WriteLine("vvedite 5 chisel");

            int[] x = { 1, 2, 3, 4, 5 };
            x[0] = Convert.ToInt32(Console.ReadLine());
            x[1] = Convert.ToInt32(Console.ReadLine());
            x[2] = Convert.ToInt32(Console.ReadLine());
            x[3] = Convert.ToInt32(Console.ReadLine());
            x[4] = Convert.ToInt32(Console.ReadLine());

            int z;

            int y = x[0] % 2;
            if (y == 0)
            {
                z = 1;
            }
            else
            {
                z = 0;
            }

            int z1;

            int y1 = x[1] % 2;
            if (y1 == 0)
            {
                z1 = 1;
            }
            else
            {
                z1 = 0;
            }

            int z2;

            int y2 = x[2] % 2;
            if (y2 == 0)
            {
                z2 = 1;
            }
            else
            {
                z2 = 0;
            }
            int z3;

            int y3 = x[3] % 2;
            if (y3 == 0)
            {
                z3 = 1;
            }
            else
            {
                z3 = 0;
            }

            int z4;

            int y4 = x[4] % 2;
            if (y4 == 0)
            {
                z4 = 1;
            }
            else
            {
                z4 = 0;
            }

            Console.WriteLine($"{z + z1 + z2 + z3 + z4} vashih chisla yavlyayutsya chetnimi");
        }*/

        /*Console.WriteLine("Vvedite 5 znacheniy");
        string a = Convert.ToString(Console.ReadLine());
        string b = Convert.ToString(Console.ReadLine());
        string c = Convert.ToString(Console.ReadLine());
        string d = Convert.ToString(Console.ReadLine());
        string e = Convert.ToString(Console.ReadLine());
        string[] x = { a, b, c, d, e };
        Console.WriteLine($"Vashi znacheniya {e} {b} {c} {d} {a}");
        */

        /*Console.WriteLine("Vvedite 5 chisel");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int[] x = { a, b, c, d, e };
        int y = x.Min();
        int z = x.Max();
        Console.WriteLine($"minimalynoe znachenie: {y}; maksimalnoe znachenie: {z}");*/

        /*Console.WriteLine("vvedite vash vozrast");
        int age = Convert.ToInt32(Console.ReadLine());
        int months = age * 12;
        int days = age * 365;

        Console.WriteLine($"vy projili {months} mesyacev ili {days} dney");*/

        /*Console.WriteLine("vvedite radius okrujnosti");
        double rad = Convert.ToDouble(Console.ReadLine());
        double ploschad = Math.PI * rad * rad;
        Console.WriteLine($"ploschad okrujnosti ravna {ploschad}");*/

        /*Console.WriteLine("vvedite 3");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double max = 0;
        if (a > b);
           max = a;
        if (a > c);
           max = c;
        else
           max = b;
        Console.WriteLine($"max {max}");*/

        /*int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         int temp = nums[3];
         nums[3] = nums[4];
         nums[4] = temp;

         for  (int i = 0; i < nums.Length; i++)
         {
             Console.WriteLine(nums[i]);
         }*/

        /*int[] nums = { 1, 9, 2, 4, 5, 7, 6, 3};
        int minIndex = 0;
        int maxIndex = 0;
        int max = nums[0];
        int min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
           if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
            if (nums[i] < min)
            {
                min = nums[i];
                minIndex = i;
            }
        }
        int temp = nums[minIndex];
        nums[minIndex] = nums[maxIndex];
        nums[maxIndex] = temp;
        for (int i = 0; i < nums.Length; i++)
            Console.WriteLine(nums[i]);*/

        /*Console.WriteLine("введите 4 числа и сумма 2 из них будет равна 9");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int[] nums = { a, b, c, d };
        int target = 9;
        if (nums[0] == target)
        {
            Console.WriteLine($"{nums[0]}");
        }
        if (nums[1] == target)
        {
            Console.WriteLine($"{nums[1]}");
        }
        if (nums[2] == target)
        {
            Console.WriteLine($"{nums[2]}");
        }
        if (nums[3] == target)
        {
            Console.WriteLine($"{nums[3]}");
        }
        if (nums[0] + nums[1] == target)
        {
            Console.WriteLine($"{nums[0]}, {nums[1]}");    
        }
        if (nums[0] + nums[2] == target)
        {
            Console.WriteLine($"{nums[0]}, {nums[2]}");
        }
        if (nums[0] + nums[3] == target)
        {
            Console.WriteLine($"{nums[0]}, {nums[3]}");
        }
        if (nums[1] + nums[2] == target)
        {
            Console.WriteLine($"{nums[1]}, {nums[2]}");
        }
        if (nums[1] + nums[3] == target)
        {
            Console.WriteLine($"{nums[1]}, {nums[3]}");
        }
        if (nums[2] + nums[3] == target)
        {
            Console.WriteLine($"{nums[2]}, {nums[3]}");
        }
         else Console.WriteLine("сумма ваших чисел не равна 9");*/


        /*Console.WriteLine("введите 4 целых числа и программа покажет их сумму и произведение");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int[] nums = { a, b, c, d };
        int x = a + b + c + d;
        int y = a * b * c * d;
        Console.WriteLine($"сумма чисел: {x}");
        Console.WriteLine($"произведение чисел: {y}");*/

        /*Console.WriteLine("vvedite 5 chisel");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int[] nums = { a, b, c, d, e };
        Console.WriteLine($"{a} {b} {c} {d} {e}");*/

        /*Console.WriteLine("vvedite 10 chisel");
        int a = Convert.ToInt32(Console.ReadLine());
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        int a4 = Convert.ToInt32(Console.ReadLine());
        int a5 = Convert.ToInt32(Console.ReadLine());
        int a6 = Convert.ToInt32(Console.ReadLine());
        int a7 = Convert.ToInt32(Console.ReadLine());
        int a8 = Convert.ToInt32(Console.ReadLine());
        int a9 = Convert.ToInt32(Console.ReadLine());
        int[] nums = { a, a1, a2, a3, a4, a5, a6, a7, a8, a9, };
        Console.WriteLine(a+a1+a2+a3+a4+a5+a6+a7+a8+a9);*/

        /*Console.WriteLine("vvedite 5 chisel");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int[] nums = { a, b, c, d, e };
        Console.WriteLine($"{a * a} {b * b} {c * c} {d * d} {e * e}");*/

        Console.WriteLine("vvedite 20 chisel");
        int[] nums = new int[20];
        int sum = 0;
        for (int i = 0; i < 20; i++)
         {
             nums[i] = Convert.ToInt32(Console.ReadLine());
             sum = sum + num[i];
         }
        int sum = x / 20;
        Console.WriteLine(y);




    }
}   

     



































