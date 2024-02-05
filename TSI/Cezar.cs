using System;


namespace TSI
{
    static class Cezar
    {
        public const string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static int LengthABC 
        {
            get
            {
                return ABC.Length; 
            } 
        }

        public static string Encrypt(string message, int key)
        {

            
            
            char[] messageArr = message.ToCharArray();

            for (int i = 0; i < messageArr.Length; i++)
            {
                if (messageArr[i] != ' ') // Проверка, что символ не является пробелом
                {
                    if ((char.IsLetter(messageArr[i])))
                    {   int offset = char.IsUpper(messageArr[i])?'A':'a';
                        messageArr[i] = (char)(((messageArr[i] + key - offset )) % LengthABC + offset);
                    }
                    else
                    {
                        throw new Exception("Give me a letter!");
                    }
                }
               
                
            }

            return new string(messageArr);
        }
        public static string Decrypt(string message, int key)
        {
            
            char[] arr = message.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ') 
                {
                    int offset = char.IsUpper(arr[i]) ? 'A' : 'a';
                    arr[i] = (char)(((arr[i] - key - offset)) % LengthABC + offset); ;
                }


            }

            return new string(arr);
        }
    }

}

    

