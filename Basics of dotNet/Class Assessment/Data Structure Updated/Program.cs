namespace DataStructureUpdated
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Console.WriteLine("\nDictionary demo \n");
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id);
                Console.WriteLine(student.Value.name);
                Console.WriteLine(student.Value.marks);
            }


            //Hashset Example
            Console.WriteLine("\nHashset demo \n");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);
                Console.WriteLine(student.marks);
            }


            //StackDemo
            Console.WriteLine("\nStack demo \n");

            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            while(students_stack.Count!=0)
            {
                Student pop_stack = students_stack.Pop();
                Console.WriteLine(pop_stack.id);
                Console.WriteLine(pop_stack.name);
                Console.WriteLine(pop_stack.marks);
            }
            


            //Queue demo
            Console.WriteLine("\nQueue demo\n");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            while (students_queue.Count != 0)
            {
                Student popQueue = students_queue.Dequeue();
                Console.WriteLine(popQueue.id);
                Console.WriteLine(popQueue.name);
                Console.WriteLine(popQueue.marks);
            }

            // Linked List Demo

            Console.WriteLine("\nLinked List demo \n");
            LinkedList<Student> students_linkedlist = new LinkedList<Student>();
            students_linkedlist.AddLast(first);
            students_linkedlist.AddLast(second);
            students_linkedlist.AddLast(third);
            foreach (Student student in students_linkedlist)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);
                Console.WriteLine(student.marks);
            }

            // Tuple Demo
            Console.WriteLine("\nTuple demo \n");
            
            List<Tuple<int, string, int>> students_tuple = new List<Tuple<int, string, int>>();
            students_tuple.Add(new Tuple<int, string, int>(1, "Alice", 10));
            students_tuple.Add(new Tuple<int, string, int>(2, "Bob", 90));
            students_tuple.Add(new Tuple<int, string, int>(3, "Charlie", 78));

            foreach (var student in students_tuple)
            {
                Console.WriteLine(student.Item1);
                Console.WriteLine(student.Item2);
                Console.WriteLine(student.Item3);
            }



        }
    }
}

