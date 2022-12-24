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

   
    public partial class update : Form
    {
        private readonly Form1 form;

        Int32 id_;
        int c_row;

        ErrorProvider firstpro;
        ErrorProvider middle;
        ErrorProvider last;
        ErrorProvider phone;
        ErrorProvider email;
        string name_only;

        string pic_path ="empty",picG;


        public update(Form1 frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void update_Load(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, Data> data_imported = new Dictionary<int, Data>();
                data_imported = Form1.dData;
                c_row = Form1.current_row;
                id_ = data_imported[c_row].Id;
                first_txt.Text = data_imported[c_row].FirstName;
                middle_txt.Text = data_imported[c_row].MiddleName;
                last_txt.Text = data_imported[c_row].LastName;
                phone_txt.Text = data_imported[c_row].Phone;
                email_txt.Text = data_imported[c_row].Email;
                pic_path = data_imported[c_row].Pic;


                pic_New.Image = Image.FromFile(pic_path);

            }
            catch (Exception eee)
            {
             

            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_txt.Text) || string.IsNullOrEmpty(middle_txt.Text) && string.IsNullOrEmpty(last_txt.Text) && string.IsNullOrEmpty(phone_txt.Text) && string.IsNullOrEmpty(email_txt.Text) )
            {

                MessageBox.Show("Please Make sure to enter all required data !");

            }
            else
            {


                System.Drawing.Image img;
                Bitmap bf;
                string pic_lname;
                Data newData;

                if (pic_path != "empty")
                {
                    img = System.Drawing.Image.FromFile(pic_path);

                    bf = new Bitmap(pic_path);



                    if (bf.Width > 800)
                    {


                        pic_lname = picG + @"\pic_" + name_only;

                        int maxheight = (bf.Height * 800 / bf.Width);
                        img = FileController.ResizeImage.resizeImage(bf, new Size(800, maxheight));
                        img.Save(pic_lname, ImageFormat.Jpeg);

                        newData = new Data(id_, first_txt.Text, middle_txt.Text, last_txt.Text, phone_txt.Text, email_txt.Text, pic_lname);
                        FileController.FileController.Update(c_row, newData);
                        form.refresh_img_after_update(pic_lname);
                        form.Refresh();
                        this.Close();
                        //MessageBox.Show("updating successful");
                    }
                    else
                    {

                        newData = new Data(id_, first_txt.Text, middle_txt.Text, last_txt.Text, phone_txt.Text, email_txt.Text, pic_path);
                        FileController.FileController.Update(c_row, newData);
                        form.refresh_img_after_update(pic_path);
                        form.Refresh();
                        this.Close();
                        MessageBox.Show("updating successful");
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Add the Contact without a Pic ?", "No image selected !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        newData = new Data(id_, first_txt.Text, middle_txt.Text, last_txt.Text, phone_txt.Text, email_txt.Text, @"C:\Users\User\Documents\Visual Studio 2013\Projects\firstTest\firstTest\bin\Debug\profile.jpg");
                        FileController.FileController.Update(c_row, newData);
                        form.refresh_img_after_update(pic_path);
                        form.Refresh();
                        this.Close();
                        MessageBox.Show("updating successful");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }




                //newData = new Data(id_, first_txt.Text, middle_txt.Text, last_txt.Text, phone_txt.Text, email_txt.Text, pic_path);
                //FileController.FileController.Update(c_row, newData);
                //form.refresh_img_after_update(pic_path);
                //form.Refresh();
                //this.Close();
            }
        }

        private void pic_New_Click(object sender, EventArgs e)
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
                pic_New.Image = Image.FromFile(pic_path);


                picG = System.IO.Path.GetDirectoryName(pic_path);
                name_only = openFileDialog1.SafeFileName;
                pic_path_txt.Text = pic_path;


            }  
        }

       
    }
}
