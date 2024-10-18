using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string lastName, string login, int loginLength, bool havingPet, double age, string[] favColor) User;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите свое имя: ");
                User.name = Console.ReadLine();
                Console.WriteLine("Введите свою фамилию: ");
                User.lastName = Console.ReadLine();
                Console.WriteLine("Введите свой логин: ");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;
                Console.WriteLine("Есть ли у вас питомец? Y/N: ");
                if (Console.ReadLine() == "Y")
                {
                    User.havingPet = true;
                }
                else if (Console.ReadLine() == "N")
                {
                    User.havingPet = false;
                }
                else
                {
                    Console.WriteLine("Нет такого варианта ответа.");
                }
                Console.WriteLine("Ваш возраст: ");
                User.age = Convert.ToDouble(Console.ReadLine());
                User.favColor = new string[3];
                int j = 0;
                foreach (var i in User.favColor)
                {
                    Console.Write($"Введите свой {j + 1} любимый цвет: \n");
                    User.favColor[j] = Console.ReadLine();
                    j++;
                }
            }

            Console.ReadKey();
        }
    }
}
