using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class DBSQL : DbAccess
    {
         public DBSQL(string connectionString)
            : base(connectionString)
        {

        }
         public DataTable getusersTable() //returns all the product table
         {
             DataSet ds = new DataSet();

             string cmdStr = "SELECT * FROM tbluser";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 ds = GetMultipleQuery(command);
             }

             return ds.Tables[0];
         }
         public Boolean checkLogIn(string username, string password) 
         {
             string cmdStr = "SELECT * FROM tbluser where user='"+username+"' AND pass='"+password+"';";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                base.Connect();
                command.Connection = _conn;
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                    count++;
                base.DisConnect();
                if (count == 1)//אם יש שם משתמש וסיסמה כאלה אז מחזיר אמת
                    return true;
                else
                    return false;
             }
            
                 
         }
         public string getUserRole(string username)//return Username role
         {
             string cmdStr = "SELECT role FROM tbluser WHERE user='" +username+ "'";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 command.Connection = _conn;
                 base.Connect();
                 OleDbDataReader Reader = command.ExecuteReader();
                 Reader.Read();
                 return Reader.GetString(0);
             }
         }
         public void addUser(User newUsr)//adding user to the database
         {
             string cmdStr = "INSERT INTO tbluser ([user],pass,role,firstname) VALUES(@user,@pass,@role,@Firstname)";
             using (OleDbCommand command = new OleDbCommand(cmdStr))//filling the purchase details
             {
                 
                 command.Parameters.AddWithValue("@user", newUsr.Username);
                 command.Parameters.AddWithValue("@pass", newUsr.Pass);
                 command.Parameters.AddWithValue("@role", newUsr.Role);
                 command.Parameters.AddWithValue("@Firstname", newUsr.Firstname);
                 base.ExecuteSimpleQuery(command);
             }
         }
         public int checkusereExist(string username)//checking if username exist
         {
             int result;
             string cmdStr = "SELECT COUNT (*) FROM tbluser WHERE user='" + username + "'";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 result = ExecuteScalarIntQuery(command);
             }
             return result;
         }
         public void UpdateUser(User user)
         { 
             //query to update the user fields by take the name 
             string cmdStr = "UPDATE [tbluser] SET role=@User_role WHERE user=@User_name";

             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 //update user fields to the database 
                 
                 command.Parameters.AddWithValue("@User_role", user.Role);
                 command.Parameters.AddWithValue("@User_name", user.Username);
                
                 base.ExecuteSimpleQuery(command);
             }

         }
         public User getUserDetailsByUsername(string username)//returns user details by username
         {
             string cmdStr = "SELECT user,pass,role,firstname FROM [tbluser] WHERE user='" + username + "'";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 command.Connection = _conn;
                 base.Connect();
                 OleDbDataReader Reader = command.ExecuteReader();
                 User getDetails = new User();
                 if (Reader.HasRows)//filling user class
                 {
                     Reader.Read();
                     getDetails.Username = Reader.GetString(0);
                     getDetails.Pass = Reader.GetString(1);
                     getDetails.Role = Reader.GetString(2);
                     getDetails.Firstname = Reader.GetString(3);
                     return getDetails;
                 }
                 else
                     return null;
             }
         }
         public User[] getAllUsers() //returns all the users in the table
         {
             DataSet ds = new DataSet();
             ArrayList usersarr = new ArrayList();
             string cmdStr = "SELECT * FROM [tbluser]";

             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 ds = GetMultipleQuery(command);
             }

             DataTable dt = new DataTable();

             try
             {
                 dt = ds.Tables[0];
             }
             catch
             {
             }
             foreach (DataRow tType in dt.Rows)
             {
                 User usr = new User();

                 usr.Firstname = tType[0].ToString();
                 usr.Username = tType[1].ToString();
                 usr.Pass = tType[2].ToString();
                 usr.Role = tType[3].ToString();

                 usersarr.Add(usr);
             }
             return (User[])usersarr.ToArray(typeof(User));
         }
         public DataTable fillUserInTable(string username)//returns all users or searched user
         {
             string cmdStr = "SELECT * FROM tbluser WHERE user like '" + username + "'";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 command.Connection = _conn;
                 base.Connect();
                 OleDbDataAdapter da = new OleDbDataAdapter(command);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
         }
         public void deleteUser(User delUsr)//deleting user from database
         {
             string cmdStr = "DELETE FROM tbluser WHERE user ='" + delUsr.Username + "'";
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 base.ExecuteSimpleQuery(command);
             }
         }
         private User[] GetUser(string cmdStr)
         {
             DataSet ds = new DataSet();
             ArrayList User = new ArrayList();
             using (OleDbCommand command = new OleDbCommand(cmdStr))
             {
                 ds = GetMultipleQuery(command);
             }
             DataTable dt = new DataTable();
             try
             {
                 dt = ds.Tables[0];

             }
             catch { }
             foreach (DataRow tType in dt.Rows)
             {
                 User UserName = new User();
                 UserName.Username = tType[0].ToString();
                 User.Add(UserName);
             }
             return (User[])User.ToArray(typeof(User));
         }
         public User[] GetUserName()
         {

             string cmdStr = "SELECT user FROM tbluser";//query retur's all user's name from Users table 
             return GetUser(cmdStr);//using Function to return result 
         }
         public User[] GetUserRole()
         {
             string cmdStr = "SELECT role FROM tbluser";//query retur's all user's name from Users table 
             return GetUser(cmdStr);//using Function to return result 
         }
        // package functions
        public Package[] GetAllPackages()
        {
            DataSet ds = new DataSet();
            ArrayList packagearr = new ArrayList();
            string cmdStr = "SELECT * FROM [Packagetbl]";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();

            try
            {
                dt = ds.Tables[0];
            }
            catch
            {
            }
            foreach (DataRow tType in dt.Rows)
            {
                Package package = new Package();
                //firmware frimware = new firmware();
                package.Id = int.Parse(tType[0].ToString());
                package.FilePath = tType[1].ToString();
                //package.FirmwareList = tType[2].ToString();
                package.Version = tType[3].ToString();

                packagearr.Add(package);
            }
            return (Package[])packagearr.ToArray(typeof(Package));
        }
        public void addPackage(Package package1)
        {
            string cmdStr = "INSERT INTO Packagetbl ([id],FirmwareList,filepath,version) VALUES(@id,@FirmwareList,@filepath,@version)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                command.Parameters.AddWithValue("@id", package1.Id);
                command.Parameters.AddWithValue("@FirmwareList", package1.FirmwareList);
                command.Parameters.AddWithValue("@filepath", package1.FilePath);
                command.Parameters.AddWithValue("@version", package1.Version);
                base.ExecuteSimpleQuery(command);
            }
        }
        public int checkPackageExist(int id)//checking if id exist
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Packagetbl WHERE id='" + id + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        public void UpdatePackage (Package updatapackage)
        {
            //query to update the user fields by take the name 
            string cmdStr = "UPDATE [Packagetbl] SET  filepath=@filepath WHERE id=@id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //update user fields to the database 
                command.Parameters.AddWithValue("@filepath", updatapackage.FilePath);
                command.Parameters.AddWithValue("@id", updatapackage.Id);
                base.ExecuteSimpleQuery(command);
            }
        }
        public void deletePackage(Package delpackage)
        {
            string cmdStr = "DELETE FROM Packagetbl WHERE user ='" + delpackage.Id + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }
        private Package[] GetPackage(string cmdStr)
        {
            DataSet ds = new DataSet();
            ArrayList Package = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];

            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Package UserName = new Package();
                UserName.Id =int.Parse( tType[0].ToString());
                Package.Add(UserName);
            }
            return (Package[])Package.ToArray(typeof(Package));
        }
        public Package GetPackageVersionById(int PackageId)
        {
            string cmdStr = "SELECT version FROM Packagetbl where ID=" + PackageId;
            Package[] arr = GetPackage(cmdStr);
            return arr[0];
        }
        public Package[] GetPackageVersion()
        {   
            DataSet ds = new DataSet();
            ArrayList Package = new ArrayList();
            string cmdStr = "SELECT version FROM [Packagetbl]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];

            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Package pck = new Package();
                pck.Version = tType[0].ToString();
                Package.Add(pck);
            }

            return (Package[])Package.ToArray(typeof(Package));
        }
        public List<string> fillPackageVersion(string cmdStr)
        {
            List<string> list = new List<string>();
            try
            {
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    base.Connect();
                    command.Connection = _conn;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add("" + reader["version"]);
                    }
                    base.DisConnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            return list;
        }
        public DataTable getpackagesTable() //returns all the package table
        {
            DataSet ds = new DataSet();

            string cmdStr = "SELECT * FROM Packagetbl";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            return ds.Tables[0];
        }
        public Package getPackageDetailsByVersion(string version)//returns user details by username
        {
            string cmdStr = "SELECT firmwarelist,filepath,id FROM [tbluser] WHERE version='" + version + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Connection = _conn;
                base.Connect();
                OleDbDataReader Reader = command.ExecuteReader();
                Package getDetails = new Package();
                if (Reader.HasRows)//filling user class
                {
                    Reader.Read();
                    getDetails.FilePath = Reader.GetString(0);
                    //getDetails.FirmwareList = Reader.GetString(1);
                    getDetails.Id = int.Parse(Reader.GetString(2));
                    getDetails.Version = Reader.GetString(3);
                    return getDetails;
                }
                else
                    return null;
            }
        } 
        //firmware functions
        private firmware[] Getfirmware(string cmdStr)
        {
            DataSet ds = new DataSet();
            ArrayList firmware = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];

            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                firmware firm = new firmware();
                firm.Id = int.Parse(tType[0].ToString());

                firmware.Add(firm);
            }
            return (firmware[])firmware.ToArray(typeof(firmware));
        }
        public firmware[] GetFirmwareType()
        {
            string cmdStr = "SELECT FirmwareType FROM [firmwaretbl]";
            return Getfirmware(cmdStr);
        }
        public firmware[] GetBinaryFile()
        {
            string cmdStr = "SELECT binaryFile FROM [firmwaretbl]";
            return Getfirmware(cmdStr);
        }
        public firmware[] GetFrimwareID()
        {
            string cmdStr = "SELECT id FROM [firmwaretbl]";
            return Getfirmware(cmdStr);
        }
        public firmware[] GetAllfirmwares()
        {
            DataSet ds = new DataSet();
            ArrayList firmwarearr = new ArrayList();
            string cmdStr = "SELECT * FROM [firmwaretbl]";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();

            try
            {
                dt = ds.Tables[0];
            }
            catch
            {
            }
            foreach (DataRow tType in dt.Rows)
            {
                firmware firmware = new firmware();
                //firmware frimware = new firmware();
                firmware.Id = int.Parse(tType[0].ToString());
                firmware.BinaryFile = tType[1].ToString();
                //package.FirmwareList = tType[2].ToString();
                firmware.firmwareType = tType[2].ToString();

                firmwarearr.Add(firmware);
            }
            return (firmware[])firmwarearr.ToArray(typeof(firmware));
        }
        public void addfirmware(firmware firm1)
        {
            string cmdStr = "INSERT INTO Firmwaretbl ([id],binaryfile,firmwaretype)VALUES(@id,@binaryfile,@firmwaretype)";
            using (OleDbCommand command =new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", firm1.Id);
                command.Parameters.AddWithValue("@binaryFile", firm1.BinaryFile);
                command.Parameters.AddWithValue("@firmwaretype", firm1.firmwareType);
                base.ExecuteSimpleQuery(command);
            }
        }
        public int checkfirmwareExist(int id)//checking if id exist
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM firmwaretbl WHERE id='" + id + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        public void UpdateFirmware(firmware updateFirmware)
        {
            //query to update the user fields by take the name 
            string cmdStr = "UPDATE [firmwaretbl] SET  BinaryFile=@BinaryFile WHERE id=@id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //update user fields to the database 
                command.Parameters.AddWithValue("@BinaryFile", updateFirmware.BinaryFile);
                command.Parameters.AddWithValue("@id", updateFirmware.Id);
                base.ExecuteSimpleQuery(command);
            }
        }
        public void deleteFirmware(firmware deleteFirmware)
        {
            string cmdStr = "DELETE FROM firmwaretbl WHERE user ='" + deleteFirmware.Id + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }
        public DataTable getfirmwareTable() //returns all the firmware table
        {
            DataSet ds = new DataSet();

            string cmdStr = "SELECT * FROM firmwaretbl";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            return ds.Tables[0];
        }


        //files functions




    }
}
