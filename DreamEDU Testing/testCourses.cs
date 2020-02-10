using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DreamEDUClasses;

namespace DreamEDU_Testing
{
    [TestClass]
    public class testCourses
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //test to see that it exists
            Assert.IsNotNull(aCourse);
        }

        [TestMethod]
        public void TutorCourseOK()
        {//create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            String TestData = "D Armstrong";
            //asign the data to the course
            aCourse.Tutor = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Tutor, TestData);
        }

        [TestMethod]
        public void TitleCourseOK()
        {//create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            String TestData = "Computer Science";
            //asign the data to the course
            aCourse.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Title, TestData);
        }

        [TestMethod]
        public void PriceCourseok()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            decimal TestData = 00.00m;
            //assign the data to the  course
            aCourse.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Price, TestData);
        }

        [TestMethod]
        public void LiveDateCourseOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the course
            aCourse.LiveDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.LiveDate, TestData);
        }

        [TestMethod]
        public void IDCourseOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            Int32 TestData = 1;
            //asign the data to the course
            aCourse.IDno = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.IDno, TestData);
        }

        [TestMethod]
        public void CategoryCourseOK()
        {//create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            String TestData = "Technology";
            //asign the data to the course
            aCourse.Category = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Category, TestData);
        }

        [TestMethod]
        public void AvailableCourseOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the  course
            aCourse.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Available, TestData);
        }


    }
}
