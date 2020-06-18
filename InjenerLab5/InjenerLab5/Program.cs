using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            Bank bank = new Bank();
            wallet.createWallet("RUB", 1000);
            wallet.getMoney("RUB");

            Console.WriteLine("-----------------------------");
            wallet.createWallet("USD", 100);
            wallet.createWallet("EUR", 100);
            wallet.addMoney("USD", 100);
            wallet.removeMoney("RUB", 100);
            wallet.getMoney("RUB");
            wallet.getMoney("USD");
            wallet.toString();
            Console.ReadLine();
            Console.WriteLine("-----------------------------");
            wallet.getTotalMoney("RUB");
            wallet.Convert(200, "EUR", "RUB");
            Console.ReadLine();
            Console.WriteLine("-----------------------------");
            wallet.print();
            Console.ReadLine();
            Console.WriteLine("-----------------------------");
            wallet.print("Счёт RUB пополнен: ", 20);
            Console.ReadLine();


        }
    }
}
