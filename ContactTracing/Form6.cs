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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");

            while (!reader.EndOfStream)
            {
                string data = reader.ReadLine();
                lblInfo.Text = lblInfo.Text + data + "\n";
            }
            reader.Close();
        }
    }
}
