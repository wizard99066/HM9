namespace HW9_2
{
    internal class Program
    {/*Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.*/
        static void Main(string[] args)
        {
            int sum = 0;
            Random n = new Random();
            int r = n.Next(7, 100);
            int[] array = new int[r];
            Console.WriteLine("массив:");
            for (int i = 0; i < r; i++)
            {
                array[i] = n.Next(-100, 100);
                Console.Write($"{array[i]};");
            }
            Console.Write("\n сумма  значений");

            for (int i = 0; i < 3;)
            {
                int rand = n.Next(0, r);
                if (array[rand] != 100000)
                {
                    sum += array[rand];
                    Console.Write($"{array[rand]};");
                    array[rand] = 100000;
                    i++;

                }

            }
            Console.WriteLine($" сумма равна {sum}");
        }// скрин работающей программы https://i.postimg.cc/pXZm9vTt/2022-09-03-114400397.png

    }
}
