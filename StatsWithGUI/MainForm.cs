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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Because the form editor doesn't lemme put text on DropDownLists, I have to manually configure it using code once the form loads.
            exportType.Text = "One line, commas";
        }

        // I made this method because there has to be a new instance of a list<double> to prevent tampering with the original
        private List<double> SortList(List<double> l)
        {
            List<double> lSorted = new List<double>();
            for (int i = 0; i < l.Count; i++) lSorted.Add(l[i]);
            lSorted.Sort();
            return lSorted;
        }
        private int GetN(List<double> l)
        {
            return l.Count;
        }

        private double GetSum(List<double> l)
        {
            double sum = 0;
            for (int i = 0; i < l.Count; i++)
            {
                sum += l[i];
            }
            return sum;
        }

        private double GetMedian(List<double> l)
        {
            double median = 0;
            List<double> lSorted = new List<double>();
            lSorted = SortList(l);
            if (GetN(l) % 2 == 1) median = lSorted[((GetN(l) + 1) / 2) - 1];
            else median = (lSorted[(GetN(l) / 2) - 1] + lSorted[GetN(l) / 2]) / 2;
            return median;
        }
        private double GetMean(List<double> l)
        {
            return GetSum(l) / GetN(l);
        }

        private double GetSD(List<double> l)
        {
            double sd = 0;
            for (int i = 0; i < l.Count; i++) sd += Math.Pow(l[i] - GetMean(l), 2);
            sd /= l.Count;
            sd = Math.Sqrt(sd);
            return sd;
        }
        private double GetQ1(List<double> l)
        {
            double firstQuartile = 0;
            List<double> lSorted = new List<double>();
            lSorted = SortList(l);
            if (GetN(l) >= 4)
            {
                if (GetN(l) % 4 == 1)
                {
                    firstQuartile = (lSorted[(GetN(l) - 1) / 4 - 1] + lSorted[(GetN(l) - 1) / 4]) / 2;
                }
                if (GetN(l) % 4 == 2)
                {
                    firstQuartile = lSorted[(GetN(l) + 2) / 4 - 1];
                }
                if (GetN(l) % 4 == 3)
                {
                    firstQuartile = lSorted[(GetN(l) + 1) / 4 - 1];
                }
                if (GetN(l) % 4 == 0)
                {
                    firstQuartile = (lSorted[GetN(l) / 4 - 1] + lSorted[GetN(l) / 4]) / 2;
                }
            }
            else
            {
                if (GetN(l) == 1)
                {
                    firstQuartile = lSorted[0];
                }
                if (GetN(l) == 2)
                {
                    firstQuartile = lSorted[0];
                }
                if (GetN(l) == 3)
                {
                    firstQuartile = lSorted[0];
                }
            }
            return firstQuartile;
        }
        private double GetQ3(List<double> l)
        {
            double thirdQuartile = 0;
            List<double> lSorted = new List<double>();
            lSorted = SortList(l);
            if (GetN(l) >= 4)
            {
                if (GetN(l) % 4 == 1)
                {
                    thirdQuartile = (lSorted[GetN(l) - (GetN(l) - 1) / 4 - 1] + lSorted[GetN(l) - (GetN(l) - 1) / 4]) / 2;
                }
                if (GetN(l) % 4 == 2)
                {
                    thirdQuartile = lSorted[((GetN(l) + 2) / 4) * 3 - 2];
                }
                if (GetN(l) % 4 == 3)
                {
                    thirdQuartile = lSorted[((GetN(l) + 1) / 4) * 3 - 1];
                }
                if (GetN(l) % 4 == 0)
                {
                    thirdQuartile = (lSorted[GetN(l) - (GetN(l) / 4) - 1] + lSorted[GetN(l) - (GetN(l) / 4)]) / 2;
                }
            }
            else
            {
                if (GetN(l) == 1)
                {
                    thirdQuartile = lSorted[0];
                }
                if (GetN(l) == 2)
                {
                    thirdQuartile = lSorted[1];
                }
                if (GetN(l) == 3)
                {
                    thirdQuartile = lSorted[2];
                }
            }
            return thirdQuartile;
        }
        private double GetIQR(List<double> l)
        {
            return GetQ3(l) - GetQ1(l);
        }

        private double GetZScore(List<double> l, int item)
        {
            if (GetSD(l) != 0) return (l[item] - GetMean(l)) / GetSD(l);
            else return 0;
        }

        private double GetPercentile(List<double> l, int item)
        {
            double originalValue = l[item];
            List<double> lSorted = new List<double>();
            lSorted = SortList(l);
            return ((double)lSorted.IndexOf(originalValue) / (double)l.Count) * 100;
        }

        private double GetPercentileCDF(List<double> l, int item)
        {
            double percentile = 0;
            // source: https://www.z-table.com/z-scores-to-percentiles-chart.html
            if (GetZScore(l, item) > -2147483648) percentile = 0;
            if (GetZScore(l, item) > -2.326) percentile = 1;
            if (GetZScore(l, item) > -2.054) percentile = 2;
            if (GetZScore(l, item) > -1.881) percentile = 3;
            if (GetZScore(l, item) > -1.751) percentile = 4;
            if (GetZScore(l, item) > -1.645) percentile = 5;
            if (GetZScore(l, item) > -1.555) percentile = 6;
            if (GetZScore(l, item) > -1.476) percentile = 7;
            if (GetZScore(l, item) > -1.405) percentile = 8;
            if (GetZScore(l, item) > -1.341) percentile = 9;
            if (GetZScore(l, item) > -1.282) percentile = 10;
            if (GetZScore(l, item) > -1.227) percentile = 11;
            if (GetZScore(l, item) > -1.175) percentile = 12;
            if (GetZScore(l, item) > -1.126) percentile = 13;
            if (GetZScore(l, item) > -1.08) percentile = 14;
            if (GetZScore(l, item) > -1.036) percentile = 15;
            if (GetZScore(l, item) > -0.994) percentile = 16;
            if (GetZScore(l, item) > -0.954) percentile = 17;
            if (GetZScore(l, item) > -0.915) percentile = 18;
            if (GetZScore(l, item) > -0.878) percentile = 19;
            if (GetZScore(l, item) > -0.842) percentile = 20;
            if (GetZScore(l, item) > -0.806) percentile = 21;
            if (GetZScore(l, item) > -0.772) percentile = 22;
            if (GetZScore(l, item) > -0.739) percentile = 23;
            if (GetZScore(l, item) > -0.706) percentile = 24;
            if (GetZScore(l, item) > -0.674) percentile = 25;
            if (GetZScore(l, item) > -0.643) percentile = 26;
            if (GetZScore(l, item) > -0.613) percentile = 27;
            if (GetZScore(l, item) > -0.583) percentile = 28;
            if (GetZScore(l, item) > -0.553) percentile = 29;
            if (GetZScore(l, item) > -0.524) percentile = 30;
            if (GetZScore(l, item) > -0.496) percentile = 31;
            if (GetZScore(l, item) > -0.468) percentile = 32;
            if (GetZScore(l, item) > -0.44) percentile = 33;
            if (GetZScore(l, item) > -0.412) percentile = 34;
            if (GetZScore(l, item) > -0.385) percentile = 35;
            if (GetZScore(l, item) > -0.358) percentile = 36;
            if (GetZScore(l, item) > -0.332) percentile = 37;
            if (GetZScore(l, item) > -0.305) percentile = 38;
            if (GetZScore(l, item) > -0.279) percentile = 39;
            if (GetZScore(l, item) > -0.253) percentile = 40;
            if (GetZScore(l, item) > -0.228) percentile = 41;
            if (GetZScore(l, item) > -0.202) percentile = 42;
            if (GetZScore(l, item) > -0.176) percentile = 43;
            if (GetZScore(l, item) > -0.151) percentile = 44;
            if (GetZScore(l, item) > -0.126) percentile = 45;
            if (GetZScore(l, item) > -0.1) percentile = 46;
            if (GetZScore(l, item) > -0.075) percentile = 47;
            if (GetZScore(l, item) > -0.05) percentile = 48;
            if (GetZScore(l, item) > -0.025) percentile = 49;
            if (GetZScore(l, item) > 0) percentile = 50;
            if (GetZScore(l, item) > 0.025) percentile = 51;
            if (GetZScore(l, item) > 0.05) percentile = 52;
            if (GetZScore(l, item) > 0.075) percentile = 53;
            if (GetZScore(l, item) > 0.1) percentile = 54;
            if (GetZScore(l, item) > 0.126) percentile = 55;
            if (GetZScore(l, item) > 0.151) percentile = 56;
            if (GetZScore(l, item) > 0.176) percentile = 57;
            if (GetZScore(l, item) > 0.202) percentile = 58;
            if (GetZScore(l, item) > 0.228) percentile = 59;
            if (GetZScore(l, item) > 0.253) percentile = 60;
            if (GetZScore(l, item) > 0.279) percentile = 61;
            if (GetZScore(l, item) > 0.305) percentile = 62;
            if (GetZScore(l, item) > 0.332) percentile = 63;
            if (GetZScore(l, item) > 0.358) percentile = 64;
            if (GetZScore(l, item) > 0.385) percentile = 65;
            if (GetZScore(l, item) > 0.412) percentile = 66;
            if (GetZScore(l, item) > 0.44) percentile = 67;
            if (GetZScore(l, item) > 0.468) percentile = 68;
            if (GetZScore(l, item) > 0.496) percentile = 69;
            if (GetZScore(l, item) > 0.524) percentile = 70;
            if (GetZScore(l, item) > 0.553) percentile = 71;
            if (GetZScore(l, item) > 0.583) percentile = 72;
            if (GetZScore(l, item) > 0.613) percentile = 73;
            if (GetZScore(l, item) > 0.643) percentile = 74;
            if (GetZScore(l, item) > 0.674) percentile = 75;
            if (GetZScore(l, item) > 0.706) percentile = 76;
            if (GetZScore(l, item) > 0.739) percentile = 77;
            if (GetZScore(l, item) > 0.772) percentile = 78;
            if (GetZScore(l, item) > 0.806) percentile = 79;
            if (GetZScore(l, item) > 0.842) percentile = 80;
            if (GetZScore(l, item) > 0.878) percentile = 81;
            if (GetZScore(l, item) > 0.915) percentile = 82;
            if (GetZScore(l, item) > 0.954) percentile = 83;
            if (GetZScore(l, item) > 0.994) percentile = 84;
            if (GetZScore(l, item) > 1.036) percentile = 85;
            if (GetZScore(l, item) > 1.08) percentile = 86;
            if (GetZScore(l, item) > 1.126) percentile = 87;
            if (GetZScore(l, item) > 1.175) percentile = 88;
            if (GetZScore(l, item) > 1.227) percentile = 89;
            if (GetZScore(l, item) > 1.282) percentile = 90;
            if (GetZScore(l, item) > 1.341) percentile = 91;
            if (GetZScore(l, item) > 1.405) percentile = 92;
            if (GetZScore(l, item) > 1.476) percentile = 93;
            if (GetZScore(l, item) > 1.555) percentile = 94;
            if (GetZScore(l, item) > 1.645) percentile = 95;
            if (GetZScore(l, item) > 1.751) percentile = 96;
            if (GetZScore(l, item) > 1.881) percentile = 97;
            if (GetZScore(l, item) > 2.054) percentile = 98;
            if (GetZScore(l, item) > 2.326) percentile = 99;
            return percentile;
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
                // copy items from listbox to a list<double>
                List<double> listDouble = new List<double>();
                for (int i = 0; i < theList.Items.Count; i++) listDouble.Add(Double.Parse(theList.Items[i].ToString()));
                nTextBox.Text = GetN(listDouble).ToString();
                sumTextBox.Text = GetSum(listDouble).ToString();
                medianTextBox.Text = GetMedian(listDouble).ToString();
                meanTextBox.Text = GetMean(listDouble).ToString();
                sdTextBox.Text = GetSD(listDouble).ToString();
                q1TextBox.Text = GetQ1(listDouble).ToString();
                q3TextBox.Text = GetQ3(listDouble).ToString();
                iqrTextBox.Text = GetIQR(listDouble).ToString();
                // calculate zscore and percentile
                // if nothing selected, keep the selected item result textboxes blank
                if (theList.SelectedIndex == -1)
                {
                    zscoreTextbox.Text = "";
                    percentileTextBox.Text = "";
                    cdfTextBox.Text = "";
                    rankCdfDifference.Text = "";
                }
                else
                {
                    zscoreTextbox.Text = GetZScore(listDouble, theList.SelectedIndex).ToString();
                    percentileTextBox.Text = GetPercentile(listDouble, theList.SelectedIndex).ToString();
                    cdfTextBox.Text = GetPercentileCDF(listDouble, theList.SelectedIndex).ToString();
                    if (GetPercentile(listDouble, theList.SelectedIndex) < GetPercentileCDF(listDouble, theList.SelectedIndex))
                        rankCdfDifference.Text = (GetPercentileCDF(listDouble, theList.SelectedIndex) - GetPercentile(listDouble, theList.SelectedIndex)).ToString();
                    else
                        rankCdfDifference.Text = (GetPercentile(listDouble, theList.SelectedIndex) - GetPercentileCDF(listDouble, theList.SelectedIndex)).ToString();
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
                graphContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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
