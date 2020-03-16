using System;

namespace DreamEDUClasses
{
    public class clsStaff
    {
        //sID private member variable
        private Int32 msID;
        private string msName;
        private string msAddress;
        private Boolean msTutorOrNot;
        private string msPhNo;
        private DateTime msJoinD;
        //sID public 
        public Int32 sID
        {
            get
            {
                //this line of code sends data
                return msID;
            }
            set
            {
                msID = value;
            }
        }
        public string sName
        {
            get
            {
                return msName;
            }
            set
            {
                msName = value;
            }
        }
        public string sAddress
        {
            get
            {
                return msAddress;
            }
            set
            {
                msAddress = value;
            }
        }
        public bool sTutorOrNot
        {
            get
            {
                return msTutorOrNot;
            }
            set
            {
                msTutorOrNot = value;
            }

        }
        public string sPhone
        {
            get
            {
                return msPhNo;
            }
            set
            {
                msPhNo = value;
            }
        }
        public DateTime sJoinD
        {
            get
            {
                return msJoinD;
            }
            set
            {
                msJoinD = value;
            }
        }

        public bool Find(int sID)
        {
            //mSID = 21;
            //msName = "Jon";
            //msAddress = "Test Address";
            //msJoinD = Convert.ToDateTime("01/01/2010");
            //msPhNo = "1234567890";
            //msTutorOrNot = true;

            //return true;

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staffID to search for
            DB.AddParameter("@sID", sID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterBySID");
            //if one recordd is found (there should be either one or zero!)
            if(DB.Count==1)
            {
                //copy the data from the database to the private data members
                msID = Convert.ToInt32(DB.DataTable.Rows[0]["sID"]);
                sName = Convert.ToString(DB.DataTable.Rows[0]["sName"]);
                sAddress = Convert.ToString(DB.DataTable.Rows[0]["sAddress"]);
                sTutorOrNot = Convert.ToBoolean(DB.DataTable.Rows[0]["sTutorOrNot"]);
                sPhone = Convert.ToString(DB.DataTable.Rows[0]["sPhone"]);
                sJoinD = Convert.ToDateTime(DB.DataTable.Rows[0]["sJoiningDate"]);
                //return that everything worked Ok
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        //public bool Find(string sName)
        //{
        //    mSID = 21;
        //    msName = "Jon";
        //    msAddress = "Test Address";
        //    msJoinD = Convert.ToDateTime("01/01/2010");
        //    msPhNo = "1234567890";
        //    msTutorOrNot = true;

        //    return true;
        //}
    }


}