using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheri_Poly
{
    public  class Program
    {
        static void Main(string[] args)
        {

            //Inheritance and polymorphism
            Inheri_Poly e1 = new Inheri_Poly("sagar", 20000);
            e1.CalulateSalary();
            // Console.WriteLine(e1.PrintD());
            Console.WriteLine(e1.ToString());

            SalesManager sm1 = new SalesManager("don", 20000, 6500);
            sm1.CalulateSalary();
            Console.WriteLine(sm1);

            Ceo ceo = new Ceo("om", 30000, 5);
            ceo.CalulateSalary();
            Console.WriteLine(ceo);
        }
    }
}
