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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceSpecific.txt");

            while (!reader.EndOfStream)
            {
                string allinfo = reader.ReadLine();
                lblInfo.Text = lblInfo.Text + allinfo + "\n";
            }
            reader.Close();
        }
    }
}
