namespace WindowsFormsApplication1
{
    partial class AllUserData
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
            this.userdatagrid = new System.Windows.Forms.DataGridView();
            this.bckbtnfrm3 = new System.Windows.Forms.Button();
            this.alluserdatalbl = new System.Windows.Forms.Label();
            this.updateuserbtn = new System.Windows.Forms.Button();
            this.addusrbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.delusrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userdatagrid
            // 
            this.userdatagrid.AllowUserToOrderColumns = true;
            this.userdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdatagrid.Location = new System.Drawing.Point(118, 67);
            this.userdatagrid.Name = "userdatagrid";
            this.userdatagrid.RowTemplate.Height = 28;
            this.userdatagrid.Size = new System.Drawing.Size(515, 298);
            this.userdatagrid.TabIndex = 0;
            this.userdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdatagrid_CellContentClick);
            // 
            // bckbtnfrm3
            // 
            this.bckbtnfrm3.Location = new System.Drawing.Point(733, 435);
            this.bckbtnfrm3.Name = "bckbtnfrm3";
            this.bckbtnfrm3.Size = new System.Drawing.Size(178, 72);
            this.bckbtnfrm3.TabIndex = 1;
            this.bckbtnfrm3.Text = "Back";
            this.bckbtnfrm3.UseVisualStyleBackColor = true;
            this.bckbtnfrm3.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // alluserdatalbl
            // 
            this.alluserdatalbl.AutoSize = true;
            this.alluserdatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.alluserdatalbl.Location = new System.Drawing.Point(300, 9);
            this.alluserdatalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alluserdatalbl.Name = "alluserdatalbl";
            this.alluserdatalbl.Size = new System.Drawing.Size(255, 46);
            this.alluserdatalbl.TabIndex = 2;
            this.alluserdatalbl.Text = "All User Data";
            // 
            // updateuserbtn
            // 
            this.updateuserbtn.Location = new System.Drawing.Point(768, 190);
            this.updateuserbtn.Name = "updateuserbtn";
            this.updateuserbtn.Size = new System.Drawing.Size(143, 49);
            this.updateuserbtn.TabIndex = 4;
            this.updateuserbtn.Text = "Edit User";
            this.updateuserbtn.UseVisualStyleBackColor = true;
            this.updateuserbtn.Click += new System.EventHandler(this.updateuserbtn_Click);
            // 
            // addusrbtn
            // 
            this.addusrbtn.Location = new System.Drawing.Point(768, 88);
            this.addusrbtn.Name = "addusrbtn";
            this.addusrbtn.Size = new System.Drawing.Size(151, 49);
            this.addusrbtn.TabIndex = 5;
            this.addusrbtn.Text = "Add User";
            this.addusrbtn.UseVisualStyleBackColor = true;
            this.addusrbtn.UseWaitCursor = true;
            this.addusrbtn.Click += new System.EventHandler(this.addusrbtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(760, 310);
            this.showbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(151, 49);
            this.showbtn.TabIndex = 3;
            this.showbtn.Text = "Show User Data";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // delusrbtn
            // 
            this.delusrbtn.Location = new System.Drawing.Point(308, 422);
            this.delusrbtn.Name = "delusrbtn";
            this.delusrbtn.Size = new System.Drawing.Size(134, 45);
            this.delusrbtn.TabIndex = 6;
            this.delusrbtn.Text = "Delete User";
            this.delusrbtn.UseVisualStyleBackColor = true;
            this.delusrbtn.Click += new System.EventHandler(this.delusrbtn_Click);
            // 
            // AllUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 540);
            this.Controls.Add(this.delusrbtn);
            this.Controls.Add(this.addusrbtn);
            this.Controls.Add(this.updateuserbtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.alluserdatalbl);
            this.Controls.Add(this.bckbtnfrm3);
            this.Controls.Add(this.userdatagrid);
            this.Name = "AllUserData";
            this.Text = "All User Data";
            this.Load += new System.EventHandler(this.AllUserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userdatagrid;
        private System.Windows.Forms.Button bckbtnfrm3;
        private System.Windows.Forms.Label alluserdatalbl;
        private System.Windows.Forms.Button updateuserbtn;
        private System.Windows.Forms.Button addusrbtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button delusrbtn;
    }
}