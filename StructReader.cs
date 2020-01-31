using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LabaN7
{
      class StructWork: InterfaceSubjectWork
    {
        public void Create(string path)  //Создание и заполнение класса
        {
            CreateAndFill(path);
        }
        public void Show()    //Вывод на экран
        {
            Show_Subject();
        }
        public void SearchByName(string name)  //Поиск по имени предмета
        {
            Search_By_Name(name);
        }
        public void SearchByYear(ushort year)   //Поиск по году 
        {
            Search_By_Year(year);
        }
        public void SearchByFaculty(string faculty) //Поиск по факультету
        {
            Search_By_Faculty(faculty);
        }
        public void SearchByDepartment(string department)  //Поиск по кафедре
        {
            Search_By_Department(department);
        }
        public void SearchByHours(ushort hours)  //Поиск по часам
        {
            Search_By_Hours(hours);
        }
        public void SortByName()  //Сортировка по имени в алфавитном порядке
        {
            Sort_By_Name();
        }
        

    }
}
