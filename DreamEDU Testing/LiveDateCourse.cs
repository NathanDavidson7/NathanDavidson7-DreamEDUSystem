using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class LiveDateCourse
    {
        [TestMethod]
        public void LiveDataCourseOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the course
            aCourse.LiveDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.LiveDate,TestData);
        }
    }
}
