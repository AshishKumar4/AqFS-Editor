namespace AqFS_Editor
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
            this.Browse_HDD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HDD_Path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Open_HDD = new System.Windows.Forms.Button();
            this.HDD_ReadStatus = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.HDD_GuestFiles = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HDD_GuestPath = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Host_SaveFromMemory = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Browse_HDD
            // 
            this.Browse_HDD.Location = new System.Drawing.Point(12, 12);
            this.Browse_HDD.Name = "Browse_HDD";
            this.Browse_HDD.Size = new System.Drawing.Size(179, 50);
            this.Browse_HDD.TabIndex = 0;
            this.Browse_HDD.Text = "Browse Hard Disk Image";
            this.Browse_HDD.UseVisualStyleBackColor = true;
            this.Browse_HDD.Click += new System.EventHandler(this.Open_HDD_Click);
            // 
            // HDD_Path
            // 
            this.HDD_Path.Location = new System.Drawing.Point(208, 12);
            this.HDD_Path.Multiline = true;
            this.HDD_Path.Name = "HDD_Path";
            this.HDD_Path.Size = new System.Drawing.Size(516, 50);
            this.HDD_Path.TabIndex = 1;
            this.HDD_Path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy Host To Guest Direct";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 297);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Console Input";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(560, 100);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(366, 296);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Console output";
            // 
            // Open_HDD
            // 
            this.Open_HDD.Location = new System.Drawing.Point(741, 12);
            this.Open_HDD.Name = "Open_HDD";
            this.Open_HDD.Size = new System.Drawing.Size(121, 49);
            this.Open_HDD.TabIndex = 7;
            this.Open_HDD.Text = "Open";
            this.Open_HDD.UseVisualStyleBackColor = true;
            this.Open_HDD.Click += new System.EventHandler(this.button2_Click);
            // 
            // HDD_ReadStatus
            // 
            this.HDD_ReadStatus.Location = new System.Drawing.Point(887, 25);
            this.HDD_ReadStatus.Name = "HDD_ReadStatus";
            this.HDD_ReadStatus.Size = new System.Drawing.Size(85, 22);
            this.HDD_ReadStatus.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Copy Guest File to Memory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HDD_GuestFiles
            // 
            this.HDD_GuestFiles.Location = new System.Drawing.Point(197, 464);
            this.HDD_GuestFiles.Multiline = true;
            this.HDD_GuestFiles.Name = "HDD_GuestFiles";
            this.HDD_GuestFiles.Size = new System.Drawing.Size(328, 47);
            this.HDD_GuestFiles.TabIndex = 10;
            this.HDD_GuestFiles.TextChanged += new System.EventHandler(this.HDD_GuestFiles_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Copy Host File to Memory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Copy File From Memory to Guest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HDD_GuestPath
            // 
            this.HDD_GuestPath.Location = new System.Drawing.Point(726, 464);
            this.HDD_GuestPath.Multiline = true;
            this.HDD_GuestPath.Name = "HDD_GuestPath";
            this.HDD_GuestPath.Size = new System.Drawing.Size(362, 47);
            this.HDD_GuestPath.TabIndex = 13;
            this.HDD_GuestPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "Copy File From Memory to Host";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 47);
            this.button6.TabIndex = 15;
            this.button6.Text = "Copy Guest File to Host Direct";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 539);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.HDD_GuestPath);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HDD_GuestFiles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HDD_ReadStatus);
            this.Controls.Add(this.Open_HDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HDD_Path);
            this.Controls.Add(this.Browse_HDD);
            this.Name = "Form1";
            this.Text = "AqFS Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse_HDD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox HDD_Path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open_HDD;
        private System.Windows.Forms.TextBox HDD_ReadStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox HDD_GuestFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox HDD_GuestPath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog Host_SaveFromMemory;
    }
}

