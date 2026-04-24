using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicketApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
        }

        // LOAD COMBOBOX 
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Select category");
            cmbCategory.Items.Add("Category One");
            cmbCategory.Items.Add("Category Two");
            cmbCategory.Items.Add("Category Three");

            cmbCategory.SelectedIndex = 0;
        }

        // CALCULATE BUTTON 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtDistance.Text) ||
                    cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int age = int.Parse(txtAge.Text);
                double distance = double.Parse(txtDistance.Text);

                double rate = 0;

                if (cmbCategory.SelectedItem.ToString() == "Category One")
                    rate = 20;
                else if (cmbCategory.SelectedItem.ToString() == "Category Two")
                    rate = 35;
                else if (cmbCategory.SelectedItem.ToString() == "Category Three")
                    rate = 50;

                double total = rate * distance;

                if (age < 12)
                    total = 0;

                if (rbFemale.Checked && age >= 12)
                    total *= 0.5;

                MessageBox.Show("Total Ticket Price: R " + total.ToString("0.00"));
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for age and distance.");
            }
        }

        // CLEAR BUTTON 
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();

            cmbCategory.SelectedIndex = 0;

            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        // EXIT BUTTON 
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // DESIGNER EVENTS 
        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}