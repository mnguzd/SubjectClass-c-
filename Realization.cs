using System;
using System.Collections.Generic;
using System.IO;

namespace LabaN7
{
    abstract class Realization
    {
        private bool created = false;

        private Subject[] subjects = null;
        private string[] text = null;
        private protected void Show_Subject()   //Вывод всего массива
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private protected void Show_Subject(uint index)   //Перегрузка. Вывод предмета по индексу
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }

        }
        private protected void Sort_By_Name(bool x)
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private protected void Sort_By_Year(bool x)
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private protected void Sort_By_Faculty(bool x)
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private protected void Sort_By_Department(bool x)
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private protected void Sort_By_Hours(bool x)
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
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
        }
        private protected void Search_By_Hours(ushort hours)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Hours == hours)
                    {
                        Show_Subject(i);
                        flag = true;
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
        private protected void Search_By_Department(string department)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Department == department)
                    {
                        Show_Subject(i);
                        flag = true;
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
        private protected void Search_By_Faculty(string faculty)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Faculty == faculty)
                    {
                        Show_Subject(i);
                        flag = true;
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
        private protected void Search_By_Year(ushort year)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Year == year)
                    {
                        Show_Subject(i);
                        flag = true;
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
        private protected void Search_By_Name(string name)
        {
            if (created)
            {
                bool flag = false;
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Name == name)
                    {
                        Show_Subject(i);
                        flag = true;
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
        private protected void CreateAndFill(string path)
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
                    Console.WriteLine($"Ошибка. Файл должен содержать как минимум 5" +
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
                Console.WriteLine("\nВведён неверный формат или файла не существует.\n");
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
                Console.WriteLine("Строка " + (index * 5 + 1) + " должна иметь вид числа." + " Error: " + ex.Message); //Ошибка конвертации
            }
            subject[index].Faculty = text[index * 5 + 2];
            subject[index].Department = text[index * 5 + 3];
            try
            {
                subject[index].Hours = Convert.ToUInt16(text[index * 5 + 4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Строка " + (index * 5 + 4) + " должна иметь вид числа." + " Error: " + ex.Message); //Ошибка конвертации
            }
            
            
        }
        private void EditMenu(uint index){
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
            Console.Write("Действие: ");
            Console.ResetColor();
            try
            {
                byte selectededit = Convert.ToByte(Console.ReadLine());
                switch (selectededit)
                {
                    case 1: {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Введите новое имя: ");
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
                                Console.Write("Введите новый год: ");
                                Console.ResetColor();
                                subjects[index].Year = Convert.ToUInt16(Console.ReadLine());
                                Console.Clear();
                                EditMenu(index);
                                break;
                            }
                            catch{
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nГод ввёден в неправильном формате\n");
                                Console.ResetColor();
                                EditMenu(index);
                                break;
                            }

                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Введите новый факультет: ");
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
                            Console.Write("Введите новую кафедру: ");
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
                                Console.Write("Введите новое кол-во часов: ");
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
                                Console.WriteLine("\nКол-во часов введено в неправильном формате\n");
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
                Console.WriteLine("\nВведите пункт 1-6\n");
                Console.ResetColor();
                Menu_Edit();
            }
        }
        private void Menu_Edit()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nВведите предмет для редактирования(0-" + (subjects.Length - 1)+"): ");
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
                Console.WriteLine("\nВведите номер элемента от 0 до "+(subjects.Length-1));
                Console.ResetColor();
                Menu_();
            }


        }
        private void Menu_Creation()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите полный путь до файла : ");
            Console.ResetColor();
            string path = Console.ReadLine();
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
            Console.WriteLine("Вывести всё или отдельный предмет?\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t1.");
            Console.ResetColor();
            Console.Write("Всё\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2.");
            Console.ResetColor();
            Console.Write("Один");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t3.");
            Console.ResetColor();
            Console.WriteLine("Обратно в меню\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Действие: ");
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
                            Console.Write("\nВведите номер предмета, от 0 до " + (subjects.Length - 1)+": ");
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
                                    Console.WriteLine("\nВы вышли за границы.\n");
                                    Console.ResetColor();
                                    Menu_Show();
                                }

                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nВыберите 1, 2 или 3 пункт.\n");
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
                        Console.WriteLine("\nВыберите 1, 2 или 3 пункт.\n");
                        Console.ResetColor();
                        Menu_Show();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nВыберите 1, 2 или 3 пункт.\n");
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
            Console.Write("Действие: ");
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
                            Console.Write("\nВведите имя : ");
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
                                Console.Write("\nВведите год : ");
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
                                Console.WriteLine("\nГод ввёден в неправильном формате.");
                                Console.ResetColor();
                                Menu_Searching();
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\nВведите факультет :");
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
                            Console.Write("\nВведите специальность :");
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
                                Console.Write("\nВведите кол-во часов :");
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
                                Console.WriteLine("\nЧасы введены в неправильном формате.");
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
                            Console.WriteLine("\nВведите пункт 1-6");
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
                Console.WriteLine("\nВведите пункт 1-6");
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
            Console.Write("Действие: ");
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
                                            Sort_By_Name(true);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по возрастанию.\n");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Name(false);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по убыванию.\n");
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
                                            Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                            Sort_By_Year(true);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по возрастанию.\n");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Year(false);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по убыванию.\n");
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
                                            Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                                Sort_By_Faculty(true);
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("\n Отсортировано по возрастанию.\n");
                                                Console.ResetColor();
                                                Menu_();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Sort_By_Faculty(false);
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("\n Отсортировано по убыванию.\n");
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
                                                Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                    Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                            Sort_By_Department(true);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по возрастанию.\n");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Department(false);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по убыванию.\n");
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
                                            Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по возрастанию.\n");
                                            Console.ResetColor();
                                            Menu_();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Sort_By_Hours(false);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n Отсортировано по убыванию.\n");
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
                                            Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                                Console.WriteLine("\nВыберите пункт 1-3 \n");
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
                            Console.WriteLine("\nВведите пункт 1-6");
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
                Console.WriteLine("\nВыберите пункт 1-6");
                Console.ResetColor();
                Menu_Sort();
            }

        }
        private protected void Menu_()         //Меню для взаимодействия.
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
                Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.Write("Действие: ");
            Console.ResetColor();
            try
            {
                select=Convert.ToByte(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nВыберите пункт 1-10 \n"); Menu_();
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
                            Console.WriteLine("\nМассив уже создан. Освободите память для загрузки нового.\n");
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
                            Console.WriteLine("\nМассив предметов не был создан\n");
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
                            Console.WriteLine("\nМассив предметов не был создан\n");
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
                            Console.WriteLine("\nМассив предметов не был создан\n");
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
                            Console.WriteLine("\nМассив предметов не был создан\n");
                            Console.ResetColor();
                            Menu_();
                        }
                        break;
               


                        
                    }
                case 10:
                    {
                        for (int i = 0; i < subjects.Length; i++)
                        {
                            subjects[i].Department = null;
                            subjects[i].Faculty = null;
                            subjects[i].Name = null;
                            subjects[i] = null;
                        }

                        created = false; GC.Collect(); Menu_(); break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nВыберите пункт 1-10 \n");
                        Console.ResetColor();
                        Menu_();
                        break;
                    }
            }
        }




    }
}
