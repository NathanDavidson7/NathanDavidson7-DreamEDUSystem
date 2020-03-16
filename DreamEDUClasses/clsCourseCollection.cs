
using System;
using System.Collections.Generic;

namespace DreamEDUClasses
{
    public class clsCourseCollection
    {
        public clsCourseCollection()
        {
            //create the items of test data
            clsCourses TestItem = new clsCourses();
            //set its properties 
            TestItem.Available = true;
            TestItem.IDno = 1;
            TestItem.Title = "Computing";
            TestItem.Category = "Technology";
            TestItem.Tutor = "D Lewis";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 200;
            //add the item to the test list
            mCourseList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCourses();
            //set its properties
            TestItem.Available = true;
            TestItem.IDno = 2;
            TestItem.Title = "Climate Solutions";
            TestItem.Category = "Science";
            TestItem.Tutor = "A Armstrong";
            TestItem.LiveDate = DateTime.Now.Date;
            TestItem.Price = 179;
            //add the item to the test list
            mCourseList.Add(TestItem);

        }


        //private data member for the list
        List<clsCourses> mCourseList = new List<clsCourses>();
        //public property for the courses list
        public List<clsCourses> CourseList
        {
            get
            {
                //return the private data
                return mCourseList;
            }
            set
            {
                //Set the private data
                mCourseList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCourseList.Count;
            }
            set
            {
                //worry about this later
            }
         }
        public clsCourses ThisCourse { get; set; }
    }
}