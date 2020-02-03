using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class TitleCourse
    {
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
    }
}
