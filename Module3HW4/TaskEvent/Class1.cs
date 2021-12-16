using System;

namespace Module3HW4.TaskEvent
{
   public class Class1
    {
        private Func<int, int, int> _sum;
        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Method_sum()
        {
            _sum += (x, y) => x + y;
            _sum += (x, y) => x + y;
            var res_sum = 0;
            var result = _sum.GetInvocationList();

            foreach (var item in result)
            {
                var sum = item.DynamicInvoke(1, 2);
                res_sum += (int)sum;
            }

            return res_sum;
        }
    }
}
