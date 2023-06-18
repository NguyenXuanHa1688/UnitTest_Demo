using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Demo.BankAccount;

namespace MSTest.Bank_Test
{
    [TestClass]
    public class Bank_MSTest
    {
        private BankAccount bankAccount;
        
        [TestInitialize]
        public void Setup()
        {
            bankAccount = new(new Logger());
        }
        [TestMethod]
        public void Deposite_AddValidMoney_ReturnTrue()
        {
            var result = bankAccount.Deposite(100);
            result.Should().BeTrue();
        }
        [DataTestMethod]
        [DataRow(200, 100)]
        [DataRow(150, 50)]
        public void Withdraw_Withdraw100whenBalance200_ReturnTrue(int balance, int withdraw)
        {
            var logMock = new Mock<ILogger>();
            logMock.Setup(x => x.LogToDB(It.IsAny<string>())).Returns(true);
            logMock.Setup(x => x.LogBalanceAfterWithdraw(It.Is<int>(x => x > 0))).Returns(true);

            bankAccount = new BankAccount(logMock.Object);
            //bankAccount.Deposite(balance);
            bankAccount.balance = balance;  

            var result = bankAccount.Withdraw(withdraw);
            result.Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow(100, 200)]
        [DataRow(50, 350)]
        public void Withdraw_Withdraw200whenBalance100_ReturnFalse(int balance, int withdraw)
        {
            var logMock = new Mock<ILogger>();
            logMock.Setup(x => x.LogToDB(It.IsAny<string>())).Returns(true);
            logMock.Setup(x => x.LogBalanceAfterWithdraw(It.Is<int>(x => x > 0))).Returns(true);

            bankAccount = new BankAccount(logMock.Object);
            bankAccount.balance = balance;

            var result = bankAccount.Withdraw(withdraw);
            result.Should().BeFalse();
        }
    }
}
