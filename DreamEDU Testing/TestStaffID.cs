using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class TestStaffID
    {
        [TestMethod]
        public void TestsID()
        {
            //create an instance of the class we want to cerate
            clsStaff aStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 sID = 1;
            //invoke the method
            Found = aStaff.Find(sID);
            //check the sID
            if(aStaff.sID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestsNAme()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string sName = "";
            Int32 sID = 1;
            Found = aStaff.Find(sID);
            if(aStaff.sName != "Jon")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestDate()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 sID = 1;
            Found = aStaff.Find(sID);
            if (aStaff.sJoiningDate != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestsAddress()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 sID = 1;
            string sAddress = "";
            Found = aStaff.Find(sID);
            if (aStaff.sAddress != "42a Western Road Leicester LE3 0GH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestsTutorOrNot()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 sID = 1;
            Boolean sTutorOrNot = false;
            Found = aStaff.Equals(sTutorOrNot);
            if (aStaff.sTutorOrNot != true)
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }

        public void TestsPhNo()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 sID = 1;
            string sPhone = "";
            Found = aStaff.Find(sID);
            if (aStaff.sName != "1234567890")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
