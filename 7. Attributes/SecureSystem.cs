using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Attributes
{
    class SecureSystem
    {
        private const int RequiredAccessLevel = 1;

        public static void CheckAccessLevel(Employee employee)
        {
            Type type = employee.GetType();

            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                if (attribute is AccessLevelAttribute)
                {
                    AccessLevelAttribute accessLevelAttribute = (AccessLevelAttribute)attribute;
                    Console.WriteLine($"{type.Name} має рівень доступу {accessLevelAttribute.Level}");


                    if (accessLevelAttribute.Level > RequiredAccessLevel)
                    {
                        Console.WriteLine($"Доступ заборонено для {type.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Доступ дозволено для {type.Name}");
                    }
                }
            }

        }
    }

    abstract class Employee
    {
    }

    [AccessLevel(2)]
    class Manager : Employee
    {
    }

    [AccessLevel(1)]
    class Director : Employee
    {
    }

    [AccessLevel(1)]
    class Programer : Employee
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class AccessLevelAttribute : Attribute
    {
        public int Level { get; }
        public AccessLevelAttribute(int level)
        {
            Level = level;
        }
    }

   
}
