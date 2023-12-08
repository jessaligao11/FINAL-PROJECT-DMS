namespace PROD_ACTIVITYY
{
    partial class Form1
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
            this.signuser = new System.Windows.Forms.TextBox();
            this.signpass = new System.Windows.Forms.TextBox();
            this.signid = new System.Windows.Forms.TextBox();
            this.loguser = new System.Windows.Forms.TextBox();
            this.logpass = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.signtn = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.signshowpass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signuser
            // 
            this.signuser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuser.Location = new System.Drawing.Point(302, 253);
            this.signuser.Name = "signuser";
            this.signuser.Size = new System.Drawing.Size(215, 31);
            this.signuser.TabIndex = 1;
            this.signuser.TextChanged += new System.EventHandler(this.signuser_TextChanged);
            // 
            // signpass
            // 
            this.signpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signpass.Location = new System.Drawing.Point(302, 301);
            this.signpass.Name = "signpass";
            this.signpass.Size = new System.Drawing.Size(215, 31);
            this.signpass.TabIndex = 2;
            this.signpass.TextChanged += new System.EventHandler(this.signpass_TextChanged);
            // 
            // signid
            // 
            this.signid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signid.Location = new System.Drawing.Point(302, 348);
            this.signid.Name = "signid";
            this.signid.Size = new System.Drawing.Size(215, 31);
            this.signid.TabIndex = 3;
            // 
            // loguser
            // 
            this.loguser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loguser.Location = new System.Drawing.Point(780, 253);
            this.loguser.Name = "loguser";
            this.loguser.Size = new System.Drawing.Size(215, 31);
            this.loguser.TabIndex = 4;
            this.loguser.TextChanged += new System.EventHandler(this.loguser_TextChanged);
            // 
            // logpass
            // 
            this.logpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpass.Location = new System.Drawing.Point(780, 331);
            this.logpass.Name = "logpass";
            this.logpass.Size = new System.Drawing.Size(215, 31);
            this.logpass.TabIndex = 5;
            // 
            // logbtn
            // 
            this.logbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(752, 393);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(137, 45);
            this.logbtn.TabIndex = 7;
            this.logbtn.Text = "log in";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click_1);
            // 
            // signtn
            // 
            this.signtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signtn.Location = new System.Drawing.Point(278, 393);
            this.signtn.Name = "signtn";
            this.signtn.Size = new System.Drawing.Size(137, 45);
            this.signtn.TabIndex = 8;
            this.signtn.Text = "sign up";
            this.signtn.UseVisualStyleBackColor = true;
            this.signtn.Click += new System.EventHandler(this.signtn_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showpass.Location = new System.Drawing.Point(1003, 338);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(18, 17);
            this.showpass.TabIndex = 10;
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // signshowpass
            // 
            this.signshowpass.AutoSize = true;
            this.signshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signshowpass.Location = new System.Drawing.Point(523, 310);
            this.signshowpass.Name = "signshowpass";
            this.signshowpass.Size = new System.Drawing.Size(18, 17);
            this.signshowpass.TabIndex = 11;
            this.signshowpass.UseVisualStyleBackColor = true;
            this.signshowpass.CheckedChanged += new System.EventHandler(this.signshowpass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROD_ACTIVITYY.Properties.Resources.LOG_IN;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 589);
            this.Controls.Add(this.signshowpass);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.signtn);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.loguser);
            this.Controls.Add(this.signid);
            this.Controls.Add(this.signpass);
            this.Controls.Add(this.signuser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox signuser;
        private System.Windows.Forms.TextBox signpass;
        private System.Windows.Forms.TextBox signid;
        private System.Windows.Forms.TextBox loguser;
        private System.Windows.Forms.TextBox logpass;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button signtn;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.CheckBox signshowpass;
    }
}

