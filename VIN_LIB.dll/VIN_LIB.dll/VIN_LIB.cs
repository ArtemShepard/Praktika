using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VIN_LIB.dll
{
    public class VIN_LIB
    {
        public int[] Weight = { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };
        public List<int> Q = new List<int>();
        int W = 0;
        Ecv ecv = new Ecv();
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
            foreach (char i in vin)
            {
                Q.Add(ecv.Vinecv[i]);
            }
            foreach (int i in Weight)
            {
                W = (Weight[i] * Q[i]) + W;
            }
            float X = W/11;
            if(W - (X * 11)!= vin[8])
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
