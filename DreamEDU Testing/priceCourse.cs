using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class priceCourse
    {
        [TestMethod]
        public void priceCourseok()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the course
            decimal TestData = 00.00m;
            //assign the data to the  course
            aCourse.price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.price, TestData);
        }
    }
}
