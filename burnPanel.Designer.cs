namespace WindowsFormsApplication1
{
    partial class burnPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brnbtn = new System.Windows.Forms.Button();
            this.versioninfodatagrid = new System.Windows.Forms.DataGridView();
            this.bckbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.versioninfodatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(76, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 108);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // brnbtn
            // 
            this.brnbtn.Location = new System.Drawing.Point(283, 185);
            this.brnbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnbtn.Name = "brnbtn";
            this.brnbtn.Size = new System.Drawing.Size(115, 31);
            this.brnbtn.TabIndex = 2;
            this.brnbtn.Text = "Burn";
            this.brnbtn.UseVisualStyleBackColor = true;
            // 
            // versioninfodatagrid
            // 
            this.versioninfodatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versioninfodatagrid.Location = new System.Drawing.Point(452, 82);
            this.versioninfodatagrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.versioninfodatagrid.Name = "versioninfodatagrid";
            this.versioninfodatagrid.RowTemplate.Height = 28;
            this.versioninfodatagrid.Size = new System.Drawing.Size(245, 125);
            this.versioninfodatagrid.TabIndex = 3;
            // 
            // bckbtn
            // 
            this.bckbtn.Location = new System.Drawing.Point(555, 257);
            this.bckbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(113, 44);
            this.bckbtn.TabIndex = 4;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = true;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(504, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Version Info";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(248, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // burnPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 334);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.versioninfodatagrid);
            this.Controls.Add(this.brnbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "burnPanel";
            this.Text = " ";
            this.Load += new System.EventHandler(this.burnPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.versioninfodatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button brnbtn;
        private System.Windows.Forms.DataGridView versioninfodatagrid;
        private System.Windows.Forms.Button bckbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}