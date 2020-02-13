using System;
using System.Text.RegularExpressions;

namespace VIN_LIB.dll
{
    public class VIN_LIB
    {
        public bool CheckVIN(string vin)
        {
            string Vinstring;
            string G;
            Regex regex = new Regex(@"[0-9|A-H|J-N|P|R-Z]{17}");
        }
        public string GetVINCountry(string vin)
        {

        }
        public int GetTransportYear (string vin)
        {

        }
    }
}
