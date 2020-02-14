using System;
using System.Text.RegularExpressions;

namespace VIN_LIB.dll
{
    public class VIN_LIB
    {
        public bool CheckVIN(string vin)
        {
            Regex regex = new Regex(@"[0-9|A-H|J-N|P|R-Z]{17}");
            if (!regex.IsMatch(vin))
            {
                return false;
            }
            Regex controlsumm = new Regex(@"[0-9,X]");
            if (!controlsumm.IsMatch(vin[8].ToString()))
            {
                return false;
            }

            return true;
        }
        public string GetVINCountry(string vin)
        {

        }
        public int GetTransportYear (string vin)
        {

        }
    }
}
