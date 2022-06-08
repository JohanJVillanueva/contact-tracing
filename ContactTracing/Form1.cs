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
            Fname = Fname.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");

            string MI = txtMI.Text;
            MI = MI.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");

            string Lname = txtLName.Text;
            Lname = Lname.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");

            //Address
            string StreetNum = txtStNo.Text;

            string StreetName = txtSTName.Text;

            string CityProv = txtCityProv.Text;

            //Phone and Email
            string PhoneNum = txtPhoneN.Text;
            PhoneNum = PhoneNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("8", "").Replace("h", "").Replace("i", "");
            PhoneNum = PhoneNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            PhoneNum = PhoneNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            PhoneNum = PhoneNum.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            PhoneNum = PhoneNum.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            PhoneNum = PhoneNum.Replace("{", "").Replace("}", "").Replace("'", "");

            string Email = txtEmail.Text;

            //date
            string theDate = dtP1.Value.ToShortDateString();

            //Time
            string Hours = txtHours.Text;
            string Minute = txtMin.Text;
            string Meridian = txtAMPM.Text;

            MessageBox.Show(PhoneNum);

            while(correct != 12)
            {
                //Input check for First Name
                if (Fname.Length == 0)
                {
                    MessageBox.Show("Missing Info on First Name! Submit again once fixed.");
                    break;
                    //Makes the first letter upper case
                }
                else if (Fname.Length > 1) {
                    Fname = char.ToUpper(Fname[0]) + Fname.Substring(1);
                    correct++;
                }

                //Input check for Middle Initial
                if (MI.Length == 0) { 
                    MessageBox.Show("Missing Info on Middle Initial! Submit again once fixed.");
                    break;
                }
                else if (MI.Length > 1)
                {
                    correct++;
                }

            }

            //MessageBox.Show(Fname);


            if (correct == 12) { 
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
                file.WriteLine("Testing1");
                file.Close();
            }
        }

    }
}