using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class IDCourse
    {
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
    }
}
