using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class TutorCourse
    {
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
    }
}
