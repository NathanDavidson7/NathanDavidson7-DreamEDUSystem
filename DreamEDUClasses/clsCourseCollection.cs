﻿
using System;
using System.Collections.Generic;

namespace DreamEDUClasses
{
    public class clsCourseCollection
    {
        //constructor for the class
        public clsCourseCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("Courses_SelectAll");
            //populate the array list with the da
            PopulateArray(DB);

        }


        //private data member for the list
        List<clsCourses> mCourseList = new List<clsCourses>();
        //private data member thisCourse
        clsCourses mThisCourse = new clsCourses();
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
        //public property for ThisCourse
        public clsCourses ThisCourse
        {
            get
            {
                //return the private data
                return mThisCourse;
            }
            set
            {
                //set the private data
                mThisCourse = value;
            }
        }

        public int Add()
        {
            //adds a new recors to the database based on the values od mThisCourse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisCourse.Title);
            DB.AddParameter("@Category", mThisCourse.Category);
            DB.AddParameter("@Tutor", mThisCourse.Tutor);
            DB.AddParameter("@LiveDate", mThisCourse.LiveDate);
            DB.AddParameter("@Available", mThisCourse.Available);
            DB.AddParameter("@Price", mThisCourse.Price);
            //execute the query returning the primary key value
            return DB.Execute("sproc_Courses_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCourse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@IDno", mThisCourse.IDno);
            //execute the stored procedure
            DB.Execute("sproc_Courses_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCourse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters of the stored procedure
            DB.AddParameter("@IDno",  mThisCourse.IDno);
            DB.AddParameter("@Title", mThisCourse.Title);
            DB.AddParameter("@Category", mThisCourse.Category);
            DB.AddParameter("@Tutor", mThisCourse.Tutor);
            DB.AddParameter("@LiveDate", mThisCourse.LiveDate);
            DB.AddParameter("@Available", mThisCourse.Available);
            DB.AddParameter("@Price", mThisCourse.Price);
            //execute the stored procedure
            DB.Execute("sproc_Courses_Update");
        }

        public void ReportByCategory(object text)
        {
            throw new NotImplementedException();
        }

        public void ReportByCategory(string Category)
        {
            //filters the records based upon a full or partial category
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Category", Category);
            //execute the stored procedure
            DB.Execute("sproc_Courses_FilterByCategoryFilterMethod");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on th data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCourseList = new List<clsCourses>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCourses aCourse = new clsCourses();
                //read in the fields from the current record
                aCourse.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                aCourse.IDno = Convert.ToInt32(DB.DataTable.Rows[Index]["IDno"]);
                aCourse.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                aCourse.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                aCourse.Tutor = Convert.ToString(DB.DataTable.Rows[Index]["Tutor"]);
                aCourse.LiveDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["LiveDate"]);
                aCourse.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mCourseList.Add(aCourse);
                //point at the next record
                Index++;
            }
        }
    }
}