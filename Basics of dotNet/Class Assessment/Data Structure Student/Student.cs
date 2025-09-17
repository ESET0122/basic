using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            
        }
        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Age = 0;
        }
        
    }
}
