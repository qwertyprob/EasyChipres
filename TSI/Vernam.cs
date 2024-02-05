using System;
using System.Collections.Generic;



namespace TSI
{
    static class Vernam
    {
        public const string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static int LengthABC
        {
            get
            {
                return ABC.Length;
            }
        }
        public static string RemoveSpaces(string input)
        {
            List<char> result = new List<char>();

            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {

                    result.Add(c);
                }
            }

            return new string(result.ToArray());
        }

        public static string KeyGenerator(int length)
        {
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = ABC[random.Next(ABC.Length)];
            }

            return new String(stringChars);
        }

        public static string Encrypt(string message, string key)
        {

            char[] messageArr = RemoveSpaces(message).ToCharArray();

            char[] keyArr = key.ToCharArray();

            for (int i = 0; i < messageArr.Length; i++)
            {
                if (messageArr[i] != ' ')
                {
                    if (char.IsLetter(messageArr[i]))
                    {
                        int offset = char.IsUpper(messageArr[i]) ? 'A' : 'a';
                        int keyChar = keyArr[i] - offset;
                        messageArr[i] = (char)((messageArr[i] + keyChar - offset) % LengthABC + offset);
                    }

                }
            }
                return new string(messageArr);
        }

            public static string Decrypt(string message, string key)
            {
                char[] messageArr = message.ToCharArray();
                char[] keyArr = key.ToCharArray();

                for (int i = 0; i < messageArr.Length; i++)
                {
                    if (messageArr[i] != ' ')
                    {
                        if (char.IsLetter(messageArr[i]))
                        {
                            int offset = char.IsUpper(messageArr[i]) ? 'A' : 'a';
                            int keyChar = keyArr[i % keyArr.Length] - offset;
                            messageArr[i] = (char)(((messageArr[i] - keyChar - offset + LengthABC) % LengthABC) + offset);
                        }
                    }
                }

                return new string(messageArr);
            } 



        }

    }
