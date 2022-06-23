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
            
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");

            List<string> dates = new List<string>();

            //int datecount = 0;
            //Date:6/23/2022 9 and 10
            string InfoDate = dtP2.Value.ToShortDateString();
            int countDate = 0;
            while (!reader.EndOfStream)
            {
                string datadate = reader.ReadLine();
                if (datadate.Contains(InfoDate))
                {
                    countDate++;
                    MessageBox.Show("Found" + countDate.ToString());
                    dates.Add(datadate);
                }

            }
            if (countDate == 0)
            {
                MessageBox.Show("No contact tracing information found on that date");
            }
            else
            {
                foreach (string datadate in dates)
                {
                    MessageBox.Show(datadate);
                }

                Form3 data = new Form3();
                data.ShowDialog(); // Shows Form2
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            
            MessageBox.Show(reader.ReadToEnd());
        }

        private void btnSbName_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();


            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            int counted = 0;
            string grabName = txtSbName.Text;
            while (!reader.EndOfStream)
            {
                string dataname = reader.ReadLine();
                if (dataname.Contains(grabName))
                {
                    //MessageBox.Show(reader.ReadLine());
                    counted++;
                    MessageBox.Show("Found: " + counted.ToString());
                    names.Add(dataname);
                    
                }
                
                   
            }
            if (counted == 0)
            {
                MessageBox.Show("No such names in database");
            }
            else
            {
                foreach (string dataname in names)
                {
                    MessageBox.Show(dataname);
                }
            }
            
            

        }

        private void btnSbLName_Click(object sender, EventArgs e)
        {
            List<string> Lnames = new List<string>();


            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            int Lcounted = 0;
            string grabLName = txtSbLName.Text;
            while (!reader.EndOfStream)
            {
                string dataLname = reader.ReadLine();
                if (dataLname.Contains(grabLName))
                {
                    //MessageBox.Show(reader.ReadLine());
                    Lcounted++;
                    MessageBox.Show("Found: " + Lcounted.ToString());
                    Lnames.Add(dataLname);

                }


            }
            if (Lcounted == 0)
            {
                MessageBox.Show("No such names in database");
            }
            else
            {
                foreach (string dataLname in Lnames)
                {
                    MessageBox.Show(dataLname);
                }
            }
        }
    }
}
