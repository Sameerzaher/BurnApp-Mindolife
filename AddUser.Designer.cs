namespace WindowsFormsApplication1
{
    partial class AddUser
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
            this.svechngesbtn = new System.Windows.Forms.Button();
            this.addnewusrlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.firstnametxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.roletxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // svechngesbtn
            // 
            this.svechngesbtn.Location = new System.Drawing.Point(104, 372);
            this.svechngesbtn.Name = "svechngesbtn";
            this.svechngesbtn.Size = new System.Drawing.Size(131, 58);
            this.svechngesbtn.TabIndex = 0;
            this.svechngesbtn.Text = "Save Changes";
            this.svechngesbtn.UseVisualStyleBackColor = true;
            this.svechngesbtn.Click += new System.EventHandler(this.svechngesbtn_Click);
            // 
            // addnewusrlbl
            // 
            this.addnewusrlbl.AutoSize = true;
            this.addnewusrlbl.Location = new System.Drawing.Point(111, 49);
            this.addnewusrlbl.Name = "addnewusrlbl";
            this.addnewusrlbl.Size = new System.Drawing.Size(111, 20);
            this.addnewusrlbl.TabIndex = 1;
            this.addnewusrlbl.Text = "Add New User";
            this.addnewusrlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(50, 194);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(80, 20);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(50, 241);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(77, 20);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "password";
            this.passlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Location = new System.Drawing.Point(50, 281);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(35, 20);
            this.rolelbl.TabIndex = 4;
            this.rolelbl.Text = "role";
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Location = new System.Drawing.Point(50, 142);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(86, 20);
            this.firstnamelbl.TabIndex = 5;
            this.firstnamelbl.Text = "First Name";
            // 
            // firstnametxtbox
            // 
            this.firstnametxtbox.Location = new System.Drawing.Point(165, 139);
            this.firstnametxtbox.Name = "firstnametxtbox";
            this.firstnametxtbox.Size = new System.Drawing.Size(100, 26);
            this.firstnametxtbox.TabIndex = 6;
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(151, 238);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(100, 26);
            this.passwordtxtbox.TabIndex = 7;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(165, 194);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(100, 26);
            this.usernametxtbox.TabIndex = 8;
            // 
            // roletxtbox
            // 
            this.roletxtbox.Location = new System.Drawing.Point(135, 281);
            this.roletxtbox.Name = "roletxtbox";
            this.roletxtbox.Size = new System.Drawing.Size(100, 26);
            this.roletxtbox.TabIndex = 9;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 473);
            this.Controls.Add(this.roletxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.firstnametxtbox);
            this.Controls.Add(this.firstnamelbl);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.addnewusrlbl);
            this.Controls.Add(this.svechngesbtn);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button svechngesbtn;
        private System.Windows.Forms.Label addnewusrlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.TextBox firstnametxtbox;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox roletxtbox;
    }
}