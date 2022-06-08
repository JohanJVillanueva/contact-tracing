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
            //Numbers
            Fname = Fname.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");
            //Symbols
            Fname = Fname.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("=", "").Replace("+", "");
            Fname = Fname.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Fname = Fname.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");


            string MI = txtMI.Text;
            //Numbers
            MI = MI.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");
            //Symbols
            MI = MI.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("=", "").Replace("+", "");
            MI = MI.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            MI = MI.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");




            string Lname = txtLName.Text;
            //Numbers
            Lname = Lname.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");
            //Symbols
            Lname = Lname.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("=", "").Replace("+", "");
            Lname = Lname.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Lname = Lname.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");



            //Address
            string StreetNum = txtStNo.Text;
            //Alphabet
            StreetNum = StreetNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("8", "").Replace("h", "").Replace("i", "");
            StreetNum = StreetNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            StreetNum = StreetNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "");

            string StreetName = txtSTName.Text;

            string CityProv = txtCityProv.Text;

            //Phone and Email
            string PhoneNum = txtPhoneN.Text;
            //Alphabet
            PhoneNum = PhoneNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("8", "").Replace("h", "").Replace("i", "");
            PhoneNum = PhoneNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            PhoneNum = PhoneNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "");
            
            //Symbols
            PhoneNum = PhoneNum.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            PhoneNum = PhoneNum.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            PhoneNum = PhoneNum.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");

            string Email = txtEmail.Text;

            //date
            string theDate = dtP1.Value.ToShortDateString();

            //Time
            string Hours = txtHours.Text;
            //Alphabet
            Hours = Hours.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("8", "").Replace("h", "").Replace("i", "");
            Hours = Hours.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Hours = Hours.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "");

            //Symbols
            Hours = Hours.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Hours = Hours.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Hours = Hours.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");


            string Minute = txtMin.Text;
            Minute = Minute.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("8", "").Replace("h", "").Replace("i", "");
            Minute = Minute.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Minute = Minute.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "");

            //Symbols
            Minute = Minute.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Minute = Minute.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Minute = Minute.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");



            string Meridian = txtAMPM.Text;
            Meridian = Meridian.ToUpper();
            //Check later if PM or AM


            while(correct != 11)
            {
                /////////////////
                //  NAME INFO  //
                /////////////////


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


                //Input check for Last Name Initial
                if (Lname.Length == 0)
                {
                    MessageBox.Show("Missing Info on Last Name! Submit again once fixed.");
                    break;
                }
                else if (Lname.Length > 1)
                {
                    correct++;
                }



                ////////////////////
                //  ADDRESS INFO  //
                ///////////////////


                //Input check for First Name
                if (StreetNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Number! Submit again once fixed.");
                    break;
                    //Makes the first letter upper case
                }
                else if (StreetNum.Length > 1)
                {
                    correct++;
                }



                //Input check for Middle Initial
                if (StreetName.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Name! Submit again once fixed.");
                    break;
                }
                else if (StreetName.Length > 1)
                {
                    correct++;
                }


                //Input check for Last Name Initial
                if (CityProv.Length == 0)
                {
                    MessageBox.Show("Missing Info on City / Province! Submit again once fixed.");
                    break;
                }
                else if (CityProv.Length > 1)
                {
                    correct++;
                }

                ////////////////////////
                //  PHONE/EMAIL INFO  //
                ///////////////////////


                //Input check for First Name
                if (PhoneNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Phone Num! Submit again once fixed.");
                    break;
                    //Makes the first letter upper case
                }
                else if (PhoneNum.Length > 1)
                {
                    correct++;
                }



                //Input check for Middle Initial
                if (Email.Length == 0)
                {
                    MessageBox.Show("Missing Info on E-mail! Submit again once fixed.");
                    break;
                }
                else if (Email.Length > 1)
                {
                    correct++;
                }


                ////////////////////
                //  TIME IN INFO  //
                ///////////////////


                //Input check for First Name
                if (Hours.Length == 0)
                {
                    MessageBox.Show("Missing Info on Hours! Submit again once fixed.");
                    break;
                    //Makes the first letter upper case
                }
                else if (Hours.Length > 1)
                {
                    correct++;
                }



                //Input check for Middle Initial
                if (Minute.Length == 0)
                {
                    MessageBox.Show("Missing Info on Minute! Submit again once fixed.");
                    break;
                }
                else if (Minute.Length > 1)
                {
                    correct++;
                }


                //Input check for Last Name Initial
                if (Meridian.Length == 0)
                {
                    MessageBox.Show("Missing Info on Meridian! Submit again once fixed.");
                    break;
                }
                else if (Meridian.Length > 1)
                {
                    correct++;
                }

            }

            
            


            if (correct == 11) 
            {
                MessageBox.Show("This information will be saved: " + Fname + " " + MI + ". " + Lname + ", " + StreetNum + "," + StreetName + ", " + CityProv + ", " + PhoneNum + ", " + Email + ", " + theDate + ", " + Hours + ":" + Minute + " " + Meridian);

                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt");
                file.WriteLine(Fname + "," + MI + "," + Lname + "," + StreetNum + "," + StreetName + "," + CityProv + "," + PhoneNum + "," + Email + "," + theDate + "," + Hours + "," + Minute + "," + Meridian);
                file.Close();

                MessageBox.Show("Information Submitted on ContactTrace.txt");
            }
        }

    }
}