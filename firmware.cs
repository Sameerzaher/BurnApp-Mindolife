using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class firmware
    {
        private int id;
        private string binaryFile;//path
        private string FirmwareType;
        public firmware()
        {

        }
        public firmware(int fid,string bbinaryFile,string FfirmwareType)
        {
            id = fid;
            binaryFile = bbinaryFile;
            FirmwareType = FfirmwareType;
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
        public string BinaryFile
        {
            set
            {
                this.binaryFile = value;
            }
            get
            {
                return this.binaryFile;
            }
        }
        public string firmwareType
        {
            set
            {
                this.FirmwareType = value;
            }
            get
            {
                return this.FirmwareType;
            }
        }

    }
}
