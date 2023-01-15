using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zadanie
{
    internal class Program
    {
        static void Main()
        {
            string name;
            Console.Title = "Давайте познакомимся...";
            Console.Write("Как Вас зовут?");
            name = Console.ReadLine();
            string surname;
            Console.Write("Ваша Фамилия? Перед тем как написать, нажмите пробел и вводите фамилию");
            surname = Console.ReadLine();
            string txt = "Очень приятно, " + name + surname + "!";
            Console.WriteLine(txt);
        }
    }
}