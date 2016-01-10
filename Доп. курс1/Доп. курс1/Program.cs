using System;
using Domain;

namespace Доп.курс1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("Животное какого возраста вы бы хотели приобрести?\n");
            var kisa = new Cat (Convert.ToInt32(Console.ReadLine()));
            do
            {
                Console.WriteLine("1) Задать имя;\n2) Задать цвет;\n3) Ударить;\n4) Покормить;\n0) Выход;\n");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите имя кошки(та):");
                        kisa.Name = Console.ReadLine();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Вы хотите поменять цвет больной(1) или здоровой(2) кошки(та)?");
                        k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цвет кошки(та):");
                        if (k == 1) kisa.Color.SickColor = Console.ReadLine();
                        else if (k == 2) kisa.Color.HealthyColor = Console.ReadLine();
                        break;
                    }
                    case 3:
                    {
                        kisa.Punish();
                        break;
                    }
                    case 4:
                    {
                        kisa.Feed();
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Текущая информация о кошке(те):");
                Console.WriteLine(kisa.Name);
                Console.WriteLine(kisa.Age);
                Console.WriteLine(kisa.CurrentColor);
            } while (k != 0);
        }
    }
}
