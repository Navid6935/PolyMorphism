using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    //کلاس کارمند
    public class Employee
    {
        public virtual void CalculateWeaklySalary(int weeklyHour, int wage)
        {
            //هر هفته 40 ساعت کار می کند
            // محاسبه حقوق در هفته
            var salary = 40 * wage;
            Console.WriteLine($"\n Angry Employee Worked {weeklyHour} hrs . Paid For 40 hrs at ${wage}/hr=${salary} \n");
            Console.WriteLine("----------------------------------------- \n");
        }
    }
    //کلاس کارفرما
    public class Contractor : Employee
    {
        public override void CalculateWeaklySalary(int weeklyHour, int wage)
        {
            //هر هفته 40 ساعت کار می کند
            // محاسبه حقوق در هفته
            var salary = weeklyHour * wage;
            Console.WriteLine($"\n This Happy Contractor Worked {weeklyHour} hrs . Paid For 40 hrs at ${wage}/hr=${salary} \n");
            Console.WriteLine("----------------------------------------- \n");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int hour = 55, wage = 70;
            List<Employee> employees = GetEmployees();

            foreach (var item in employees)
            {
                item.CalculateWeaklySalary(hour, wage);
            }
        }

        private static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            return new List<Employee> { someEmployee, someContractor };
        }
    }
}
