using firstTest.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstTest
{
    public partial class add : Form
    {
        private readonly Form1 form;
        ErrorProvider firstpro;
        ErrorProvider middle;
        ErrorProvider last;
        ErrorProvider phone;
        ErrorProvider email;
        string name_only;

        string pic_path ="empty",picG;
        public add(Form1 frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Pictures",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_path = openFileDialog1.FileName;
                picG = System.IO.Path.GetDirectoryName(pic_path);
                name_only = openFileDialog1.SafeFileName;
                addPic.Image = Image.FromFile(pic_path);
                pathpic.Text = pic_path;

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img;
            Bitmap bf;
            string pic_lname;
            if (IsValidEmail(email_txtb.Text))
            {

            if (pic_path != "empty")
            {
                img = System.Drawing.Image.FromFile(pic_path);

                bf = new Bitmap(pic_path);

               

                    if (bf.Width > 800)
                    {
                        pic_lname = picG + @"\pic_"+ DateTime.Now.ToString("hh_mm_ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + name_only;

                        int maxheight = (bf.Height * 800 / bf.Width);
                        img = FileController.ResizeImage.resizeImage(bf, new Size(800, maxheight));
                        img.Save(pic_lname, ImageFormat.Jpeg);

                        form.RemoveAllRows();
                        Data newData = new Data(FileController.FileController.getNewId(), first_txtb.Text, middle_txtb.Text, last_txtb.Text, phone_txtb.Text, email_txtb.Text, pic_lname);
                        FileController.FileController.Add(newData);
                        form.Checkifhighorlow();
                        this.Close();
                        form.Refresh();
                        MessageBox.Show("adding successful");
                    }
                    else
                    {

                        form.RemoveAllRows();
                        Data newData = new Data(FileController.FileController.getNewId(), first_txtb.Text, middle_txtb.Text, last_txtb.Text, phone_txtb.Text, email_txtb.Text, pic_path);
                        FileController.FileController.Add(newData);
                        form.Checkifhighorlow();
                        this.Close();
                        form.Refresh();
                        MessageBox.Show("adding successful");
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Add the Contact without a Pic ?", "No image selected !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        form.RemoveAllRows();
                        Data newData = new Data(FileController.FileController.getNewId(), first_txtb.Text, middle_txtb.Text, last_txtb.Text, phone_txtb.Text, email_txtb.Text, @"C:\Users\User\Documents\Visual Studio 2013\Projects\firstTest\firstTest\bin\Debug\profile.jpg");
                        FileController.FileController.Add(newData);
                        form.Checkifhighorlow();
                        this.Close();
                        form.Refresh();
                        MessageBox.Show("adding successful");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a correct email !");

            }
        }
       
        private void first_txtb_Validating(object sender, CancelEventArgs e)
        {
          
           if (String.IsNullOrEmpty(first_txtb.Text))
            {
                e.Cancel = true;
                firstpro.SetError(first_txtb, "Required");
            }
            else
            {
                firstpro.SetError(first_txtb, "");
            }
        }

        private void add_Load(object sender, EventArgs e)
        {
            firstpro = new ErrorProvider();
            middle = new ErrorProvider();
            last = new ErrorProvider();
            phone = new ErrorProvider();
            email = new ErrorProvider();

            firstpro = new System.Windows.Forms.ErrorProvider();
            firstpro.SetIconAlignment(this.first_txtb, ErrorIconAlignment.MiddleRight);
            firstpro.SetIconPadding(this.first_txtb, 2);
            firstpro.BlinkRate = 1000;
            firstpro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            middle = new System.Windows.Forms.ErrorProvider();
            middle.SetIconAlignment(this.middle_txtb, ErrorIconAlignment.MiddleRight);
            middle.SetIconPadding(this.middle_txtb, 2);
            middle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            last = new System.Windows.Forms.ErrorProvider();
            last.SetIconAlignment(this.last_txtb, ErrorIconAlignment.MiddleRight);
            last.SetIconPadding(this.last_txtb, 2);
            last.BlinkRate = 1000;
            last.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            phone = new System.Windows.Forms.ErrorProvider();
            phone.SetIconAlignment(this.phone_txtb, ErrorIconAlignment.MiddleRight);
            phone.SetIconPadding(this.phone_txtb, 2);
            phone.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            email = new System.Windows.Forms.ErrorProvider();
            email.SetIconAlignment(this.email_txtb, ErrorIconAlignment.MiddleRight);
            email.SetIconPadding(this.email_txtb, 2);
            email.BlinkRate = 1000;
            email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        private void middle_txtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(middle_txtb.Text))
            {
                e.Cancel = true;
                firstpro.SetError(middle_txtb, "Required");
            }
            else
            {
                firstpro.SetError(middle_txtb, "");
            }
        }

        private void last_txtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(last_txtb.Text))
            {
                e.Cancel = true;
                firstpro.SetError(last_txtb, "Required");
            }
            else
            {
                firstpro.SetError(last_txtb, "");
            }
        }

        private void phone_txtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(phone_txtb.Text))
            {
                e.Cancel = true;
                firstpro.SetError(phone_txtb, "Required");
            }
            else
            {
                firstpro.SetError(phone_txtb, "");
                if (phone_txtb.Text.Length !=8)
                {
                    firstpro.SetError(phone_txtb, "enter a 8 digits number");


                }

            }
        }

     
        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
        private void email_txtb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(email_txtb.Text))
            {
                e.Cancel = true;
                firstpro.SetError(email_txtb, "Required");
            }
            else
            {
                if (IsValidEmail(email_txtb.Text))
                firstpro.SetError(email_txtb, "");
                else
                    firstpro.SetError(email_txtb, "enter a correct email !");

            }
        }

        private void phone_txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                //e.Handled = true;
                if (char.IsDigit(e.KeyChar))
                {
                    //Count the digits already in the text.  I'm using linq:
                    if ((sender as TextBox).Text.Count(Char.IsDigit) >= 8)
                    {
                        e.Handled = true;


                        firstpro.SetError(phone_txtb, "please enter a 8 digits number");

                    }
                }
            }
        }

      
        }
}
