using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class Employee
    {

        public int id
        {
            get;set;
        }
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public int salary
        {
            get; set;
        }


        public Employee(int id,string firstName,string lastName,int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        
        public Employee()
        {

        }
        public int getAnnualSalary()
        {
            return this.salary * 12;
        }
        public int rasieSalary(int percent)
        {
            return this.salary + this.salary * percent;
        }
        public void display()
        {
            Console.WriteLine("Employee[id={0},name={1} {2},salary={3}]", this.id, this.firstName, this.lastName, this.salary);
        }
        
    }
}
