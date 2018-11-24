//Name: Joel Taame
//Date: 19/12/2017
//Title: formDisplayData
//Purpose: displays data for user to see in order of building IRN, allows them to search for records and browse to the next or previous records

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace culminating_JoelTaame
{
    public partial class formDisplayData : Form
    {
        public formDisplayData()
        {
            InitializeComponent();
        }

        //next record button clicked
        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRN[formMenu.strBuildingIRN.Length - 1].ToString())  //when they reach the last record
            {
                MessageBox.Show("You cannot go further");
            }
            else if (this.lblBuildingIRN.Text == "Building IRN: ")  // if they just etered onto the form, meaining there is no record being displayed
            {
                this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRN[0];
                this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingName[0];
                this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRN[0];
                this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictName[0];
                this.lblCounty.Text = "County: " + formMenu.strCounty[0];
                this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrress[0];
                this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCode[0];
                this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNum[0];
                this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipal[0];
                this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpan[0];
                this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatus[0];
                this.lblDesignation.Text = "Designation: " + formMenu.strDesignation[0];
                this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMet[0];
                this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossible[0];
                this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollment[0];
                this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06[0];
                this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06[0];
            }

            for (int i = 0; i < formMenu.strBuildingIRN.Length - 1; i++)    // -1 is to skip the last record and prevent error
            { 
                if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRN[i])  // will display next record
                {
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRN[i + 1];
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingName[i + 1];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRN[i + 1];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictName[i + 1];
                    this.lblCounty.Text = "County: " + formMenu.strCounty[i + 1];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrress[i + 1];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCode[i + 1];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNum[i + 1];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipal[i + 1];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpan[i + 1];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatus[i + 1];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignation[i + 1];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMet[i + 1];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossible[i + 1];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollment[i + 1];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06[i + 1];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06[i + 1];
                    break;
                }
            }
        }
        
        //prev record button clicked
        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRN[0])  //when they are at the first record
            {
                MessageBox.Show("You cannot go further back then this...");
            }

            for (int i = 1; i < formMenu.strBuildingIRN.Length; i++)    // i starts at 1 so it skips the first record since it checks for first record in the if statement above ^
            {
                if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRN[i])
                {
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRN[i - 1];
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingName[i - 1];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRN[i - 1];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictName[i - 1];
                    this.lblCounty.Text = "County: " + formMenu.strCounty[i - 1];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrress[i - 1];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCode[i - 1];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNum[i - 1];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipal[i - 1];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpan[i - 1];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatus[i - 1];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignation[i - 1];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMet[i - 1];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossible[i - 1];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollment[i - 1];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06[i - 1];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06[i - 1];
                }
            }
        }

        //search button clicked
        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < formMenu.strBuildingIRN.Length; i++)
            {
                if (this.txtbxSearch.Text == formMenu.strBuildingIRN[i])     // checks if info matches any records & displays records
                {
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRN[i];
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingName[i];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRN[i];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictName[i];
                    this.lblCounty.Text = "County: " + formMenu.strCounty[i];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrress[i];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCode[i];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNum[i];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipal[i];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpan[i];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatus[i];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignation[i];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMet[i];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossible[i];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollment[i];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06[i];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06[i];
                    break;
                }
                else if ((i == formMenu.strBuildingIRN.Length-1) && (this.txtbxSearch.Text != formMenu.strBuildingIRN[formMenu.strBuildingIRN.Length-1]) && (this.txtbxSearch.Text != ""))  // if the loop has reached its last cycle (meaning that the info did not match any record or else it would have breaked)
                {
                    MessageBox.Show("Your information did not match any records...");
                    this.txtbxSearch.Text = "";
                }
            }
        }

        //return to main menu
        private void btnReturnToMM_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu f = new formMenu();
            f.Show();
        }
    }
}