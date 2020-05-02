using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DreamEDU_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.sTutorOrNot = true;
            TestItem.sID = 1;
            TestItem.sJoinD = DateTime.Now.Date;
            TestItem.sName = "some one";
            TestItem.sPhone = "1234567890";
            TestItem.sAddress = "Western Road LE3 0GH";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        
        [TestMethod]
        public void ThisStaffOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object 
            TestStaff.sTutorOrNot = true;
            TestStaff.sID = 1;
            TestStaff.sJoinD = DateTime.Now.Date;
            TestStaff.sName = "some one";
            TestStaff.sPhone = "1234567890";
            TestStaff.sAddress = "Western Road LE3 0GH";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.sTutorOrNot = true;
            TestItem.sID = 1;
            TestItem.sJoinD = DateTime.Now.Date;
            TestItem.sName = "some one";
            TestItem.sPhone = "1234567890";
            TestItem.sAddress = "Western Road LE3 0GH";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
      
    }
}
