﻿using System;
using DreamEDUClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DreamEDU_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff sStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(sStaff);
        }
    }
}