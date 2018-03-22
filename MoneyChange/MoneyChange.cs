
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
            var cinco = GetMoney(number - diez * 10, 5);
            var uno = GetMoney(number - cinco *5, 1);
            Console.WriteLine(diez + cinco + uno);
            Console.ReadLine();
        }

        private static int GetMoney(int number, int moneyChange)
        {
            var moneyChangeCount = 0;
            var dif = number - moneyChange;
            
            while (dif > moneyChange)
            {
                
                dif = dif - moneyChange;
                moneyChangeCount++;
            }

            return moneyChangeCount;
        }
    }
}
