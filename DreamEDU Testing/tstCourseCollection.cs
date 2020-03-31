﻿using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DreamEDU_Testing
{
    [TestClass]
    public class tstCourseCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCourses);
        }

        [TestMethod]
        public void CourseListOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCourses> TestList = new List<clsCourses>();
            //add an item to the list
            //create the item of test data
            clsCourses TestItem = new clsCourses();
            //set its properties 
            TestItem.Available = true;
            TestItem.IDno = 1;
            TestItem.Title = "Computing";
            TestItem.Category = "Technology";
            TestItem.Tutor = "D Lewis";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 200;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCourses.CourseList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCourses.CourseList, TestList);

        }


        [TestMethod]
        public void ThisCoursePropertyOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create some test data to assign to the property
            clsCourses TestCourses = new clsCourses();
            //set the properties of the test object
            TestCourses.Available = true;
            TestCourses.IDno = 1;
            TestCourses.Title = "Computing";
            TestCourses.Category = "Technology";
            TestCourses.Tutor = "D Lewis";
            TestCourses.LiveDate = DateTime.Now.Date;
            TestCourses.Price = 200;
            //assign the data to the property
            AllCourses.ThisCourse = TestCourses;
            //test to see that the two values are the same
            Assert.AreEqual(AllCourses.ThisCourse, TestCourses);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCourses> TestList = new List<clsCourses>();
            //add an item to the list
            //create the item of test data
            clsCourses TestItem = new clsCourses();
            //set its properties 
            TestItem.Available = true;
            TestItem.IDno = 1;
            TestItem.Title = "Computing";
            TestItem.Category = "Technology";
            TestItem.Tutor = "D Lewis";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 200;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCourses.CourseList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCourses.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create the item of test data
            clsCourses TestItem = new clsCourses();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Available = true;
            TestItem.IDno = 1;
            TestItem.Title = "Web Development";
            TestItem.Category = "Technology";
            TestItem.Tutor = "R Sunderland";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 180;
            //set ThisCourse to the test data
            AllCourses.ThisCourse = TestItem;
            //add the record
            PrimaryKey = AllCourses.Add();
            //set the primary key of the test data
            TestItem.IDno = PrimaryKey;
            //find the record
            AllCourses.ThisCourse.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCourses.ThisCourse, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create the item of test data
            clsCourses TestItem = new clsCourses();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Available = true;
            TestItem.IDno = 1;
            TestItem.Title = "Web Development";
            TestItem.Category = "Technology";
            TestItem.Tutor = "R Sunderland";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 180;
            //set ThisCourse to the test data
            AllCourses.ThisCourse = TestItem;
            //add the record
            PrimaryKey = AllCourses.Add();
            //set the primary key of the test data
            TestItem.IDno = PrimaryKey;
            //find the record
            AllCourses.ThisCourse.Find(PrimaryKey);
            //delete the record
            AllCourses.Delete();
            //now find the record
            Boolean Found = AllCourses.ThisCourse.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

    }
    
}
