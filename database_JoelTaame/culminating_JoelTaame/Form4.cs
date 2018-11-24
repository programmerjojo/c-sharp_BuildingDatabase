//Name: Joel Taame
//Date: 19/12/2017
//Title: formAddRecord
//Purpose: allows user to add records

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
    public partial class formAddRecord : Form
    {
        public formAddRecord()
        {
            InitializeComponent();
        }

        //submit new record 
        private void btnSubmitNewRec_Click(object sender, EventArgs e)
        {
            if (txtbxBuildingIRN.Text == "")    // making sure that the building irn is filled given a value
            {
                MessageBox.Show("You can leave informatiom blank, however you MUST include the building IRN");
            }
            else
            {
                try
                {
                    //size for temp arrays
                    formMenu.strTempBuildingIRN = new string[formMenu.strBuildingIRN.Length + 1];
                    formMenu.strTempBuildingName = new string[formMenu.strBuildingName.Length + 1];
                    formMenu.strTempDistrictIRN = new string[formMenu.strDistrictIRN.Length + 1];
                    formMenu.strTempDistrictName = new string[formMenu.strDistrictName.Length + 1];
                    formMenu.strTempCounty = new string[formMenu.strCounty.Length + 1];
                    formMenu.strTempStreetAdrress = new string[formMenu.strStreetAdrress.Length + 1];
                    formMenu.strTempCityAndZipCode = new string[formMenu.strCityAndZipCode.Length + 1];
                    formMenu.strTempPhoneNum = new string[formMenu.strPhoneNum.Length + 1];
                    formMenu.strTempPrincipal = new string[formMenu.strPrincipal.Length + 1];
                    formMenu.strTempGradeSpan = new string[formMenu.strGradeSpan.Length + 1];
                    formMenu.strTempOpenOrClosedStatus = new string[formMenu.strOpenOrClosedStatus.Length + 1];
                    formMenu.strTempDesignation = new string[formMenu.strDesignation.Length + 1];
                    formMenu.strTempNumOfStandardsMet = new string[formMenu.strNumOfStandardsMet.Length + 1];
                    formMenu.strTempNumOfStandardsPossible = new string[formMenu.strNumOfStandardsPossible.Length + 1];
                    formMenu.strTempEnrollment = new string[formMenu.strEnrollment.Length + 1];
                    formMenu.strTempAttendance2005to06 = new string[formMenu.strAttendance2005to06.Length + 1];
                    formMenu.strTempPerformanceIndexScore2005to06 = new string[formMenu.strPerformanceIndexScore2005to06.Length + 1];

                    //info for temp arrays except for last item
                    for (int i = 0; i < formMenu.strTempBuildingIRN.Length - 1; i++)
                    {
                        formMenu.strTempBuildingIRN[i] = formMenu.strBuildingIRN[i];
                        formMenu.strTempBuildingName[i] = formMenu.strBuildingName[i];
                        formMenu.strTempDistrictIRN[i] = formMenu.strDistrictIRN[i];
                        formMenu.strTempDistrictName[i] = formMenu.strDistrictName[i];
                        formMenu.strTempCounty[i] = formMenu.strCounty[i];
                        formMenu.strTempStreetAdrress[i] = formMenu.strStreetAdrress[i];
                        formMenu.strTempCityAndZipCode[i] = formMenu.strCityAndZipCode[i];
                        formMenu.strTempPhoneNum[i] = formMenu.strPhoneNum[i];
                        formMenu.strTempPrincipal[i] = formMenu.strPrincipal[i];
                        formMenu.strTempGradeSpan[i] = formMenu.strGradeSpan[i];
                        formMenu.strTempOpenOrClosedStatus[i] = formMenu.strOpenOrClosedStatus[i];
                        formMenu.strTempDesignation[i] = formMenu.strDesignation[i];
                        formMenu.strTempNumOfStandardsMet[i] = formMenu.strNumOfStandardsMet[i];
                        formMenu.strTempNumOfStandardsPossible[i] = formMenu.strNumOfStandardsPossible[i];
                        formMenu.strTempEnrollment[i] = formMenu.strEnrollment[i];
                        formMenu.strTempAttendance2005to06[i] = formMenu.strAttendance2005to06[i];
                        formMenu.strTempPerformanceIndexScore2005to06[i] = formMenu.strPerformanceIndexScore2005to06[i];
                    }

                    //inputting last item into end of temp array       
                    formMenu.strTempBuildingIRN[formMenu.strTempBuildingIRN.Length - 1] = txtbxBuildingIRN.Text;
                    formMenu.strTempBuildingName[formMenu.strTempBuildingName.Length - 1] = txtbxBuildingName.Text;
                    formMenu.strTempDistrictIRN[formMenu.strTempDistrictIRN.Length - 1] = txtbxDistrictIRN.Text;
                    formMenu.strTempDistrictName[formMenu.strTempDistrictName.Length - 1] = txtbxDistrictName.Text;
                    formMenu.strTempCounty[formMenu.strTempCounty.Length - 1] = txtbxCounty.Text;
                    formMenu.strStreetAdrress[formMenu.strStreetAdrress.Length - 1] = txtbxStreetAddress.Text;
                    formMenu.strTempCityAndZipCode[formMenu.strTempCityAndZipCode.Length - 1] = txtbxCityAndZipCode.Text;
                    formMenu.strTempPhoneNum[formMenu.strTempPhoneNum.Length - 1] = txtbxPhoneNum.Text;
                    formMenu.strTempPrincipal[formMenu.strTempPrincipal.Length - 1] = txtbxPrincipal.Text;
                    formMenu.strTempGradeSpan[formMenu.strTempGradeSpan.Length - 1] = txtbxGradeSpan.Text;
                    formMenu.strTempOpenOrClosedStatus[formMenu.strTempOpenOrClosedStatus.Length - 1] = txtbxOpenOrClosedStatus.Text;
                    formMenu.strTempDesignation[formMenu.strTempDesignation.Length - 1] = txtbxDesignation.Text;
                    formMenu.strTempNumOfStandardsMet[formMenu.strTempNumOfStandardsMet.Length - 1] = txtbxNumOfStandardsMet.Text;
                    formMenu.strTempNumOfStandardsPossible[formMenu.strTempNumOfStandardsPossible.Length - 1] = txtbxNumOfStandardsPossible.Text;
                    formMenu.strTempEnrollment[formMenu.strTempEnrollment.Length - 1] = txtbxEnrollment.Text;
                    formMenu.strTempAttendance2005to06[formMenu.strTempAttendance2005to06.Length - 1] = txtbxAttendance2005To06.Text;
                    formMenu.strTempPerformanceIndexScore2005to06[formMenu.strTempPerformanceIndexScore2005to06.Length - 1] = txtbxPerformanceIndexScore2005To06.Text;
                    
                    //declaring size for new arrays
                    formMenu.strBuildingIRN = new string[formMenu.strBuildingIRN.Length + 1];
                    formMenu.strBuildingName = new string[formMenu.strBuildingName.Length + 1];
                    formMenu.strDistrictIRN = new string[formMenu.strDistrictIRN.Length + 1];
                    formMenu.strDistrictName = new string[formMenu.strDistrictName.Length + 1];
                    formMenu.strCounty = new string[formMenu.strCounty.Length + 1];
                    formMenu.strStreetAdrress = new string[formMenu.strStreetAdrress.Length + 1];
                    formMenu.strCityAndZipCode = new string[formMenu.strCityAndZipCode.Length + 1];
                    formMenu.strPhoneNum = new string[formMenu.strPhoneNum.Length + 1];
                    formMenu.strPrincipal = new string[formMenu.strPrincipal.Length + 1];
                    formMenu.strGradeSpan = new string[formMenu.strGradeSpan.Length + 1];
                    formMenu.strOpenOrClosedStatus = new string[formMenu.strOpenOrClosedStatus.Length + 1];
                    formMenu.strDesignation = new string[formMenu.strDesignation.Length + 1];
                    formMenu.strNumOfStandardsMet = new string[formMenu.strNumOfStandardsMet.Length + 1];
                    formMenu.strNumOfStandardsPossible = new string[formMenu.strNumOfStandardsPossible.Length + 1];
                    formMenu.strEnrollment = new string[formMenu.strEnrollment.Length + 1];
                    formMenu.strAttendance2005to06 = new string[formMenu.strAttendance2005to06.Length + 1];
                    formMenu.strPerformanceIndexScore2005to06 = new string[formMenu.strPerformanceIndexScore2005to06.Length + 1];

                    //inputting info into orig array
                    for (int i = 0; i < formMenu.strBuildingIRN.Length; i++)
                    {
                        formMenu.strBuildingIRN[i] = formMenu.strTempBuildingIRN[i];
                        formMenu.strBuildingName[i] = formMenu.strTempBuildingName[i];
                        formMenu.strDistrictIRN[i] = formMenu.strTempDistrictIRN[i];
                        formMenu.strDistrictName[i] = formMenu.strTempDistrictName[i];
                        formMenu.strCounty[i] = formMenu.strTempCounty[i];
                        formMenu.strStreetAdrress[i] = formMenu.strTempStreetAdrress[i];
                        formMenu.strCityAndZipCode[i] = formMenu.strTempCityAndZipCode[i];
                        formMenu.strPhoneNum[i] = formMenu.strTempPhoneNum[i];
                        formMenu.strPrincipal[i] = formMenu.strTempPrincipal[i];
                        formMenu.strGradeSpan[i] = formMenu.strTempGradeSpan[i];
                        formMenu.strOpenOrClosedStatus[i] = formMenu.strTempOpenOrClosedStatus[i];
                        formMenu.strDesignation[i] = formMenu.strTempDesignation[i];
                        formMenu.strNumOfStandardsMet[i] = formMenu.strTempNumOfStandardsMet[i];
                        formMenu.strNumOfStandardsPossible[i] = formMenu.strTempNumOfStandardsPossible[i];
                        formMenu.strEnrollment[i] = formMenu.strTempEnrollment[i];
                        formMenu.strAttendance2005to06[i] = formMenu.strTempAttendance2005to06[i];
                        formMenu.strPerformanceIndexScore2005to06[i] = formMenu.strTempPerformanceIndexScore2005to06[i];
                    }

                    //check if buildingIRN and enrollment are numbers (will create error if it is unable to parse which will lead to the catch message)
                    int intTempBuildingIRN;
                    int intTempEnrollment;
                    intTempBuildingIRN = Int32.Parse(txtbxBuildingIRN.Text); //no if statement for building irn one, since it is required
                    if (txtbxEnrollment.Text != "") //if statement for enrollment because it isn't required but if it's included, it must be a number
                    {
                        intTempEnrollment = Int32.Parse(txtbxEnrollment.Text);
                    }

                    //if there were no errors and the added record was successfully implemented
                    MessageBox.Show("Your record has been added");

                    //clear labels
                    txtbxBuildingIRN.Text = "";
                    txtbxBuildingName.Text = "";
                    txtbxDistrictIRN.Text = "";
                    txtbxDistrictName.Text = "";
                    txtbxCounty.Text = "";
                    txtbxStreetAddress.Text = "";
                    txtbxCityAndZipCode.Text = "";
                    txtbxPhoneNum.Text = "";
                    txtbxPrincipal.Text = "";
                    txtbxGradeSpan.Text = "";
                    txtbxOpenOrClosedStatus.Text = "";
                    txtbxDesignation.Text = "";
                    txtbxNumOfStandardsMet.Text = "";
                    txtbxNumOfStandardsPossible.Text = "";
                    txtbxEnrollment.Text = "";
                    txtbxAttendance2005To06.Text = "";
                    txtbxPerformanceIndexScore2005To06.Text = "";
                }
                catch (Exception)   //record will not be added and this will be shows, labels are not cleared and user is able to fix their info
                {
                    MessageBox.Show("There was an error with your input, make sure your BuildingIRN and enrollment are numbers");
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