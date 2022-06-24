using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void lblSbDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSbDate_Click(object sender, EventArgs e)
        {
            //Filters info by Date
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            //Makes a list of the strings corresponding to the right date
            List<string> dates = new List<string>();

            //grabs date from dtp2
            string InfoDate = dtP2.Value.ToShortDateString();
            int countDate = 0;

            //loop through the file line by line to see if there is any instances of the query
            while (!reader.EndOfStream)
            {
                string datadate = reader.ReadLine();
                if (datadate.Contains(InfoDate))
                {
                    countDate++;

                    dates.Add(datadate);
                }

            }
            if (countDate == 0)
            {
                MessageBox.Show("No contact tracing information found on that date");
                reader.Close();
            }
            else
            {
                //writes a separate txt file to be able to isolate the query 
                reader.Close();
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceDate.txt");
                foreach (string datadate in dates)
                {
    
                    file.WriteLine(datadate);
                }
                MessageBox.Show("Found: " + countDate.ToString() + " forms on said date");
                MessageBox.Show("The info will be saved and can be viewed at ContactTraceDate.txt");
                file.Close();
                Form3 data = new Form3();
                data.ShowDialog(); // Shows Form3


            }
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //opens form6 to show all data
            Form6 all = new Form6();
            all.ShowDialog(); // Shows Form6


        }

        private void btnSbName_Click(object sender, EventArgs e)
        {
            //Filters info by First Name
            //Makes a list of the strings corresponding to the right name
            List<string> names = new List<string>();


            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            int counted = 0;
            string grabName = txtSbName.Text;
            //loop through the file line by line to see if there is any instances of the query
            while (!reader.EndOfStream)
            {
                string dataname = reader.ReadLine();
                if (dataname.Contains(grabName))
                {
                    counted++;
                    names.Add(dataname);
                    

                }
                
                   
            }
            if (counted == 0)
            {
                reader.Close();
                MessageBox.Show("No such names in database");
            }
            else
            {
                reader.Close();
                //writes a separate txt file to be able to isolate the query 
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceFirstName.txt");
                foreach (string dataname in names)
                {
                    
                    file.WriteLine(dataname);
                }
                MessageBox.Show("Found: " + counted.ToString() + " instances of: " + grabName);
                MessageBox.Show("The info will be saved and can be viewed at ContactTraceFirstName.txt");
                file.Close();
                Form4 namedata = new Form4();
                namedata.ShowDialog(); // Shows Form4
            }
            


        }

        private void btnSbLName_Click(object sender, EventArgs e)
        {
            //Filters info by Lname
            //Makes a list of the strings corresponding to the right lname
            List<string> Lnames = new List<string>();


            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            int Lcounted = 0;
            string grabLName = txtSbLName.Text;
            //loop through the file line by line to see if there is any instances of the query
            while (!reader.EndOfStream)
            {
                string dataLname = reader.ReadLine();
                if (dataLname.Contains(grabLName))
                {
                    Lcounted++;
                    Lnames.Add(dataLname);

                }


            }
            if (Lcounted == 0)
            {
                MessageBox.Show("No such names in database");
                reader.Close();
            }
            else
            {
                reader.Close();
                //writes a separate txt file to be able to isolate the query 
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceLastName.txt");
                foreach (string dataLname in Lnames)
                {

                    file.WriteLine(dataLname);

                }
                MessageBox.Show("Found: " + Lcounted.ToString() + " instances of: " + grabLName);
                MessageBox.Show("The info will be saved and can be viewed at ContactTraceLastName.txt");
                file.Close();
                Form5 lnamedata = new Form5();
                lnamedata.ShowDialog(); 
            }
            reader.Close();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            //Filters info by Date AND Query
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            //Makes a list of the strings corresponding to the right date / info
            List<string> all = new List<string>();
            
            string Query = txtSearchAll.Text;
            //grabs date from dtp3
            string AllInfoDate = dtP3.Value.ToShortDateString();
            int counted = 0;
            //loop through the file line by line to see if there is any instances of the query
            while (!reader.EndOfStream)
            {
                string Allinfo = reader.ReadLine();
                if (Allinfo.Contains(AllInfoDate))
                {
                    if (Allinfo.Contains(Query))
                    {
                        counted++;
                        all.Add(Allinfo);
                    }                   
                    
                }

            }
            if (counted == 0)
            {
                MessageBox.Show("Nothing found");
                reader.Close();
            }
            else
            {
                reader.Close();
                //writes a separate txt file to be able to isolate the query 
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceSpecific.txt");
                foreach (string info in all)
                {
                    file.WriteLine(info);
                }
                MessageBox.Show("Found: " + counted.ToString() + " forms on said date");
                MessageBox.Show("The info will be saved and can be viewed at ContactTraceDate.txt");
                file.Close();
                Form7 data = new Form7();
                data.ShowDialog(); // Shows Form7


            }
        }

        private void dtP2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
