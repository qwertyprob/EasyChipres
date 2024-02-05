using System;


namespace TSI
{
    static public class Vigenere
    {
        public const string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static int LengthABC
        {
            get
            {
                return ABC.Length;
            }
        }
        public static string Encrypt(string message, string key)
        {
            char[] keyArr = key.ToCharArray();
            char[] messageArr = message.ToCharArray();
            int keyIndex = 0; // Initialize key index outside the loop

            for (int i = 0; i < messageArr.Length; i++)
            {
                if (messageArr[i] != ' ')
                {
                    if (char.IsLetter(messageArr[i]))
                    {
                        int offset = char.IsUpper(messageArr[i]) ? 'A' : 'a';
                        int keyChar = keyArr[keyIndex % keyArr.Length] - offset;
                        messageArr[i] = (char)((messageArr[i] + keyChar - offset) % LengthABC + offset);
                    }
                    else
                    {
                        throw new Exception("Give me a letter!");
                    }

                    keyIndex++;
                }
            }

            return new string(messageArr);
        }
        public static string Decrypt(string message, string key)
        {
            char[] keyArr = key.ToCharArray();
            char[] messageArr = message.ToCharArray();
            int keyIndex = 0;

            for (int i = 0; i < messageArr.Length; i++)
            {
                if (messageArr[i] != ' ')
                {
                    if (char.IsLetter(messageArr[i]))
                    {
                        int offset = char.IsUpper(messageArr[i]) ? 'A' : 'a';
                        int keyChar = keyArr[keyIndex % keyArr.Length] - offset;
                        int decryptedChar = (messageArr[i] - keyChar - offset + LengthABC) % LengthABC + offset;
                        messageArr[i] = (char)decryptedChar;
                    }
                    else
                    {
                        throw new Exception("Not a letter!");
                    }

                    keyIndex++;
                }
            }

            return new string(messageArr);
        }





    }
}  


