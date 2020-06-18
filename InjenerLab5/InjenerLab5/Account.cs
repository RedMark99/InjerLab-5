using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    public class Account
    {
        internal String Currency;
        int Value;

        public Account(String Currency, int Value)
        {
            this.Currency = Currency;
            this.Value = Value;
        }

        public void addMoney(int value) 
        {
            this.Value += value;
        }

        public void removeMoney(int value)
        {
            if (this.Value > value)
            {
                this.Value -= value;
            }
            else 
            {
                Console.WriteLine("Недостаточно средств на счете");
            }
        }

        public int getValue() 
        {
            return this.Value;
        }

    }
}
