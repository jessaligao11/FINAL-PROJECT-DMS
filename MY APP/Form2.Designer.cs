namespace PROD_ACTIVITYY
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.yournote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletenote = new System.Windows.Forms.Button();
            this.updatenote = new System.Windows.Forms.Button();
            this.savenote = new System.Windows.Forms.Button();
            this.mynotes = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.note1 = new System.Windows.Forms.TextBox();
            this.note2 = new System.Windows.Forms.TextBox();
            this.note3 = new System.Windows.Forms.TextBox();
            this.note4 = new System.Windows.Forms.TextBox();
            this.note5 = new System.Windows.Forms.TextBox();
            this.updatetask = new System.Windows.Forms.Button();
            this.diary = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yournote
            // 
            this.yournote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yournote.Location = new System.Drawing.Point(559, 68);
            this.yournote.Name = "yournote";
            this.yournote.Size = new System.Drawing.Size(524, 34);
            this.yournote.TabIndex = 2;
            this.yournote.TextChanged += new System.EventHandler(this.yournote_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // deletenote
            // 
            this.deletenote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletenote.Location = new System.Drawing.Point(434, 353);
            this.deletenote.Name = "deletenote";
            this.deletenote.Size = new System.Drawing.Size(134, 42);
            this.deletenote.TabIndex = 5;
            this.deletenote.Text = "delete";
            this.deletenote.UseVisualStyleBackColor = true;
            this.deletenote.Click += new System.EventHandler(this.deletenote_Click);
            // 
            // updatenote
            // 
            this.updatenote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatenote.Location = new System.Drawing.Point(662, 353);
            this.updatenote.Name = "updatenote";
            this.updatenote.Size = new System.Drawing.Size(134, 42);
            this.updatenote.TabIndex = 6;
            this.updatenote.Text = "update";
            this.updatenote.UseVisualStyleBackColor = true;
            this.updatenote.Click += new System.EventHandler(this.updatenote_Click);
            // 
            // savenote
            // 
            this.savenote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savenote.Location = new System.Drawing.Point(908, 353);
            this.savenote.Name = "savenote";
            this.savenote.Size = new System.Drawing.Size(134, 42);
            this.savenote.TabIndex = 7;
            this.savenote.Text = "save";
            this.savenote.UseVisualStyleBackColor = true;
            this.savenote.Click += new System.EventHandler(this.savenote_Click);
            // 
            // mynotes
            // 
            this.mynotes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mynotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mynotes.FormattingEnabled = true;
            this.mynotes.ItemHeight = 28;
            this.mynotes.Location = new System.Drawing.Point(383, 114);
            this.mynotes.Name = "mynotes";
            this.mynotes.Size = new System.Drawing.Size(700, 200);
            this.mynotes.TabIndex = 9;
            this.mynotes.SelectedIndexChanged += new System.EventHandler(this.viewnotes_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 179);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(34, 247);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(34, 319);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(22, 21);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(34, 384);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(22, 21);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(62, 102);
            this.note1.Multiline = true;
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(191, 34);
            this.note1.TabIndex = 18;
            this.note1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(62, 171);
            this.note2.Multiline = true;
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(191, 34);
            this.note2.TabIndex = 19;
            this.note2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // note3
            // 
            this.note3.Location = new System.Drawing.Point(62, 242);
            this.note3.Multiline = true;
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(191, 34);
            this.note3.TabIndex = 20;
            this.note3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // note4
            // 
            this.note4.Location = new System.Drawing.Point(62, 311);
            this.note4.Multiline = true;
            this.note4.Name = "note4";
            this.note4.Size = new System.Drawing.Size(191, 34);
            this.note4.TabIndex = 21;
            this.note4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // note5
            // 
            this.note5.Location = new System.Drawing.Point(62, 373);
            this.note5.Multiline = true;
            this.note5.Name = "note5";
            this.note5.Size = new System.Drawing.Size(191, 34);
            this.note5.TabIndex = 22;
            this.note5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // updatetask
            // 
            this.updatetask.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetask.Location = new System.Drawing.Point(85, 472);
            this.updatetask.Name = "updatetask";
            this.updatetask.Size = new System.Drawing.Size(134, 42);
            this.updatetask.TabIndex = 23;
            this.updatetask.Text = "update/save";
            this.updatetask.UseVisualStyleBackColor = true;
            this.updatetask.Click += new System.EventHandler(this.updatetask_Click);
            // 
            // diary
            // 
            this.diary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diary.Location = new System.Drawing.Point(959, 472);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(134, 42);
            this.diary.TabIndex = 24;
            this.diary.Text = "diary";
            this.diary.UseVisualStyleBackColor = true;
            this.diary.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROD_ACTIVITYY.Properties.Resources.LOG_IN__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 535);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.updatetask);
            this.Controls.Add(this.note5);
            this.Controls.Add(this.note4);
            this.Controls.Add(this.note3);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mynotes);
            this.Controls.Add(this.savenote);
            this.Controls.Add(this.updatenote);
            this.Controls.Add(this.deletenote);
            this.Controls.Add(this.yournote);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox yournote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button deletenote;
        private System.Windows.Forms.Button updatenote;
        private System.Windows.Forms.Button savenote;
        private System.Windows.Forms.ListBox mynotes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox note1;
        private System.Windows.Forms.TextBox note2;
        private System.Windows.Forms.TextBox note3;
        private System.Windows.Forms.TextBox note4;
        private System.Windows.Forms.TextBox note5;
        private System.Windows.Forms.Button updatetask;
        private System.Windows.Forms.Button diary;
    }
}