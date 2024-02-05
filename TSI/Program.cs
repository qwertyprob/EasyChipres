using System;



namespace TSI
{
    internal class Prog
    {
        static void Main(string[] args)
        {   
            //Инициализация данных для Цезаря
            int CezarKey = 3;
            string CezarMessage = "Parola mea";
            string CezarDecrypt = "Sdurod phd";
            //Инициализация данных для Вижена

            string VigenereMessage = "Parola mea";
            string VigenereKey = "Bec";

            //Инициализация данных для Вернама
            string VernamMessage = "LA MULTI ANI";
            string VernamRandomKey = Vernam.KeyGenerator(Vernam.RemoveSpaces(VernamMessage).Length);
            string VernamStandartKey = "VIDAGTSROL";

            //Шифр Цезаря Encryption
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("\t1.Шифр Цезаря:");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("\tДанные:||Текст:{0}|| Ключ:{1} ||", CezarMessage,CezarKey);
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"\tEncryption: {Cezar.Encrypt(CezarMessage,CezarKey)}");
            Console.WriteLine($"\tDecryption: {Cezar.Decrypt(CezarDecrypt,CezarKey)}");
            Console.WriteLine(new string('-', 100));

            //Шифр Виженера Encryption
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("\t2.Шифр  Виженера:");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("\tДанные:||Текст:{0}|| Ключ:{1} ||", VigenereMessage, VigenereKey);
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"\tEncryption: {Vigenere.Encrypt(VigenereMessage, VigenereKey)}");
            Console.WriteLine($"\tDecryption: {Vigenere.Decrypt("QetPpc Nic", VigenereKey)}");
            Console.WriteLine(new string('-', 100));

            //Шифр Вернама Encryption
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("\t3.Шифр Вернама:");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("\tДанные:||Текст:{0}|| Ключ:{1} ||", VernamMessage, VernamStandartKey);
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"\tEncryption: {Vernam.Encrypt(VernamMessage, VernamRandomKey)}"); //Здесь можно вписать как и ключ с примера так и свой(Рандомный)
            Console.WriteLine($"\tDecryption: {Vernam.Decrypt("GIPURMARBT", "VIDAGTSROL")}");
            Console.WriteLine(new string('=', 100));

        }
    }
}
