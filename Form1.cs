using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string StudentName;
                int StudentID, Age;
                string gender = " ", courses = " ", fullSTDinfo, Extra = " ";
                StudentName = textBox1.Text;
                //vallidating and parsing for id_textBox & age using try parse
                if (int.TryParse(textBox2.Text, out StudentID))
                {
                   
                }
                else
                {
                    MessageBox.Show("waxa number eheen lama ogolo");
                     }

                Age = int.Parse(textBox3.Text);
                Age = int.Parse(textBox3.Text);
                if (Age >= 18 & Age <= 35)
                {

                     
                }
                else
                {
                    MessageBox.Show("so gali da'a udhaxeyso 18 ila 35");
                    
                }

                 //meeshan waxa lagu hubina jinsiga qofka.
                if (Male.Checked)
                {
                    gender = "Male";
                }
                else if (Female.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("wa ina dorata mid kamida");
                }
                 if (listBox1.SelectedIndex != -1)
                {
                    courses =listBox1.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("errors.Message ");

                }
                //Extra curricular checking
                if (checkBox1.Checked)
                {
                    Extra = " YES";
                }
                else
                {
                    Extra = "NO";
                }
                fullSTDinfo = "Name: " + StudentName + " \n  ID: " + StudentID + "\n  Age: " + Age + "\n  Gender: " + gender + "\n   Extra_curricular:  " + Extra + "\n   courses: " + courses;

                label4.Text = fullSTDinfo;


                textBox1.Focus();
            }
            catch (Exception errors)
            {
                MessageBox.Show(errors.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.ClearSelected();
            checkBox1.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
