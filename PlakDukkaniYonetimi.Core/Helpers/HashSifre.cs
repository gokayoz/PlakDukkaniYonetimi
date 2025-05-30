using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYonetimi.Core.Helpers
{
    public static class HashSifre
    {
        public static string SifreHashle(string sifre)
        {
            using (SHA256 hashSifre = SHA256.Create())
            {
                return string.Concat(
                    hashSifre
                    .ComputeHash(Encoding.UTF8.GetBytes(sifre))
                    .Select(s => s.ToString("X2"))
                    );
            }
        }
    }
}