using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheri_Poly
{
    public class Inheri_Poly 
    {
        protected string ename;
        protected double basesal, gs, hra, ta, da, pf, total;
        protected int empid;
        private static int count;
        public Inheri_Poly(string ename, double basesal)
        {
            count++;
            this.empid = count;
            this.ename = ename;
            this.basesal = basesal;
        }
        public virtual void CalulateSalary()
        {
            hra = basesal * 0.40;
            ta = basesal * 0.20;
            da = basesal * 0.15;
            pf = basesal * 0.12;

            total = (hra + da + ta);

            gs = (hra + da + ta) - pf;
        }
        public override string ToString()
        {
            return $"name is {ename}\n id is {empid} \nbasic salary is {basesal}\n" +
                $"gross salary is {gs}";
        }
        
    }
    public class SalesManager : Inheri_Poly
    {
        private double comm;

        public SalesManager(string ename, double basesal, double comm) : base(ename, basesal)
        {
            this.comm = comm;
        }
        public override void CalulateSalary()
        {
            hra = basesal * 0.40;
            ta = basesal * 0.20;
            da = basesal * 0.15;
            pf = basesal * 0.12;

            total = (hra + da + ta + comm);

            gs = (total) - pf;
        }
        public override string ToString()
        {
            return $"\n\nname is {ename}\n id is {empid} \nbasic salary is {basesal}\ntotal salary {total}\n" +
                $"gross salary is {gs}";
        }
    }

    public class Ceo : Inheri_Poly
    {
        private double loss;

        public Ceo(string ename, double basesal, double loss) : base(ename, basesal)
        {
            this.loss = loss;
        }
        public override void CalulateSalary()
        {
            hra = basesal * 0.40;
            ta = basesal * 0.20;
            da = basesal * 0.15;
            pf = basesal * 0.12;

            total = (hra + da + ta);

            gs = (total) - pf - loss;
        }
        public override string ToString()
        {
            return $"\n\nname is {ename}\n id is {empid} \nbasic salary is {basesal}\ntotal salary {total}\n" +
                $"gross salary is {gs}";
        }
    }
}
