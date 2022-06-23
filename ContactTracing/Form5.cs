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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceLastName.txt");

            while (!reader.EndOfStream)
            {
                string datalname = reader.ReadLine();
                lblInfo.Text = lblInfo.Text + datalname + "\n";
            }
            reader.Close();


        }
    }
}
