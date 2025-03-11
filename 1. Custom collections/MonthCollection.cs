using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Custom_collections
{
    class MonthCollection: IEnumerable<Month>
    {
        Month[] months =
        {
            new Month("January", 1, 31),
            new Month("February", 2, 28),
            new Month("March", 3, 31),
            new Month("April", 4, 30),
            new Month("May", 5, 31),
            new Month("June", 6, 30),
            new Month("July", 7, 31),
            new Month("August", 8, 31),
            new Month("September", 9, 30),
            new Month("October", 10, 31),
            new Month("November", 11, 30),
            new Month("December", 12, 31)
        };

        public IEnumerator<Month> GetEnumerator()
        {
            foreach (var month in months)
            {
                yield return month;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Month FindByNumber(int number)
        {
            return months.FirstOrDefault(m => m.Number == number);
        }

        public Month[] FindByDays(int days)
        {
            return months.Where(m => m.Days == days).ToArray();
        }
    }

    public record Month(string Name, int Number, int Days);
}
