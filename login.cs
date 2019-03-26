using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public static string username;
        String conn_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sameer Zaher\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Database11.accdb;
Persist Security Info=False;";

        public login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void goToForm(string role)//בדיקת תפקיד ולפי זה יודעים לאן לעבור
        {
            if (role.Equals("admin"))
            {
                adminpanelfrm newForm = new adminpanelfrm();
                newForm.Show();
                this.Hide();
            }
            else
                if (role.Equals("qa"))
                {
                    qapanel newForm = new qapanel();
                    newForm.Show();
                    this.Hide();
                }
              else
                   if(role.Equals("burner"))
                    {
                        burnPanel newForm = new burnPanel();
                        newForm.Show();
                        this.Hide();
                    }
                
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            username = usernametxtbox.Text;//ישומש בעתיד בפורמים אחרים
            DBSQL logIn = new DBSQL(conn_string);
            if (logIn.checkLogIn(usernametxtbox.Text, passwordtxtbox.Text))//בדיקת שם משתמש וסיסמה
            {
                goToForm(logIn.getUserRole(username));//בדיקת תפקיד והעברה לפורם אחר
            }
            else
                MessageBox.Show("User Name And Password Is Not Correct");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                passwordtxtbox.Focus();
            }
        }

        private void passwordtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                loginbtn.PerformClick();
        }
    }
}
