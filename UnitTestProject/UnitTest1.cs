using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string Name = "subhi";
            string Email = "subhi@gmail.com";
            string MobileNumber = "98765432098";
            string expected = "subhi" + "subhi@gmail.com" + "98765432098";

            // Act
            string actual = Add(Name, Email, MobileNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private string Add(string name, string email, string mobileNumber)
        {
            return name + email + mobileNumber;
        }
    }
}
