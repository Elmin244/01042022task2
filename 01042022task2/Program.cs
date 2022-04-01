using System;

namespace _01042022task2
{
    class Program
    {
        static void Main(string[] args)
        {
             
            List<int> listObj = new List<int>();
            listObj.Add(123);
            listObj.Add(235);
            Console.WriteLine("List Second Value: {0}", listObj[1]);
            Dictionary<int, string> Dic = new Dictionary<int, string>();
            Dic.Add(123, "Elmin");
            Console.WriteLine("Dictionary Value: {0}", obj[123]);
            Stack<int> Stackk = new Stack<int>();
            Stackk.Push(1);
            Stackk.Push(2);
            Stackk.Push(3);  
            Console.WriteLine("First {0}", Stackk.Pop());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("First{0}", queue.Dequeue());
            Console.WriteLine();
            Employee emp = new Employee();
            emp.ID = 1001;
            emp.Name = "Senan";
            emp.Address = "Baku";
            emp1 emp2 = new Employee();
            emp2.ID = 1002;
            emp2.Name = "Fatime";
            emp2.Address = "Sumqayit";
            
            List<Employee> EmpList = new List<Employee>();
            empList.Add(empObj1);
            empList.Add(emp2);
            foreach (Employee emp in EmpList)
            {
                Console.WriteLine(emp.ID);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Address);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    
}
