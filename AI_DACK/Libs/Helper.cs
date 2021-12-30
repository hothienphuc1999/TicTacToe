using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_DACK.libs
{
    static public class Helper
    {
        static public char[,] DeepCopyChar(char[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            char[,] result = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = input[i, j];
                }
            }
            return result;
        }
        static public void PrintCharMatrix(char[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Helper.PrintToFile(input[i, j].ToString());
                }
                Helper.PrintToFile("\n");
            }
        }
        static public void PrintToFile(string data)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\THIENPHUC\\source\\repos\\AI_DACK\\AI_DACK\\case.txt",true))
            {
                writer.Write(data);
            }
        }
    }
}
