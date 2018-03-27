
using System;

namespace MoneyChange
{
    class MoneyChange
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var number = int.Parse(input);

            var diez = GetMoney(number, 10);
            number = number - diez * 10;
            var cinco = GetMoney(number , 5);
            number = number - cinco * 5;
            var uno = GetMoney(number, 1);

            Console.WriteLine(diez + cinco + uno);
            Console.ReadLine();
        }

        private static int GetMoney(int number, int moneyChange)
        {
            var moneyChangeCount = 0;
            var dif = number - moneyChange;
            moneyChangeCount++;
            if (number - moneyChange < 0)
            {
                return 0;
            }
            while (dif >= moneyChange && dif > 0)
            {
                
                dif = dif - moneyChange;
                moneyChangeCount++;
            }

            return moneyChangeCount;
        }
    }
}
