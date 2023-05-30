using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КНБ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери команду: \n 1. Камень \n 2. Ножницы \n 3. Бумага \n 4. Ящерица \n 5. Спок \n");
            Random rnd = new Random();
            int a = Convert.ToInt32(Console.ReadLine()), b = rnd.Next(1, 6);
            if (a == 1 && b == 2 | b == 4) { Console.WriteLine("You Win"); }
            else if (a == 2 && b == 3 | b == 4) { Console.WriteLine("You Win"); }
            else if (a == 3 && b == 1 | b == 5) { Console.WriteLine("You Win"); }
            else if (a == 4 && b == 3 | b == 5) { Console.WriteLine("You Win"); }
            else if (a == 5 && b == 2 | b == 1) { Console.WriteLine("You Win"); }
            else if (a == b) { Console.WriteLine("Draw"); }
            else { Console.WriteLine("You Lost"); }
            Console.WriteLine(b);
        }
    }
}
