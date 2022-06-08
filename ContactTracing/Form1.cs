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
            //Error Correction
            byte correct = 0;
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
            
            while(correct < 9)
            {

            }
            if (Fname.Length == 0)
                MessageBox.Show("Missing Info on First Name!");
            else if (Fname.Length > 1)
                char.ToUpper(Fname[0]);

            MessageBox.Show(Fname);


            StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
            file.WriteLine("Testing1");
            file.Close();
        }

    }
}