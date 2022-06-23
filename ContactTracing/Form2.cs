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
            //StreamReader reader = new StreamReader(@"C:\Users\liljo\Documents\Forms\ContactTrace.txt");

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
            int i = 0;
            string grabName = txtSbName.Text;
            while (!reader.EndOfStream)
            {
                string dataname = reader.ReadLine();
                if (dataname.Contains(grabName))
                {
                    //MessageBox.Show(reader.ReadLine());
                    i++;
                    MessageBox.Show("Found: " + i.ToString());
                    names.Add(dataname);
                    
                }
                   
            }

            foreach(string dataname in names)
            {
                MessageBox.Show(dataname);
            }

        }
    }
}
