using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispatcher;


namespace ConsoleApp1
{

    public class Salesman : Employee  //,Mydispatcher
    {
        public double insentive;

        public Salesman():base()
        {
            this.insentive = 0;
        }
        public Salesman(int id, String name, double sal,double insentive):base(id, name, sal)
        {
            this.insentive = insentive;
        }

        public double Insentive
        {
            get { return this.insentive; }
            set { this.insentive = value;}
        }

        public override string ToString()
        {
            String data = base.ToString();
            return data + " Bouns " + insentive;
        }

/*
        public void DeductIncomeTax(double amount)
        {
            base.Sal = Sal - 0.90 * amount;
            Console.WriteLine("10% income tax is deducted from your account");

        }
        public void DeductServiceTax(double amount)
        {
            base.Sal = Sal - 0.80 * amount;
            Console.WriteLine("20% income tax is deducted from your account");
        }
        public double DeductProfessionalTax(double amount)
        {
            this.Sal = this.Sal + this.insentive + amount;
            Console.WriteLine(" Bouns Is Applied " + insentive);
            return Sal;
        }*/
    }
}

