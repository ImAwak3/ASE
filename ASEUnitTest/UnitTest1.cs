using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace ASEUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //checking cursor move to right value//
        public void Test_Moveto_Right_value()
        {
            var v = new Validate();
            string[] result = v.getValidate("moveto 10 10", 1, 1);
            Assert.AreEqual(result[0], "moveto", result[1], "10", result[2], "10");

        }
        //checking move to wrong value//
        public void Test_Moveto_Wrong_value()
        {
            var v = new Validate();
            string[] result = v.getValidate("moveto 10", 1, 1);
            Assert.AreEqual(result[0], "errormoveto");

        }
        //checking draw to right value//
        public void Test_Drawto_Right_value()
        {
            var v = new Validate();
            string[] result = v.getValidate("drawto 10 10",1,1);
            Assert.AreEqual(result[0], "drawto", result[1], "10", result[2], "10");

        }


        public void TestMethod1()
        {
        }
    }
}
