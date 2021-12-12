using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    class BCipher:ICipher
    {
        char[] enLowAlf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
        char[] ruLowAlf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToLower().ToCharArray();
        char[] enUpAlf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] ruUpAlf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        public string Encode(string str)
        {
            string cipherText = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (enLowAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (enLowAlf[j] != str[i])
                        j++;
                    cipherText += enLowAlf[enLowAlf.Length - (j + 1)];
                }
                else if (enUpAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (enUpAlf[j] != str[i])
                        j++;
                    cipherText += enUpAlf[enUpAlf.Length - (j + 1)];
                }
                else
               if (ruLowAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (ruLowAlf[j] != str[i])
                        j++;
                    cipherText += ruLowAlf[ruLowAlf.Length - (j + 1)];
                }
                else
               if (ruUpAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (ruUpAlf[j] != str[i])
                        j++;
                    cipherText += ruUpAlf[ruUpAlf.Length - (j + 1)];
                }
                else cipherText += str[i];
            }
            return cipherText;
        }
        public string Decode(string str)
        {
            string plainCipher = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (enLowAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (enLowAlf[j] != str[i])
                        j++;
                    plainCipher += enLowAlf[enLowAlf.Length - (j + 1)];
                }
                else if (enUpAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (enUpAlf[j] != str[i])
                        j++;
                    plainCipher += enUpAlf[enUpAlf.Length - (j + 1)];
                }
                else
               if (ruLowAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (ruLowAlf[j] != str[i])
                        j++;
                    plainCipher += ruLowAlf[ruLowAlf.Length - (j + 1)];
                }
                else
               if (ruUpAlf.Contains(str[i]))
                {
                    int j = 0;
                    while (ruUpAlf[j] != str[i])
                        j++;
                    plainCipher += ruUpAlf[ruUpAlf.Length - (j + 1)];
                }
                else plainCipher += str[i];
            }
            return plainCipher;
        }
    }
}
