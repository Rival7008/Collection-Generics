using System;
using System.Collections.Generic;

namespace Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee anton = new Employee(1, "Male", "Anton", 60000);
            Employee adam = new Employee(2, "Male", "Adam", 20000);
            Employee annie = new Employee(3, "Female", "Annie", 50000);
            Employee amanda = new Employee(4, "Female", "Amanda", 10000);
            Employee zigge = new Employee(5, "Male", "Zigge", 100);

            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(anton);
            employees.Push(adam);
            employees.Push(annie);
            employees.Push(amanda);
            employees.Push(zigge);

            Console.WriteLine("All employees in stack:");
            int Stack = employees.Count;
            foreach (var item in employees)
            {
                Stack--;
                Console.WriteLine(item);
                Console.WriteLine($"There are {Stack} employees left to list.\n");
            }
            Console.WriteLine("Pop all employees from stack:");
            while (employees.Count > 0)
            {
                Console.WriteLine(employees.Pop());
                Console.WriteLine($"There are {employees.Count} left to pop.\n");
            }


            employees.Push(anton);
            employees.Push(adam);
            employees.Push(annie);
            employees.Push(amanda);
            employees.Push(zigge);


            Console.WriteLine("Peek at the item at the top of the stack two times:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Employee at the top of the stack is:\n{employees.Peek()}\n" + $"There are {employees.Count} employees left in the stack\n");
            }


            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(anton);
            employeeList.Add(adam);
            employeeList.Add(annie);
            employeeList.Add(amanda);
            employeeList.Add(zigge);


            Employee checkEmployee = adam;
            Console.WriteLine((employeeList.Contains(checkEmployee)) ? $"{checkEmployee._name} exist in the list\n" : $"{checkEmployee._name} does not exist in the list\n");


            Console.WriteLine($"First male employee:\n {employeeList.Find(x => x._gender.Contains("Male"))}\n");


            List<Employee> maleList = employeeList.FindAll(x => x._gender.Contains("Male"));
            Console.WriteLine("All male employees:");
            foreach (var item in maleList)
            {
                Console.WriteLine($"{item}\n");
            }



            int checkId = 2;
            Console.WriteLine((employeeList.Exists(x => x._id == checkId)) ? $"Employee with Id {checkId} exists" : $"Employee with Id {checkId} does not exist");
        }
    }
}
