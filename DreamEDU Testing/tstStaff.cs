using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string sID = "1";
        string sName = "Himanshu";
        string sAddress = "Leicester";
        string sPhone = "1234567890";
        string sJoiningDate = DateTime.Now.Date.ToString();



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
            astaff.sJoiningDate = TestData;
            //test to see that two values are the same
            Assert.AreEqual(astaff.sJoiningDate, TestData);
        }
        public void ValidMethodOK()
        {
            //create an instance of a class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store my error messages
            String Error = "";
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //sName Validation Tests!!
        [TestMethod]
        public void sNameMinLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "";//this should fail
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void sNameMin()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "a";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sNameMinPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aa";//this shhould pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sNameMaxLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaaaaaaaaaaa";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sNameMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaaaaaaaaaaaa";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sNameMaxPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//this should fail
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sNameMid()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaa";
            //invoke the method//this should be ok
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sNameExtremeMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "";
            sName = sName.PadRight(500,'a');
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //sAddress Validation Tests!!
        [TestMethod]
        public void sAddressMinLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sAddress = "";//this should fail
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void sAddressMin()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sAddress = "a";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sAddressMinPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sAddress = "aa";//this shhould pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sAddressMaxLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sAddress = "";//this should pass
            sAddress = sAddress.PadRight(49, 'a');
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sAddressMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sAddress = "";//this should pass
            sAddress = sAddress.PadRight(50,'a');
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sAddressMaxPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaaaaaaaaaaaaa";//this should fail
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sAddressMid()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaa";
            //invoke the method//this should be ok
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sAddressExtremeMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "";
            sName = sName.PadRight(500, 'a');
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //sPhone Validation Tests!!
        [TestMethod]
        public void sPhoneMinLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "";//this should fail
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void sPhoneMin()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "a";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneMinPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aa";//this shhould pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneMaxLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaa";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaaaaaaa";//this should pass
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneMaxPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //string sName = "aaaaaaaaaaa";//this should fail
            sPhone = "12345678901";
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneMid()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "aaaaa";
            //invoke the method//this should be ok
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sPhoneExtremeMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string sName = "";
            sName = sName.PadRight(500, 'a');
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateExtremeMin()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string sJoiningDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateMinLessOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string sJoiningDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateMin()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string sJoiningDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateMinPlusOne()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string sJoiningDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateExtremeMax()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string sJoiningDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void sJoiningDateInvalidData()
        {
            //create an instance of the class we want
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the sJoiningDate to a non date value
            string sJoiningDate = "this is not a valid date!";
            //invoke the method
            Error = aStaff.Valid(sName, sAddress, sPhone, sJoiningDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

