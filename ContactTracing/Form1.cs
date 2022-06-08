namespace ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            //file.WriteLine("Testing");
            file.Close();
        }

    }
}