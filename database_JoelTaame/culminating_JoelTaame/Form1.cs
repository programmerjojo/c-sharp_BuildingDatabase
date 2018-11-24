//Name: Joel Taame
//Date: 19/12/2017
//Title: formMenu
//Purpose: main menu for user to navigate to different options

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace culminating_JoelTaame
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        //for origional array (sorted by building IRN)
        public static string[] strBuildingIRN;
        public static string[] strBuildingName;
        public static string[] strDistrictIRN;
        public static string[] strDistrictName;
        public static string[] strCounty;
        public static string[] strStreetAdrress;
        public static string[] strCityAndZipCode;
        public static string[] strPhoneNum;
        public static string[] strPrincipal;
        public static string[] strGradeSpan;
        public static string[] strOpenOrClosedStatus;
        public static string[] strDesignation;
        public static string[] strNumOfStandardsMet;
        public static string[] strNumOfStandardsPossible;
        public static string[] strEnrollment;
        public static string[] strAttendance2005to06;
        public static string[] strPerformanceIndexScore2005to06;

        //for alphabetical arrays (sorted by building name)
        public static string[] strBuildingIRNAlpha;
        public static string[] strBuildingNameAlpha;
        public static string[] strDistrictIRNAlpha;
        public static string[] strDistrictNameAlpha;
        public static string[] strCountyAlpha;
        public static string[] strStreetAdrressAlpha;
        public static string[] strCityAndZipCodeAlpha;
        public static string[] strPhoneNumAlpha;
        public static string[] strPrincipalAlpha;
        public static string[] strGradeSpanAlpha;
        public static string[] strOpenOrClosedStatusAlpha;
        public static string[] strDesignationAlpha;
        public static string[] strNumOfStandardsMetAlpha;
        public static string[] strNumOfStandardsPossibleAlpha;
        public static string[] strEnrollmentAlpha;
        public static string[] strAttendance2005to06Alpha;
        public static string[] strPerformanceIndexScore2005to06Alpha;

        //temp arrays for adding & deleting
        public static string[] strTempBuildingIRN;
        public static string[] strTempBuildingName;
        public static string[] strTempDistrictIRN;
        public static string[] strTempDistrictName;
        public static string[] strTempCounty;
        public static string[] strTempStreetAdrress;
        public static string[] strTempCityAndZipCode;
        public static string[] strTempPhoneNum;
        public static string[] strTempPrincipal;
        public static string[] strTempGradeSpan;
        public static string[] strTempOpenOrClosedStatus;
        public static string[] strTempDesignation;
        public static string[] strTempNumOfStandardsMet;
        public static string[] strTempNumOfStandardsPossible;
        public static string[] strTempEnrollment;
        public static string[] strTempAttendance2005to06;
        public static string[] strTempPerformanceIndexScore2005to06;
          
        //used to make sure inputtingValueFromTextFile only runs once when menuForm is loaded. so when you return to the menuForm from another form, the method won't run again 
        public static int globalCounter = 0;

        //taking the records from the text file
        public static void InfoToArray()
        {
            int intCounter = 0;     //to get size for the arrays
            StreamReader re = File.OpenText("schoolinfo.txt");  //open file
            string strInput = null;   //to store value for each line     
            while ((strInput = re.ReadLine()) != null) //Counting the lines in the file
            {
                intCounter++;
            }
            re.Close(); //close streamreader

            re = File.OpenText("schoolinfo.txt");   //re-open so you can read file from top to bottom again         
            //assigning sizes to arrays (-1 because the file's first line should be skipped)
            strBuildingIRN = new string[intCounter - 1];
            strBuildingName = new string[intCounter - 1];
            strDistrictIRN = new string[intCounter - 1];
            strDistrictName = new string[intCounter - 1];
            strCounty = new string[intCounter - 1];
            strStreetAdrress = new string[intCounter - 1];
            strCityAndZipCode = new string[intCounter - 1];
            strPhoneNum = new string[intCounter - 1];
            strPrincipal = new string[intCounter - 1];
            strGradeSpan = new string[intCounter - 1];
            strOpenOrClosedStatus = new string[intCounter - 1];
            strDesignation = new string[intCounter - 1];
            strNumOfStandardsMet = new string[intCounter - 1];
            strNumOfStandardsPossible = new string[intCounter - 1];
            strEnrollment = new string[intCounter - 1];
            strAttendance2005to06 = new string[intCounter - 1];
            strPerformanceIndexScore2005to06 = new string[intCounter - 1];

            //declaring variables we'll use later when we chop up the information of each line into seperate arrays
            int intNumCount = 0;    //to skip first line
            string strTempInput;    //when we chop up/seperate each line using the commas (or " in some cases)
            int intTempPosition = 0; //to get position of next comma (or ")
            intCounter = 0; //reset counter value to 0

            while ((strInput = re.ReadLine()) != null)
            {
                strTempInput = strInput;
                if (intNumCount > 0)    //to skip the first line in file
                {
                    //the arrays with the if else statements are the ones that have exceptions as some of the records for that specific type are in quotes and have multiple commas in them
                    //if they do not have an if else statements it means none of the records for that type are surrounded by quotes and only have commas surrounding them

                    intTempPosition = strInput.IndexOf(",");
                    strBuildingIRN[intCounter] = strTempInput.Substring(0, intTempPosition); //building num

                    if (strTempInput.Substring(intTempPosition + 1, 1) == "\"")
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 2);
                        intTempPosition = strTempInput.IndexOf("\"");
                        strBuildingName[intCounter] = strTempInput.Substring(0, intTempPosition);
                        strTempInput = strTempInput.Substring(1);
                    }
                    else
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 1);
                        intTempPosition = strTempInput.IndexOf(",");
                        strBuildingName[intCounter] = strTempInput.Substring(0, intTempPosition);
                    } // building names              
                    
                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strDistrictIRN[intCounter] = strTempInput.Substring(0, intTempPosition); //district num                    

                    if (strTempInput.Substring(intTempPosition + 1, 1) == "\"")
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 2);
                        intTempPosition = strTempInput.IndexOf("\"");
                        strDistrictName[intCounter] = strTempInput.Substring(0, intTempPosition);
                        strTempInput = strTempInput.Substring(1);
                    }
                    else
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 1);
                        intTempPosition = strTempInput.IndexOf(",");
                        strDistrictName[intCounter] = strTempInput.Substring(0, intTempPosition);
                    } // district names

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strCounty[intCounter] = strTempInput.Substring(0, intTempPosition); // county names
                  
                    if (strTempInput.Substring(intTempPosition + 1, 1) == "\"")
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 2);
                        intTempPosition = strTempInput.IndexOf("\"");
                        strStreetAdrress[intCounter] = strTempInput.Substring(0, intTempPosition);
                        strTempInput = strTempInput.Substring(1);
                    }
                    else
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 1);
                        intTempPosition = strTempInput.IndexOf(",");
                        strStreetAdrress[intCounter] = strTempInput.Substring(0, intTempPosition);
                    } // street adress

                    if (strTempInput.Substring(intTempPosition + 1, 1) == "\"")
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 2);
                        intTempPosition = strTempInput.IndexOf("\"");
                        strCityAndZipCode[intCounter] = strTempInput.Substring(0, intTempPosition);
                        strTempInput = strTempInput.Substring(1);
                    }
                    else
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 1);
                        intTempPosition = strTempInput.IndexOf(",");
                        strCityAndZipCode[intCounter] = strTempInput.Substring(0, intTempPosition);
                    } // city and zip code                    

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strPhoneNum[intCounter] = strTempInput.Substring(0, intTempPosition); // phone #

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strPrincipal[intCounter] = strTempInput.Substring(0, intTempPosition); // principal

                    if (strTempInput.Substring(intTempPosition+1, 1) == "\"")
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 2);
                        intTempPosition = strTempInput.IndexOf("\"");
                        strGradeSpan[intCounter] = strTempInput.Substring(0, intTempPosition);
                        strTempInput = strTempInput.Substring(1);
                    }
                    else
                    {
                        strTempInput = strTempInput.Substring(intTempPosition + 1);
                        intTempPosition = strTempInput.IndexOf(",");
                        strGradeSpan[intCounter] = strTempInput.Substring(0, intTempPosition);
                    } // grade span
                    
                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strOpenOrClosedStatus[intCounter] = strTempInput.Substring(0, intTempPosition); // open or closed status

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strDesignation[intCounter] = strTempInput.Substring(0, intTempPosition); // designation
                    
                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strNumOfStandardsMet[intCounter] = strTempInput.Substring(0, intTempPosition); // num of standards met

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strNumOfStandardsPossible[intCounter] = strTempInput.Substring(0, intTempPosition); // num of standards possible

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strEnrollment[intCounter] = strTempInput.Substring(0, intTempPosition); // enrollment

                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    intTempPosition = strTempInput.IndexOf(",");
                    strAttendance2005to06[intCounter] = strTempInput.Substring(0, intTempPosition); // attendance from 2005-06
                    
                    strTempInput = strTempInput.Substring(intTempPosition + 1);
                    strPerformanceIndexScore2005to06[intCounter] = strTempInput; // performence index score from 2005-06 

                    intCounter++;
                } 
                intNumCount++;
            }       
            re.Close();
        }

        //form loads, inputtingValueFromTextFile method runs, but only once
        private void formMenu_Load(object sender, EventArgs e)
        {
            if (globalCounter == 0)
            {
                InfoToArray();
                globalCounter++;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //display data button
        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDisplayData f = new formDisplayData();
            f.Show();
        }

        //alphabetical order button
        private void btnAlphabeticallyBySchool_Click(object sender, EventArgs e)
        {
            //first sort to alphabetical before going to the next form

            //declaring size for alphabetical array
            strBuildingIRNAlpha = new string[strBuildingIRN.Length];
            strBuildingNameAlpha = new string[strBuildingName.Length];
            strDistrictIRNAlpha = new string[strDistrictIRN.Length];
            strDistrictNameAlpha = new string[strDistrictName.Length];
            strCountyAlpha = new string[strCounty.Length];
            strStreetAdrressAlpha = new string[strStreetAdrress.Length];
            strCityAndZipCodeAlpha = new string[strCityAndZipCode.Length];
            strPhoneNumAlpha = new string[strPhoneNum.Length];
            strPrincipalAlpha = new string[strPrincipal.Length];
            strGradeSpanAlpha = new string[strGradeSpan.Length];
            strOpenOrClosedStatusAlpha = new string[strOpenOrClosedStatus.Length];
            strDesignationAlpha = new string[strDesignation.Length];
            strNumOfStandardsMetAlpha = new string[strNumOfStandardsMet.Length];
            strNumOfStandardsPossibleAlpha = new string[strNumOfStandardsPossible.Length];
            strEnrollmentAlpha = new string[strEnrollment.Length];
            strAttendance2005to06Alpha = new string[strAttendance2005to06.Length];
            strPerformanceIndexScore2005to06Alpha = new string[strPerformanceIndexScore2005to06.Length];

            //inputting values into temp arrays, basically duplicating all the origional arrays before we sort them
            for (int i = 0; i < strBuildingNameAlpha.Length; i++)
            {
                strBuildingIRNAlpha[i] = strBuildingIRN[i];
                strBuildingNameAlpha[i] = strBuildingName[i];
                strDistrictIRNAlpha[i] = strDistrictIRN[i];
                strDistrictNameAlpha[i] = strDistrictName[i];
                strCountyAlpha[i] = strCounty[i];
                strStreetAdrressAlpha[i] = strStreetAdrress[i];
                strCityAndZipCodeAlpha[i] = strCityAndZipCode[i];
                strPhoneNumAlpha[i] = strPhoneNum[i];
                strPrincipalAlpha[i] = strPrincipal[i];
                strGradeSpanAlpha[i] = strGradeSpan[i];
                strOpenOrClosedStatusAlpha[i] = strOpenOrClosedStatus[i];
                strDesignation[i] = strDesignation[i];
                strNumOfStandardsMetAlpha[i] = strNumOfStandardsMet[i];
                strNumOfStandardsPossibleAlpha[i] = strNumOfStandardsPossible[i];
                strEnrollmentAlpha[i] = strEnrollment[i];
                strAttendance2005to06Alpha[i] = strAttendance2005to06[i];
                strPerformanceIndexScore2005to06Alpha[i] = strPerformanceIndexScore2005to06[i];
            }

            //bubble sortting alpha arrays
            for (int j = 0; j < strBuildingNameAlpha.Length; j++)
            {
                for (int k = 0; k < strBuildingNameAlpha.Length-1; k++)
                {
                    if (strBuildingNameAlpha[k].CompareTo(strBuildingNameAlpha[k+1]) > 0)
                    {
                        // building num
                        string strBuildingNameTempVal = strBuildingNameAlpha[k];
                        strBuildingNameAlpha[k] = strBuildingNameAlpha[k + 1];
                        strBuildingNameAlpha[k + 1] = strBuildingNameTempVal;

                        // building IRN
                        string strBuildingIRNTempVal = strBuildingIRNAlpha[k];
                        strBuildingIRNAlpha[k] = strBuildingIRNAlpha[k + 1];
                        strBuildingIRNAlpha[k + 1] = strBuildingIRNTempVal;

                        // district IRN
                        string strDistrictIRNTempVal = strDistrictIRNAlpha[k];
                        strDistrictIRNAlpha[k] = strDistrictIRNAlpha[k + 1];
                        strDistrictIRNAlpha[k + 1] = strDistrictIRNTempVal;

                        // district name
                        string strDistrictNameTempVal = strDistrictNameAlpha[k];
                        strDistrictNameAlpha[k] = strDistrictNameAlpha[k + 1];
                        strDistrictNameAlpha[k + 1] = strDistrictNameTempVal;

                        // county
                        string strCountyTempVal = strCountyAlpha[k];
                        strCountyAlpha[k] = strCountyAlpha[k + 1];
                        strCountyAlpha[k + 1] = strCountyTempVal;

                        // street adrress
                        string strStreetAdrressTempVal = strStreetAdrressAlpha[k];
                        strStreetAdrressAlpha[k] = strStreetAdrressAlpha[k + 1];
                        strStreetAdrressAlpha[k + 1] = strStreetAdrressTempVal;

                        // city and zip code
                        string strCityAndZipCodeTempVal = strCityAndZipCodeAlpha[k];
                        strCityAndZipCodeAlpha[k] = strCityAndZipCodeAlpha[k + 1];
                        strCityAndZipCodeAlpha[k + 1] = strCityAndZipCodeTempVal;

                        // phone #
                        string strPhoneNumTempVal = strPhoneNumAlpha[k];
                        strPhoneNumAlpha[k] = strPhoneNumAlpha[k + 1];
                        strPhoneNumAlpha[k + 1] = strPhoneNumTempVal;

                        // principal
                        string strPrincipalTempVal = strPrincipalAlpha[k];
                        strPrincipalAlpha[k] = strPrincipalAlpha[k + 1];
                        strPrincipalAlpha[k + 1] = strPrincipalTempVal;

                        // grade span
                        string strGradeSpanTempVal = strGradeSpanAlpha[k];
                        strGradeSpanAlpha[k] = strGradeSpanAlpha[k + 1];
                        strGradeSpanAlpha[k + 1] = strGradeSpanTempVal;

                        // open or closed status
                        string strOpenOrClosedStatusTempVal = strOpenOrClosedStatusAlpha[k];
                        strOpenOrClosedStatusAlpha[k] = strOpenOrClosedStatusAlpha[k + 1];
                        strOpenOrClosedStatusAlpha[k + 1] = strOpenOrClosedStatusTempVal;

                        // designation
                        string strDesignationTempVal = strDesignationAlpha[k];
                        strDesignationAlpha[k] = strDesignationAlpha[k + 1];
                        strDesignationAlpha[k + 1] = strDesignationTempVal;

                        // number of standards met
                        string strNumOfStandardsMetTempVal = strNumOfStandardsMetAlpha[k];
                        strNumOfStandardsMetAlpha[k] = strNumOfStandardsMetAlpha[k + 1];
                        strNumOfStandardsMetAlpha[k + 1] = strNumOfStandardsMetTempVal;

                        // number of standards possible
                        string strNumOfStandardsPossibleTempVal = strNumOfStandardsPossibleAlpha[k];
                        strNumOfStandardsPossibleAlpha[k] = strNumOfStandardsPossibleAlpha[k + 1];
                        strNumOfStandardsPossibleAlpha[k + 1] = strNumOfStandardsPossibleTempVal;

                        // enrollment
                        string strEnrollmentTempVal = strEnrollmentAlpha[k];
                        strEnrollmentAlpha[k] = strEnrollmentAlpha[k + 1];
                        strEnrollmentAlpha[k + 1] = strEnrollmentTempVal;

                        // attendance 2005 to 06
                        string strAttendance2005to06TempVal = strAttendance2005to06Alpha[k];
                        strAttendance2005to06Alpha[k] = strAttendance2005to06Alpha[k + 1];
                        strAttendance2005to06Alpha[k + 1] = strAttendance2005to06TempVal;

                        // performance index score 2005 to 06
                        string strPerformanceIndexScore2005to06TempVal = strPerformanceIndexScore2005to06Alpha[k];
                        strPerformanceIndexScore2005to06Alpha[k] = strPerformanceIndexScore2005to06Alpha[k + 1];
                        strPerformanceIndexScore2005to06Alpha[k + 1] = strPerformanceIndexScore2005to06TempVal;
                    }
                }
            }
            
            //Now you can change forms
            this.Hide();
            formSortAlphabetical f = new formSortAlphabetical(); 
            f.Show();
        }

        //add record
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAddRecord f = new formAddRecord();
            f.Show();
        }

        //summary of records button
        private void btnSummaryOfData_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSummaryOfData f = new formSummaryOfData();
            f.Show();
        }

        //delete record button
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDeleteRecord f = new formDeleteRecord();
            f.Show();
        }


        //exit button button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}