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
    public partial class AllUserData : Form
    {
        String _conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;Persist Security Info=False;";


        public AllUserData()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            adminpanelfrm frm = new adminpanelfrm();
            frm.Show();
            this.Close();

        }

        private void AllUserData_Load(object sender, EventArgs e)
        {
            updateForm();

        }
        public void updateForm()
        {
            try
            {
                DBSQL cnct = new DBSQL(_conn);
                userdatagrid.DataSource = cnct.fillUserInTable("");
                for (int i = 0; i < userdatagrid.Rows.Count; i++)//אם סטטוס לא פעיל אז השם יופיע בוורוד
                {
                    string rd = "" + userdatagrid.Rows[i].Cells[0].Value;
                    if (rd.Equals("0"))
                        userdatagrid.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
                userdatagrid.Columns.Remove("Firstname");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void userdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            DBSQL cnct = new DBSQL(_conn);
            userdatagrid.DataSource = cnct.getAllUsers();
            for (int i = 0; i < userdatagrid.Rows.Count; i++)
            {
                string rd = "" + userdatagrid.Rows[i].Cells[0].Value;
                if (rd.Equals("0"))
                    userdatagrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
            userdatagrid.Columns.Remove("Firstname");
           
        }

        private void addusrbtn_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.Show();
        }

        private void updateuserbtn_Click(object sender, EventArgs e)
        {
            UpdateUser frm = new UpdateUser();
            frm.Show();
        }

        private void delusrbtn_Click(object sender, EventArgs e)
        {
            DeleteUser frm = new DeleteUser();
            frm.Show();
        }


    }
}
