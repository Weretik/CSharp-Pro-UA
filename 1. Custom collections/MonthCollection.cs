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
            new Month("Січень", 1, 31),
            new Month("Лютий", 2, 28),
            new Month("Березень", 3, 31),
            new Month("Квітень", 4, 30),
            new Month("Травень", 5, 31),
            new Month("Червень", 6, 30),
            new Month("Липень", 7, 31),
            new Month("Серпень", 8, 31),
            new Month("Вересень", 9, 30),
            new Month("Жовтень", 10, 31),
            new Month("Листопад", 11, 30),
            new Month("Грудень", 12, 31)
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
