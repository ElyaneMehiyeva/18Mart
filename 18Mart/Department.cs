using System;
using System.Collections.Generic;
using System.Text;

namespace _18Mart
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        public Employee[] Employees = new Employee[0];
        public void AddEmployee(Employee worker)
        {
            if (this.Employees.Length < this.EmployeeLimit )
            {
                if(worker.Salary < this.SalaryLimit)
                {
                    Array.Resize(ref this.Employees, this.Employees.Length + 1);
                    this.Employees[this.Employees.Length - 1] = worker;
                } else
                {
                    throw new Exception("Maas Limitini Kecib!");
                }
               
            }
            else
            {
                throw new Exception("Isci limiti kecdiniz!");
            }
        }
    }
}
