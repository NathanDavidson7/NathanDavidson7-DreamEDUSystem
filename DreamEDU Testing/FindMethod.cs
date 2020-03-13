using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class FindMethod
    {
        [TestMethod]
        public void FindOK()
        {
            //create an instance of a classs we want to create
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 sID = 1;
            //invoke method
            Found = aStaff.Find(sID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
