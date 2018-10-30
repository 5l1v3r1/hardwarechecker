using System.Management;

namespace hardwarechecker.Core
{
    public static class HardwareId
    {
        public static string GetHardwareId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection result = searcher.Get();
            string id = "";
            foreach (ManagementObject mo in result)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            return id;
        }
    }
}
