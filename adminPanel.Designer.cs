namespace WindowsFormsApplication1
{
    partial class adminpanelfrm
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
            this.brwbtn = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.filepathtxtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.brwmltibtn = new System.Windows.Forms.Button();
            this.allusrdatabtn = new System.Windows.Forms.Button();
            this.bckbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brwbtn
            // 
            this.brwbtn.Location = new System.Drawing.Point(555, 49);
            this.brwbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brwbtn.Name = "brwbtn";
            this.brwbtn.Size = new System.Drawing.Size(119, 40);
            this.brwbtn.TabIndex = 0;
            this.brwbtn.Text = "Browse";
            this.brwbtn.UseVisualStyleBackColor = true;
            this.brwbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(394, 114);
            this.uploadbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(127, 45);
            this.uploadbtn.TabIndex = 1;
            this.uploadbtn.Text = "Upload";
            this.uploadbtn.UseVisualStyleBackColor = true;
            // 
            // filepathtxtbox
            // 
            this.filepathtxtbox.Location = new System.Drawing.Point(267, 60);
            this.filepathtxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filepathtxtbox.Name = "filepathtxtbox";
            this.filepathtxtbox.Size = new System.Drawing.Size(254, 20);
            this.filepathtxtbox.TabIndex = 2;
            this.filepathtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // brwmltibtn
            // 
            this.brwmltibtn.Location = new System.Drawing.Point(555, 114);
            this.brwmltibtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brwmltibtn.Name = "brwmltibtn";
            this.brwmltibtn.Size = new System.Drawing.Size(119, 45);
            this.brwmltibtn.TabIndex = 3;
            this.brwmltibtn.Text = "Browse Multiple Files";
            this.brwmltibtn.UseVisualStyleBackColor = true;
            // 
            // allusrdatabtn
            // 
            this.allusrdatabtn.Location = new System.Drawing.Point(58, 67);
            this.allusrdatabtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allusrdatabtn.Name = "allusrdatabtn";
            this.allusrdatabtn.Size = new System.Drawing.Size(105, 47);
            this.allusrdatabtn.TabIndex = 4;
            this.allusrdatabtn.Text = "All User Data";
            this.allusrdatabtn.UseVisualStyleBackColor = true;
            this.allusrdatabtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bckbtn
            // 
            this.bckbtn.Location = new System.Drawing.Point(552, 214);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(122, 50);
            this.bckbtn.TabIndex = 5;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = true;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // adminpanelfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 311);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.allusrdatabtn);
            this.Controls.Add(this.brwmltibtn);
            this.Controls.Add(this.filepathtxtbox);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.brwbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminpanelfrm";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brwbtn;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.TextBox filepathtxtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button brwmltibtn;
        private System.Windows.Forms.Button allusrdatabtn;
        private System.Windows.Forms.Button bckbtn;
    }
}