using System;
using System.Collections.Generic;
using System.IO;

namespace LabaN7
{
    abstract class InterfaceSubjectWork
    {
        private Subject[] subjects = null;
        private string[] text = null;
        private protected void Show_Subject()
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
        private protected void Show_Subject(int index)
        {
            Console.WriteLine("\tПредмет № " + index + ":\n");
            Console.WriteLine("\tНазвание: " + subjects[index].Name);
            Console.WriteLine("\tГод обучения: " + subjects[index].Year);
            Console.WriteLine("\tФакультет: " + subjects[index].Faculty);
            Console.WriteLine("\tКафедра: " + subjects[index].Department);
            Console.WriteLine("\tКол-во часов: " + subjects[index].Hours);
            Console.WriteLine("--------------------------------");

        }
        private protected void Sort_By_Name()
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
        private protected void Search_By_Hours(ushort hours)
        {
            for (int i = 0; i < subjects.Length; i++)
                if (subjects[i].Hours == hours)
                    Show_Subject(i);
        }
        private protected void Search_By_Department(string department)
        {
            for (int i = 0; i < subjects.Length; i++)
                if (subjects[i].Department == department)
                    Show_Subject(i);
        }
        private protected void Search_By_Faculty(string faculty)
        {
            for (int i = 0; i < subjects.Length; i++)
                if (subjects[i].Faculty == faculty)
                    Show_Subject(i);
        }
        private protected void Search_By_Year(ushort year)
        {
            for (int i = 0; i < subjects.Length; i++)
                if (subjects[i].Year == year)
                    Show_Subject(i);
        }
        private protected void Search_By_Name(string name)
        {
            for (int i = 0; i < subjects.Length; i++)
                if (subjects[i].Name == name)
                    Show_Subject(i);
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
                    for (int i = 0; i < subjects.Length; i++)
                        Fill(subjects, text, i);  // Вызов метода Fill() заполнения объекта данными
                }
                else
                    Console.WriteLine($"Ошибка. Файл должен содержать как минимум 5" +
                        " строк для каждого из полей структуры,а в вашем файле " + text.Length + " строк(и).");
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


    }
}
