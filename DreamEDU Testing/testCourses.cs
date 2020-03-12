using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DreamEDUClasses;

namespace DreamEDU_Testing
{
    [TestClass]
    public class testCourses
    {
        //good test data
        //create some test data to pass to the method
        string Title = "Computing";
        string Category = "Technology";
        string Tutor = "D Lewis";
        string LiveDate = DateTime.Now.Date.ToString();
        string Price = "200";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 IDno = 1;
            //invoke the method
            Found = aCourse.Find(IDno);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestIDnoFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            Int32 IDno = 1;
            //invoke the method
            Found = aCourse.Find(IDno);
            //check the address no
            if (aCourse.IDno != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLiveDateFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            DateTime LiveDate = Convert.ToDateTime("01/01/2020");
            //DateTime LiveDate = 01/01/2020;
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.LiveDate != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            String Title = Convert.ToString("Computing");
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.Title != "Computing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTutorFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            String Tutor = Convert.ToString("D Lewis");
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.Tutor != "D Lewis")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            String Category = Convert.ToString("Technology");
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.Category != "Technology")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            Decimal Price = Convert.ToDecimal(200.00);
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.Price != Convert.ToDecimal(200.00))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            Boolean Available = Convert.ToBoolean(true);
            //invoke the method
            Found = aCourse.Find(1);
            //check the address no
            if (aCourse.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //TITLE VALIDATION TESTS!
        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";//this should trigger an error
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "a";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaaaa";//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //LiveDate VALIDATION TESTS!
        [TestMethod]
        public void LiveDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string LiveDate = TestDate.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LiveDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string LiveDate = TestDate.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LiveDateMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string LiveDate = TestDate.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LiveDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string LiveDate = TestDate.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LiveDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string LiveDate = TestDate.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LiveDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //set the LiveDate to a non date value
            string LiveDate = "this is not a date!";
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //Category TEST METHODS!
        [TestMethod]
        public void CategoryMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "";//this should trigger an error
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "a";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aaaaaaaaaaaaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aaaaaaaaaa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "aaaaaaaaaaaaaaaaaaaaa";//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Tutor TEST METHODS!
        [TestMethod]
        public void TutorMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "";//this should trigger an error
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "a";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "aa";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "aaaaaaaaaaaaaaaaaaabbbbb";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "aaaaaaaaaaaaaaaaaaabbbbbb";//this should be ok
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TutorMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "aaaaaaaaaaaaaaaaaaabbbbbbb";//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TutorExtermeMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Tutor = "";
            Tutor = Tutor.PadRight(500, 't');//this should fail
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Price TEST METHODS!
        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to -100
            TestPrice = -100.00m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to -00.01
            TestPrice = -01.00m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to 00.01
            TestPrice = 00.01m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to 10000.00
            TestPrice = 10000.00m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to 10000.01
            TestPrice = 10000.01m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourses aCourse = new clsCourses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            Decimal TestPrice;
            //set TestPrice to a value
            TestPrice = 00.00m;
            //change price to 9999999.99
            TestPrice = 9999999.99m;
            //convert the decimal variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

    }
}
