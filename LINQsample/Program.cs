using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQsample
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{Name="Kajal",Salary=56000},
                new Employee{Name="Sameer",Salary=46000},
                new Employee{Name="Ajay",Salary=36000},
                new Employee{Name="Rashi",Salary=60000},
                new Employee{Name="Priya",Salary=79000},
            };
            //var result= from e in list
            //            select e;

            //var result = from e in list
            //             where e.Name.Contains("y")
            //             select e;
            //var result= from e in list
            //            where e.Salary>55000
            //            orderby e.Salary
            //            select e;
            //var result = from e in list
            //             where e.Salary > 55000
            //             orderby e.Salary descending
            //             select e;


            // using Lambda expression

            //var result = list.Where(x => x.Salary < 52000).ToList();

            //var result = list.Where(a => a.Salary > 35000).Where(a=>a.Salary<40000).OrderByDescending(x => x.Salary).ToList();

            var result = list.Where(a => a.Salary > 50000).OrderBy(x => x.Salary).ToList();

            foreach (Employee r in result)
            {
                Console.WriteLine("Name : "+r.Name + "  Salary : " + r.Salary);
            }


        }
    }
}
