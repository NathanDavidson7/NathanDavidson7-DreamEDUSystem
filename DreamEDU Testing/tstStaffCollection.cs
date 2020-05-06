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
            TestItem.sJoiningDate = DateTime.Now.Date;
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
            TestStaff.sJoiningDate = DateTime.Now.Date;
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
            TestItem.sJoiningDate = DateTime.Now.Date;
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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.sTutorOrNot = true;
            TestItem.sID = 1;
            TestItem.sJoiningDate = DateTime.Now.Date;
            TestItem.sName = "some one";
            TestItem.sPhone = "1234567890";
            TestItem.sAddress = "some address";
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.sID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to seee that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.sTutorOrNot = true;
            TestItem.sID = 1;
            TestItem.sJoiningDate = DateTime.Now.Date;
            TestItem.sName = "some one";
            TestItem.sPhone = "1234567890";
            TestItem.sAddress = "some address";
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.sID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the recod was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.sTutorOrNot = true;
            TestItem.sID = 1;
            TestItem.sJoiningDate = DateTime.Now.Date;
            TestItem.sName = "some one";
            TestItem.sPhone = "1234567890";
            TestItem.sAddress = "some address";
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.sID = PrimaryKey;
            //modify the test data
            TestItem.sTutorOrNot = false;
            TestItem.sID = 3;
            TestItem.sJoiningDate = DateTime.Now.Date;
            TestItem.sName = "another one";
            TestItem.sPhone = "8901234567";
            TestItem.sAddress = "another address";
            //set all the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void ReportBysPhoneMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredsPhone = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredsPhone.ReportBysPhone("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredsPhone.Count);
        }

        [TestMethod]
        public void ReportBysPhoneNoneFound()
        {
            //create an instance of the class containing filtered results
            clsStaffCollection FilteredsPhone = new clsStaffCollection();
            //apply a Phone number that dosent exist
            FilteredsPhone.ReportBysPhone("xxxxxxxxxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredsPhone.Count);

        }
        [TestMethod]
        public void ReportBysPhoneTestDataFound()
        {
            //create an instance of the class containing filtered results
            clsStaffCollection FilteredsPhone = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a phone number that dosent exist 
            FilteredsPhone.ReportBysPhone("xxxxxxxxxx");
            //chexk that the correct number of records are found
            if(FilteredsPhone.Count == 2)
            {
                //check that the first record is ID 35
                if(FilteredsPhone.StaffList[0].sID!= 35)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredsPhone.StaffList[1].sID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
