using System;

namespace _18Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmer : Elyane Mehiyeva\n");

            Department company = new Department()
            {
                Name = "UDEMY",
                EmployeeLimit = 2,
                SalaryLimit = 5000
            };
            Employee worker1 = new Employee()
            {
                Name = "Subhan",
                Surname = "Mehiyev",
                Salary = 3500
            };
            Employee worker2 = new Employee()
            {
                Name = "Elyane",
                Surname = "Mehiyeva",
                Salary = 7000
            };
            Employee worker3 = new Employee()
            {
                Name = "Ehtiram",
                Surname = "Mehiyev",
                Salary= 2000
            };
            Employee worker4 = new Employee()
            {
                Name = "Onur",
                Surname = "Rahimli",
                Salary = 6000
            };
            Employee[] workerArray = { worker1, worker2, worker3, worker4 };

            foreach (Employee worker in workerArray)
            {
                try
                {
                    company.AddEmployee(worker);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach(Employee worker in company.Employees)
            {
                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine($"Worker Name : {worker.Name}\nWorker Surname : {worker.Surname}\nWorker Salary : {worker.Salary}");
                
            }
        }
    }
}
