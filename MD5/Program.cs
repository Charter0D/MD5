using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MD5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] mydata = File.ReadAllBytes(Console.ReadLine());
                Console.WriteLine(GetMd5Hash(md5, frombytes(mydata)));
                Console.ReadKey();
            }
        }

        public static string frombytes(byte[] ar)
        {
            string nqwe = string.Empty;
            for (int i = 0; i < ar.Length; i++)
            {
                if (i == ar.Length - 1)
                {
                    nqwe += ar[i].ToString();
                }
                else
                {
                    nqwe += ar[i].ToString();
                    nqwe += ":";
                }
            }
            return nqwe;
        }

        static string GetMd5Hash(System.Security.Cryptography.MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
