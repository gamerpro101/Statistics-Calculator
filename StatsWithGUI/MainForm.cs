using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsWithGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateStatistics()
        {
            if (theList.Items.Count == 0)
            {
                nTextBox.Text = "";
                sumTextBox.Text = "";
                medianTextBox.Text = "";
                meanTextBox.Text = "";
                sdTextBox.Text = "";
                q1TextBox.Text = "";
                q3TextBox.Text = "";
                iqrTextBox.Text = "";
            }
            else
            {
                // n (amount of items in the list)
                int n = theList.Items.Count;
                nTextBox.Text = n.ToString();
                // sum
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += Double.Parse(theList.Items[i].ToString());
                }
                sumTextBox.Text = sum.ToString();
                // median (we create a list that's specifically sorted, because we have to sort when calculating median.)
                double median = 0;
                List<double> sortedList = new List<double>();
                for (int i = 0; i < n; i++) sortedList.Add(Double.Parse(theList.Items[i].ToString()));
                sortedList.Sort();
                if (n % 2 == 1) median = sortedList[((n + 1) / 2) - 1];
                else median = (sortedList[(n / 2) - 1] + sortedList[n / 2]) / 2;
                medianTextBox.Text = median.ToString();
                // mean (on the other hand, for mean we don't have to sort, same with SD)
                double mean = 0;
                mean = sum / n;
                meanTextBox.Text = mean.ToString();
                // standard deviation
                double sd = 0;
                for (int i = 0; i < n; i++) sd += Math.Pow(Double.Parse(theList.Items[i].ToString()) - mean, 2);
                sd /= n;
                sd = Math.Sqrt(sd);
                sdTextBox.Text = sd.ToString();
                // quartiles 1 and 3, IQR
                double firstQuartile = 0;
                double thirdQuartile = 0;
                double iqr = 0;
                if (n >= 4)
                {
                    if (n % 4 == 1)
                    {
                        firstQuartile = (sortedList[(n - 1) / 4 - 1] + sortedList[(n - 1) / 4]) / 2;
                        thirdQuartile = (sortedList[n - (n - 1) / 4 - 1] + sortedList[n - (n - 1) / 4]) / 2;
                    }
                    if (n % 4 == 2)
                    {
                        firstQuartile = sortedList[(n + 2) / 4 - 1];
                        thirdQuartile = sortedList[((n + 2) / 4) * 3 - 2];
                    }
                    if (n % 4 == 3)
                    {
                        firstQuartile = sortedList[(n + 1) / 4 - 1];
                        thirdQuartile = sortedList[((n + 1) / 4) * 3 - 1];
                    }
                    if (n % 4 == 0)
                    {
                        firstQuartile = (sortedList[n / 4 - 1] + sortedList[n / 4]) / 2;
                        thirdQuartile = (sortedList[n - (n / 4) - 1] + sortedList[n - (n / 4)]) / 2;
                    }
                }
                else
                {
                    if (n == 1)
                    {
                        firstQuartile = sortedList[0];
                        thirdQuartile = sortedList[0];
                    }
                    if (n == 2)
                    {
                        firstQuartile = sortedList[0];
                        thirdQuartile = sortedList[1];
                    }
                    if (n == 3)
                    {
                        firstQuartile = sortedList[0];
                        thirdQuartile = sortedList[2];
                    }
                }
                iqr = thirdQuartile - firstQuartile;
                q1TextBox.Text = firstQuartile.ToString();
                q3TextBox.Text = thirdQuartile.ToString();
                iqrTextBox.Text = iqr.ToString();
                // calculate zscore and percentile
                // if nothing selected, keep the selected item result textboxes blank
                if (theList.SelectedIndex == -1)
                {
                    zscoreTextbox.Text = "";
                    percentileTextBox.Text = "";
                }
                else
                {
                    // zscore
                    double zscore = 0;
                    // address 0 situation to prevent NaN from happening
                    if (sd != 0) zscore = (Double.Parse(theList.SelectedItem.ToString()) - mean) / sd;
                    else zscore = 0;
                    zscoreTextbox.Text = zscore.ToString();
                    // percentile
                    // source: https://www.z-table.com/z-scores-to-percentiles-chart.html
                    double percentile = 0;
                    if (zscore > -2147483648) percentile = 0;
                    if (zscore > -2.326) percentile = 1;
                    if (zscore > -2.054) percentile = 2;
                    if (zscore > -1.881) percentile = 3;
                    if (zscore > -1.751) percentile = 4;
                    if (zscore > -1.645) percentile = 5;
                    if (zscore > -1.555) percentile = 6;
                    if (zscore > -1.476) percentile = 7;
                    if (zscore > -1.405) percentile = 8;
                    if (zscore > -1.341) percentile = 9;
                    if (zscore > -1.282) percentile = 10;
                    if (zscore > -1.227) percentile = 11;
                    if (zscore > -1.175) percentile = 12;
                    if (zscore > -1.126) percentile = 13;
                    if (zscore > -1.08) percentile = 14;
                    if (zscore > -1.036) percentile = 15;
                    if (zscore > -0.994) percentile = 16;
                    if (zscore > -0.954) percentile = 17;
                    if (zscore > -0.915) percentile = 18;
                    if (zscore > -0.878) percentile = 19;
                    if (zscore > -0.842) percentile = 20;
                    if (zscore > -0.806) percentile = 21;
                    if (zscore > -0.772) percentile = 22;
                    if (zscore > -0.739) percentile = 23;
                    if (zscore > -0.706) percentile = 24;
                    if (zscore > -0.674) percentile = 25;
                    if (zscore > -0.643) percentile = 26;
                    if (zscore > -0.613) percentile = 27;
                    if (zscore > -0.583) percentile = 28;
                    if (zscore > -0.553) percentile = 29;
                    if (zscore > -0.524) percentile = 30;
                    if (zscore > -0.496) percentile = 31;
                    if (zscore > -0.468) percentile = 32;
                    if (zscore > -0.44) percentile = 33;
                    if (zscore > -0.412) percentile = 34;
                    if (zscore > -0.385) percentile = 35;
                    if (zscore > -0.358) percentile = 36;
                    if (zscore > -0.332) percentile = 37;
                    if (zscore > -0.305) percentile = 38;
                    if (zscore > -0.279) percentile = 39;
                    if (zscore > -0.253) percentile = 40;
                    if (zscore > -0.228) percentile = 41;
                    if (zscore > -0.202) percentile = 42;
                    if (zscore > -0.176) percentile = 43;
                    if (zscore > -0.151) percentile = 44;
                    if (zscore > -0.126) percentile = 45;
                    if (zscore > -0.1) percentile = 46;
                    if (zscore > -0.075) percentile = 47;
                    if (zscore > -0.05) percentile = 48;
                    if (zscore > -0.025) percentile = 49;
                    if (zscore > 0) percentile = 50;
                    if (zscore > 0.025) percentile = 51;
                    if (zscore > 0.05) percentile = 52;
                    if (zscore > 0.075) percentile = 53;
                    if (zscore > 0.1) percentile = 54;
                    if (zscore > 0.126) percentile = 55;
                    if (zscore > 0.151) percentile = 56;
                    if (zscore > 0.176) percentile = 57;
                    if (zscore > 0.202) percentile = 58;
                    if (zscore > 0.228) percentile = 59;
                    if (zscore > 0.253) percentile = 60;
                    if (zscore > 0.279) percentile = 61;
                    if (zscore > 0.305) percentile = 62;
                    if (zscore > 0.332) percentile = 63;
                    if (zscore > 0.358) percentile = 64;
                    if (zscore > 0.385) percentile = 65;
                    if (zscore > 0.412) percentile = 66;
                    if (zscore > 0.44) percentile = 67;
                    if (zscore > 0.468) percentile = 68;
                    if (zscore > 0.496) percentile = 69;
                    if (zscore > 0.524) percentile = 70;
                    if (zscore > 0.553) percentile = 71;
                    if (zscore > 0.583) percentile = 72;
                    if (zscore > 0.613) percentile = 73;
                    if (zscore > 0.643) percentile = 74;
                    if (zscore > 0.674) percentile = 75;
                    if (zscore > 0.706) percentile = 76;
                    if (zscore > 0.739) percentile = 77;
                    if (zscore > 0.772) percentile = 78;
                    if (zscore > 0.806) percentile = 79;
                    if (zscore > 0.842) percentile = 80;
                    if (zscore > 0.878) percentile = 81;
                    if (zscore > 0.915) percentile = 82;
                    if (zscore > 0.954) percentile = 83;
                    if (zscore > 0.994) percentile = 84;
                    if (zscore > 1.036) percentile = 85;
                    if (zscore > 1.08) percentile = 86;
                    if (zscore > 1.126) percentile = 87;
                    if (zscore > 1.175) percentile = 88;
                    if (zscore > 1.227) percentile = 89;
                    if (zscore > 1.282) percentile = 90;
                    if (zscore > 1.341) percentile = 91;
                    if (zscore > 1.405) percentile = 92;
                    if (zscore > 1.476) percentile = 93;
                    if (zscore > 1.555) percentile = 94;
                    if (zscore > 1.645) percentile = 95;
                    if (zscore > 1.751) percentile = 96;
                    if (zscore > 1.881) percentile = 97;
                    if (zscore > 2.054) percentile = 98;
                    if (zscore > 2.326) percentile = 99;
                    percentileTextBox.Text = percentile.ToString();
                }
            }
        }

        private void frequencyOnOff_CheckedChanged(object sender, EventArgs e) => frequency.Enabled = !frequency.Enabled;

        private void addNumber_Click(object sender, EventArgs e)
        {
            if (frequencyOnOff.Checked)
            {
                for (int i = 0; i < frequency.Value; i++) theList.Items.Add(numberToAdd.Value);
            }
            else theList.Items.Add(numberToAdd.Value);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                // Just a easteregg where holding shift while clicking ABOUT will change the way the form handles being resized.
                theList.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                addGB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                removeGB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                resultsGB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                streamGB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                selectedGB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                exportType.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                histogramContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
            else MessageBox.Show("Statistics Calculator. Made entirely from hand, no ChatGPT. Only Google and StackOverflow.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            // to prevent unhandled exception, we handle it by giving user a message
            if (theList.SelectedIndex == -1) MessageBox.Show("Select an item to remove from the list and try again","FATAL ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else theList.Items.RemoveAt(theList.SelectedIndex);
        }

        private void clearList_Click(object sender, EventArgs e) => theList.Items.Clear();

        private void mode2_CheckedChanged(object sender, EventArgs e)
        {
            calculate.Enabled = !calculate.Enabled;
            timer1.Enabled = !timer1.Enabled;
        }

        private void calculate_Click(object sender, EventArgs e) => CalculateStatistics();

        private void timer1_Tick(object sender, EventArgs e) => CalculateStatistics();

        private void numberToAdd_ValueChanged(object sender, EventArgs e)
        {
            if (numberToAdd.Value != (int)numberToAdd.Value)
            {
                // change the DecimalPlaces to amount of decimal places of the number
                numberToAdd.DecimalPlaces = numberToAdd.Value.ToString().Length - ((int)numberToAdd.Value).ToString().Length - 1;
            }
            else
            {
                // remove unneccessary zeroes after decimal point
                numberToAdd.Value = (int)numberToAdd.Value;
                numberToAdd.DecimalPlaces = 0;
            }
        }

        // since frequency can't be decimal, it rounds it DOWN (that's how it works) to the nearest integer.
        private void frequency_ValueChanged(object sender, EventArgs e) => frequency.Value = (int)frequency.Value;

        private void exportButton_Click(object sender, EventArgs e) => saveFileDialog1.ShowDialog();
      

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Thank you StackOverflow
            // https://stackoverflow.com/questions/20595279/c-sharp-save-all-items-in-a-listbox-to-text-file
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
            for (int i = 0; i < theList.Items.Count; i++)
            {
                var item = theList.Items[i].ToString();
                if (exportType.Text == "New line for each item") SaveFile.WriteLine(item);
                else
                {
                    if (i == 0) SaveFile.Write(item);
                    else SaveFile.Write(", " + item);
                }
            }
            SaveFile.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Because the form editor doesn't lemme put text on DropDownLists, I have to manually configure it using code once the form loads.
            exportType.Text = "One line, commas";
        }

        private void importButton_Click(object sender, EventArgs e) => openFileDialog1.ShowDialog();

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileText = new StreamReader(this.openFileDialog1.FileName).ReadToEnd();
            string[] lines = new string[0];
            if (fileText.IndexOf(',') != -1) lines = fileText.Split(',');
            // https://stackoverflow.com/questions/1547476/split-a-string-on-newlines-in-net
            else lines = fileText.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (!importWithoutReplacement.Checked) theList.Items.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Double.Parse(lines[i]).ToString();
                theList.Items.Add(lines[i]);
            }
        }
    }
}
