using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    public class MoneyPrinter
    {
        List<History> history = new List<History>();

        public MoneyPrinter()
        {
        }

        public void addHistory(String operation, int Amount) 
        {
            history.Add(new History(operation, DateTime.Now, Amount));
        }

        public void print() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("История:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < history.Count(); i++) 
            {
                Console.WriteLine("Операция: " + history[i].Operation + " Дата: " + history[i].Date + " на сумму: " + history[i].Amount.ToString());
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("История закончина");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void print(String operation, int amount)
        {
            int count = amount;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("История:");
            Console.ForegroundColor = ConsoleColor.Magenta;

            if (amount > count) 
            {
                count = history.Count();
            }

            for (int i = 0; i < history.Count(); i++)
            {
                if(operation == history[i].Operation)
                    Console.WriteLine("Операция: " + history[i].Operation + " Дата: " + history[i].Date + " на сумму: " + history[i].Amount.ToString());
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("История закончина");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
