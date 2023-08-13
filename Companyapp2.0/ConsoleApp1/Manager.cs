using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dispatcher;

namespace ConsoleApp1
{
    public class Manager :Employee  //, Mydispatcher
    {
        public double bouns;

        public Manager():base()
        {
            this.bouns = 0;
        }
        public Manager( int id, String name, double sal,double bouns):base(id,name,sal)
        {
            this.bouns = bouns;
        }

        public double Bouns
        {
            get { return this.bouns; }
            set { this.bouns = value; }
        }

        public override string ToString()
        {
            String data = base.ToString();
            return data + " Bouns " + bouns;
        }

/*
       public void DeductIncomeTax(double amount)
        {
            base.Sal = Sal - 0.90*amount;
            Console.WriteLine("10% income tax is deducted from your account");

        }
        public void DeductServiceTax(double amount)
        {
            base.Sal = Sal - 0.80*amount;
            Console.WriteLine("20% income tax is deducted from your account");
        }
        public double DeductProfessionalTax(double amount)
        {
            this.Sal = this.Sal +this.bouns+amount;
            Console.WriteLine(" Bouns Is Applied "+bouns);
            return Sal;
        }*/
    }
}