using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
