using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {

        }

        private void myButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Visible = true;
            greetingLabel.Text = nameTextBox.Text + ", Have a nice day :)";
            nameTextBox.Visible = false;
            myButton.Visible = false;
            colorLabel.Visible = false;
            colorComboBox.Visible = false;
            Tshirtimg.Visible = true;
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorComboBox.SelectedIndex == 0)
            {
                this.BackColor = Color.Red;
            }
            else if (colorComboBox.SelectedIndex == 1)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

    }
}
