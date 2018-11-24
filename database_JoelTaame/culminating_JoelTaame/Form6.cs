//Name: Joel Taame
//Date: 19/12/2017
//Title: formDeletedRecord
//Purpose: allows user to delete record

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
    public partial class formDeleteRecord : Form
    {
        public formDeleteRecord()
        {
            InitializeComponent();
        }

        //delete record button
        private void btnDeleteRec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < formMenu.strBuildingIRN.Length; i++)
            {
                if (this.txtbxDeleteRec.Text == formMenu.strBuildingIRN[i])
                {
                    //clearing both textboxes
                    btnDeletedRecord.Text = "Record that you deleted: ";
                    txtbxDeleteRec.Text = "";

                    //showing the deleted record
                    btnDeletedRecord.Visible = true;
                    btnDeletedRecord.Text = btnDeletedRecord.Text + formMenu.strBuildingIRN[i] + ", " + formMenu.strBuildingName[i] + ", " + formMenu.strDistrictIRN[i] + ", " + formMenu.strDistrictName[i] + ", " + formMenu.strCounty[i] + ", " + formMenu.strStreetAdrress[i] + ", " + formMenu.strCityAndZipCode[i] + ", " + formMenu.strPhoneNum[i] + ", " + formMenu.strPrincipal[i] + ", " + formMenu.strGradeSpan[i] + ", " + formMenu.strOpenOrClosedStatus[i] + ", " + formMenu.strDesignation[i] + ", " + formMenu.strNumOfStandardsMet[i] + ", " + formMenu.strNumOfStandardsPossible[i] + ", " + formMenu.strEnrollment[i] + ", " + formMenu.strAttendance2005to06[i] + ", " + formMenu.strPerformanceIndexScore2005to06[i];

                    //location of what array to delete
                    int tempPosition = i;

                    //declaring size for temp arrays
                    formMenu.strTempBuildingIRN = new string[formMenu.strBuildingIRN.Length - 1];
                    formMenu.strTempBuildingName = new string[formMenu.strBuildingName.Length - 1];
                    formMenu.strTempDistrictIRN = new string[formMenu.strDistrictIRN.Length - 1];
                    formMenu.strTempDistrictName = new string[formMenu.strDistrictName.Length - 1];
                    formMenu.strTempCounty = new string[formMenu.strCounty.Length - 1];
                    formMenu.strTempStreetAdrress = new string[formMenu.strStreetAdrress.Length - 1];
                    formMenu.strTempCityAndZipCode = new string[formMenu.strCityAndZipCode.Length - 1];
                    formMenu.strTempPhoneNum = new string[formMenu.strPhoneNum.Length - 1];
                    formMenu.strTempPrincipal = new string[formMenu.strPrincipal.Length - 1];
                    formMenu.strTempGradeSpan = new string[formMenu.strGradeSpan.Length - 1];
                    formMenu.strTempOpenOrClosedStatus = new string[formMenu.strOpenOrClosedStatus.Length - 1];
                    formMenu.strTempDesignation = new string[formMenu.strDesignation.Length - 1];
                    formMenu.strTempNumOfStandardsMet = new string[formMenu.strNumOfStandardsMet.Length - 1];
                    formMenu.strTempNumOfStandardsPossible = new string[formMenu.strNumOfStandardsPossible.Length - 1];
                    formMenu.strTempEnrollment = new string[formMenu.strEnrollment.Length - 1];
                    formMenu.strTempAttendance2005to06 = new string[formMenu.strAttendance2005to06.Length - 1];
                    formMenu.strTempPerformanceIndexScore2005to06 = new string[formMenu.strPerformanceIndexScore2005to06.Length - 1];

                    //inputting info excluding deleted into temp arrays
                    for (int j = 0; j < tempPosition; j++)
                    {
                        formMenu.strTempBuildingIRN[j] = formMenu.strBuildingIRN[j];
                        formMenu.strTempBuildingName[j] = formMenu.strBuildingName[j];
                        formMenu.strTempDistrictIRN[j] = formMenu.strDistrictIRN[j];
                        formMenu.strTempDistrictName[j] = formMenu.strDistrictName[j];
                        formMenu.strTempCounty[j] = formMenu.strCounty[j];
                        formMenu.strTempStreetAdrress[j] = formMenu.strStreetAdrress[j];
                        formMenu.strTempCityAndZipCode[j] = formMenu.strCityAndZipCode[j];
                        formMenu.strTempPhoneNum[j] = formMenu.strPhoneNum[j];
                        formMenu.strTempPrincipal[j] = formMenu.strPrincipal[j];
                        formMenu.strTempGradeSpan[j] = formMenu.strGradeSpan[j];
                        formMenu.strTempOpenOrClosedStatus[j] = formMenu.strOpenOrClosedStatus[j];
                        formMenu.strTempDesignation[j] = formMenu.strDesignation[j];
                        formMenu.strTempNumOfStandardsMet[j] = formMenu.strNumOfStandardsMet[j];
                        formMenu.strTempNumOfStandardsPossible[j] = formMenu.strNumOfStandardsPossible[j];
                        formMenu.strTempEnrollment[j] = formMenu.strEnrollment[j];
                        formMenu.strTempAttendance2005to06[j] = formMenu.strAttendance2005to06[j];
                        formMenu.strTempPerformanceIndexScore2005to06[j] = formMenu.strPerformanceIndexScore2005to06[j];
                    }
                    for (int j = tempPosition; j < formMenu.strTempBuildingIRN.Length; j++)
                    {
                        formMenu.strTempBuildingIRN[j] = formMenu.strBuildingIRN[j+1];
                        formMenu.strTempBuildingName[j] = formMenu.strBuildingName[j+1];
                        formMenu.strTempDistrictIRN[j] = formMenu.strDistrictIRN[j + 1];
                        formMenu.strTempDistrictName[j] = formMenu.strDistrictName[j + 1];
                        formMenu.strTempCounty[j] = formMenu.strCounty[j + 1];
                        formMenu.strTempStreetAdrress[j] = formMenu.strStreetAdrress[j + 1];
                        formMenu.strTempCityAndZipCode[j] = formMenu.strCityAndZipCode[j + 1];
                        formMenu.strTempPhoneNum[j] = formMenu.strPhoneNum[j + 1];
                        formMenu.strTempPrincipal[j] = formMenu.strPrincipal[j + 1];
                        formMenu.strTempGradeSpan[j] = formMenu.strGradeSpan[j + 1];
                        formMenu.strTempOpenOrClosedStatus[j] = formMenu.strOpenOrClosedStatus[j + 1];
                        formMenu.strTempDesignation[j] = formMenu.strDesignation[j + 1];
                        formMenu.strTempNumOfStandardsMet[j] = formMenu.strNumOfStandardsMet[j + 1];
                        formMenu.strTempNumOfStandardsPossible[j] = formMenu.strNumOfStandardsPossible[j + 1];
                        formMenu.strTempEnrollment[j] = formMenu.strEnrollment[j + 1];
                        formMenu.strTempAttendance2005to06[j] = formMenu.strAttendance2005to06[j + 1];
                        formMenu.strTempPerformanceIndexScore2005to06[j] = formMenu.strPerformanceIndexScore2005to06[j + 1];
                    }

                    //declaring size for orig arrays
                    formMenu.strBuildingIRN = new string[formMenu.strTempBuildingIRN.Length];
                    formMenu.strBuildingName = new string[formMenu.strTempBuildingName.Length];
                    formMenu.strDistrictIRN = new string[formMenu.strTempDistrictIRN.Length];
                    formMenu.strDistrictName = new string[formMenu.strTempDistrictName.Length];
                    formMenu.strCounty = new string[formMenu.strTempCounty.Length];
                    formMenu.strStreetAdrress = new string[formMenu.strTempStreetAdrress.Length];
                    formMenu.strCityAndZipCode = new string[formMenu.strTempCityAndZipCode.Length];
                    formMenu.strPhoneNum = new string[formMenu.strTempPhoneNum.Length];
                    formMenu.strPrincipal = new string[formMenu.strTempPrincipal.Length];
                    formMenu.strGradeSpan = new string[formMenu.strTempGradeSpan.Length];
                    formMenu.strOpenOrClosedStatus = new string[formMenu.strTempOpenOrClosedStatus.Length];
                    formMenu.strDesignation = new string[formMenu.strTempDesignation.Length];
                    formMenu.strNumOfStandardsMet = new string[formMenu.strTempNumOfStandardsMet.Length];
                    formMenu.strNumOfStandardsPossible = new string[formMenu.strTempNumOfStandardsPossible.Length];
                    formMenu.strEnrollment = new string[formMenu.strTempEnrollment.Length];
                    formMenu.strAttendance2005to06 = new string[formMenu.strTempAttendance2005to06.Length];
                    formMenu.strPerformanceIndexScore2005to06 = new string[formMenu.strTempPerformanceIndexScore2005to06.Length];

                    //inputting all info back into orig array
                    for (int j = 0; j < formMenu.strBuildingIRN.Length; j++)
                    {
                        formMenu.strBuildingIRN[j] = formMenu.strTempBuildingIRN[j];
                        formMenu.strBuildingName[j] = formMenu.strTempBuildingName[j];
                        formMenu.strDistrictIRN[j] = formMenu.strTempDistrictIRN[j];
                        formMenu.strDistrictName[j] = formMenu.strTempDistrictName[j];
                        formMenu.strCounty[j] = formMenu.strTempCounty[j];
                        formMenu.strStreetAdrress[j] = formMenu.strTempStreetAdrress[j];
                        formMenu.strCityAndZipCode[j] = formMenu.strTempCityAndZipCode[j];
                        formMenu.strPhoneNum[j] = formMenu.strTempPhoneNum[j];
                        formMenu.strPrincipal[j] = formMenu.strTempPrincipal[j];
                        formMenu.strGradeSpan[j] = formMenu.strTempGradeSpan[j];
                        formMenu.strOpenOrClosedStatus[j] = formMenu.strTempOpenOrClosedStatus[j];
                        formMenu.strDesignation[j] = formMenu.strTempDesignation[j];
                        formMenu.strNumOfStandardsMet[j] = formMenu.strTempNumOfStandardsMet[j];
                        formMenu.strNumOfStandardsPossible[j] = formMenu.strTempNumOfStandardsPossible[j];
                        formMenu.strEnrollment[j] = formMenu.strTempEnrollment[j];
                        formMenu.strAttendance2005to06[j] = formMenu.strTempAttendance2005to06[j];
                        formMenu.strPerformanceIndexScore2005to06[j] = formMenu.strTempPerformanceIndexScore2005to06[j];
                    }
                }
                else if ((i == formMenu.strBuildingIRN.Length - 1) && (this.txtbxDeleteRec.Text != formMenu.strBuildingIRN[formMenu.strBuildingIRN.Length - 1]) && (this.txtbxDeleteRec.Text != ""))    // if the loop has reached its last cycle (meaning that the info did not match any record or else it would have breaked)
                {
                    MessageBox.Show("You're information did not match any records...");
                    this.txtbxDeleteRec.Text = "";
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