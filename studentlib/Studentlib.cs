using System;
using System.Collections;
namespace studentlib
{
    public class Student
    {
        public int ID;
        public string FIO;
        public string Group;
        public string Data;
        public ArrayList student = new ArrayList();
        public ArrayList students = new ArrayList();
        public ArrayList fio = new ArrayList();
        public ArrayList id = new ArrayList();
        public ArrayList data = new ArrayList();

        public void Dobavit()//Добавить студента
        {
            Console.WriteLine("Введите данные студента");
            Random r = new Random();
            ID = r.Next(20);
            Console.WriteLine("Введите ФИО");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите Группу");
            Group = Console.ReadLine();
            Console.WriteLine("Введите Дату(dd.mm.yyyy)");
            Data = Console.ReadLine();
            student = new ArrayList();
            student.Add(ID);
            student.Add(FIO);
            student.Add(Group);
            student.Add(Data);
            id.Add(ID);
            fio.Add(FIO);
            data.Add(Data);
            string s = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students.Add(s);
        }
        public void Izmenit()//Изменить данные студента
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + n + " ), которого надо изменить");
            int s = Convert.ToInt32(Console.ReadLine());
            fio.RemoveAt(s);
            Console.WriteLine("Выберите, что нужно изменить: \n1 - ФИО\n2 - Группу\n3 - Дату рождения");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите ФИО");
                string fiO = Console.ReadLine();
                student[1] = fiO;
                fio.Add(fiO);
            }
            if (v == 2)
            {
                Console.WriteLine("Введите Группу");
                string group = Console.ReadLine();
                student[2] = group;
            }
            if (v == 3)
            {
                Console.WriteLine("Введите Дату(dd.mm.yyyy)");
                string data = Console.ReadLine();
                student[3] = data;
            }
            string st = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students[s] = st;
        }

        public void Delite()//Удалить студента
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + n + " ), которого надо удалить");
            int s = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(s);
        }
        public void Inf()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + "\n");
            }
        }

        public void InfFIO()
        {
            Console.WriteLine("Список студентов:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(fio[i]);
            }
        }

        public void infID()//Информация по ID
        {
            Console.WriteLine("Id студентов:");
            int k = 0;
            for (int i = 0; i < id.Count; i++)
            {
                Console.WriteLine(id[i]);
                k++;
            }
            int[] c = new int[k];
            id.CopyTo(c);
            Console.WriteLine("Введите ID студента");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Информация о студенте:");
            for (int j = 0; j < id.Count; j++)
            {
                if (d == c[j])
                {
                    Console.WriteLine(students[j]);
                }
            }
        }

        public void Vdata()//Кол-во лет студента
        {
            Console.WriteLine("Id студентов:");
            int k = 0;
            int[] cc = new int[4];
            int c1 = 0;
            int voz;
            for (int i = 0; i < id.Count; i++)
            {
                Console.WriteLine(id[i]);
                k++;
            }
            int[] c = new int[k];
            id.CopyTo(c);
            Console.WriteLine("Введите ID студента");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < id.Count; j++)
            {
                if (d == c[j])
                {
                    string s = data[j].ToString();
                    char[] ss = s.ToCharArray();
                    cc[0] = ss[6] - '0';
                    cc[1] = ss[7] - '0';
                    cc[2] = ss[8] - '0';
                    cc[3] = ss[9] - '0';
                    for (int i = 0; i < 4; i++)
                    {
                        c1 = c1 * 10 + cc[i];
                    }
                }
            }
            voz = 2020 - c1;
            Console.WriteLine("Возраст студента: " + voz);
        }

        public void FII()//Вывод Фамилии и инициалов
        {
            string v = "";
            string f1 = "";
            char im = ' ';
            char ot = ' ';
            int k = 0;
            int k1 = 0;
            for (int i = 0; i < fio.Count; i++)
            {
                string s = fio[i].ToString();
                char[] ss = s.ToCharArray();
                for (int f = s.Length - 1; f >= 0; f--)
                {
                    if (ss[f] == ' ')
                    {
                        f1 = "";
                    }
                    else f1 = ss[f] + f1;
                }
                for (int j = 0; j < s.Length; j++)
                {
                    if (ss[j] == ' ')
                    {
                        k1++;
                        if (k1 == 1)
                        {
                            im = ss[j + 1];
                        }

                    }
                }
                for (int h = 0; h < s.Length; h++)
                {
                    if (ss[h] == ' ')
                    {
                        k++;
                        if (k == 2)
                        {
                            ot = ss[h + 1];
                        }
                    }
                }

            }
            v = f1 + " " + im + '.' + ot + '.';
            Console.WriteLine(v);
        }

        public void Vvoz()//Вывод студентов младше или старше 18
        {
            int[] cc = new int[4];
            int c1 = 0;
            int voz;
            Console.WriteLine("Вывести студентов \n1 - старше 18\n2 - младше 18");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < students.Count; j++)
            {
                string s = data[j].ToString();
                char[] ss = s.ToCharArray();
                cc[0] = ss[6] - '0';
                cc[1] = ss[7] - '0';
                cc[2] = ss[8] - '0';
                cc[3] = ss[9] - '0';
                for (int i = 0; i < 4; i++)
                {
                    c1 = c1 * 10 + cc[i];
                }
                voz = 2020 - c1;
                if (d == 1 && voz >= 18)
                {
                    Console.WriteLine(students[j]);
                }
                else if (d == 2)
                {
                    if (voz < 18)
                    {
                        Console.WriteLine(students[j]);
                    }
                }
            }
        }

        public void poiskpoF()//Поиск по фамилии
        {
            Console.WriteLine("Введите фамилию");
            string str = Console.ReadLine();
            string f1 = "";
            for (int i = 0; i < fio.Count; i++)
            {
                string s = fio[i].ToString();
                char[] ss = s.ToCharArray();
                for (int f = s.Length - 1; f >= 0; f--)
                {
                    if (ss[f] == ' ')
                    {
                        f1 = "";
                    }
                    else f1 = ss[f] + f1;
                }
                if (f1 == str)
                {
                    Console.WriteLine(students[i]);
                }
            }
        }
    }
}
