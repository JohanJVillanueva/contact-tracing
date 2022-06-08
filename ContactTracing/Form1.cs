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
            //Name
            string Fname = txtFName.Text;
            string MI = txtMI.Text;
            string Lname = txtLName.Text;

            //Address
            string StreetNum = txtStNo.Text;
            string StreetName = txtSTName.Text;
            string CityProv = txtCityProv.Text;

            //Phone and Email
            string PhoneNum = txtPhoneN.Text;
            string Email = txtEmail.Text;

            //date
            string theDate = dtP1.Value.ToShortDateString();

            //Time
            string Hours = txtHours.Text;
            string Minute = txtMin.Text;
            string Meridian = txtAMPM.Text;





            StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            //file.WriteLine("Testing");
            file.Close();
        }

    }
}