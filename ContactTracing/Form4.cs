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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //Reads the notepad file and displays it in the labelinfo variable
            StreamReader reader = new StreamReader(@"E:\Programming\ContactTracing\ContactTracing\ContactTraceFirstName.txt");

            while (!reader.EndOfStream)
            {
                string datafname = reader.ReadLine();
                lblInfo.Text = lblInfo.Text + datafname + "\n";
            }
            reader.Close();
        }
    }
}
