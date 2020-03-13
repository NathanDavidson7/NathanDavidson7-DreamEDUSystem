using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void staffIDOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            Int32 TestData = 1;
            //assign data 
            astaff.sID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sID, TestData);
        }

        [TestMethod]
        public void staffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            string TestData = "Jon";
            //assign data 
            astaff.sName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sName, TestData);
        }

        [TestMethod]
        public void staffAddressOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            string TestData = "21b";
            //assign data 
            astaff.sAddress = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sAddress, TestData);
        }

        [TestMethod]
        public void staffTutorOrNotOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            Boolean TestData = true;
            //assign data 
            astaff.sTutorOrNot = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sTutorOrNot, TestData);
        }

        [TestMethod]
        public void staffPhNoOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            string TestData = "1234567890";
            //assign data 
            astaff.sPhone= TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sPhone, TestData);
        }

        [TestMethod]
        public void staffJoiningDateOK()
        {
            //create an instance of the class we want to create
            clsStaff astaff = new clsStaff();
            //create some test data to assign 
            DateTime TestData = DateTime.Now.Date;
            //assign data 
            astaff.sJoinD = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sJoinD, TestData);
        }
    }
}
