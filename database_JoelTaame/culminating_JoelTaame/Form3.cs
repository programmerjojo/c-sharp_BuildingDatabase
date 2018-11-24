//Name: Joel Taame
//Date: 19/12/2017
//Title: formSortAlphabetical
//Purpose: displays data for user to see in alphabetical order, allows them to search for records by building name and browse to the next or previous records

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
    public partial class formSortAlphabetical : Form
    {
        public formSortAlphabetical()
        {
            InitializeComponent();
        }

        //next record button clicked
        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRNAlpha[formMenu.strBuildingIRNAlpha.Length - 1].ToString())    //when tehy reach the last record
            {
                MessageBox.Show("You cannot go further");
            }
            else if (this.lblBuildingName.Text == "Building Name: ")    // if they just etered onto the form, meaining there is no record being displayed
            {
                this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingNameAlpha[0];
                this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRNAlpha[0];
                this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRNAlpha[0];
                this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictNameAlpha[0];
                this.lblCounty.Text = "County: " + formMenu.strCountyAlpha[0];
                this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrressAlpha[0];
                this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCodeAlpha[0];
                this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNumAlpha[0];
                this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipalAlpha[0];
                this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpanAlpha[0];
                this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatusAlpha[0];
                this.lblDesignation.Text = "Designation: " + formMenu.strDesignationAlpha[0];
                this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMetAlpha[0];
                this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossibleAlpha[0];
                this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollmentAlpha[0];
                this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06Alpha[0];
                this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06Alpha[0];
            }

            for (int i = 0; i < formMenu.strBuildingNameAlpha.Length-1; i++)    // -1 is to skip the last record and prevent error
            {
                if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRNAlpha[i])    // will display next record
                {
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingNameAlpha[i + 1];
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRNAlpha[i + 1];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRNAlpha[i + 1];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictNameAlpha[i + 1];
                    this.lblCounty.Text = "County: " + formMenu.strCountyAlpha[i + 1];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrressAlpha[i + 1];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCodeAlpha[i + 1];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNumAlpha[i + 1];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipalAlpha[i + 1];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpanAlpha[i + 1];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatusAlpha[i + 1];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignationAlpha[i + 1];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMetAlpha[i + 1];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossibleAlpha[i + 1];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollmentAlpha[i + 1];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06Alpha[i + 1];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06Alpha[i + 1];
                    break;
                }
            }
        }       
       
        //prev record button clicked
        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRNAlpha[0].ToString())  //when they are at the first record
            {
                MessageBox.Show("You cannot go further back then this...");
            }

            for (int i = 1; i < formMenu.strBuildingNameAlpha.Length; i++)  // i starts at 1 so it skips the first record since it checks for first record in the if statement above ^
            {            
                if (this.lblBuildingIRN.Text == "Building IRN: " + formMenu.strBuildingIRNAlpha[i])
                {
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingNameAlpha[i - 1];
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRNAlpha[i - 1];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRNAlpha[i - 1];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictNameAlpha[i - 1];
                    this.lblCounty.Text = "County: " + formMenu.strCountyAlpha[i - 1];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrressAlpha[i - 1];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCodeAlpha[i - 1];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNumAlpha[i - 1];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipalAlpha[i - 1];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpanAlpha[i - 1];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatusAlpha[i - 1];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignationAlpha[i - 1];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMetAlpha[i - 1];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossibleAlpha[i - 1];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollmentAlpha[i - 1];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06Alpha[i - 1];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06Alpha[i - 1];
                    break;
                }
            }
        }

        //search button clicked
        private void btnSearchButton_Click(object sender, EventArgs e)
        {           
            for (int i = 0; i < formMenu.strBuildingNameAlpha.Length; i++)
            {
                if (this.txtbxSearch.Text == formMenu.strBuildingNameAlpha[i])  // checks if info matches any records & displays records
                {
                    this.lblBuildingName.Text = "Building Name: " + formMenu.strBuildingNameAlpha[i];
                    this.lblBuildingIRN.Text = "Building IRN: " + formMenu.strBuildingIRNAlpha[i];
                    this.lblDistrictIRN.Text = "District IRN: " + formMenu.strDistrictIRNAlpha[i];
                    this.lblDistrictName.Text = "District Name: " + formMenu.strDistrictNameAlpha[i];
                    this.lblCounty.Text = "County: " + formMenu.strCountyAlpha[i];
                    this.lblStreetAddress.Text = "Street Adrress: " + formMenu.strStreetAdrressAlpha[i];
                    this.lblCityAndZipCode.Text = "City and Zip Code: " + formMenu.strCityAndZipCodeAlpha[i];
                    this.lblPhoneNum.Text = "Phone #: " + formMenu.strPhoneNumAlpha[i];
                    this.lblPrincipal.Text = "Principal: " + formMenu.strPrincipalAlpha[i];
                    this.lblGradeSpan.Text = "Grade Span: " + formMenu.strGradeSpanAlpha[i];
                    this.lblOpenOrClosedStatus.Text = "Open/Closed Status: " + formMenu.strOpenOrClosedStatusAlpha[i];
                    this.lblDesignation.Text = "Designation: " + formMenu.strDesignationAlpha[i];
                    this.lblNumOfStandardsMet.Text = "Number of Standards Met: " + formMenu.strNumOfStandardsMetAlpha[i];
                    this.lblNumOfStandardsPossible.Text = "Number of Standards Possible: " + formMenu.strNumOfStandardsPossibleAlpha[i];
                    this.lblEnrollment.Text = "Enrollment: " + formMenu.strEnrollmentAlpha[i];
                    this.lblAttendance2005To06.Text = "Attendance 2005 to 06: " + formMenu.strAttendance2005to06Alpha[i];
                    this.lblPerformanceIndexScore2005To06.Text = "Performance Index Score 2005 to 06: " + formMenu.strPerformanceIndexScore2005to06Alpha[i];
                    break;
                }
                if ((i == formMenu.strBuildingNameAlpha.Length - 1) && (this.txtbxSearch.Text != formMenu.strBuildingNameAlpha[formMenu.strBuildingNameAlpha.Length - 1]))  // if the loop has reached its last cycle (meaning that the info did not match any record or else it would have breaked)
                {
                    MessageBox.Show("You're information did not match any records...");
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