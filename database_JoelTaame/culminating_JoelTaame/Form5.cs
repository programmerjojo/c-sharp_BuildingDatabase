//Name: Joel Taame
//Date: 19/12/2017
//Title: formSummaryData
//Purpose: allows user to explore more information such as total enrollment, lowest enrollment, num of records, num of counties, abd a histogram

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
    public partial class formSummaryOfData : Form
    {
        public formSummaryOfData()
        {
            InitializeComponent();
        }    

        //total enrollment
        private void btnTotalEnrollment_Click(object sender, EventArgs e)
        {
            int sumOfEnrollment = 0;

            //adds all the ernollments one by one (uses if statements to prevent error)
            for (int i = 0; i < formMenu.strEnrollment.Length; i++)
            {
                if  (formMenu.strEnrollment[i] != "--" && formMenu.strEnrollment[i] != "NC" && formMenu.strEnrollment[i] != "")
                {
                    sumOfEnrollment += Int32.Parse(formMenu.strEnrollment[i]);        
                }
            }

            txtbxSummaryOfDataOptionResult.Text = sumOfEnrollment.ToString();
        }
        //lowest enrollment
        private void btnLowestEnrollment_Click(object sender, EventArgs e)
        {
            int lowestEnrollment = 100000000;   //has to start at a high number for the sake of the loop (you could set the value to the first value of the strEnrollment array however with another data set the first record can have a "" value and it will cause an error)

            //checks for smallest enrollment one by one (uses if statement to get rid errors caused by exceptions)
            for (int i = 0; i < formMenu.strEnrollment.Length; i++)
            {
                if (formMenu.strEnrollment[i] != "--" && formMenu.strEnrollment[i] != "NC" && formMenu.strEnrollment[i] != "")
                {
                    if (Int32.Parse(formMenu.strEnrollment[i]) < lowestEnrollment)
                    {
                        lowestEnrollment = Int32.Parse(formMenu.strEnrollment[i]);
                    }
                }
            }
            
            txtbxSummaryOfDataOptionResult.Text = lowestEnrollment.ToString();
        }
        //highest enrollment
        private void btnHighestEnrollment_Click(object sender, EventArgs e)
        {
            int highestEnrollment = 0;   //has to start at a high number for the sake of the loop (you could set the value to the first value of the strEnrollment array however with another data set the first record can have a "" value and it will cause an error)

            //checks for smallest enrollment one by one (uses if statement to get rid errors caused by exceptions)
            for (int i = 0; i < formMenu.strEnrollment.Length; i++)
            {
                if (formMenu.strEnrollment[i] != "--" && formMenu.strEnrollment[i] != "NC" && formMenu.strEnrollment[i] != "")
                {
                    if (Int32.Parse(formMenu.strEnrollment[i]) > highestEnrollment)
                    {
                        highestEnrollment = Int32.Parse(formMenu.strEnrollment[i]);
                    }
                }
            }

            txtbxSummaryOfDataOptionResult.Text = highestEnrollment.ToString();
        }

        //number of records
        private void btnNumOfRecords_Click(object sender, EventArgs e)
        {
            txtbxSummaryOfDataOptionResult.Text = formMenu.strBuildingIRN.Length.ToString();    //length of array is number of records
        }      
        //number of counties
        private void btnNumOfCounty_Click(object sender, EventArgs e)
        {
            int sumOfCounty = 0;

            //declare size of temp array
            formMenu.strTempCounty = new string[formMenu.strCounty.Length];
            for (int i = 0; i < formMenu.strCounty.Length; i++)
            {
                formMenu.strTempCounty[i] = formMenu.strCounty[i];
            }

            //double loop that ultimately turns every duplucate of a certain county and changes its value into nothing ("")
            for (int i = 0; i < formMenu.strTempCounty.Length; i++)
            {
                for (int j = 0; j < formMenu.strTempCounty.Length; j++)
                {
                    if (formMenu.strTempCounty[i] == formMenu.strTempCounty[j] && i != j)
                    {
                        formMenu.strTempCounty[i] = "";
                    }
                }
            }

            //adds up all counties that are left
            for (int i = 0; i < formMenu.strTempCounty.Length; i++)
            {
                if (formMenu.strTempCounty[i] != "")
                {
                    sumOfCounty++;
                }
            }
            txtbxSummaryOfDataOptionResult.Text = sumOfCounty.ToString();
        }

        //histogram
        private void btnHistogram_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHistogram f = new formHistogram();
            f.Show();
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