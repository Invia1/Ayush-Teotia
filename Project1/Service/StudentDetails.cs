using System;
using System.Collections.Generic;
using project1.Models;

namespace project1.Service
{
    internal class StudentDetails
    {
        List<Student> list = new List<Student>();
        public int CreateStudent(Student student)
        {
            list.Add(student);
            return 1;
        }
        public List<Student> GetList()
        {
            return list;
        }

        public void update(int id)
        {
            List<Student> students = GetList();
            try
            {
                foreach(Student stu in students)
                {
                    if (stu.Id == id)
                    {
                        stu.Id = id;
                        Console.WriteLine("enter the new name");
                        stu.Name = Console.ReadLine();
                        Console.WriteLine("enter the new class");
                        stu.address = Console.ReadLine();
                    }
                }
            }catch (Exception ex) { ex.ToString(); }
        }

        public void delete(int id)
        {
            List<Student> students = GetList();
            try
            {
                foreach(Student stu in students)
                {
                    if(stu.Id == id)
                    {
                        students.Remove(stu);
                    }
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void search(int id)
        {
            Student st = new Student();
            List<Student> students = GetList();
            try
            {
                foreach (Student stu in students)
                {
                    if (stu.Id == id)
                    {
                        Console.WriteLine("name : " + stu.Name);
                        Console.WriteLine("class name: " + stu.address);
                        break;
                    }

                }
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
    
