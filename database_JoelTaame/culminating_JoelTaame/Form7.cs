//Name: Joel Taame
//Date: 19/12/2017
//Title: formHistgram
//Purpose: displays histogram displaying number of shcools that have a certain number of enrollments

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
    public partial class formHistogram : Form
    {
        public formHistogram()
        {
            InitializeComponent();
        }

        private void formHistogram_Load(object sender, EventArgs e)     //this will run every time form will load in case records are modified
        {
            //number of records for their respective ranges variables declared
            int intbar0 = 0;
            int intbar1 = 0;
            int intbar2 = 0;
            int intbar3 = 0;
            int intbar4 = 0;
            int intbar5 = 0;
            int intbar6 = 0;
            int intbar7 = 0;
            int intbar8 = 0;
            int intbar9 = 0;
            int intbar10 = 0;

            //finds number of records for each range
            for (int i = 0; i < formMenu.strEnrollment.Length; i++)
            {
                if  (formMenu.strEnrollment[i] != "--" && formMenu.strEnrollment[i] != "NC" && formMenu.strEnrollment[i] != "")
                {
                    if (Int32.Parse(formMenu.strEnrollment[i]) < 100)
                    {
                        intbar0++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 100 && Int32.Parse(formMenu.strEnrollment[i]) < 200)
                    {
                        intbar1++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 200 && Int32.Parse(formMenu.strEnrollment[i]) < 300)
                    {
                        intbar2++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 300 && Int32.Parse(formMenu.strEnrollment[i]) < 400)
                    {
                        intbar3++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 400 && Int32.Parse(formMenu.strEnrollment[i]) < 500)
                    {
                        intbar4++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 500 && Int32.Parse(formMenu.strEnrollment[i]) < 600)
                    {
                        intbar5++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 600 && Int32.Parse(formMenu.strEnrollment[i]) < 700)
                    {
                        intbar6++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 700 && Int32.Parse(formMenu.strEnrollment[i]) < 800)
                    {
                        intbar7++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 800 && Int32.Parse(formMenu.strEnrollment[i]) < 900)
                    {
                        intbar8++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 900 && Int32.Parse(formMenu.strEnrollment[i]) < 1000)
                    {
                        intbar9++;
                    }
                    else if (Int32.Parse(formMenu.strEnrollment[i]) >= 1000)
                    {
                        intbar10++;
                    }
                }
            }

            /*heights and locations for each bar
             * the reason for multiplying by 0.36 is because the space between the horizontal lines in 36 pixels
             * the reason for the x axis for the location is because that's where that certain bar is located on the form
             * the reason for the y axis being 422 - the bar height is because the base line's y location is 422 and you subtract by the bar height to move it higher
                    (the reason the bar moves higher when you subtract is because the y location will be closer to 0, and since the top of the form is 0 due to the quadrent grid system, the bar will move up
             */

            //first bar
            if (intbar0 < 100)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 200)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 300)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 400)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 500)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 600)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 700)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 800)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 900)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 < 1000)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }
            else if (intbar0 >= 1000)
            {
                bar100.Height = (int)(intbar0 * 0.36);
                bar100.Location = new Point(133, 422 - bar100.Height);
            }

            //second bar
            if (intbar1 < 100)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 200)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 300)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 400)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 500)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 600)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 700)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 800)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 900)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 < 1000)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }
            else if (intbar1 >= 1000)
            {
                bar200.Height = (int)(intbar1 * 0.36);
                bar200.Location = new Point(186, 422 - bar200.Height);
            }

            //third bar
            if (intbar2 < 100)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 200)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 300)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 400)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 500)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 600)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 700)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 800)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 900)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 < 1000)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }
            else if (intbar2 >= 1000)
            {
                bar300.Height = (int)(intbar2 * 0.36);
                bar300.Location = new Point(240, 422 - bar300.Height);
            }

            //fourth bar
            if (intbar3 < 100)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 200)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 300)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 400)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 500)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 600)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 700)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 800)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 900)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 < 1000)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }
            else if (intbar3 >= 1000)
            {
                bar400.Height = (int)(intbar3 * 0.36);
                bar400.Location = new Point(294, 422 - bar400.Height);
            }

            //fifth bar
            if (intbar4 < 100)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 200)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 300)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 400)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 500)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 600)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 700)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 800)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 900)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 < 1000)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }
            else if (intbar4 >= 1000)
            {
                bar500.Height = (int)(intbar4 * 0.36);
                bar500.Location = new Point(349, 422 - bar500.Height);
            }

            //sixth bar
            if (intbar5 < 100)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 200)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 300)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 400)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 500)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 600)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 700)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 800)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 900)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 < 1000)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }
            else if (intbar5 >= 1000)
            {
                bar600.Height = (int)(intbar5 * 0.36);
                bar600.Location = new Point(403, 422 - bar600.Height);
            }

            //seventh bar
            if (intbar6 < 100)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 200)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 300)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 400)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 500)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 600)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 700)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 800)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 900)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 < 1000)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }
            else if (intbar6 >= 1000)
            {
                bar700.Height = (int)(intbar6 * 0.36);
                bar700.Location = new Point(458, 422 - bar700.Height);
            }

            //eight bar
            if (intbar7 < 100)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 200)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 300)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 400)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 500)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 600)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 700)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 800)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 900)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 < 1000)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }
            else if (intbar7 >= 1000)
            {
                bar800.Height = (int)(intbar7 * 0.36);
                bar800.Location = new Point(512, 422 - bar800.Height);
            }

            //ninth bar
            if (intbar8 < 100)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 200)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 300)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 400)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 500)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 600)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 700)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 800)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 900)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 < 1000)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }
            else if (intbar8 >= 1000)
            {
                bar900.Height = (int)(intbar8 * 0.36);
                bar900.Location = new Point(566, 422 - bar900.Height);
            }

            //tenth bar
            if (intbar9 < 100)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 200)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 300)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(186, 422 - bar1000.Height);
            }
            else if (intbar9 < 400)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 500)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 600)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(186, 422 - bar1000.Height);
            }
            else if (intbar9 < 700)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 800)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 900)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 < 1000)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }
            else if (intbar9 >= 1000)
            {
                bar1000.Height = (int)(intbar9 * 0.36);
                bar1000.Location = new Point(620, 422 - bar1000.Height);
            }

            //eleventh bar
            if (intbar10 < 100)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 200)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 300)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 400)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 500)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 600)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 700)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 800)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 900)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 < 1000)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
            else if (intbar10 >= 1000)
            {
                bar1000up.Height = (int)(intbar10 * 0.36);
                bar1000up.Location = new Point(674, 422 - bar1000up.Height);
            }
        }

        private void btnReturnToMM_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu f = new formMenu();
            f.Show();
        }
    }
}