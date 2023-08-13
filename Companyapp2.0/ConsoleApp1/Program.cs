using ConsoleApp1;
using Dispatcher;
using System.Linq.Expressions;
Console.WriteLine("Welcome To IACSD");

bool flag = true;

List<Employee> employees = new List<Employee>();

while(flag)
{

    Console.WriteLine("1:Insert Manager 2:Insert SalesMan 3:Display 4:DeductProfessionalTax" +
        " 5 :DeductServiceTax 6:DeductIncomeTax 7:exit");
    int i = int.Parse(Console.ReadLine());
    switch (i)
    {
        case 1:
            Console.WriteLine(" id , name,  sal, bouns ");
            int id = int.Parse(Console.ReadLine());
            String n = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine());
            double bouns = double.Parse(Console.ReadLine());
            Manager m = new Manager(id, n, sal, bouns);
            employees.Add(m);
            break;
        case 2:
            Console.WriteLine(" id , name,  sal, Insentive ");
            int id1 = int.Parse(Console.ReadLine());
            String name1 = Console.ReadLine();
            double sal1 = double.Parse(Console.ReadLine());
            double insentive = double.Parse(Console.ReadLine());
            Salesman s = new Salesman(id1, name1, sal1, insentive);
            employees.Add(s);
            break;
       case 3:
            employees.ForEach(p => Console.WriteLine(p));
            break;
        case 4:
            Mydispatcher mydispatcher = new Mydispatcher(); 
            Console.WriteLine("Enter the Emp Id");
            int a = int.Parse(Console.ReadLine());
            Employee e=employees.FirstOrDefault(p => p.Id == a);
            mydispatcher b=new mydispatcher(mydispatcher.DeductProfessionalTax);
           // e.Sal=b(e.Sal);
           Console.WriteLine(b(e.Sal));
            e.Sal = b(e.Sal);
            break;
        case 5:
            Mydispatcher mydispatcher1 = new Mydispatcher();
            Console.WriteLine("Enter the Emp Id");
            int a1 = int.Parse(Console.ReadLine());
            Employee e1 = employees.FirstOrDefault(p => p.Id == a1);
            mydispatcher b1 = new mydispatcher(mydispatcher1.DeductServiceTax);
            //e1.Sal = b1(e1.Sal);
            Console.WriteLine(b1(e1.Sal));
            break;
        case 6:
            Mydispatcher mydispatcher2 = new Mydispatcher();
            Console.WriteLine("Enter the Emp Id");
            int a2 = int.Parse(Console.ReadLine());
            Employee e2 = employees.FirstOrDefault(p => p.Id == a2);
            mydispatcher b2 = new mydispatcher(mydispatcher2.DeductIncomeTax);
           // e2.Sal = b2(e2.Sal);
            Console.WriteLine(b2(e2.Sal));
            break;
        case 7:
            flag = false;
            break;
    }


}

