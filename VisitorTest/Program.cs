using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var general = new GeneralEmployee() { Name = "小王" };
            var mamger = new ManagerEmployee() { Name = "小名" };
            List<Employee> employees = new List<Employee>();
            employees.Add(general);
            employees.Add(mamger);

            var departMentA = new ConcreteDepartmentA();
            var departMentB = new ConcreteDepartmentB();

            foreach(var item in employees)
            {
                item.accept(departMentA);
                item.accept(departMentB);
            }

            Console.ReadLine();
        }
    }
}
