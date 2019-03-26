using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class User
    {
        
        
        private string username;
        private string pass;
        private string role;
        private string FirstName;
       public User()
        {

        }
        public User(string Uusername, string Upass, string Urole, string UFirstName)
        {
            username = Uusername;
            pass = Upass;
            role = Urole;
            FirstName = UFirstName;

        }
        public string Username
        {
            set
            {
                this.username = value;
            }
            get
            {
                return this.username;
            }
        }
        public string Pass
        {
            set
            {
                this.pass = value;

            }
            get
            {
                return this.pass;
            }
        }
        public string Role
        {
            set
            {
                this.role = value;

            }
            get
            {
                return this.role;
            }
        }
        public string Firstname
        {
            set
            {
                this.FirstName = value;

            }
            get
            {
                return this.FirstName;
            }
        }

    }
}
