using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAS_System.Data_Types;
namespace UnitTests.RAS_System
{
    [TestClass]
    public class BigIntTests
    { 
        [DataRow("0")]
        [DataRow("01928")]
        [TestMethod]
        public void IsBigIntPass(string literal)
        {
            Assert.IsTrue(BigInt.IsBigInt(literal));
        }

        [DataRow("i")]
        [DataRow("-1")]
        [DataRow("0.9")]
        [DataRow("42Hello42")]
        [TestMethod]
        public void IsBigIntFail(string literal)
        {
            Assert.IsFalse(BigInt.IsBigInt(literal));
        }
    }
}
