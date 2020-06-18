using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InjenerLab5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addMoneyRub1000()
        {
            Wallet wallet = new Wallet();

            wallet.createWallet("RUB", 0);

            int expected = 1000;

            wallet.addMoney("RUB", 1000);

            int result = wallet.getCash("RUB");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void removeMoneyRub1000minus500()
        {
            Wallet wallet = new Wallet();

            wallet.createWallet("RUB", 1000);

            int expected = 500;

            wallet.removeMoney("RUB", 500);

            int result = wallet.getCash("RUB");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void getMoneyRUB1000()
        {
            Wallet wallet = new Wallet();

            wallet.createWallet("RUB", 1000);

            int expected = 1000;

            int result = wallet.getCash("RUB");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void toStringRUB1000()
        {
            Wallet wallet = new Wallet();

            wallet.createWallet("RUB", 1000);

            string expected = "Cодержание кошелька: { 1000 RUB }";

            string result = wallet.toString(); 

            Assert.AreEqual(expected, result);
        }


    }
}
