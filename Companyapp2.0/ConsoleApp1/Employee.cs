using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        private int id;
        private string name;
        private double sal;
        public Employee()
        {

            this.id = 0;
            this.name = "";
            this.sal = 0.0;
        }

        public Employee(int id, String name, double sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Sal
        {
            get { return this.sal; }
            set { this.Sal = value; }
        }
        public override string ToString()
        {
            return " ID : " + id + " NAME :  " + name + " Salaray " + sal;

        }
    }
}
