using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_generator
{
    //рандомно генерирует символы из списка
    class Randgen
    {
        string password;
        List<char> cList = new List<char>();
        Random rnd = new Random();

        public string Rand_gen(int count)
        {
            //список подходящих символов
            cList.Add((char)33);
            for (int i = 35; i <= 38; i++) { cList.Add((char)i); }
            for (int i = 48; i <= 57; i++) { cList.Add((char)i); }
            for (int i = 63; i <= 90; i++) { cList.Add((char)i); }
            for (int i = 97; i <= 122; i++) { cList.Add((char)i);}

            for (int i = 0; i < count; i++)
            {
                password += cList[rnd.Next(0, cList.Count)];
            }
            return password;
        }
    }
}
