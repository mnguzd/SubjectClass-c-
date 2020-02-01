using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace LabaN7
{
    abstract class Realization
    {
        private bool created = false;
        private Subject[] subjects = null;
        private string[] text = null;
        private protected void Show_Subject()
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
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private protected void Show_Subject(uint index)
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
        private protected void Sort_By_Name()
        {
            if (created)
            {
                for (int i = 0; i < subjects.Length; i++)
                    for (int g = i + 1; g < subjects.Length; g++)
                        if (subjects[i].Name.CompareTo(subjects[g].Name) > 0)
                        {
                            var temp = subjects[i];
                            subjects[i] = subjects[g];
                            subjects[g] = temp;
                        }
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private protected void Search_By_Hours(ushort hours)
        {
            if (created)
            {
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Hours == hours)
                        Show_Subject(i);
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private protected void Search_By_Department(string department)
        {
            if (created)
            {
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Department == department)
                        Show_Subject(i);
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
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Faculty == faculty)
                        Show_Subject(i);
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
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Year == year)
                        Show_Subject(i);
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
                for (uint i = 0; i < subjects.Length; i++)
                    if (subjects[i].Name == name)
                        Show_Subject(i);
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан, используйте метод .Create()");
            }
        }
        private protected void CreateAndFill(string path)
        {
            using (StreamReader str = new StreamReader(path))   //Поток для чтения файла 
            {
                var list = new List<string>(); //Список строк файла
                while (!str.EndOfStream)
                    list.Add(str.ReadLine());
                text = list.ToArray(); //Из списка делается массив строк
                if (text.Length > 0 && text.Length % 5 == 0)
                {
                    subjects = new Subject[text.Length / 5];
                    created = true;
                    for (int i = 0; i < subjects.Length; i++)
                        Fill(subjects, text, i);  // Вызов метода Fill() заполнения объекта данными
                }
                else
                {
                    Console.WriteLine($"Ошибка. Файл должен содержать как минимум 5" +
                        " строк для каждого из полей структуры,а в вашем файле " + text.Length + " строк(и).");
                    list.Clear();
                    text = null;
                }
            }
        }
        private void Fill(Subject[] subject, string[] text, int index) //Заполнение объекта данными из массива строк(файла)
        {
            subject[index] = new Subject();
            subject[index].Name = text[index * 5];
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
        private protected void Edit_(uint index)
        {
            if (created && index >= 0 && index < subjects.Length)
            {
                EditMenu(index);
                int x;
                bool Cycle = true;
                try
                {
                    char cycle = Convert.ToChar(Console.ReadLine());
                    while (cycle != '0' && Cycle)
                    {
                        switch (cycle)
                        {
                            case '1':
                                Console.Write("Введите новое имя: ");
                                subjects[index].Name = Console.ReadLine();
                                EditMenu(index); break;
                            case '2':
                                Console.Write("Введите новый год: ");
                                try
                                {
                                    subjects[index].Year = Convert.ToUInt16(Console.ReadLine());
                                    EditMenu(index);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка. Введите число. " + ex.Message);
                                    Cycle = false;
                                }
                                break;
                            case '3':
                                Console.Write("Введите новый факультет: ");
                                subjects[index].Faculty = Console.ReadLine();
                                EditMenu(index);
                                break;
                            case '4':
                                Console.Write("Введите новую кафедру: ");
                                subjects[index].Department = Console.ReadLine();
                                EditMenu(index);
                                break;
                            case '5':
                                Console.Write("Введите новые часы: ");
                                try
                                {
                                    subjects[index].Hours = Convert.ToUInt16(Console.ReadLine());
                                    EditMenu(index);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка. Введите число. " + ex.Message);
                                    Cycle = false;
                                }
                                break;
                            case '0': Environment.Exit(0); break;
                            default:
                                Console.WriteLine("Ошибка. Введите цифру 0-5");
                                Cycle = false; break;
                        }
                        cycle = Convert.ToChar(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка .Введите цифру 0-5");
                }
            }
            else
            {
                Console.WriteLine("Массив предметов не был создан или вы выбрали неправильный индекс.");
            }
        }
        private void EditMenu(uint index){
            Console.WriteLine("\tРедактирование");
            Console.WriteLine("--------------------------------");
            Show_Subject(index);
            Console.WriteLine(" 1.  Имя");
            Console.WriteLine(" 2.  Год");
            Console.WriteLine(" 3.  Факультет");
            Console.WriteLine(" 4.  Кафедра");
            Console.WriteLine(" 5.  Часы");
            Console.WriteLine(" 0.  Выйти");
            Console.Write("Выберите команду:");
        }



    }
}
