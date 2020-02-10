using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DreamEDUClasses;

namespace DreamEDU_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the classs we want to create
            clsStaff sStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(sStaff);
        }
    }
}
