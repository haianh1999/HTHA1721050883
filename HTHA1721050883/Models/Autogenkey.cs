﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTHA1721050883.Models
{
    public class Autogenkey
    {
        public string GenKey(string text, string id)
        {
            string strPhanso = "";
            strPhanso = id.Substring(3);
            int AutoKey = Convert.ToInt32(id.Substring(3)) + 1;
            string strkey = "";
            string strName = "";

            for (int i = 0; i < (strPhanso.Length - AutoKey.ToString().Length); i++)
            {
                strName += "0";
            }
            strkey = text + strName + AutoKey.ToString();

            return strkey;
        }

        internal object GenKey(string v, object personID)
        {
            throw new NotImplementedException();
        }
    }
}