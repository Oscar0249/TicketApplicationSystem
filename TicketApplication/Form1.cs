using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int distance = int.Parse(txtDistance.Text);
            string category = cmbCategory.Text;

            string gender = rbMale.Checked ? "Male" : "Female";

            MessageBox.Show(
                $"Name : {name}\nGender: {gender}\nAge: {age}\nCategory:\nDistance: {distance} km", "Ticket Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();
            cmbCategory.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
