using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student_list = new List<Student>();
            Student gopu = new Student(1, "Gopu", 25);
            Student gannu = new Student(2, "Ganesh", 24);
            Student sworu = new Student(3, "Swaraj", 22);

            student_list.Add(gopu);
            student_list.Add(gannu);
            student_list.Add(sworu);

            Console.WriteLine("Student Details are as follows:");
            foreach (var student in student_list)
            {
                Console.WriteLine($"Id: {student.Id} , Name: {student.Name}, Age: {student.Age}");
            }

            // Using same student objects as dictionary value and id as dictionary keys as created above

            List<Dictionary<int, Student>> student_dict = new List<Dictionary<int, Student>>();
            for (int i = 0; i < student_list.Count; i++) { 
                student_dict.Add(new Dictionary<int, Student> { { student_list[i].Id, student_list[i] } });
            }
            Console.WriteLine("Student Details from Dictionary are as follows:");
            foreach (var dict in student_dict)
            {
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"Id: {kvp.Key} , Name: {kvp.Value.Name}, Age: {kvp.Value.Age}");
                }
            }
            // Creating dictionary with string key(ID,Name,Age) and string value as list of student details
            List<Dictionary<String, String>> student_dict_str = new List<Dictionary<String, String>>();
            for (int i = 0; i < student_list.Count; i++)
            {
                student_dict_str.Add(new Dictionary<String, String> { { "Id", student_list[i].Id.ToString() }, { "Name", student_list[i].Name }, { "Age", student_list[i].Age.ToString() } });
            }
            Console.WriteLine("Student Details from Dictionary with string key and value are as follows:");
            foreach (var dict in student_dict_str)
            {
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine();
            }

        }
    }
}
