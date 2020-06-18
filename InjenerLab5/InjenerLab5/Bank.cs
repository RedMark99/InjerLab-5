using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjenerLab5
{
    public class Bank
    {
        double USDToRUB = 60.3;
        double EURToRUB = 68.3;

        double RUBToUSD = 0.014;
        double EURToUSD = 1.13;

        double USDToEUR = 0.89;
        double RUBToEUR = 0.01;


        double anyToAny = 5.5;
          
        Random rnd = new Random();


        internal bool check = true;

        public double getTotalMoney(string InCurrency, string OutCurrency, int value)
        {
            double sum = 0;

            if (InCurrency == "RUB")
            {
                if (OutCurrency == "EUR")
                    sum = value * EURToRUB;
                else if (OutCurrency == "USD")
                    sum = value * USDToRUB;
                else
                    sum = value * anyToAny;
            }

            else if (InCurrency == "USD")
            {
                if (OutCurrency == "EUR")
                    sum = value * EURToUSD;
                else if (OutCurrency == "RUB")
                    sum = value * RUBToUSD;
                else
                    sum = value * anyToAny;
            }

            else if (InCurrency == "EUR")
            {
                if (OutCurrency == "RUB")
                    sum = value * RUBToEUR;
                else if (OutCurrency == "USD")
                    sum = value * USDToEUR;
                else
                    sum = value * anyToAny;
            }

            else 
            {
                Console.WriteLine("Выберите другую валюту для возвращения");
                sum = 0;
                check = false;
                return sum;
            }

            return sum;
        }

        public double Convert(string InCurrency, string OutCurrency, int value)
        {
            double sum = 0;

            if (InCurrency == "RUB")
            {
                if (OutCurrency == "EUR")
                    sum = value * (EURToRUB * (rnd.NextDouble() + 0.1));
                else if (OutCurrency == "USD")
                    sum = value * (USDToRUB * (rnd.NextDouble() + 0.1));
                else
                    sum = value * (anyToAny * (rnd.NextDouble() + 0.1));
            }

            else if (InCurrency == "USD")
            {
                if (OutCurrency == "EUR")
                    sum = value * (EURToUSD * (rnd.NextDouble() + 0.1));
                else if (OutCurrency == "RUB")
                    sum = value * (RUBToUSD * (rnd.NextDouble() + 0.1));
                else
                    sum = value * (anyToAny * (rnd.NextDouble() + 0.1));
            }

            else if (InCurrency == "EUR")
            {
                if (OutCurrency == "RUB")
                    sum = value * (RUBToEUR * (rnd.NextDouble() + 0.1));
                else if (OutCurrency == "USD")
                    sum = value * (USDToEUR * (rnd.NextDouble() + 0.1));
                else
                    sum = value * (anyToAny * (rnd.NextDouble() + 0.1));
            }

            else
            {
                sum = value * anyToAny;
            }

            return sum;
        }
    }
}
