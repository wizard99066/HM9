namespace HM9
{
    internal class Program
    {//Reverse String
        static void Main(string[] args)
        {
                        
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                char[] str1 = str.ToCharArray();
                Array.Reverse(str1);
                str = new string(str1);
                Console.WriteLine(str);

            //https://i.postimg.cc/FsKPq9wP/2022-09-03-114030798.png    скрин программы
        }
    }
}