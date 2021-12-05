using System;

namespace algorithmsC10
{
    public class Polymorphism
    {
        public class Employee {
            public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
            {
                var salary = 40 * wage;
                Console.WriteLine("\nThis EMPLOYEE worked {0} hrs. "
                                    + "Paid for 40 hrs (no overtime) at $ {1}"
                                    + "/hr = ${2} \n", weeklyHours, wage, salary);
                Console.WriteLine("--------------------------------------------------------");

            }
        }

        public class Contractor : Employee
        {
            public override void CalculateWeeklySalary(int weeklyHours, int wage)
            {
                var salary = weeklyHours * wage;
                Console.WriteLine("\nThis CONTRACTOR worked {0} hrs. "
                                    + "Paid for 40 hrs (w/ overtime) at $ {1}"
                                    + "/hr = ${2} \n", weeklyHours, wage, salary);

            }

            private void test() { }
        }
    }
}