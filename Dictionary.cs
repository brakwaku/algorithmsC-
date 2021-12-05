using System;
using System.Collections.Generic;

namespace algorithmsC7
{
    public class Employee
    {
        public string name { get; set; }
        public int id { get; set; }
        public string department { get; set; }

        public Employee(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }

    }

    public class CustomDictionary
    {
        public static void displayFreqOfEachElement(int[] arr)
        {
            Dictionary<int, int> freqDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                {
                    freqDictionary[arr[i]]++;
                }
                else
                {
                    freqDictionary[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in freqDictionary)
            {
                Console.WriteLine(x.Key + " -> " + x.Value);
            }
        }
        public static void supposedFx3()
        {
            Employee employee = new Employee("Rob", 2234, "Electronics");
            Employee employee2 = new Employee("Tom", 2343, "Clothes");
            Employee employee3 = new Employee("Rob", 2235, "Babies");

            Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
            employeeById.Add(employee.id, employee);
            employeeById.Add(employee2.id, employee2);
            employeeById.Add(employee3.id, employee3);

            Employee e;
            if (employeeById.TryGetValue(2343, out e))
            {
                Console.WriteLine(e.name + " : " + e.department);
            }
        }
    }

}