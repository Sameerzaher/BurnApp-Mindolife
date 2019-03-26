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
    public partial class DeleteUser : Form
    {
        String _conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;Persist Security Info=False;";

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void delusrbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usrtodeltxtbox.Text))
            {
                User delusr = new User();
                delusr.Username = usrtodeltxtbox.Text;
                try
                {
                    DBSQL delete = new DBSQL(_conn);
                    
                    delete.deleteUser(delusr);
                    MessageBox.Show("The User Has been Deleted ");
                    AllUserData frm = new AllUserData();
                    frm.Show();
                    this.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
    }
}
