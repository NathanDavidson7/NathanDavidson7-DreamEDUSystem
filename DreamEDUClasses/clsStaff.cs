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
        public DateTime sJoiningDate
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
                sJoiningDate = Convert.ToDateTime(DB.DataTable.Rows[0]["sJoiningDate"]);
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
        
        //function for the public validation method
        public string Valid(string sName,
                           string sAddress,
                           string sPhone,
                           string sJoiningDate)
        ///this function accepts 5 parameters for vaidation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            
            //if the sName is blank
            if (sName.Length == 0)
            {
                //record Error
                Error = Error + "The name may not be blank";
            }
            //if sName is greater than 20 characters
            if(sName.Length > 20)
            {
                //record Error
                Error = Error + "The name should have less than 20 characters";
            }
            
            //if the sAddress is blank
            if (sAddress.Length == 0)
            {
                //record Error
                Error = Error + "The name may not be blank";
            }
            //if sAddress is greater than 20 characters
            if (sAddress.Length > 50)
            {
                //record Error
                Error = Error + "The address should have less than 20 characters";
            }
            //if sPhone is blank
            if (sPhone.Length == 0)
            {
                Error = Error + "The Phone may not be blank";
            }
            //if sPhone is greater than 10
            if (sPhone.Length > 10)
            {
                Error = Error + "The Phone should have 10 characters";
            }
            //copy the sJoiningDate value to the DataTemp variable
            try
            {
                DateTemp = Convert.ToDateTime(sJoiningDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record Error
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "invalid date format";
            }
            //return any error messages
            return Error;
        }
    }

    


}