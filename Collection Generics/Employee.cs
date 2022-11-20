using System;

namespace Collection_Generics
{
    internal class Employee
    {
        internal int _id { get; set;}
        internal string _gender { get; set; }
        internal string _name { get; set; }
        internal decimal _salary { get; set; }

        public Employee(int id, string gender, string name, decimal salary)
        {
            _id = id;
            _gender = gender;
            _name = name;
            _salary = salary;
        }

        public override string ToString()
        {
            return $"Id : {_id}\nName : {_name}\nGender : {_gender}\nSalary : {_salary}";
        }
    }
}
