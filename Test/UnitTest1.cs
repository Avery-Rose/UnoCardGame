using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BOLayer;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Card target = new Card(Color.Black, FaceValue.ChangeColor);
            Assert.IsTrue(target.FaceValue == FaceValue.ChangeColor);
            Assert.IsTrue(target.Color == Color.Black);
        }
    }
}
