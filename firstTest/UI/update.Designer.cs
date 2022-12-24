namespace firstTest
{
    partial class update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.last_txt = new System.Windows.Forms.TextBox();
            this.middle_txt = new System.Windows.Forms.TextBox();
            this.first_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.pic_New = new System.Windows.Forms.PictureBox();
            this.pic_path_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_New)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Email";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(174, 262);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(257, 26);
            this.email_txt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "First name";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(320, 173);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(257, 26);
            this.phone_txt.TabIndex = 17;
            // 
            // last_txt
            // 
            this.last_txt.Location = new System.Drawing.Point(35, 173);
            this.last_txt.Name = "last_txt";
            this.last_txt.Size = new System.Drawing.Size(257, 26);
            this.last_txt.TabIndex = 16;
            // 
            // middle_txt
            // 
            this.middle_txt.Location = new System.Drawing.Point(320, 81);
            this.middle_txt.Name = "middle_txt";
            this.middle_txt.Size = new System.Drawing.Size(257, 26);
            this.middle_txt.TabIndex = 15;
            // 
            // first_txt
            // 
            this.first_txt.Location = new System.Drawing.Point(35, 81);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(257, 26);
            this.first_txt.TabIndex = 14;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(174, 359);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(257, 46);
            this.update_btn.TabIndex = 25;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // pic_New
            // 
            this.pic_New.Location = new System.Drawing.Point(714, 81);
            this.pic_New.Name = "pic_New";
            this.pic_New.Size = new System.Drawing.Size(200, 200);
            this.pic_New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_New.TabIndex = 26;
            this.pic_New.TabStop = false;
            this.pic_New.Click += new System.EventHandler(this.pic_New_Click);
            // 
            // pic_path_txt
            // 
            this.pic_path_txt.AutoSize = true;
            this.pic_path_txt.Location = new System.Drawing.Point(675, 308);
            this.pic_path_txt.Name = "pic_path_txt";
            this.pic_path_txt.Size = new System.Drawing.Size(280, 20);
            this.pic_path_txt.TabIndex = 27;
            this.pic_path_txt.Text = "click on the picuter to pick another one";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 540);
            this.Controls.Add(this.pic_path_txt);
            this.Controls.Add(this.pic_New);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.last_txt);
            this.Controls.Add(this.middle_txt);
            this.Controls.Add(this.first_txt);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_New)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox last_txt;
        private System.Windows.Forms.TextBox middle_txt;
        private System.Windows.Forms.TextBox first_txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.PictureBox pic_New;
        private System.Windows.Forms.Label pic_path_txt;
    }
}