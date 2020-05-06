using System;
using System.Collections.Generic;

namespace DreamEDUClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the stored procedre
            PopulateArray(DB);
            
        }

        void PopulateArray(clsDataConnection DB)
        {
            //poulates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the recods
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank staff
                clsStaff aStaff = new clsStaff();
                //read in the fields from the current record
                aStaff.sTutorOrNot = Convert.ToBoolean(DB.DataTable.Rows[Index]["sTutorOrNot"]);
                aStaff.sPhone = Convert.ToString(DB.DataTable.Rows[Index]["sPhone"]);
                aStaff.sName = Convert.ToString(DB.DataTable.Rows[Index]["sName"]);
                aStaff.sAddress = Convert.ToString(DB.DataTable.Rows[Index]["sAddress"]);
                aStaff.sJoiningDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["sJoiningDate"]);
                aStaff.sID = Convert.ToInt32(DB.DataTable.Rows[Index]["sID"]);
                //add the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //public property for the staff list
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the datbase based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@sName", mThisStaff.sName);
            DB.AddParameter("@sAddress", mThisStaff.sAddress);
            DB.AddParameter("@sPhone", mThisStaff.sPhone);
            DB.AddParameter("@sTutorOrNot", mThisStaff.sTutorOrNot);
            DB.AddParameter("@sJoiningDate", mThisStaff.sJoiningDate);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@sID", mThisStaff.sID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@sID", mThisStaff.sID);
            DB.AddParameter("@sName", mThisStaff.sName);
            DB.AddParameter("@sAddress", mThisStaff.sAddress);
            DB.AddParameter("@sPhone", mThisStaff.sPhone);
            DB.AddParameter("@sTutorOrNot", mThisStaff.sTutorOrNot);
            DB.AddParameter("@sJoiningDate", mThisStaff.sJoiningDate);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportBysPhone(string sPhone)
        {
            //filters the records based on the full or partial sPhone number
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the sPhone parameter to the database
            DB.AddParameter("@sPhone", sPhone);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterBysPhone");
            //populate the array list withthe data table
            PopulateArray(DB);
        }
    }
}