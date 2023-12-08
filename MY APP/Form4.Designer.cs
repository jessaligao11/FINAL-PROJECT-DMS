namespace PROD_ACTIVITYY
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.savediary = new System.Windows.Forms.Button();
            this.richTextBoxdiary = new System.Windows.Forms.RichTextBox();
            this.daydiary = new System.Windows.Forms.TextBox();
            this.monthdiary = new System.Windows.Forms.TextBox();
            this.yeardiary = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.showdiary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROD_ACTIVITYY.Properties.Resources.LOG_IN__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(972, 519);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 42);
            this.exit.TabIndex = 25;
            this.exit.Text = "log out";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // savediary
            // 
            this.savediary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savediary.Location = new System.Drawing.Point(808, 519);
            this.savediary.Name = "savediary";
            this.savediary.Size = new System.Drawing.Size(134, 42);
            this.savediary.TabIndex = 26;
            this.savediary.Text = "save";
            this.savediary.UseVisualStyleBackColor = true;
            this.savediary.Click += new System.EventHandler(this.savediary_Click);
            // 
            // richTextBoxdiary
            // 
            this.richTextBoxdiary.Location = new System.Drawing.Point(92, 438);
            this.richTextBoxdiary.Name = "richTextBoxdiary";
            this.richTextBoxdiary.Size = new System.Drawing.Size(647, 96);
            this.richTextBoxdiary.TabIndex = 27;
            this.richTextBoxdiary.Text = "";
            this.richTextBoxdiary.TextChanged += new System.EventHandler(this.richTextBoxdiary_TextChanged);
            // 
            // daydiary
            // 
            this.daydiary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daydiary.Location = new System.Drawing.Point(276, 189);
            this.daydiary.Name = "daydiary";
            this.daydiary.Size = new System.Drawing.Size(215, 31);
            this.daydiary.TabIndex = 28;
            this.daydiary.TextChanged += new System.EventHandler(this.daydiary_TextChanged);
            // 
            // monthdiary
            // 
            this.monthdiary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthdiary.Location = new System.Drawing.Point(276, 257);
            this.monthdiary.Name = "monthdiary";
            this.monthdiary.Size = new System.Drawing.Size(215, 31);
            this.monthdiary.TabIndex = 29;
            this.monthdiary.TextChanged += new System.EventHandler(this.monthdiary_TextChanged);
            // 
            // yeardiary
            // 
            this.yeardiary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeardiary.Location = new System.Drawing.Point(276, 322);
            this.yeardiary.Name = "yeardiary";
            this.yeardiary.Size = new System.Drawing.Size(215, 31);
            this.yeardiary.TabIndex = 30;
            this.yeardiary.TextChanged += new System.EventHandler(this.yeardiary_TextChanged);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(972, 455);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(134, 42);
            this.homebtn.TabIndex = 31;
            this.homebtn.Text = "home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // showdiary
            // 
            this.showdiary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdiary.Location = new System.Drawing.Point(808, 455);
            this.showdiary.Name = "showdiary";
            this.showdiary.Size = new System.Drawing.Size(134, 42);
            this.showdiary.TabIndex = 32;
            this.showdiary.Text = "show";
            this.showdiary.UseVisualStyleBackColor = true;
            this.showdiary.Click += new System.EventHandler(this.showdiary_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 589);
            this.Controls.Add(this.showdiary);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.yeardiary);
            this.Controls.Add(this.monthdiary);
            this.Controls.Add(this.daydiary);
            this.Controls.Add(this.richTextBoxdiary);
            this.Controls.Add(this.savediary);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button savediary;
        private System.Windows.Forms.RichTextBox richTextBoxdiary;
        private System.Windows.Forms.TextBox daydiary;
        private System.Windows.Forms.TextBox monthdiary;
        private System.Windows.Forms.TextBox yeardiary;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button showdiary;
    }
}