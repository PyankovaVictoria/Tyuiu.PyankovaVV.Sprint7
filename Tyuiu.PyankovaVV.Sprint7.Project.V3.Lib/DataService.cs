using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Tyuiu.PyankovaVV.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public string[,] SortAlhp(string[,] array)  
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            string[] mas2 = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                mas2[i] = array[i, 1];
            }

            IEnumerable<string> sortAscendingQuery =
            from mas in mas2
            orderby mas
            select mas;

            int c = 0;
            foreach (string s in sortAscendingQuery)
            {
                mas2[c] = s;
                c++;
            }

            int count = 0;
            while (count != rows - 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (mas2[count] == "ФИО")
                    {
                        count++;
                        break;
                    }
                    if (mas2[count] == array[i, 1])
                    {
                        count++;
                        for (int j = 0; j < columns; j++)
                        {
                            matrix[count, j] = array[i, j];
                        }
                        break;
                    }
                }
            }

            for (int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            return matrix;
        }

        public string[,] FiltrKaf(string num, string[,] array) 
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            for (int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            int count = 1;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 10] == num)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[count, j] = array[i, j];
                    }
                    count++;
                }
            }
            return matrix;
        }

        public string[,] FiltrRazd(string num, string[,] array) 
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            for (int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            int count = 1;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 5] == num)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[count, j] = array[i, j];
                    }
                    count++;
                }
            }
            return matrix;
        }

        public string[,] Search(string num, string[,] array) 
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            string[,] matrix = new string[rows, columns];

            for (int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            int count = 1;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 1] == num)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[count, j] = array[i, j];
                    }
                }
            }
            return matrix;
        }

        public int[] Count(string[,] array) 
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            int[] matrix = new int[3];
            string[] matNames = { "", "", "" };

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 10] != matNames[0] && matNames[0] == "")
                {
                    matNames[0] = array[i, 10];
                    count1++;
                }
                else
                {
                    if (array[i, 10] == matNames[0])
                    {
                        count1++;
                    }
                }

                if (array[i, 10] != matNames[1] && matNames[1] == "")
                {
                    matNames[1] = array[i, 10];
                    count2++;
                }
                else
                {
                    if (array[i, 10] == matNames[1])
                    {
                        count2++;
                    }
                }

                if (array[i, 10] != matNames[2] && matNames[2] == "")
                {
                    matNames[2] = array[i, 10];
                    count3++;
                }
                else
                {
                    if (array[i, 10] == matNames[2])
                    {
                        count3++;
                    }
                }
            }

            matrix[0] = count1;
            matrix[1] = count2;
            matrix[2] = count3;

            return matrix;
        }
    }    
}
