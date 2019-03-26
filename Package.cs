using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Package
    {
        private int id;
        private List<firmware> firmwareList;
        private string version;
        private string filePath;
        public Package()
        {

        }
        public Package(int pid, string Vversion,List<firmware> ffrimwareList,string FfilePath)
        {
            id = pid; 
            firmwareList = ffrimwareList;
            version = Vversion;
            filePath = FfilePath;
        }
        public List<firmware> FirmwareList
        {
            set
            {
                this.firmwareList = value;
            }
            get
            {
                return this.firmwareList;
            }
        }
        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string FilePath
        {
            set
            {
                this.filePath = value;
            }
            get
            {
                return this.filePath;
            }
        }      
        public string Version
        {
            set
            {
                this.version = value;
            }
            get
            {
                return this.version;
            }
        }

    }
}
