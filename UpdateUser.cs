using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UpdateUser : Form
    {
        String _conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;Persist Security Info=False;";
        public UpdateUser()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void updateusrbtn_Click(object sender, EventArgs e)
        {
            User updateUsr = new User();
            DBSQL updte = new DBSQL(_conn);
            updateUsr = updte.getUserDetailsByUsername(login.username);

            if (updateUsr == null)
                MessageBox.Show("No User With This ID Number");
           if(!string.IsNullOrEmpty(roletxtbox.Text))
               try
               {
                   updte.UpdateUser(updateUsr);
                   MessageBox.Show("user Has Updated Successfuly");
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Error " + ex);
               }
            
           
        }
      

        private void UpdateUser_Load(object sender, EventArgs e)
        {
             User updateusr = new User();
           
            DBSQL updte = new DBSQL(_conn);
        
            updateuserusrnamecmbbox.Items.Clear();
           

            updateusr = updte.getUserDetailsByUsername(login.username);
            
            User[] userarr = updte.GetUserName();
            for (int i = 0; i < userarr.Length; i++)
            {
                updateuserusrnamecmbbox.Items.Add(userarr[i].Username);
                roletxtbox.Text = updateusr.Role;
            }
         
          
            
          
        }

        private void updateuserusrnamecmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
