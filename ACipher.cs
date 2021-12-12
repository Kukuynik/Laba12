using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    class ACipher:ICipher
    {
        public string Encode(string str)
        {
            string cipherText = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] =='z')
                {
                    cipherText += 'a';
                }else if (str[i] == 'Z')
                {
                    cipherText += 'A';
                }else if (str[i] == 'я')
                {
                    cipherText += 'а';
                }
                else if (str[i] == 'Я')
                {
                    cipherText += 'А';
                }
                else
                {
                    cipherText += (char)(str[i] + 1);
                }
            }
            return cipherText;
        }
        public string Decode(string str)
        {
            string plainText="";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    plainText += 'z';
                } else if (str[i] == 'A')
                {
                    plainText += 'Z';
                } else if (str[i] == 'а')
                {
                    plainText +='я';
                }else if (str[i] == 'А')
                {
                    plainText += 'Я';
                }else plainText += (char)(str[i] - 1);
            }
            return plainText;
        }
    }
}
