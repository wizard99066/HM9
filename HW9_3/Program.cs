namespace HW9_3
{
    internal class Program
    {/*You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?*/
        public static int ClimbStairs(int n)
        {
            int y = 1;
            int result = 1;
            int z = 1;
            for (var i = 1; i < n; i++)
            {
                z = result;
                result += y;
                y = z;
            }
            return result;
            //Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Random n = new Random();
            int r = n.Next(3, 100); // кол-во ступенек
            Console.WriteLine($"кол-во ступенек {r}");
            int n2 = ClimbStairs(r);
            Console.WriteLine($"возможные комбинации {n2}");
            Console.ReadKey();
        } // https://i.postimg.cc/5NcqVL7k/2022-09-03-120824258.png    скрин работающей программы
    }
}