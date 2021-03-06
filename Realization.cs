using System;
using System.Collections.Generic;
using System.IO;

namespace LabaN7
{
    class Realization
    {
        private bool created = false;
        private Subject[] subjects = null;
        private string[] text = null;
        private string path;
        private void Show_Subject()   //Вывод всего массива
        {
            if (created)
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    Console.WriteLine("\tПредмет № " + i + ":\n");
                    Console.WriteLine("\tНазвание: " + subjects[i].Name);
                    Console.WriteLine("\tГод обучения: " + subjects[i].Year);
                    Console.WriteLine("\tФакультет: " + subjects[i].Faculty);
                    Console.WriteLine("\tКафедра: " + subjects[i].Department);
                    Console.WriteLine("\tКол-во часов: " + subjects[i].Hours);
                    Console.WriteLine("--------------------------------");
                }
                GC.Collect();
            }
            else
            {
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private void Show_Subject(uint index)   //Перегрузка. Вывод предмета по индексу
        {
            if (created)
            {
                Console.WriteLine("\tПредмет № " + index + ":\n");
                Console.WriteLine("\tНазвание: " + subjects[index].Name);
                Console.WriteLine("\tГод обучения: " + subjects[index].Year);
                Console.WriteLine("\tФакультет: " + subjects[index].Faculty);
                Console.WriteLine("\tКафедра: " + subjects[index].Department);
                Console.WriteLine("\tКол-во часов: " + subjects[index].Hours);
                Console.WriteLine("--------------------------------");
            }
            else
            {
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
            }

        }
        private void Sort_By_Name(bool x)
        {
            if (created)
            {
                if (x)
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Name.CompareTo(subjects[g].Name) > 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Name.CompareTo(subjects[g].Name) < 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
            }
            else
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
        }
        private void Sort_By_Year(bool x)
        {
            if (created)
            {
                if (x)
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Year > subjects[g].Year)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Year < subjects[g].Year)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
            }
            else
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
        }
        private void Sort_By_Faculty(bool x)
        {
            if (created)
            {
                if (x)
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Faculty.CompareTo(subjects[g].Faculty) > 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Faculty.CompareTo(subjects[g].Faculty) < 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
            }
            else
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
        }
        private void Sort_By_Department(bool x)
        {
            if (created)
            {
                if (x)
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Department.CompareTo(subjects[g].Department) > 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Department.CompareTo(subjects[g].Department) < 0)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
            }
            else
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
        }
        private void Sort_By_Hours(bool x)
        {
            if (created)
            {
                if (x)
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Hours > subjects[g].Hours)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < subjects.Length; i++)
                        for (int g = i + 1; g < subjects.Length; g++)
                            if (subjects[i].Hours < subjects[g].Hours)
                            {
                                var temp = subjects[i];
                                subjects[i] = subjects[g];    //Выходя из зоны видимости temp удаляется, присваивание null не нужно
                                subjects[g] = temp;
                            }
                }
            }
            else
                Console.WriteLine(" Массив предметов не был создан, используйте метод .Create()");
        }
        private void Search_By_Hours(ushort hours)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Hours == hours)
                    {
                        Show_Subject(i);
                        flag = true;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Успешно!");
                        Console.ResetColor();
                        break;
                    }
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\n Не найдено");
                    Console.ResetColor();
                }
            }
            else
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private void Search_By_Department(string department)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Department == department)
                    {
                        Show_Subject(i);
                        flag = true;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Успешно!");
                        Console.ResetColor();
                        break;
                    }
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Не найдено");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private void Search_By_Faculty(string faculty)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Faculty == faculty)
                    {
                        Show_Subject(i);
                        flag = true;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Успешно!");
                        Console.ResetColor();
                        break;
                    }
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Не найдено");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private void Search_By_Year(ushort year)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Year == year)
                    {
                        Show_Subject(i);
                        flag = true;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Успешно!");
                        Console.ResetColor();
                        break;
                    }
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Не найдено");
                    Console.ResetColor();
                }

            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private void Search_By_Name(string name)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Name == name)
                    {
                        Show_Subject(i);
                        flag = true;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Успешно!");
                        Console.ResetColor();
                        break;
                    }
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" Не найдено");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private void CreateAndFill(string path)
        {
            if (File.Exists(path))
            {
                var list = new List<string>();       //Список строк файла  
                StreamReader str = new StreamReader(path);
                while (!str.EndOfStream)
                    list.Add(str.ReadLine());
                str.Dispose();                 //Освобождается память
                text = list.ToArray();           //Из списка делается массив строк 
                list.Clear();   //Важный недочет
                if (text.Length > 0 && text.Length % 5 == 0)
                {
                    subjects = new Subject[text.Length / 5];
                    created = true;
                    for (int i = 0; i < subjects.Length; i++)
                    {
                        Fill(subjects, text, i);// Вызов метода Fill() заполнения объекта данными
                    }
                    text = null;    //Важный недочет
                      
                }
                else
                {
                    Console.WriteLine($" Ошибка. Файл должен содержать как минимум 5" +
                        " строк для каждого из полей структуры,а в вашем файле " + text.Length + " строк(и).");
                    list.Clear();
                    text = null;
                }
                GC.Collect();      //Сборка мусора
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Введён неверный формат или файла не существует.\n");
                Console.ResetColor();
            }
        }
        private void Fill(Subject[] subject, string[] text, int index) //Заполнение объекта данными из массива строк(файла)
        {
            subject[index] = new Subject
            {
                Name = text[index * 5]
            };
            try
            {
                subject[index].Year = Convert.ToUInt16(text[index * 5 + 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Строка " + (index * 5 + 1) + " должна иметь вид числа." + " Error: " + ex.Message); //Ошибка конвертации
            }
            subject[index].Faculty = text[index * 5 + 2];
            subject[index].Department = text[index * 5 + 3];
            try
            {
                subject[index].Hours = Convert.ToUInt16(text[index * 5 + 4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Строка " + (index * 5 + 4) + " должна иметь вид числа." + " Error: " + ex.Message); //Ошибка конвертации
            }
            
            
        }
        private void AddFirst(string name, ushort year, string faculty, string department, ushort hours)
        {
            var sb=new Subject[subjects.Length+1];
            for(int i=0; i < subjects.Length; i++)
            {
                sb[i] = new Subject();
            }
            sb[0].Name = name;
            sb[0].Department = department;
            sb[0].Faculty = faculty;
            sb[0].Hours = hours;
            sb[0].Year = year;
            subjects.CopyTo(sb, 1);
            subjects = null;
            GC.Collect();
            subjects = new Subject[sb.Length];
            for(int i = 0; i < sb.Length; i++)
            {
                subjects[i] = sb[i];
            }
            sb = null;
            GC.Collect();
        }
        private void AddLast(string name, ushort year, string faculty, string department, ushort hours)
        {
            var sb = new Subject[subjects.Length + 1];
            for (int i = 0; i < subjects.Length; i++)
            {
                sb[i] = new Subject();
                sb[i] = subjects[i];
            }
            sb[subjects.Length] = new Subject();
            sb[subjects.Length].Name = name;
            sb[subjects.Length].Department = department;
            sb[subjects.Length].Faculty = faculty;
            sb[subjects.Length].Hours = hours;
            sb[subjects.Length].Year = year;
            subjects = null;
            GC.Collect();
            subjects = new Subject[sb.Length];
            for (int i = 0; i < sb.Length; i++)
            {
                subjects[i] = sb[i];
            }
            sb = null;
            GC.Collect();
        }
        private void AddIndex(uint index, string name, ushort year, string faculty, string department, ushort hours)
        {
            var sb = new Subject[subjects.Length + 1];
            for (int i = 0; i < index; i++)
            {
                sb[i] = new Subject();
                sb[i] = subjects[i];
            }
            for (uint i = index; i < sb.Length-1; i++)
            {
                sb[i+1] = new Subject();
                sb[i + 1] = subjects[i];
            }
            sb[index] = new Subject();
            sb[index].Name = name;
            sb[index].Department = department;
            sb[index].Faculty = faculty;
            sb[index].Hours = hours;
            sb[index].Year = year;
            subjects = null;
            GC.Collect();
            subjects = new Subject[sb.Length];
            for (int i = 0; i < sb.Length; i++)
            {
                subjects[i] = sb[i];
            }
            sb = null;
            GC.Collect();

        }
        private void DeleteIndex(uint index)
        {
            Subject[] sb = new Subject[subjects.Length - 1];
            for(int i = 0; i < index; i++)
            {
                sb[i] = subjects[i];
            }
            for(uint i = index+1; i < subjects.Length; i++)
            {
                sb[i-1] = subjects[i];
            }
            subjects = null;
            GC.Collect();
            subjects = new Subject[sb.Length];
            for(int i = 0; i < sb.Length; i++)
            {
                subjects[i] = sb[i];
            }
            sb = null;
            GC.Collect();
        }
        private void SaveFile(string path)
        {
            using (StreamWriter str = new StreamWriter(path, false))
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    str.WriteLine(subjects[i].Name);
                    str.WriteLine(subjects[i].Year.ToString());
                    str.WriteLine(subjects[i].Faculty);
                    str.WriteLine(subjects[i].Department);
                    str.WriteLine(subjects[i].Hours.ToString());
                }
            }
        }
        private void EditMenu(uint index)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tРедактирование\n");
            Console.ResetColor();
            Show_Subject(index);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 1. ");
            Console.ResetColor();
            Console.Write("Имя\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 2. ");
            Console.ResetColor();
            Console.Write("Год\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 3. ");
            Console.ResetColor();
            Console.Write("Факульет\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 4. ");
            Console.ResetColor();
            Console.Write("Кафедра\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 5. ");
            Console.ResetColor();
            Console.Write("Часы\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 6. ");
            Console.ResetColor();
            Console.Write("Выйти\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                byte selectededit = Convert.ToByte(Console.ReadLine());
                switch (selectededit)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Введите новое имя: ");
                            Console.ResetColor();
                            subjects[index].Name = Console.ReadLine();
                            Console.Clear();
                            EditMenu(index);
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Введите новый год: ");
                                Console.ResetColor();
                                subjects[index].Year = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                                EditMenu(index);
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Год ввёден в неправильном формате\n");
                                Console.ResetColor();
                                EditMenu(index);
                                break;
                            }

                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Введите новый факультет: ");
                            Console.ResetColor();
                            subjects[index].Faculty = Console.ReadLine();
                            Console.Clear();
                            EditMenu(index);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Введите новую кафедру: ");
                            Console.ResetColor();
                            subjects[index].Department = Console.ReadLine();
                            Console.Clear();
                            EditMenu(index);
                            break;
                        }
                    case 5:
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Введите новое кол-во часов: ");
                                Console.ResetColor();
                                subjects[index].Hours = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                                EditMenu(index);
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Кол-во часов введено в неправильном формате\n");
                                Console.ResetColor();
                                EditMenu(index);
                                break;
                            }
                        }
                    case 6:
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Введите пункт 1-6\n");
                Console.ResetColor();
                Menu_Edit();
            }
        }
        private void Menu_File()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\tЗапись в файл\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  1.");
            Console.ResetColor();
            Console.Write("В исходный файл \t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.Write("В новый файл\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  3.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        {

                            SaveFile(path);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите адресс файла (Если файла не существует, создается новый): ");
                            Console.ResetColor();
                            string destination = Console.ReadLine();
                            SaveFile(destination);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_();
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Ошибка. Введите пункт 1-3.");
                            Console.ResetColor();
                            Menu_File();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Ошибка. Введите пункт 1-3.");
                Console.ResetColor();
                Menu_File();
            }

        }
        private void Menu_Edit()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n Введите предмет для редактирования(0-" + (subjects.Length - 1)+"): ");
            Console.ResetColor();
            try
            {
                uint selecsubject = Convert.ToUInt32(Console.ReadLine());
                Console.Clear();
                EditMenu(selecsubject);
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Введите номер элемента от 0 до "+(subjects.Length-1));
                Console.ResetColor();
                Menu_();
            }
        }
        private void Menu_Creation()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Введите полный путь до файла : ");
            Console.ResetColor();
            path = Console.ReadLine();
            Console.WriteLine();
            CreateAndFill(path);
            Console.Clear();
            Menu_();
        }
        private void Menu_Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t Вывод на экран\n");
            Console.ResetColor();
            Console.WriteLine("  Вывести всё или отдельный предмет?\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  1.");
            Console.ResetColor();
            Console.Write("Всё\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.Write("Один");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\t3.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());

                switch (select)
                {
                    case '1': { Console.Clear(); Show_Subject(); Menu_(); break; }
                    case '2':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите номер предмета, от 0 до " + (subjects.Length - 1)+": ");
                            Console.ResetColor();
                            try
                            {
                                uint x = Convert.ToUInt32(Console.ReadLine());
                                if (x >= 0 && x < subjects.Length)
                                {
                                    Console.Clear();
                                    Show_Subject(x);
                                    Menu_();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n Вы вышли за границы.\n");
                                    Console.ResetColor();
                                    Menu_Show();
                                }

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Выберите 1, 2 или 3 пункт.\n");
                                Console.ResetColor();
                                Menu_Show();
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n Выберите 1, 2 или 3 пункт.\n");
                        Console.ResetColor();
                        Menu_Show();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Выберите 1, 2 или 3 пункт.\n");
                Console.ResetColor();
                Menu_Show();
            }

        }
        private void Menu_Searching()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tПоиск\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1.");
            Console.ResetColor();
            Console.Write("По имени\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.WriteLine("По году\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3.");
            Console.ResetColor();
            Console.Write("По факультету\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4.");
            Console.ResetColor();
            Console.WriteLine("По специальности\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5.");
            Console.ResetColor();
            Console.Write("По часам.\t"); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню.\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите имя : ");
                            Console.ResetColor();
                            string name = Console.ReadLine();
                            Console.Clear();
                            Search_By_Name(name);
                            Menu_();
                            break;
                        }
                    case '2':
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите год : ");
                                Console.ResetColor();
                                string name = Console.ReadLine();
                                Console.Clear();
                                Search_By_Year(Convert.ToUInt16(name));
                                Menu_();
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Год ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Searching();
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите факультет :");
                            Console.ResetColor();
                            string name = Console.ReadLine();
                            Console.Clear();
                            Search_By_Faculty(name);
                            Menu_();
                            break;
                        }
                    case '4':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите специальность :");
                            Console.ResetColor();
                            string name = Console.ReadLine();
                            Console.Clear();
                            Search_By_Department(name);
                            Menu_();
                            break;
                        }
                    case '5':
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите кол-во часов :");
                                Console.ResetColor();
                                string name = Console.ReadLine();
                                Console.Clear();
                                Search_By_Hours(Convert.ToUInt16(name));
                                Menu_();
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Часы введены в неправильном формате.");
                                Console.ResetColor();
                                Menu_Searching();
                            }
                            break;

                        }
                    case '6':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Введите пункт 1-6");
                            Console.ResetColor();
                            Menu_Searching();
                            break;
                        }
                    
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Введите пункт 1-6");
                Console.ResetColor();
                Menu_Searching();
            }
        }
        private void Menu_Sort()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tСортировка\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1.");
            Console.ResetColor();
            Console.Write("По имени\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.WriteLine("По году\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3.");
            Console.ResetColor();
            Console.Write("По факультету\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4.");
            Console.ResetColor();
            Console.WriteLine("По специальности\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5.");
            Console.ResetColor();
            Console.Write("По часам.\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню.\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\tСортировка по имени\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 1. ");
                            Console.ResetColor();
                            Console.WriteLine("По возрастанию (A->Z)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 2. ");
                            Console.ResetColor();
                            Console.WriteLine("По убыванию (Z->A)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 3. ");
                            Console.ResetColor();
                            Console.WriteLine("Отмена\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Действие: ");
                            Console.ResetColor();
                            try
                            {
                                byte nameselect = Convert.ToByte(Console.ReadLine());
                                switch (nameselect)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Sort_By_Name(true);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Name(false);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Menu_();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n Выберите пункт 1-3 \n");
                                            Console.ResetColor();
                                            Menu_Sort();
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Выберите пункт 1-3 \n");
                                Console.ResetColor();
                                Menu_Sort();
                                break;
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\tСортировка по году\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 1. ");
                            Console.ResetColor();
                            Console.WriteLine("По возрастанию (0->2020)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 2. ");
                            Console.ResetColor();
                            Console.WriteLine("По убыванию (2020->0)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 3. ");
                            Console.ResetColor();
                            Console.WriteLine("Отмена\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Действие: ");
                            Console.ResetColor();
                            try
                            {
                                byte nameselect = Convert.ToByte(Console.ReadLine());
                                switch (nameselect)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Sort_By_Year(true);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Year(false);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Menu_();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n Выберите пункт 1-3 \n");
                                            Console.ResetColor();
                                            Menu_Sort();
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Выберите пункт 1-3 \n");
                                Console.ResetColor();
                                Menu_Sort();
                                break;
                            }
                            break;
                        }
                    case '3':
                        {
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\tСортировка по Факультету\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" 1. ");
                                Console.ResetColor();
                                Console.WriteLine("По возрастанию (A->Z)\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" 2. ");
                                Console.ResetColor();
                                Console.WriteLine("По убыванию (Z->A)\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" 3. ");
                                Console.ResetColor();
                                Console.WriteLine("Отмена\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" Действие: ");
                                Console.ResetColor();
                                try
                                {
                                    byte nameselect = Convert.ToByte(Console.ReadLine());
                                    switch (nameselect)
                                    {
                                        case 1:
                                            {
                                                Console.Clear();
                                                Sort_By_Faculty(true);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.Write(" Успешно!");
                                                Console.ResetColor();
                                                Menu_();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Sort_By_Faculty(false);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.Write(" Успешно!");
                                                Console.ResetColor();
                                                Menu_();
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Clear();
                                                Menu_();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("\n Выберите пункт 1-3 \n");
                                                Console.ResetColor();
                                                Menu_Sort();
                                                break;
                                            }
                                    }
                                }
                                catch
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n Выберите пункт 1-3 \n");
                                    Console.ResetColor();
                                    Menu_Sort();
                                    break;
                                }
                                break;
                            }
                        }
                    case '4':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\tСортировка по специальности\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 1. ");
                            Console.ResetColor();
                            Console.WriteLine("По возрастанию (A->Z)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 2. ");
                            Console.ResetColor();
                            Console.WriteLine("По убыванию (Z->A)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 3. ");
                            Console.ResetColor();
                            Console.WriteLine("Отмена\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Действие: ");
                            Console.ResetColor();
                            try
                            {
                                byte nameselect = Convert.ToByte(Console.ReadLine());
                                switch (nameselect)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Sort_By_Department(true);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Department(false);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Menu_();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n Выберите пункт 1-3 \n");
                                            Console.ResetColor();
                                            Menu_Sort();
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Выберите пункт 1-3 \n");
                                Console.ResetColor();
                                Menu_Sort();
                                break;

                            }
                            break;
                        }
                    case '5':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\tСортировка по часам\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 1. ");
                            Console.ResetColor();
                            Console.WriteLine("По возрастанию (0->500)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 2. ");
                            Console.ResetColor();
                            Console.WriteLine("По убыванию (500->0)\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" 3. ");
                            Console.ResetColor();
                            Console.WriteLine("Отмена\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Действие: ");
                            Console.ResetColor();
                            try
                            {
                                byte nameselect = Convert.ToByte(Console.ReadLine());
                                switch (nameselect)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Sort_By_Hours(true);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Hours(false);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" Успешно!");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Menu_();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n Выберите пункт 1-3 \n");
                                            Console.ResetColor();
                                            Menu_Sort();
                                            break;
                                        }
                                }

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Выберите пункт 1-3 \n");
                                Console.ResetColor();
                                Menu_Sort();
                                break;
                            }
                            break;
                        }
                    case '6':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Введите пункт 1-6");
                            Console.ResetColor();
                            Menu_Sort();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Выберите пункт 1-6");
                Console.ResetColor();
                Menu_Sort();
            }
        }
        private void Menu_Add()
        {
            string name;
            ushort year=0;
            string department;
            string faculty;
            ushort hours=0;
            uint index=0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tДобавление элемента\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  1.");
            Console.ResetColor();
            Console.Write("В начало\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.WriteLine("В конец\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  3.");
            Console.ResetColor();
            Console.Write("В любое место\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню.\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите имя : ");
                            Console.ResetColor();
                            name = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите год : ");
                                Console.ResetColor();
                                year = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Год ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите факультет: ");
                            Console.ResetColor();
                            faculty = Console.ReadLine();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите кафедру : ");
                            Console.ResetColor();
                            department = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите часы : ");
                                Console.ResetColor();
                                hours = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Часы введены в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            AddFirst(name, year, faculty, department, hours);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_Add();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите имя : ");
                            Console.ResetColor();
                            name = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите год : ");
                                Console.ResetColor();
                                year = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Год ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите факультет: ");
                            Console.ResetColor();
                            faculty = Console.ReadLine();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите кафедру : ");
                            Console.ResetColor();
                            department = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите часы : ");
                                Console.ResetColor();
                                hours = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Часы введены в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            AddLast(name, year, faculty, department, hours);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_Add();
                            break;
                        }
                    case '3':
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите новый номер предмета (0 - начало, "+subjects.Length+" - конец): ");
                                Console.ResetColor();
                                index = Convert.ToUInt32(Console.ReadLine());
                                if (!(index >= 0 && index <= subjects.Length))
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n Нельзя выходить за рамки массива.");
                                    Console.ResetColor();
                                    Menu_Add();
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Номер ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите имя : ");
                            Console.ResetColor();
                            name = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите год : ");
                                Console.ResetColor();
                                year = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                            }
                            catch
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Год ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите факультет: ");
                            Console.ResetColor();
                            faculty = Console.ReadLine();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Введите кафедру : ");
                            Console.ResetColor();
                            department = Console.ReadLine();
                            Console.Clear();
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите часы : ");
                                Console.ResetColor();
                                hours = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Часы введены в неправильном формате.");
                                Console.ResetColor();
                                Menu_Add();
                            }
                            AddIndex(index,name, year, faculty, department, hours);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_Add();
                            break;
                        }
                    case '4':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Введите пункт 1-4");
                            Console.ResetColor();
                            Menu_Add();
                            break;
                        }
                }
    }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Введите пункт 1-4");
                Console.ResetColor();
                Menu_Add();
            }
        }
        private void Menu_Delete()
        {
            uint index;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\tУдаление элемента\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  1.");
            Console.ResetColor();
            Console.Write("Ввести номер\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                char select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\n Введите предмет для удаления(0-" + (subjects.Length - 1) + "): ");
                                Console.ResetColor();
                                index = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                                DeleteIndex(index);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(" Успешно!");
                                Console.ResetColor();
                                Menu_();
                            }
                            catch
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n Номер ввёден в неправильном формате, либо вы хотите удалить несуществующий предмет.");
                                Console.ResetColor();
                                Menu_Delete();
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Menu_();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Ошибка. Введите пункт 1-2.");
                            Console.ResetColor();
                            Menu_Delete();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Ошибка. Введите пункт 1-2.");
                Console.ResetColor();
                Menu_Delete();
            }
        }
        public void Menu_()         //Меню для взаимодействия.
        {
            byte select = new byte();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\tГлавное меню\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 1. ");
            Console.ResetColor();
            if (!created)
            {
                Console.Write("Создать массив\t\t");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Массив создан ("+subjects.Length+" эл.)\t");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 2. ");
            Console.ResetColor();
            Console.WriteLine("Вывод на экран\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 3. ");
            Console.ResetColor();
            Console.Write("Поиск\t\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 4. ");
            Console.ResetColor();
            Console.WriteLine("Сортировка\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 5. ");
            Console.ResetColor();
            Console.Write("Редактирование\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 6. ");
            Console.ResetColor();
            Console.WriteLine("Добавление элемента\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 7. ");
            Console.ResetColor();
            Console.Write("Удаление элемента\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 8. ");
            Console.ResetColor();
            Console.WriteLine("Запись в файл\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 9. ");
            Console.ResetColor();
            Console.Write("Освобождение памяти\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 10. ");
            Console.ResetColor();
            Console.WriteLine("Выход");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                select=Convert.ToByte(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n Выберите пункт 1-10 \n"); Menu_();
                Console.ResetColor();
            }
            switch (select)
            {
                case 1: {
                        if (!created)
                        {
                            Console.Clear();
                            Menu_Creation();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив уже создан. Освободите память для загрузки нового.\n");
                            Console.ResetColor();
                            Menu_();
                            break;
                        }
                    }
                case 2: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Show();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break; }
                case 3: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Searching();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 4: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Sort();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 5: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Edit();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 6: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Add();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 7: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_Delete();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 8: {
                        if (created)
                        {
                            Console.Clear();
                            Menu_File();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;

                    }
                case 9: {
                        if (created)
                        {
                            Console.Clear();
                            subjects = null;
                            created = false; GC.Collect();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" Успешно!");
                            Console.ResetColor();
                            Menu_(); break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n Массив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
                    }
                case 10:{
                        Environment.Exit(0);
                        break;
                    }
                default:{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n Выберите пункт 1-10 \n");
                        Console.ResetColor();
                        Menu_();
                        break;
                    }
            }
        }
    }
}
