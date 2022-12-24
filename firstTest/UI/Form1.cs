using firstTest.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstTest
{
    public partial class Form1 : Form
    {

        String path = Environment.CurrentDirectory + @"\" + "ContactsBook.txt";
        public static Dictionary<int, Data> dData = new Dictionary<int, Data>();
        String cell;
        public static int current_row = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        public void Form1_Load_1(object sender, EventArgs e)
        {
          
            dtgrid.ReadOnly = true;


            if (!File.Exists(path))
            {
                delete_button.Enabled = false;
                btn_update.Enabled = false;
                FileStream f = new FileStream(path, FileMode.OpenOrCreate);
                f.Close();
            }
            else
            {
                dData = FileController.FileController.GetContacts();
         try {
             if (dData.Count != 0)
             {

                 int idfirst = dData.Keys.First();

                 List<Data> Ldata = new List<Data>();
                 foreach (KeyValuePair<int, Data> entry in dData)
                 {
                     Ldata.Add(entry.Value);
                 }

                dtgrid.DataSource = Ldata;
                dtgrid.Columns[2].Visible = false;
                dtgrid.Columns[5].Visible = false;
                dtgrid.Columns[6].Visible = false;
                dtgrid.Rows[0].Selected = true;
                delete_button.Enabled = true;
                btn_update.Enabled = true;
                id_txt.Text = dData[idfirst].Id + "";
                first_txt.Text = dData[idfirst].FirstName;
                middle_txt.Text = dData[idfirst].MiddleName;
                last_txt.Text = dData[idfirst].LastName;
                phone_txt.Text = dData[idfirst].Phone;
                email_txt.Text = dData[idfirst].Email;
                pic.Image = Image.FromFile(dData[idfirst].Pic);
                
            }else
                {
                    dtgrid.Columns.Add("id", "Id");
                    dtgrid.Columns.Add("firstname", "FirstName");
                    dtgrid.Columns.Add("lastname", "LastName");
                    dtgrid.Columns.Add("phone", "Phone");

                    records_txt.Visible = true;
                    panel2.Visible = false;
                }
         }
         catch (Exception eee)
         {
             MessageBox.Show(eee.Message, "Error !",
   MessageBoxButtons.OK, MessageBoxIcon.Error);


         }
        }

           
        }
        public void refresh_img_after_update(string path)
        {
            pic.Image = Image.FromFile(path);

        }

        public void Refresh()
        {

            dtgrid.DataSource = null;
            Dictionary<int, Data> MainData = new Dictionary<int, Data>();
            MainData = FileController.FileController.GetContacts();
            List<Data> Ldata = new List<Data>();
            foreach (KeyValuePair<int, Data> entry in MainData)
            {
                Ldata.Add(entry.Value);
            }



            dtgrid.DataSource = Ldata;
            dtgrid.Columns[2].Visible = false;
            dtgrid.Columns[5].Visible = false;
            dtgrid.Columns[6].Visible = false;
            if (dtgrid.Rows.Count <= 0)
            {

                delete_button.Enabled = false;
                btn_update.Enabled = false;
                id_txt.Text = "-";
                first_txt.Text = "-";
                middle_txt.Text = "-";
                last_txt.Text = "-";
                phone_txt.Text = "-";
                email_txt.Text = "-";
                pic.Image = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2013\Projects\firstTest\firstTest\bin\Debug\profile.jpg");
                //Checkifhighorlow();
                records_txt.Visible = true;
                panel2.Visible = false;

            }
            else
            {
                dData = FileController.FileController.GetContacts();
                int idfirst = dData.Keys.First();

                delete_button.Enabled = true;
                btn_update.Enabled = true;
                id_txt.Text = dData[idfirst].Id + "";
                first_txt.Text = dData[idfirst].FirstName;
                middle_txt.Text = dData[idfirst].MiddleName;
                last_txt.Text = dData[idfirst].LastName;
                phone_txt.Text = dData[idfirst].Phone;
                email_txt.Text = dData[idfirst].Email;
                pic.Image = Image.FromFile(dData[idfirst].Pic);

                dtgrid.Rows[0].Selected = true;

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgrid.Rows[selectedrowindex]; 
            current_row = int.Parse(selectedRow.Cells["Id"].Value + "");
            update upd = new update(this);


            upd.ShowDialog(); 

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("are you Sure !", "Delete !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                try
                {
                    //id cell
                     int selectedrowindex = dtgrid.SelectedCells[0].RowIndex;
                     DataGridViewRow selectedRow = dtgrid.Rows[selectedrowindex];
                    //string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);


                     current_row = int.Parse(selectedRow.Cells["Id"].Value+"");
                    FileController.FileController.Delete(current_row);
                   
                    Refresh();

                 
                    if (dtgrid.Rows.Count <= 0)
                    {

                        delete_button.Enabled = false;
                        btn_update.Enabled = false;
                        id_txt.Text = "-";
                        first_txt.Text = "-";
                        middle_txt.Text = "-";
                        last_txt.Text = "-";
                        phone_txt.Text = "-";
                        email_txt.Text = "-";
                        pic.Image = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2013\Projects\firstTest\firstTest\bin\Debug\profile.jpg");
                        //Checkifhighorlow();
                        records_txt.Visible = true;
                        panel2.Visible = false;

                    }
                    else
                    {
                        int idfirst = dData.Keys.First();

                        delete_button.Enabled = true;
                        btn_update.Enabled = true;
                        id_txt.Text = dData[idfirst].Id + "";
                        first_txt.Text = dData[idfirst].FirstName;
                        middle_txt.Text = dData[idfirst].MiddleName;
                        last_txt.Text = dData[idfirst].LastName;
                        phone_txt.Text = dData[idfirst].Phone;
                        email_txt.Text = dData[idfirst].Email;
                        pic.Image = Image.FromFile(dData[idfirst].Pic);

                        dtgrid.Rows[0].Selected = true;

                    }

                }
                 catch(Exception eM)
            {
                MessageBox.Show(eM.Message, "Error !",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void add_button_Click(object sender, EventArgs e)
        {

            add addf = new add(this);
            addf.ShowDialog();

        
        }
        public void RemoveAllRows()
        {

            dtgrid.DataSource = null;
            dtgrid.Columns.Clear();
            dtgrid.Rows.Clear();

        }
        public void Checkifhighorlow()
        {

            if (dtgrid.Rows.Count <= 0)
            {
                records_txt.Visible = false;
            }else
            {
                records_txt.Visible = true;


            }


        }

        public void HideorVisible()
        {
            if (panel2.Visible)
                panel2.Visible = false;
            else panel2.Visible = true;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgrid_MouseClick(object sender, MouseEventArgs e)
        {
            if(dtgrid.Rows.Count>0 && records_txt.Visible==false)
            {

                panel2.Visible = true;

            }
            try
            {
                if (dtgrid.CurrentRow.Index != dtgrid.Rows.Count)
                {
                        if (dtgrid.CurrentRow.Cells[0].Value != null)
                        {
                            cell = dtgrid.CurrentRow.Cells[0].Value.ToString();
                            int Icell = Int32.Parse(cell);

                            if (dData[Icell].Id == Icell)
                            {

                                delete_button.Enabled = true;
                                btn_update.Enabled = true;
                                id_txt.Text = dData[Icell].Id + "";
                                first_txt.Text = dData[Icell].FirstName;
                                middle_txt.Text = dData[Icell].MiddleName;
                                last_txt.Text = dData[Icell].LastName;
                                phone_txt.Text = dData[Icell].Phone;
                                email_txt.Text = dData[Icell].Email;
                                pic.Image = Image.FromFile(dData[Icell].Pic);


                            }
                        }

                    }
                }
            
            catch(Exception eM)
            {
    //            MessageBox.Show(eM.Message, "Error !",
    //MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }

        private void dtgrid_KeyUp(object sender, KeyEventArgs e)
        {
            //panel2.Visible = true;
            if (dtgrid.Rows.Count > 0 && records_txt.Visible == false)
            {

                panel2.Visible = true;

            }
            try
            {
                if (dtgrid.CurrentRow.Index != dtgrid.Rows.Count)
                {
                    if (dtgrid.CurrentRow.Cells[0].Value != null)
                    {
                        cell = dtgrid.CurrentRow.Cells[0].Value.ToString();
                        int Icell = Int32.Parse(cell);

                        if (dData[Icell].Id == Icell)
                        {

                            delete_button.Enabled = true;
                            btn_update.Enabled = true;
                            id_txt.Text = dData[Icell].Id + "";
                            first_txt.Text = dData[Icell].FirstName;
                            middle_txt.Text = dData[Icell].MiddleName;
                            last_txt.Text = dData[Icell].LastName;
                            phone_txt.Text = dData[Icell].Phone;
                            email_txt.Text = dData[Icell].Email;
                            pic.Image = Image.FromFile(dData[Icell].Pic);


                        }
                    }

                }
            }

            catch (Exception eM)
            {
                //            MessageBox.Show(eM.Message, "Error !",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtgrid_KeyDown(object sender, KeyEventArgs e)
        {
            //panel2.Visible = true;
            if (dtgrid.Rows.Count > 0 && records_txt.Visible == false)
            {

                panel2.Visible = true;

            }
            try
            {
                if (dtgrid.CurrentRow.Index != dtgrid.Rows.Count)
                {
                    if (dtgrid.CurrentRow.Cells[0].Value != null)
                    {
                        cell = dtgrid.CurrentRow.Cells[0].Value.ToString();
                        int Icell = Int32.Parse(cell);

                        if (dData[Icell].Id == Icell)
                        {

                            delete_button.Enabled = true;
                            btn_update.Enabled = true;
                            id_txt.Text = dData[Icell].Id + "";
                            first_txt.Text = dData[Icell].FirstName;
                            middle_txt.Text = dData[Icell].MiddleName;
                            last_txt.Text = dData[Icell].LastName;
                            phone_txt.Text = dData[Icell].Phone;
                            email_txt.Text = dData[Icell].Email;
                            pic.Image = Image.FromFile(dData[Icell].Pic);


                        }
                    }

                }
            }

            catch (Exception eM)
            {
                //            MessageBox.Show(eM.Message, "Error !",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        
        }
 
 
    
}
