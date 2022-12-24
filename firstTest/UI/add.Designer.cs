namespace firstTest
{
    partial class add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            this.first_txtb = new System.Windows.Forms.TextBox();
            this.middle_txtb = new System.Windows.Forms.TextBox();
            this.last_txtb = new System.Windows.Forms.TextBox();
            this.phone_txtb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_txtb = new System.Windows.Forms.TextBox();
            this.addPic = new System.Windows.Forms.PictureBox();
            this.pathpic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPic)).BeginInit();
            this.SuspendLayout();
            // 
            // first_txtb
            // 
            this.first_txtb.Location = new System.Drawing.Point(79, 128);
            this.first_txtb.Name = "first_txtb";
            this.first_txtb.Size = new System.Drawing.Size(257, 26);
            this.first_txtb.TabIndex = 1;
            this.first_txtb.Validating += new System.ComponentModel.CancelEventHandler(this.first_txtb_Validating);
            // 
            // middle_txtb
            // 
            this.middle_txtb.Location = new System.Drawing.Point(389, 127);
            this.middle_txtb.Name = "middle_txtb";
            this.middle_txtb.Size = new System.Drawing.Size(257, 26);
            this.middle_txtb.TabIndex = 2;
            this.middle_txtb.Validating += new System.ComponentModel.CancelEventHandler(this.middle_txtb_Validating);
            // 
            // last_txtb
            // 
            this.last_txtb.Location = new System.Drawing.Point(79, 220);
            this.last_txtb.Name = "last_txtb";
            this.last_txtb.Size = new System.Drawing.Size(257, 26);
            this.last_txtb.TabIndex = 3;
            this.last_txtb.Validating += new System.ComponentModel.CancelEventHandler(this.last_txtb_Validating);
            // 
            // phone_txtb
            // 
            this.phone_txtb.Location = new System.Drawing.Point(389, 219);
            this.phone_txtb.Name = "phone_txtb";
            this.phone_txtb.Size = new System.Drawing.Size(257, 26);
            this.phone_txtb.TabIndex = 4;
            this.phone_txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txtb_KeyPress);
            this.phone_txtb.Validating += new System.ComponentModel.CancelEventHandler(this.phone_txtb_Validating);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(218, 403);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(257, 46);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "First name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Name *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email *";
            // 
            // email_txtb
            // 
            this.email_txtb.Location = new System.Drawing.Point(79, 313);
            this.email_txtb.Name = "email_txtb";
            this.email_txtb.Size = new System.Drawing.Size(257, 26);
            this.email_txtb.TabIndex = 12;
            this.email_txtb.Validating += new System.ComponentModel.CancelEventHandler(this.email_txtb_Validating);
            // 
            // addPic
            // 
            this.addPic.Image = ((System.Drawing.Image)(resources.GetObject("addPic.Image")));
            this.addPic.Location = new System.Drawing.Point(737, 37);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(200, 200);
            this.addPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPic.TabIndex = 14;
            this.addPic.TabStop = false;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // pathpic
            // 
            this.pathpic.AutoSize = true;
            this.pathpic.Location = new System.Drawing.Point(733, 257);
            this.pathpic.Name = "pathpic";
            this.pathpic.Size = new System.Drawing.Size(222, 20);
            this.pathpic.TabIndex = 15;
            this.pathpic.Text = "Click on the here to add Photo";
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 673);
            this.Controls.Add(this.pathpic);
            this.Controls.Add(this.addPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_txtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.phone_txtb);
            this.Controls.Add(this.last_txtb);
            this.Controls.Add(this.middle_txtb);
            this.Controls.Add(this.first_txtb);
            this.Name = "add";
            this.Text = "add";
            this.Load += new System.EventHandler(this.add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_txtb;
        private System.Windows.Forms.TextBox middle_txtb;
        private System.Windows.Forms.TextBox last_txtb;
        private System.Windows.Forms.TextBox phone_txtb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_txtb;
        private System.Windows.Forms.PictureBox addPic;
        private System.Windows.Forms.Label pathpic;
    }
}