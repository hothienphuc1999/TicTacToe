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
        
    }
}
