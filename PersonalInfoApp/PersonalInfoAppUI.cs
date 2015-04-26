using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class PersonalInformationAppUI : Form
    {
        public PersonalInformationAppUI()
        {
            InitializeComponent();
        }
         
        List<string> personalInfo = new List<string> { };
       
        private void saveInfoButton_Click(object sender, EventArgs e)
        {   //save info in a text box
            if (firstNameTextBox.Text != string.Empty)
            {
                personalInfo.Add(firstNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Enter First Name");
            }
            if(lastNameTextBox.Text != string.Empty)
            { 
                personalInfo.Add(lastNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Last Name");
            }
            if(fatherNameTextBox.Text != string.Empty)
            {
            personalInfo.Add(fatherNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Entee Father's Name");
                
            }
            if(motherNameTextBox.Text != string.Empty)
            {
            personalInfo.Add(motherNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Mother's Name");
            }
            if (adrressTextBox.Text != string.Empty)
            {
                personalInfo.Add(adrressTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Address");
            }

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            adrressTextBox.Clear();



        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            string[] personalInformation = personalInfo.ToArray();
          
            MessageBox.Show("First Name : "+personalInformation[0]+ "\n \nLast Name : "+personalInformation[1]+ 
                "\n \nFather's Name : "+personalInformation[2]+ "\n \nMother's Name: "+personalInformation[3]+"\n \nAddress: "+
                personalInformation[4],personalInformation[0]+"'s Information");

        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            string[] personalInformation = personalInfo.ToArray();
            MessageBox.Show("Name :" + personalInformation[0] + " " + personalInformation[1],"Name");

        }

        private void showParentsNameButton_Click(object sender, EventArgs e)
        {   
            string []personalInformation=personalInfo.ToArray();
            MessageBox.Show("Fathers's Name :" + personalInformation[2]+"\nMother's Name :"+ personalInformation[3],"Parents Inoformation");

        }

        private void showAddressButton_Click(object sender, EventArgs e)
        {
            string[] personalInformation = personalInfo.ToArray();
            MessageBox.Show(personalInformation[4],"Address");

        }
    }
}
