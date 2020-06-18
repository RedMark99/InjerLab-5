using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    public class Wallet
    {
        List<Account> walletAccount = new List<Account> ();
        Account acc;
        Bank bank = new Bank();
        MoneyPrinter money = new MoneyPrinter();

        public void createWallet(String Currency, int Value) 
        {
            walletAccount.Add(new Account(Currency, Value));
            money.addHistory("Создан счёт: " + Currency, 0);
        }

        public void addMoney(String Currency, int Value)
        {
            for(int i = 0; i < walletAccount.Count(); i++) 
            {
                int count = 0;
                if (walletAccount[i].Currency == Currency) 
                {
                    walletAccount[i].addMoney(Value);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Пополенен кошелёк: " + Currency + " на сумму: " + Value.ToString());
                    money.addHistory("Счёт " + Currency + " пополнен: ", Value);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Currency + ": 0, такого счёта нету заберите деньги");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    count++;
                }
            }
        }

        public void removeMoney(String Currency, int Value)
        {
            int count = 0;
            for (int i = 0; i < walletAccount.Count(); i++)
            {
                if (walletAccount[i].Currency == Currency)
                {
                    walletAccount[i].removeMoney(Value);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Списано с счёта: " + Currency + " на сумму: " + Value.ToString());
                    money.addHistory("С счёта " + Currency + " списано: ", Value);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (count > 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Currency + ":" + Value.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    count++;
                }
            }
        }

        public void getMoney(String Currency)
        {
            int count = 0;
            for (int i = 0; i < walletAccount.Count(); i++)
            {
                if (walletAccount[i].Currency == Currency)
                {
                    walletAccount[i].getValue();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Баланс " + Currency + " счёта: " + walletAccount[i].getValue());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (count > walletAccount.Count() - 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Баланс " + Currency + " счёта: 0");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    count++;
                }
            }
        }

        public int getCash(String Currency) 
        {

            int count = 0;
            for (int i = 0; i < walletAccount.Count(); i++)
            {
                if (walletAccount[i].Currency == Currency)
                {
                    walletAccount[i].getValue();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Баланс " + Currency + " счёта: " + walletAccount[i].getValue());
                    Console.ForegroundColor = ConsoleColor.White;
                    return walletAccount[i].getValue();
                }
            }

            return 0;
            
        }

        public string toString()
        {
            int count = 0;
            Console.ForegroundColor = ConsoleColor.Magenta;
            string writter = "Cодержание кошелька: { ";
            Console.Write("Cодержание кошелька: { ");
            for (int i = 0; i < walletAccount.Count(); i++)
            {
                if (i < walletAccount.Count() - 1)
                {
                    Console.Write(walletAccount[i].getValue() + " " + walletAccount[i].Currency + ", ");
                    writter += walletAccount[i].getValue() + " " + walletAccount[i].Currency + ", ";
                }
                else
                {
                    Console.Write(walletAccount[i].getValue() + " " + walletAccount[i].Currency);
                    writter += walletAccount[i].getValue() + " " + walletAccount[i].Currency;
                }
            }
            Console.Write(" }");
            writter += " }";
            Console.ForegroundColor = ConsoleColor.White;
            return writter;
        }

        public void getTotalMoney(String Currency)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            double sum = 0;
            for (int i = 0; i < walletAccount.Count(); i++)
            {
                if (walletAccount[i].Currency != Currency)
                    sum += bank.getTotalMoney(Currency, walletAccount[i].Currency, walletAccount[i].getValue());
                else if (walletAccount[i].Currency == Currency)
                    sum += walletAccount[i].getValue();
            }
            Console.WriteLine("Общий баланс всех счетов в валюте: " + Currency + " Составляет: " + sum);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Convert(int value, string Currency, string Currency2)
        {
            double sum = 0;
            sum += bank.Convert(Currency, Currency2, value);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Перевод в валюту: " + Currency + " Составляет: " + sum);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void print() 
        {
            money.print();
        }

        public void print(string operation, int amount)
        {
            money.print(operation, amount);
        }
    }
}
