using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Kelly", 10000);

            // Test for a negative balance
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000,
                    DateTime.Now,
                    "Attempt to overdraw")
            );
        }

        [Fact]
        public void Test3()
        {
            // Test that the initial balances must be positive
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("ivalid", 55)
            );
        }
    }
}