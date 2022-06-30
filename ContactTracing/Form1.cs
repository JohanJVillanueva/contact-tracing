using QRCoder;
using AForge.Video;
using AForge;
using AForge.Video.DirectShow;
using ZXing;
using System.Drawing;
using System.Text;
using System.IO;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

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
            StreetNum = StreetNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            StreetNum = StreetNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            StreetNum = StreetNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            string StreetName = txtSTName.Text;
            StreetName = StreetName.Replace(",", "");
            string CityProv = txtCityProv.Text;

            //Phone and Email
            string PhoneNum = txtPhoneN.Text;
            //Alphabet
            PhoneNum = PhoneNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            PhoneNum = PhoneNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            PhoneNum = PhoneNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

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
            Hours = Hours.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Hours = Hours.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Hours = Hours.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Hours = Hours.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Hours = Hours.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Hours = Hours.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");


            string Minute = txtMin.Text;
            Minute = Minute.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Minute = Minute.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Minute = Minute.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Minute = Minute.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Minute = Minute.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Minute = Minute.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");



            string Meridian = txtAMPM.Text;
            //Alphabet
            Meridian = Meridian.Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Meridian = Meridian.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Meridian = Meridian.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z","");

            //Symbols
            Meridian = Meridian.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Meridian = Meridian.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");

            //Numbers
            Meridian = Meridian.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");


            //Meridian = Meridian.ToUpper();
            //Check later if PM or AM

            string Temperature = txtTemp.Text;
            //Alphabet
            Temperature = Temperature.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Temperature = Temperature.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Temperature = Temperature.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "").Replace(".", "");

            string Sex = "";

            if (txtMale.Checked == true)
            {
                Sex = txtMale.Text;
            }
            else
            {
                Sex = txtFemale.Text;
            }

            String vax = "";
            if (rbNoVax.Checked == true)
            {
                vax = rbNoVax.Text;
            }
            else if(rbOneVax.Checked == true)
            {
                vax = rbOneVax.Text;
            }
            else if(rbVaB.Checked == true)
            {
                vax = rbVaB.Text;
            }

            string Age = txtAge.Text;
            Age = Age.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Age = Age.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Age = Age.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Age = Age.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Age = Age.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Age = Age.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");

            string Symptoms = "";

                     
            foreach (var item in clbox.CheckedItems)
            {
                Symptoms = Symptoms + "-" + item.ToString();
            }

            if(Symptoms.Length == 0)
            {
                Symptoms = "No symptoms";
            }

            //MessageBox.Show(Symptoms);








            while (correct != 13)
            {
                /////////////////
                //  NAME INFO  //
                /////////////////


                //Input check for First Name
                if (Fname.Length == 0)
                {
                    MessageBox.Show("Missing Info on First Name! Submit again once fixed.");
                    break;
                    
                }
                else if (Fname.Length > 0) {
                    Fname = char.ToUpper(Fname[0]) + Fname.Substring(1);
                    correct++;
                }



                //Input check for Middle Initial
                if (MI.Length == 0) { 
                    MessageBox.Show("Missing Info on Middle Initial! Submit again once fixed.");
                    break;
                }
                else if (MI.Length > 0)
                {
                    correct++;
                }


                //Input check for Last Name Initial
                if (Lname.Length == 0)
                {
                    MessageBox.Show("Missing Info on Last Name! Submit again once fixed.");
                    break;
                }
                else if (Lname.Length > 0)
                {
                    correct++;
                }



                ////////////////////
                //  ADDRESS INFO  //
                ///////////////////


                //Input check for Street Num
                if (StreetNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Number! Submit again once fixed.");
                    break;
                    
                }
                else if (StreetNum.Length > 0)
                {
                    correct++;
                }



                //Input check for Street Name
                if (StreetName.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Name! Submit again once fixed.");
                    break;
                }
                else if (StreetName.Length > 0)
                {
                    correct++;
                }


                //Input check for City Prov
                if (CityProv.Length == 0)
                {
                    MessageBox.Show("Missing Info on City / Province! Submit again once fixed.");
                    break;
                }
                else if (CityProv.Length > 0)
                {
                    correct++;
                }

                ////////////////////////
                //  PHONE/EMAIL INFO  //
                ///////////////////////


                //Input check for Phone Num
                if (PhoneNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Phone Num! Submit again once fixed.");
                    break;
                    
                }
                else if (PhoneNum.Length > 0)
                {
                    correct++;
                }



                //Input check for Email
                if (Email.Length == 0)
                {
                    MessageBox.Show("Missing Info on E-mail! Submit again once fixed.");
                    break;
                }
                else if (Email.Length > 0)
                {
                    correct++;
                }


                ////////////////////
                //  TIME IN INFO  //
                ///////////////////


                //Input check for Hours
                if (Hours.Length == 0)
                {
                    MessageBox.Show("Missing Info on Hours! Submit again once fixed.");
                    break;
                    
                }
                else if (Hours.Length != 0)
                {
                    correct++;
                }



                //Input check for Minutes
                if (Minute.Length == 0)
                {
                    MessageBox.Show("Missing Info on Hours! Submit again once fixed.");
                    break;

                }
                else if (Minute.Length != 0)
                {
                    correct++;
                }


                //Input check for Meridian
                if (Meridian.Length == 0)
                {
                    MessageBox.Show("Missing Info on Meridian! Submit again once fixed.");
                    break;
                }

                else if (Meridian.Length > 0)
                {
                    correct++;
                }

                //Input check for Temperature
                if (Temperature.Length == 0)
                {
                    MessageBox.Show("Missing Info on Temperature! Submit again once fixed.");
                    break;
                }

                else if (Temperature.Length > 0)
                {
                    correct++;
                }

                //Input check for Age
                if (Age.Length == 0)
                {
                    MessageBox.Show("Missing Info on Age! Submit again once fixed.");
                    break;
                }

                else if (Age.Length > 0)
                {
                    correct++;
                }

            }

            
            


            if (correct == 13) 
            {
                //Show information in a messagebox, for the user to see 
                MessageBox.Show("This information will be saved: " + Environment.NewLine + "First Name: " + Fname + Environment.NewLine + "Midle Initial: " + MI + ". " + Environment.NewLine + "Last Name: " + Lname +Environment.NewLine + "Sex: " + Sex + Environment.NewLine + "Age: " + Age + Environment.NewLine + "Street No.: " + StreetNum + Environment.NewLine + "Street Name: " + StreetName + Environment.NewLine + "City/Province: " + CityProv + Environment.NewLine + "Phone Number: " + PhoneNum + Environment.NewLine + "Email: " + Email + Environment.NewLine + "Date: " + theDate +Environment.NewLine + "Time: " + Hours + ":" + Minute + " " + Meridian + Environment.NewLine + "Temperature: " + Temperature + Environment.NewLine + "Vaxxed: " + vax + Environment.NewLine + "Symptoms: " + Symptoms);

                //Writes it to the contacttrace.txt file, it appends it, not overwrites.
                StreamWriter file = new StreamWriter(@"E:\Programming\ContactTracing\ContactTracing\ContactTrace.txt", true);
                file.WriteLine("Name: " +Fname + "  ,  " + MI + "  ,  " + Lname + "  ,  " + "Address: " + StreetNum + "  ,  " + StreetName + "  ,  " + CityProv + "  ,  " + "Contact:" + PhoneNum + "  ,  " + Email + "  ,  " + "Date:" + theDate + "  ,  " + Hours + ":" + Minute + " " + Meridian + "  ,  " + "Temperature: " + Temperature + "  ,  " + Sex + "  ,  " + "Vax Info" + vax + "  ,  " + Age + "  ,  " + "Symptoms: " + Symptoms);
                file.Close();

                //Confirm to the user that the info was copied and the application will restart by itself
                MessageBox.Show("Information Submitted on ContactTrace.txt");
                MessageBox.Show("Application will now restart for a new form to be inputted. Thank you for using! Stay safe!");
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void txtMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Check if inputted password is correct to be able to proceed to the form2 / LilJohn Admin Desk
            String pws = txtPw.Text;
            if (pws == "LilJohn")
            {
                Form2 info = new Form2();
                info.ShowDialog(); // Shows Form2
            }
            else {
                MessageBox.Show("Wrong Password");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
                cmbCamera.Items.Add(filterinfo.Name);
            cmbCamera.SelectedIndex = 0;

            //captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            //captureDevice.NewFrame += FinalFrame_NewFrame;
            //captureDevice.Start();
            //timer1.Start();

        }

        private void btnQRGenerate_Click(object sender, EventArgs e)
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
            StreetNum = StreetNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            StreetNum = StreetNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            StreetNum = StreetNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            string StreetName = txtSTName.Text;
            StreetName = StreetName.Replace(",", "");
            string CityProv = txtCityProv.Text;

            //Phone and Email
            string PhoneNum = txtPhoneN.Text;
            //Alphabet
            PhoneNum = PhoneNum.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            PhoneNum = PhoneNum.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            PhoneNum = PhoneNum.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

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
            Hours = Hours.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Hours = Hours.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Hours = Hours.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Hours = Hours.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Hours = Hours.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Hours = Hours.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");


            string Minute = txtMin.Text;
            Minute = Minute.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Minute = Minute.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Minute = Minute.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Minute = Minute.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Minute = Minute.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Minute = Minute.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");



            string Meridian = txtAMPM.Text;
            //Alphabet
            Meridian = Meridian.Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Meridian = Meridian.Replace("j", "").Replace("k", "").Replace("l", "").Replace("n", "").Replace("o", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Meridian = Meridian.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Meridian = Meridian.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Meridian = Meridian.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");

            //Numbers
            Meridian = Meridian.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "");


            //Meridian = Meridian.ToUpper();
            //Check later if PM or AM

            string Temperature = txtTemp.Text;
            //Alphabet
            Temperature = Temperature.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Temperature = Temperature.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Temperature = Temperature.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "").Replace(".", "");

            string Sex = "";

            if (txtMale.Checked == true)
            {
                Sex = txtMale.Text;
            }
            else
            {
                Sex = txtFemale.Text;
            }

            String vax = "";
            if (rbNoVax.Checked == true)
            {
                vax = rbNoVax.Text;
            }
            else if (rbOneVax.Checked == true)
            {
                vax = rbOneVax.Text;
            }
            else if (rbVaB.Checked == true)
            {
                vax = rbVaB.Text;
            }

            string Age = txtAge.Text;
            Age = Age.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "");
            Age = Age.Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "");
            Age = Age.Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "");

            //Symbols
            Age = Age.Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("=", "").Replace("+", "");
            Age = Age.Replace("\\", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("[", "").Replace("]", "");
            Age = Age.Replace("{", "").Replace("}", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");

            string Symptoms = "";


            foreach (var item in clbox.CheckedItems)
            {
                Symptoms = Symptoms + "-" + item.ToString();
            }

            if (Symptoms.Length == 0)
            {
                Symptoms = "No symptoms";
            }

            //MessageBox.Show(Symptoms);








            while (correct != 13)
            {
                /////////////////
                //  NAME INFO  //
                /////////////////


                //Input check for First Name
                if (Fname.Length == 0)
                {
                    MessageBox.Show("Missing Info on First Name! Submit again once fixed.");
                    break;

                }
                else if (Fname.Length > 0)
                {
                    Fname = char.ToUpper(Fname[0]) + Fname.Substring(1);
                    correct++;
                }



                //Input check for Middle Initial
                if (MI.Length == 0)
                {
                    MessageBox.Show("Missing Info on Middle Initial! Submit again once fixed.");
                    break;
                }
                else if (MI.Length > 0)
                {
                    correct++;
                }


                //Input check for Last Name Initial
                if (Lname.Length == 0)
                {
                    MessageBox.Show("Missing Info on Last Name! Submit again once fixed.");
                    break;
                }
                else if (Lname.Length > 0)
                {
                    correct++;
                }



                ////////////////////
                //  ADDRESS INFO  //
                ///////////////////


                //Input check for Street Num
                if (StreetNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Number! Submit again once fixed.");
                    break;

                }
                else if (StreetNum.Length > 0)
                {
                    correct++;
                }



                //Input check for Street Name
                if (StreetName.Length == 0)
                {
                    MessageBox.Show("Missing Info on Street Name! Submit again once fixed.");
                    break;
                }
                else if (StreetName.Length > 0)
                {
                    correct++;
                }


                //Input check for City Prov
                if (CityProv.Length == 0)
                {
                    MessageBox.Show("Missing Info on City / Province! Submit again once fixed.");
                    break;
                }
                else if (CityProv.Length > 0)
                {
                    correct++;
                }

                ////////////////////////
                //  PHONE/EMAIL INFO  //
                ///////////////////////


                //Input check for Phone Num
                if (PhoneNum.Length == 0)
                {
                    MessageBox.Show("Missing Info on Phone Num! Submit again once fixed.");
                    break;

                }
                else if (PhoneNum.Length > 0)
                {
                    correct++;
                }



                //Input check for Email
                if (Email.Length == 0)
                {
                    MessageBox.Show("Missing Info on E-mail! Submit again once fixed.");
                    break;
                }
                else if (Email.Length > 0)
                {
                    correct++;
                }


                ////////////////////
                //  TIME IN INFO  //
                ///////////////////


                //Input check for Hours
                if (Hours.Length == 0)
                {
                    MessageBox.Show("Missing Info on Hours! Submit again once fixed.");
                    break;

                }
                else if (Hours.Length != 0)
                {
                    correct++;
                }



                //Input check for Minutes
                if (Minute.Length == 0)
                {
                    MessageBox.Show("Missing Info on Hours! Submit again once fixed.");
                    break;

                }
                else if (Minute.Length != 0)
                {
                    correct++;
                }


                //Input check for Meridian
                if (Meridian.Length == 0)
                {
                    MessageBox.Show("Missing Info on Meridian! Submit again once fixed.");
                    break;
                }

                else if (Meridian.Length > 0)
                {
                    correct++;
                }

                //Input check for Temperature
                if (Temperature.Length == 0)
                {
                    MessageBox.Show("Missing Info on Temperature! Submit again once fixed.");
                    break;
                }

                else if (Temperature.Length > 0)
                {
                    correct++;
                }

                //Input check for Age
                if (Age.Length == 0)
                {
                    MessageBox.Show("Missing Info on Age! Submit again once fixed.");
                    break;
                }

                else if (Age.Length > 0)
                {
                    correct++;
                }

            }





            if (correct == 13)
            {
                //Show information in a messagebox, for the user to see 
                MessageBox.Show("This information will be generated to the QR Code: " + Environment.NewLine + "First Name: " + Fname + Environment.NewLine + "Midle Initial: " + MI + ". " + Environment.NewLine + "Last Name: " + Lname + Environment.NewLine + "Sex: " + Sex + Environment.NewLine + "Age: " + Age + Environment.NewLine + "Street No.: " + StreetNum + Environment.NewLine + "Street Name: " + StreetName + Environment.NewLine + "City/Province: " + CityProv + Environment.NewLine + "Phone Number: " + PhoneNum + Environment.NewLine + "Email: " + Email + Environment.NewLine + "Date: " + theDate + Environment.NewLine + "Time: " + Hours + ":" + Minute + " " + Meridian + Environment.NewLine + "Temperature: " + Temperature + Environment.NewLine + "Vaxxed: " + vax + Environment.NewLine + "Symptoms: " + Symptoms);

                QRCodeGenerator qr = new QRCodeGenerator();
                string info = "Name: " + Fname + "  ,  " + MI + "  ,  " + Lname + "  ,  " + "Address: " + StreetNum + "  ,  " + StreetName + "  ,  " + CityProv + "  ,  " + "Contact:" + PhoneNum + "  ,  " + Email + "  ,  " + "Date:" + theDate + "  ,  " + Hours + ":" + Minute + " " + Meridian + "  ,  " + "Temperature: " + Temperature + "  ,  " + Sex + "  ,  " + "Vax Info" + vax + "  ,  " + Age + "  ,  " + "Symptoms: " + Symptoms;

                QRCodeData data = qr.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pctQR.Image = code.GetGraphic(5);

            }

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += FinalFrame_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            pctScanQR.Image = (Bitmap)eventArgs.Frame.Clone();
            //pctScanQR.Image = (Bitmap)eventArgs.Frame.Clone();
            

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if(captureDevice.IsRunning)
                captureDevice.Stop();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pctScanQR.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pctScanQR.Image);
                if(result != null)
                {
                    MessageBox.Show("You have inputted this information: ");
                    MessageBox.Show(result.ToString());
                    string time = DateTime.Now.ToString("hh:mm tt");
                    MessageBox.Show(time);

                    timer1.Stop();
                    string theDate = dtP1.Value.ToShortDateString();

                    string InfoObtained = result.ToString();
                    StringBuilder sb = new StringBuilder(InfoObtained);
                    if (InfoObtained.Contains("Date"))
                    {
                        int start = InfoObtained.IndexOf("Date");
                        int end = InfoObtained.IndexOf("Temperature");
                        int width = end - start;
                        //MessageBox.Show(start.ToString());
                        sb.Remove(start, width);
                        string add = "Date: " + theDate + " , " + time + " , ";
                        sb.Insert(start, add);
                        InfoObtained = sb.ToString();
                        MessageBox.Show(InfoObtained);
                    }
                    else
                    {
                        MessageBox.Show("Wrong input");
                    }

                    //if (captureDevice.IsRunning)
                    //{
                    //    captureDevice.Stop();
                    //}

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}