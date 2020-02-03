using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class CategoryCourse
    {
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
    }
}
