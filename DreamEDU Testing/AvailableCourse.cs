﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class AvailableCourse
   
    {
        [TestMethod]
        public void ActiveCourseOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the  course
            aCourse.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCourse.Active, TestData);
        }
    }
}
