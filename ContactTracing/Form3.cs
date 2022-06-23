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
    public partial class Form3 : Form
    {
        public Form3()
        {


            InitializeComponent();
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceDate.txt");

            while (!reader.EndOfStream)
            {
                string datadate = reader.ReadLine();
                lblInfo.Text = lblInfo.Text + datadate + "\n";
            }
            
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
