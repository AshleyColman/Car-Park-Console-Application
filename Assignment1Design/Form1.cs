using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //For saving and loading files
namespace Assignment1Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e) // Calculate Button Code
        {
            int iNumLines = txtTimes.Lines.Length; // Counts the amount of lines in the textbox
            string[] sNumbers = new string[iNumLines]; // Makes a string array for the number of lines in the textbox
            sNumbers = txtTimes.Text.Split('\n'); // Splits the input of the textbox into lines
            int[] iNumbers = new int[iNumLines]; // New int array using iNumLines//
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion holds sNumbers and iNumLines
            Allotted(iNumbers, iNumLines, txtAllotted, txtTimeLimit); // Calling Allotted Function
            OverPercent(iNumbers, iNumLines, txtOverPercent, txtTimeLimit); // Calling OverPercent Function
            Warden(iNumbers, iNumLines, txtWarden, txtTimeLimit); // Calling Warden Function
        }


        public int[] ArrayConversion(string[] sNumbers, int iNumlines) // Array Conversion
        {
            int[] iNumbers = new int[iNumlines]; // Int iNumbers array 
            int iCount = 0; // Int iCount for loop
            int iOut = 0; // Int Out
            while (iCount < iNumlines) // While iCount is less than iNumLines
            {
                if (int.TryParse(sNumbers[iCount], out iOut)) // If the sNumbers can be converted to an int output
                {
                    iNumbers[iCount] = Convert.ToInt32(sNumbers[iCount]); // Convert sNumbers to int iNumbers
                }
                else // If False
                {
                    iNumbers[iCount] = 0; // Int iNumbers = 0
                }
                iCount++; // Loops around the array
            }

            return iNumbers; // Return iNumbers

        }

        public void Allotted(int[] iNumbers, int iNumLines, TextBox txtAllotted, TextBox txtTimeLimit) // Procedure returning nothing because void return type, variables passed, textbox output
        {
            int iCount = 0; // Int iCount for loop
            int iOver = 0; // Int iOver for numbers over timelimit
            string sLimit = Convert.ToString(txtTimeLimit.Text);
            int iLimit = Convert.ToInt32(sLimit); // Converts sLimit text to int

            while (iCount < iNumLines) // While iCount is less than iNumlines
            {
                if (iNumbers[iCount] > iLimit) // If iNumbers cell is greater than iLimit
                {
                    iOver++; // Add 1 to int iOver
                }
                else // If condition is not true
                {

                }
                iCount++; // Loops around array
            }
            txtAllotted.Text = Convert.ToString(iOver); // Ouputs int iOver in txtAllotted textbox
            return; // Returns back to the program
        }

        public void OverPercent(int[] iNumbers, int iNumLines, TextBox txtOverPercent, TextBox txtTimeLimit) // Procedure returning nothing because void return type, variables passed, textbox output
        {
            int iCount = 0; // int iCount for loop
            double dOver = 0; // double dOver

            int iLimit = Convert.ToInt32(txtTimeLimit.Text); // Converts the text in txtTimeLimit to an int value and stores in iLimit //

            while (iCount < iNumLines) // Whilst iCount is smaller than iNumlines
            {

                if (iNumbers[iCount] > iLimit)// If iNumbers, cell, is greater than iLimit
                {
                    dOver++; // Add 1 to dOver
                }

                iCount++; // Loops around the array
            }

            double dPercentageOver = (dOver / iNumLines) * 100; // dPercentage over = iOver divded by iNumlines, times 100
            string sPercent = Convert.ToString(dPercentageOver); // Converts dPercentOver to a string value 
            txtOverPercent.Text = sPercent; // Outputs sPercent in txtOverPercent

        }

        public void Warden(int[] iNumbers, int iNumLines, TextBox txtWarden, TextBox txtTimeLimit) // Procedure returning nothing because void return type, variables passed, textbox output
        {
            int iCount = 0; // int ICount for loop
            double dOver = 0; // double dOver
            string sLimit = txtTimeLimit.Text; // string sLimit
            int iLimit = Convert.ToInt32(sLimit); // Converts sLimit to int value

            while (iCount < iNumLines) // While iCount is smaller than iNumLines
            {
                if (iNumbers[iCount] > iLimit) // if iNumbers, cell, is greater than iLimit
                {
                    dOver++; // Add 1 to dOver
                }

                iCount++; // Loops around the array
            }

            double dPercentage = (dOver / iNumLines) * 100; // Percentage calculation
            if (dPercentage > 50) // If dPercentage is greater than 50
            {
                txtWarden.Text = "Send"; // Output "Send" string in txtWarden
            }
            else // If false
            {
                txtWarden.Text = "Don't Send"; // Output "Don't Send" string in txtWarden
            }

        }
        private void btnCalculate2_Click(object sender, EventArgs e)
        {


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Second Calculate Button
        {
            int iNumLines = txtTimes2.Lines.Length; // Counts the amount of lines in the textbox
            string[] sNumbers = new string[iNumLines]; // Makes string array for the number of lines in the textbox
            sNumbers = txtTimes2.Text.Split('\n'); // Splits the input of the textbox into lines
            int[] iNumbers = new int[iNumLines]; // New int array using iNumLines//
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion holds sNumbers and iNumLines
            Allotted(iNumbers, iNumLines, txtAllotted2, txtTimeLimit2); // Calling Allotted Function
            OverPercent(iNumbers, iNumLines, txtOverPercent2, txtTimeLimit2); // Calling OverPercent Function
            Warden(iNumbers, iNumLines, txtWarden2, txtTimeLimit2); //Calling Warden Function
        }

        private void btnCalculate3_Click(object sender, EventArgs e) // Third Calculate Button
        {
            int iNumLines = txtTimes3.Lines.Length; // Counts the amount of lines in the textbox
            string[] sNumbers = new string[iNumLines]; // Makes string array for the number of lines in the textbox
            sNumbers = txtTimes3.Text.Split('\n'); // Splits the input of the textbox into lines
            int[] iNumbers = new int[iNumLines]; // New int array using iNumLines//
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion holds sNumbers and iNumLines
            Allotted(iNumbers, iNumLines, txtAllotted3, txtTimeLimit3); // Calling Allotted Function
            OverPercent(iNumbers, iNumLines, txtOverPercent3, txtTimeLimit3); // Calling OverPercent Function
            Warden(iNumbers, iNumLines, txtWarden3, txtTimeLimit3); // Calling Warden Function
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exits the application when clicked
        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace); // Launches the help application 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iNumLines = txtTimes.Lines.Length; // int iNumLines = the number of lines in tTimes

            string[] sNumbers = new string[iNumLines]; // New string array called sNumbers, uses iNumLines
            sNumbers = txtTimes.Text.Split('\n'); // sNumbers = the number of lines in txtTimes
            int[] iNumbers = new int[iNumLines]; // New int array called iNumbers, uses iNumLines
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion Function call

            string[] sData = new string[6]; // Creates data array with 6 cells
            sData[0] = txtCarParkName.Text + Environment.NewLine; // Data cell 0 takes text within txtCarParkName and adds new line
            sData[1] = txtTimes.Text + Environment.NewLine; // Data cell 0 takes text within txtTimes and adds new line
            sData[2] = txtTimeLimit.Text + Environment.NewLine; // Data cell 1 takes text within txtTimeLimit and adds new line
            sData[3] = txtAllotted.Text + Environment.NewLine; // Data cell 2 takes text within txtAllotted and adds new line
            sData[4] = txtOverPercent.Text + Environment.NewLine; // Data cell 3 takes text within txtOverPercent and adds new line
            sData[5] = txtWarden.Text; // Data cell 4 takes text within txtWarden and adds new line

            System.IO.File.WriteAllLines(@"H:\My Documents\data1.txt", sData); // Writes data to data1.txt file located in My Documents
            MessageBox.Show("Saved"); // Displays Saved string in a MessageBox to the user once saved
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTimes.Text = string.Empty; // Clears the textbox before loading
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"H:\My Documents\data1.txt")) //Loads the file named "data1" from the My Documents storage location//
            {
                string sLine; // String name called sLine
                int iLines = File.ReadLines(@"H:\My Documents\data1.txt").Count(); // Reads the lines within the data3 file
                while ((sLine = file.ReadLine()) != null) // While sLine equals the line read within the file
                {
                    txtTimes.Text += sLine; // Puts file output into the Times textbox
                    txtTimes.Text += Environment.NewLine; // Writes a new line
                }
                MessageBox.Show("File Loaded"); // Displays a messagebox
            }
        }

        private void save2ToolStripMenuItem_Click(object sender, EventArgs e) // Second Save Function
        {
            int iNumLines = txtTimes.Lines.Length; // int iNumLines = the number of lines in tTimes

            string[] sNumbers = new string[iNumLines]; // New string array called sNumbers, uses iNumLines
            sNumbers = txtTimes.Text.Split('\n'); // sNumbers = the number of lines in txtTimes
            int[] iNumbers = new int[iNumLines]; // New int array called iNumbers, uses iNumLines
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion Function call

            string[] sData = new string[6]; // Creates data array with 6 cells
            sData[0] = txtCarParkName2.Text + Environment.NewLine; // Data cell 0 takes text within txtCarParkName and adds new line
            sData[1] = txtTimes2.Text + Environment.NewLine; // Data cell 1 takes text within txtTimes and adds new line
            sData[2] = txtTimeLimit2.Text + Environment.NewLine; // Data cell 2 takes text within txtTimeLimit and adds new line
            sData[3] = txtAllotted2.Text + Environment.NewLine; // Data cell 3 takes text within txtAllotted and adds new line
            sData[4] = txtOverPercent2.Text + Environment.NewLine; // Data cell 4 takes text within txtOverPercent and adds new line
            sData[5] = txtWarden2.Text; // Data cell 5 takes text within txtWarden and adds new line

            System.IO.File.WriteAllLines(@"H:\My Documents\data2.txt", sData); // Writes data to data2.txt file located in My Documents
            MessageBox.Show("Saved"); // Displays Saved string in a MessageBox to the user once saved
        }

        private void save3ToolStripMenuItem_Click(object sender, EventArgs e) // Third Save Function
        {
            int iNumLines = txtTimes.Lines.Length; // int iNumLines = the number of lines in tTimes

            string[] sNumbers = new string[iNumLines]; // New string array called sNumbers, uses iNumLines
            sNumbers = txtTimes.Text.Split('\n'); // sNumbers = the number of lines in txtTimes
            int[] iNumbers = new int[iNumLines]; // New int array called iNumbers, uses iNumLines
            iNumbers = ArrayConversion(sNumbers, iNumLines); // ArrayConversion Function call

            string[] sData = new string[6]; // Creates data array with 6 cells
            sData[0] = txtCarParkName3.Text + Environment.NewLine; // Data cell 0 takes text within txtCarParkName and adds new line
            sData[1] = txtTimes3.Text + Environment.NewLine; // Data cell 1 takes text within txtTimes and adds new line
            sData[2] = txtTimeLimit3.Text + Environment.NewLine; // Data cell 2 takes text within txtTimeLimit and adds new line
            sData[3] = txtAllotted3.Text + Environment.NewLine; // Data cell 3 takes text within txtAllotted and adds new line
            sData[4] = txtOverPercent3.Text + Environment.NewLine; // Data cell 4 takes text within txtOverPercent and adds new line
            sData[5] = txtWarden3.Text + Environment.NewLine; // Data cell 5 takes text within txtWarden and adds new line

            System.IO.File.WriteAllLines(@"H:\My Documents\data3.txt", sData); // Writes data to data3.txt file located in My Documents
            MessageBox.Show("Saved"); // Displays Saved string in a MessageBox to the user once saved
        }

        private void load2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTimes2.Text = string.Empty; // Clears the textbox before loading
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"H:\My Documents\data2.txt")) //Loads the file named "data2" from the My Documents storage location//
            {
                string sLine; // String name called sLine
                int iLines = File.ReadLines(@"H:\My Documents\data2.txt").Count(); // Reads the lines within the data3 file
                while ((sLine = file.ReadLine()) != null) // While sLine equals the line read within the file
                {
                    txtTimes2.Text += sLine; // Puts file output into the Times3 textbox
                    txtTimes2.Text += Environment.NewLine; // Writes a new line
                }
                MessageBox.Show("File Loaded"); // Displays a messagebox
            }
        }

        private void load3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTimes3.Text = string.Empty; // Clears the textbox before loading
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"H:\My Documents\data3.txt")) //Loads the file named "data3" from the My Documents storage location//
            {
                string sLine; // String name called sLine
                int iLines = File.ReadLines(@"H:\My Documents\data3.txt").Count(); // Reads the lines within the data3 file
                while ((sLine = file.ReadLine()) != null) // While sLine equals the line read within the file
                {
                    txtTimes3.Text += sLine; // Puts file output into the Times3 textbox
                    txtTimes3.Text += Environment.NewLine; // Writes a new line
                }
                MessageBox.Show("File Loaded"); // Displays a messagebox
            }
        }
    }
}







