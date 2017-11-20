//Timothy Mahan
//Program 2
//Due 3/8/16
//Section 01
/*This program takes the character entered in the first position of the text box and trys to parse it into a char variable.
 *Next the credit hours entered by the user are entered and parsed into a float variable. Both of these pieces of information are then 
 *tested to determine when a student should register based on the input they provide.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONSTANTS
            const byte SOPHOMORE = 30;//minimum hours needed to be a sophomore
            const byte JUNIOR = 60;//minimum hours needed to be a junior
            const byte SENIOR = 90;//minimum hours needed to be a senior

            //User Input
            float credits = 0;//store number of credit hours entered by student
            char name; //stores first letter of last name

            //Output Strings 

            //These store time and day depending on credit hours and last name
            string time = "default";
            string day = "default";

            //these times are the five possible periods for opening registration
            string regtime1 = "8:30 AM";
            string regtime2 = "10:00 AM";
            string regtime3 = "11:30 AM";
            string regtime4 = "2:00 PM";
            string regtime5 = "4:00 PM";

            //These are all of the possible days for opening registration
            string regDay1 = "March 30";//senior registration day
            string regDay2 = "March 31";//junior registration day
            string regDay3 = "April 1";//first registration day for sophomores
            string regDay4 = "April 4";//second registration day for sophomores
            string regDay5 = "April 5";//first registration day for freshmen
            string regDay6 = "April 6";//second registration day for freshmen

            if (char.IsLetter(nameTxtBox.Text, 0))//test to see if the first digit in the nameTxtBox Textproperty is valid
            {
                name = char.ToUpper(nameTxtBox.Text[0]);
                if (float.TryParse(creditsTxtBox.Text, out credits))//test to see if the credits Text property can be parsed as double.
                {
                    if (credits >= 0)
                    {
                        if (credits < JUNIOR)//test to see if a student is not a junior or senior
                        {
                            if (name >= 'E' && name <= 'F' || name >= 'R' && name <= 'S')//see what time a student may register based on name
                            {
                                time = regtime1;
                            }
                            else if (name >= 'G' && name <= 'I' || name >= 'T' && name <= 'V')
                            {
                                time = regtime2;
                            }
                            else if (name >= 'J' && name <= 'L' || name >= 'W' && name <= 'Z')
                            {
                                time = regtime3;
                            }
                            else if (name >= 'M' && name <= 'O' || name >= 'A' && name <= 'B')
                            {
                                time = regtime4;
                            }
                            else
                            {
                                time = regtime5;
                            }
                            if (credits < SOPHOMORE)//tests to see if freshmen
                            {
                                if (name >= 'E' && name <= 'Q')//sets day for freshmen depending on name's value
                                {
                                    day = regDay5;
                                }
                                else
                                {
                                    day = regDay6;
                                }
                            }
                            else
                            {
                                if (name >= 'E' && name <= 'Q')//sets day for sophomore depending on name's value
                                {
                                    day = regDay3;
                                }
                                else
                                {
                                    day = regDay4;
                                }
                            }
                        }
                        else
                        {
                            if (name >= 'E' || name <= 'I')//time student may register based on name value
                            {
                                time = regtime1;
                            }
                            else if (name >= 'J' || name <= 'O')
                            {
                                time = regtime2;
                            }
                            else if (name >= 'P' || name <= 'S')
                            {
                                time = regtime3;
                            }
                            else if (name >= 'T' || name <= 'Z')
                            {
                                time = regtime4;
                            }
                            else
                            {
                                time = regtime5;
                            }
                            if (credits < SENIOR)//determines whether junior or senior, sets day according to credits value.
                            {
                                day = regDay2;
                            }
                            else
                            {
                                day = regDay1;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Total Credits Earned hours must be greater than or equal to 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Please only enter non-negative numbers in the Credit Hours box.");
                }
            }
            else
            {
                MessageBox.Show("Please only enter text characters in the Last Name box.");
            }
            regLbl.Text = day + ", " + time;
        }
    }
}
