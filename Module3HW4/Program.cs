using System;
using Module3HW4.TaskEvent;
using Module3HW4.TaskLinq;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var total_sum = 0;
            class1.TryCatch(() =>
            {
                total_sum = class1.Method_sum();
            });
            Console.WriteLine(total_sum);
            var res = new Starter();
            res.FillData();
        }
    }
}
