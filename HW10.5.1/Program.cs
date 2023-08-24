using System;


namespace HW10._5._1
{
    class Program
    {

        public static void Main(string[] args)
        {
            Summ summ = new Summ(Reader.Read(), Reader.Read());
            if (summ.X == 0 || summ.Y == 0)
                Console.WriteLine("Рассчитать сумму невозможно");
            else
                Console.WriteLine($"Результат сложения: {summ.Sum(summ.X, summ.Y)}");

        }
    }
}