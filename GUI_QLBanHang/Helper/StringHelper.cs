﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GUI_QLBanHang.Helper
{
    public static class StringHelper
    {
        public static string MD5Hash (string str)
        {
            MD5 md5 = MD5.Create ();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sb = new StringBuilder ();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString ();
        }
        public static string GetRandomString(int Length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder sb = new StringBuilder ();
            Random r = new Random ();
            while (0 < Length--)
            {
                sb.Append(valid[r.Next(valid.Length)]);
            }
            return sb.ToString ();
        }
    }
}
