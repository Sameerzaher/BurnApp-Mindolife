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
    public partial class AddUser : Form
    {
        String _conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;Persist Security Info=False;";
        public AddUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void svechngesbtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(firstnametxtbox.Text)&&(!string.IsNullOrWhiteSpace(usernametxtbox.Text)&&(!string.IsNullOrWhiteSpace(passwordtxtbox.Text)&&(!string.IsNullOrWhiteSpace(roletxtbox.Text)))))
            {
                    DBSQL insert = new DBSQL(_conn);
                if (insert.checkusereExist(usernametxtbox.Text)>0)//בדיקת שהמשתמש לא קיים
                    MessageBox.Show("This Username Is Already Exist");
                else
                {
                    User newUsr = new User();
                    newUsr.Firstname = firstnametxtbox.Text;
                    newUsr.Username = usernametxtbox.Text;
                    newUsr.Pass = passwordtxtbox.Text;
                    newUsr.Role = roletxtbox.Text;
                    
                    try
                    {
                        insert.addUser(newUsr);
                        MessageBox.Show("The new User has been added successfuly");
                        AllUserData frm = new AllUserData();
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
            }
            else
                MessageBox.Show("Please insert the all details");

        }
    }
}
