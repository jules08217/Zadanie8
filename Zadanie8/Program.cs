using System;
using studentlib;
namespace Zadanie8
{
    class Program
    {
        public static void Menu()
        {
            Student s = new Student();
            Console.WriteLine("Выберите действие:\n1 - Вывести информацию\n2 - Добавить студента\n3 - Удалить студента\n4 - Изменить студента\n5 - Поиск студентов\n6 - Выход");
            int v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.WriteLine("Выберите доп.действие\n1 - Вся информация о студентах\n2 - Список студентов с инициалами\n3 -Список студентов старше или младше 18");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    if (v1 == 1)
                    {
                        s.Inf();
                    }
                    else if (v1 == 2)
                    {
                        s.InfFIO();
                    }
                    else if (v1 == 3)
                    {
                        s.Vvoz();
                    }
                    break;
                case 2:
                    s.Dobavit();
                    break;
                case 3:
                    s.Delite();
                    break;
                case 4:
                    s.Izmenit();
                    break;
                case 5:
                    Console.WriteLine("Выберите доп.действие\n1 - Поиск по фамилии\n2 - Поиск по ID");
                    int v2 = Convert.ToInt32(Console.ReadLine());
                    if (v2 == 1)
                    {
                        s.poiskpoF();
                    }
                    if (v2 == 2)
                    {
                        s.infID();
                    }
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }  
            Menu();
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
