using System;
using System.Collections.Generic;


class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите количество ячеек и растояние (через энтер)");
        var cells = Convert.ToInt32(Console.ReadLine());
        var dis = Convert.ToInt32(Console.ReadLine());
        var maxSumm = -1;
        var left = 0;
        var right = dis + 1;
        var mass = new int[cells];

        var rnd = new Random();
        Console.WriteLine(" ");

        for (var i = 0; i < cells; i++)
        {
            mass[i] = rnd.Next(1 , 10);
            Console.WriteLine("{0} : {1}",mass[i], i);

            if (i > dis)
            {
                if (mass[i] + mass[left] > maxSumm)
                {
                    maxSumm = mass[i] + mass[left];
                    right = i;
                }
                if (mass[i - dis - 1] + mass[i] > maxSumm)
                {
                    maxSumm = mass[i - dis - 1] + mass[i];
                    left = i - dis - 1;
                    right = i;
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine(left);
        Console.WriteLine(right);
    }
}
