namespace WindowsFormsApplication1
{
    partial class DeleteUser
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
            this.delusrlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usrtodeltxtbox = new System.Windows.Forms.TextBox();
            this.delusrbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delusrlbl
            // 
            this.delusrlbl.AutoSize = true;
            this.delusrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.delusrlbl.Location = new System.Drawing.Point(85, 40);
            this.delusrlbl.Name = "delusrlbl";
            this.delusrlbl.Size = new System.Drawing.Size(405, 46);
            this.delusrlbl.TabIndex = 0;
            this.delusrlbl.Text = "Delete User By Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // usrtodeltxtbox
            // 
            this.usrtodeltxtbox.Location = new System.Drawing.Point(233, 140);
            this.usrtodeltxtbox.Name = "usrtodeltxtbox";
            this.usrtodeltxtbox.Size = new System.Drawing.Size(141, 26);
            this.usrtodeltxtbox.TabIndex = 2;
            // 
            // delusrbtn
            // 
            this.delusrbtn.Location = new System.Drawing.Point(233, 190);
            this.delusrbtn.Name = "delusrbtn";
            this.delusrbtn.Size = new System.Drawing.Size(141, 46);
            this.delusrbtn.TabIndex = 3;
            this.delusrbtn.Text = "Delete ";
            this.delusrbtn.UseVisualStyleBackColor = true;
            this.delusrbtn.Click += new System.EventHandler(this.delusrbtn_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 293);
            this.Controls.Add(this.delusrbtn);
            this.Controls.Add(this.usrtodeltxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delusrlbl);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label delusrlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrtodeltxtbox;
        private System.Windows.Forms.Button delusrbtn;
    }
}