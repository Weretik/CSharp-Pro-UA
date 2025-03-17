using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Attributes
{
    class MyClass
    {
        [Obsolete("\"OldMethod\" не актуальний метод, використовуй замість нього метод \"NewMethod\"")]
        public void OldMethod() => Console.WriteLine("Старий неактуальний метод");

        public void NewMethod() => Console.WriteLine("Новий та актуальний метод");

        [Obsolete("\"DeprecatedMethod\" метод заборонено використовувати", true)]
        public void DeprecatedMethod() => Console.WriteLine("Цей метод взагалі не можна використовувати.");
    }
}
