//Name:     Shazam Zafar
//Date:     1/13/2019
//Class:    C Sharp
//Program:  Temperature Converter

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterZafar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FahrenheitButton_Click(object sender, EventArgs e)
        {
            // try block
            try
            {

                // Variables
                double C;
                double F;

                //converting textbox
                C = double.Parse(TempTextBox.Text);

                // Formula  for Fahrenheit
                F = C * 9 / 5 + 32;

                // Displaying 
                TempLabel.Text = F.ToString();
            }
            // Catch block to catch any erros
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CelsiusButton_Click(object sender, EventArgs e)
        {
            // Try Block
            try
            {
                // Variables
                double C;
                double F;

                //Converting Textbox
                F = double.Parse(TempTextBox.Text);

                //Formula  for Celsius
                C = 5.0 / 9.0 * (F - 32);

                //Displaying
                TempLabel.Text = C.ToString();
            }
            // Catch block to catch any erros
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clearing The TextBox
            TempTextBox.Clear();
            //Clearing The Label
            TempLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exiting the Program
            Close();
        }
    }
}
