using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace msssManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> employees= new Dictionary<string, string>();
        private string fileName = @"employees.csv";
        #region LOADING DATA
      
        private Dictionary<string, string> readFromCSV(string path) {
            using (var reader = new StreamReader(path))
            {
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    employees.Add(values[0], values[1]);
                    //Debug.WriteLine("value in the stream is [" + values[0] +"]and ["+ values[1] + "]");
                }
            }
            return null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readFromCSV(fileName);
            displayDataListView(DataListView,employees);
            setInstructions();
        }

        private void displayDataListView(ListView lv, Dictionary<string,string> source) { 
            lv.Items.Clear();
            
            foreach (KeyValuePair<string, string> entry in source)
            {
                ListViewItem lvi = new ListViewItem(entry.Key);
                lvi.SubItems.Add(entry.Value);
                lv.Items.Add(lvi);
            }
        }

        private void appendNewLine(string nl) {
            InstructionBox.AppendText(nl);
            InstructionBox.AppendText(Environment.NewLine);
        }
        private void setInstructions() {
            string title = "How to use :";
            string admin = "ctrl+a: enter admin mode";
            string filter_by_id = "ctrl+i: filter by ID";
            string filter_by_name = "ctrl+i: filter by Name";
            string quit = "ctrl+q : quit the app";

            appendNewLine(title);
            appendNewLine(admin);
            appendNewLine(filter_by_id);
            appendNewLine(filter_by_name);
            appendNewLine(quit);

        }
        #endregion

        #region FILTERING WITH ID AND NAME

        private void filterById_KeyUp(object sender, KeyEventArgs e)
        {
            displayDataListView(ResultListView, FilteredById(sender, e));
        }

        private void filterByName_KeyUp(object sender, KeyEventArgs e)
        {
            displayDataListView(ResultListView, FilteredByName(sender, e));
        }

        private Dictionary<string, string> FilteredById(object sender, KeyEventArgs e )
        {
            Dictionary<string, string>  resultList = new Dictionary<string, string>();
            string input = "";
           
            Regex reg = new Regex(@"^([0-9]{1,9}?)$");

            if (!reg.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, input)))
            {
                e.Handled = true;
                
            }
            else {
                resultList = filterSourceBy((sender as TextBox).Text, employees,0);

            }
            return resultList;
        }

        private Dictionary<string, string> FilteredByName(object sender, KeyEventArgs e)
        {
            Dictionary<string, string> resultList = new Dictionary<string, string>();
            string input = "";

            Regex reg = new Regex(@"^([a-z,A-Z]{1,9}?)$");

            if (!reg.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, input)))
            {
                e.Handled = true;

            }
            else
            {
                resultList = filterSourceBy((sender as TextBox).Text, employees, 1);

            }
            return resultList;
        }

        //recursive search is good here?

        private Dictionary<string, string> filterSourceBy(string target, Dictionary<string, string> source,int Switches)
        {
            Dictionary<string, string> resultList = new Dictionary<string, string>();
            
            foreach (KeyValuePair<string, string> entry in source)
            {
                string measure = "";
                if (Switches == 0) {
                    measure = entry.Key;
                }
                else {
                    measure = entry.Value;
                }
                //here, use binary search
                if (measure.StartsWith(target))
                {
                    resultList.Add(entry.Key, entry.Value);
                  
                }

            }
            return resultList;
        }

        private Dictionary<string, string> filterSourceWithName(string target, Dictionary<string, string> source)
        {
            Dictionary<string, string> resultList = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in source)
            {
                //here, use binary search
                if (entry.Value.StartsWith(target))
                {

                    resultList.Add(entry.Key, entry.Value);
                    // Debug.WriteLine("contains [" + resultList.Count + "]");
                }

            }
            return resultList;
        }



        #endregion

        #region Keyboard Management


        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                if (e.KeyData == Keys.W || e.KeyData == Keys.S)
                {
                    Console.WriteLine("combination");
                }
                Console.WriteLine("shift");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

}
