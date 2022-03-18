using System;
using System.Collections.Generic;
using System.Text;

namespace _18Mart
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (CheckCondition(value))
                {
                    this._name = value;
                }
            }
        }
        public string Surname
        {
            get { return this._surname; }
            set
            {
                if (CheckCondition(value))
                {
                    this._surname = value;
                }
            }
        }
        public double Salary
        {
            get { return this._salary; }
            set
            {
                if (value >= 250)
                {
                    this._salary = value;
                }
            }
        }
        public bool CheckCondition(string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && char.IsUpper(str[0]))
            {
                for(int i = 1; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
