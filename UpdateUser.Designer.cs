namespace WindowsFormsApplication1
{
    partial class UpdateUser
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
            this.roletxtbox = new System.Windows.Forms.TextBox();
            this.rolelbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.addnewusrlbl = new System.Windows.Forms.Label();
            this.updateusrbtn = new System.Windows.Forms.Button();
            this.updateuserusrnamecmbbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roletxtbox
            // 
            this.roletxtbox.Location = new System.Drawing.Point(284, 245);
            this.roletxtbox.Name = "roletxtbox";
            this.roletxtbox.Size = new System.Drawing.Size(100, 26);
            this.roletxtbox.TabIndex = 19;
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Location = new System.Drawing.Point(172, 251);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(35, 20);
            this.rolelbl.TabIndex = 14;
            this.rolelbl.Text = "role";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(155, 176);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(80, 20);
            this.usernamelbl.TabIndex = 12;
            this.usernamelbl.Text = "username";
            // 
            // addnewusrlbl
            // 
            this.addnewusrlbl.AutoSize = true;
            this.addnewusrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addnewusrlbl.Location = new System.Drawing.Point(151, 50);
            this.addnewusrlbl.Name = "addnewusrlbl";
            this.addnewusrlbl.Size = new System.Drawing.Size(243, 46);
            this.addnewusrlbl.TabIndex = 11;
            this.addnewusrlbl.Text = "Update User";
            this.addnewusrlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateusrbtn
            // 
            this.updateusrbtn.Location = new System.Drawing.Point(193, 312);
            this.updateusrbtn.Name = "updateusrbtn";
            this.updateusrbtn.Size = new System.Drawing.Size(131, 58);
            this.updateusrbtn.TabIndex = 10;
            this.updateusrbtn.Text = "Update";
            this.updateusrbtn.UseVisualStyleBackColor = true;
            this.updateusrbtn.Click += new System.EventHandler(this.updateusrbtn_Click);
            // 
            // updateuserusrnamecmbbox
            // 
            this.updateuserusrnamecmbbox.FormattingEnabled = true;
            this.updateuserusrnamecmbbox.Location = new System.Drawing.Point(275, 176);
            this.updateuserusrnamecmbbox.Name = "updateuserusrnamecmbbox";
            this.updateuserusrnamecmbbox.Size = new System.Drawing.Size(119, 28);
            this.updateuserusrnamecmbbox.TabIndex = 20;
            this.updateuserusrnamecmbbox.SelectedIndexChanged += new System.EventHandler(this.updateuserusrnamecmbbox_SelectedIndexChanged);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 525);
            this.Controls.Add(this.updateuserusrnamecmbbox);
            this.Controls.Add(this.roletxtbox);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.addnewusrlbl);
            this.Controls.Add(this.updateusrbtn);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roletxtbox;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label addnewusrlbl;
        private System.Windows.Forms.Button updateusrbtn;
        private System.Windows.Forms.ComboBox updateuserusrnamecmbbox;
    }
}