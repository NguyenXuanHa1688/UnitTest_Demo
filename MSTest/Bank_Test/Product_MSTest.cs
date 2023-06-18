using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Demo.BankAccount;

namespace MSTest.Bank_Test
{
    [TestClass]
    public class Product_MSTest
    {
        [TestMethod]
        public void GetProductPrice_PlatinumCustomer_ReturnPriceWithDiscount()
        {
            Product product = new Product() { Price = 50 };
            var result = product.GetPrice(new Customer() { IsPlatinum = true });
            result.Should().Be(40);
        }

    }
}
