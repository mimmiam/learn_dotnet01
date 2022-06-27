using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace workshop01.Helper
{
    public class ConvertApp
    {
        public static string ToString(bool? val)
        {
            return val == true ? "ใช่" : val == false ? "ไม่ใช่" : "";
        }

        public static string ToString(DateTime? val)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            if (val == null) return "";
            else return val.Value.ToString("dd/MM/yyyy HH:mm:ss", culture);
        }


        public static string ToString(decimal? val)
        {
            if (val == null) return "0";
            else return val.Value.ToString("N0");
        }
        public static string ToString(int? val)
        {
            if (val == null) return "0";
            else return val.Value.ToString();
        }
        public static string ToString(long? val)
        {
            if (val == null) return "0";
            else return val.Value.ToString();
        }
        public static string ToString(string val)
        {
            return val;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        //Decode
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        public static string DateToString(DateTime? val)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            if (val == null) return "";
            else return val.Value.ToString("dd/MM/yyyy", culture);
        }

        public static string DateToStringSQL(DateTime? val)
        {
            CultureInfo myCIintlEn = new CultureInfo("en-US");
            if (val == null) return "";
            else return val.Value.ToString("yyyy-MM-dd", myCIintlEn);
        }

        public static DateTime StringToDateSQL(string val)
        {
            CultureInfo myCIintlEn = new CultureInfo("en-US");
            if (val.Length < 8)
                return DateTime.ParseExact(val, "yyyyMMdd", myCIintlEn).ToLocalTime();
            else
                return DateTime.ParseExact(val, "yyyy-MM-dd", myCIintlEn).ToLocalTime();
        }

        public static DateTime StringToDate(string val)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            return DateTime.ParseExact(val, "dd/MM/yyyy", culture).ToLocalTime();
        }

        public static string TimeToString(DateTime? val)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            if (val == null) return "";
            else return val.Value.ToString("HH:mm:ss", culture);
        }

        public static decimal StringToDecimal(string val)
        {
            decimal.TryParse(val?.Replace(",", ""), out decimal temp);
            return temp;
        }


        public static long StringToInt64(string val)
        {
            long.TryParse(val?.Replace(",", ""), out long temp);
            return temp;
        }

    }
}