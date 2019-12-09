using System;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace Laundry
{
   public class IDGenerator
    {
        public static string GetCPUId()
        {
            string cpuInfo = String.Empty;
            string temp = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == String.Empty)
                {// only return cpuInfo from first CPU
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }
            }
            return cpuInfo;
        }

        public static string GetHard() // gereftan serial hard
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string hard = "1";
            foreach (ManagementObject info in searcher.Get())
            {

                hard = (info["SerialNumber"].ToString()).Trim();
            }
            return hard;
        }
        public static string GetMotherBoardID()
        {
            ManagementObjectCollection mbCol = new ManagementClass("Win32_BaseBoard").GetInstances();
            //Enumerating the list
            ManagementObjectCollection.ManagementObjectEnumerator mbEnum = mbCol.GetEnumerator();
            //Move the cursor to the first element of the list (and most probably the only one)
            mbEnum.MoveNext();
            //Getting the serial number of that specific motherboard
            return ((ManagementObject)(mbEnum.Current)).Properties["SerialNumber"].Value.ToString();
        }

        public static string GetMacAddress()
        {
            string macs = "";
            // get network interfaces physical addresses
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                PhysicalAddress pa = ni.GetPhysicalAddress();
                macs += pa.ToString();
            }
            return macs;
        }

        /// <summary>
        /// return Volume Serial Number from hard drive
        /// </summary>
        /// <param name="strDriveLetter">[optional] Drive letter</param>
        /// <returns>[string] VolumeSerialNumber</returns>
        public static string GetVolumeSerial()
        {
            string strDriveLetter = "";
            ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                try
                {
                    if ((UInt16)mo["MediaType"] == 29)
                    {
                        String serial = mo["SerialNumber"].ToString().Trim();
                        if (!String.IsNullOrEmpty(serial))
                        {
                            Console.WriteLine("Harddrive serial: " + (string)mo["SerialNumber"]);
                            strDriveLetter = (string)mo["SerialNumber"];
                            return strDriveLetter;
                        }
                    }
                }
                catch { }
            }
            return strDriveLetter;
        }
        
        public static string GetOpenLock(string serial)
        {
            StringBuilder alph = new StringBuilder();
            StringBuilder num = new StringBuilder();
            

            if (serial.Length > 14)
                serial = serial.Substring(0, 15);
            foreach (char c in serial)

                if (char.IsDigit(c))
                    num.Append(c);
                else
                    alph.Append(c);
            string alph1 = alph.ToString();
            string num1 = num.ToString();

            int[] reg = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                reg[i] = Int16.Parse(num1.Substring(i, 1));
            }

            for (int i = 0; i < num1.Length; i++)
            {
                reg[i] = reg[i] + 7;

            }
            Array.Reverse(reg);

            string show, compelet = "";
            for (int i = 0; i < num1.Length; i++)
            {
                show = "";
                show = reg[i].ToString();
                compelet = compelet + show;

            }
            return compelet;

        }
        public static string GetUniqueID()
        {
            string ID = GetCPUId() + GetMotherBoardID() + GetMacAddress() + GetVolumeSerial();
            // generate hash
            HMACSHA1 hmac = new HMACSHA1();
            hmac.Key = Encoding.ASCII.GetBytes(GetMotherBoardID());
            hmac.ComputeHash(Encoding.ASCII.GetBytes(ID));
            // convert hash to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hmac.Hash.Length; i++)
            {
                sb.Append(hmac.Hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
