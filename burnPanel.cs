using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;
using System.IO.Compression;
namespace WindowsFormsApplication1
{
    public partial class burnPanel : Form
    {
        private DBSQL dataB;
        Utilities uti = new Utilities();
        private ComboBox CmbNameHelp = new ComboBox();
        private ArrayList panelArray = new ArrayList();
        String _conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb;Persist Security Info=False;";
        public burnPanel()
        {
            InitializeComponent();

        }
        void Fillcombo()
        {
                
        }
        private void bckbtn_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }

        private void burnPanel_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<string> list = new List<String>();
            DBSQL fill = new DBSQL(_conn);
            string cmdStr = "SELECT version FROM [Packagetbl]";
            list = fill.fillPackageVersion(cmdStr);
            foreach (string val in list)
            {
                comboBox1.Items.Add(val);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
