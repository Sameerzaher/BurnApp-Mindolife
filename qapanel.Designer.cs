namespace WindowsFormsApplication1
{
    partial class qapanel
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
            this.bckbtmfrmqa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bckbtmfrmqa
            // 
            this.bckbtmfrmqa.Location = new System.Drawing.Point(471, 177);
            this.bckbtmfrmqa.Name = "bckbtmfrmqa";
            this.bckbtmfrmqa.Size = new System.Drawing.Size(150, 51);
            this.bckbtmfrmqa.TabIndex = 0;
            this.bckbtmfrmqa.Text = "Back";
            this.bckbtmfrmqa.UseVisualStyleBackColor = true;
            this.bckbtmfrmqa.Click += new System.EventHandler(this.bckbtmfrmqa_Click);
            // 
            // qapanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 261);
            this.Controls.Add(this.bckbtmfrmqa);
            this.Name = "qapanel";
            this.Text = "QA Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bckbtmfrmqa;
    }
}