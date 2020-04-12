using System;
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

        [TestMethod]
        public void UpdateMethodOK()
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
            //modify the test data
            TestItem.Available = false;
            TestItem.IDno = 11;
            TestItem.Title = "Front-end Web Development";
            TestItem.Category = "Technology";
            TestItem.Tutor = "S Sunderland";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 150;
            //set the record based on the new test data
            AllCourses.ThisCourse = TestItem;
            //update the record
            AllCourses.Update();
            //find the record
            AllCourses.ThisCourse.Find(PrimaryKey);
            //test to see ThisCourse matches the test data
            Assert.AreEqual(AllCourses.ThisCourse, TestItem);
        }

        [TestMethod]
        public void ReportByCategoryMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCourseCollection AllCourses = new clsCourseCollection();
            //create an instance of the filtered data
            clsCourseCollection FilteredCourses = new clsCourseCollection();
            //apply a blank string (should return all records);
            FilteredCourses.ReportByCategory("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCourses.Count, FilteredCourses.Count);
            
        }

        [TestMethod]
        public void ReportByCategoryNoneFound()
        {
            //create an instance of the filtered data
            clsCourseCollection FilteredCourses = new clsCourseCollection();
            //apply a category that doesnt exist
            FilteredCourses.ReportByCategory("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCourses.Count);
        }

        [TestMethod]
        public void ReportByCategoryTestDataFound()
        {
            //create an instance of the filtered data
            clsCourseCollection FilteredCourses = new clsCourseCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a category that doesnt exist
            FilteredCourses.ReportByCategory("Science");
            //check that the correct number of records are found
            if (FilteredCourses.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCourses.CourseList[0].IDno != 2)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCourses.CourseList[1].IDno != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
    
}
