using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<Department> departmens = new List<Department>();

            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                List<string> employeeInfo = Console.ReadLine().Split(' ').ToList();

                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];
                int position = -1;

                Employee newEmployee = new Employee(name, salary);

                for (int j =0; j<departmens.Count; j++)
                {
                    if(department == departmens[j].Name)
                    {
                        position = j;
                    }
                }

                if (position < 0)
                {
                    departmens.Add(new Department(department));
                    departmens[departmens.Count - 1].EmployeesInDepartment.Add(newEmployee);
                }
                else
                {
                    departmens[position].EmployeesInDepartment.Add(newEmployee);
                }
            }

            double maxAverageSalary = -1;
            string maxAverageSalaryDepartment = "";

            foreach (Department dep in departmens)
            {
                double sumSalary = dep.EmployeesInDepartment.Sum(select => select.Salary);
                double averageSalary = sumSalary / dep.EmployeesInDepartment.Count;

                if (maxAverageSalary < averageSalary)
                {
                    maxAverageSalary = averageSalary;
                    maxAverageSalaryDepartment = dep.Name;
                }
            }

            for (int a = 0; a < departmens.Count; a++)
            {
                if (departmens[a].Name == maxAverageSalaryDepartment)
                {
                    Console.WriteLine($"Highest Average Salary: {departmens[a].Name}");

                    List<Employee> orderedEmployee = departmens[a].EmployeesInDepartment
                        .OrderByDescending(order => order.Salary).ToList();

                    foreach (Employee empl in orderedEmployee)
                    {
                        Console.WriteLine($"{empl.Name} {empl.Salary:F2}");
                    }
                }
            }
        }   
    }

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }

    class Department
    {
        public List<Employee> EmployeesInDepartment { get; set; }

        public string Name { get; set; }

        public Department(string name)
        {
            this.Name = name;
            EmployeesInDepartment = new List<Employee>();
        }
    }
}
