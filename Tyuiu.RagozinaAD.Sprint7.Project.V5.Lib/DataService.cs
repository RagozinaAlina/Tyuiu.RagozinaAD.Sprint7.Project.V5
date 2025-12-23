using System.IO;
using System.Text;

namespace Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public int len = 0;
        public string[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);

            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }
        public double FindTotalValue(double[] array)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return Math.Round(result, 3);
        }
        public double FindMinValue(double[] array)
        {
            return array.Min();
        }

        public double FindMaxValue(double[] array)
        {
            return array.Max();
        }
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            return numsArray;
        }

        public string[,] SortMax(string[,] matrix, int NumberColumn)
        {
            int rowCount = matrix.GetLength(0);
            int[] values = new int[rowCount-1]; 
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }
            for (int i = 0; i < values.Length - 1; i++)
            {
                values[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(values, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) -1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (values[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }
        public string[,] SortMin(string[,] matrix, int NumberColumn)
        {
            int rowCount = matrix.GetLength(0);
            int[] values = new int[rowCount -1]; 
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }
            for (int i = 0; i < values.Length - 1; i++)
            {
                values[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(values, (x, y) => x.CompareTo(y));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) -1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (values[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }
        public string[,] Search(string[,] table, string n)
        {
            int s = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (table[i, 1] == n)
                {
                    s++;
                }
            }

            string[,] res = new string[s, 4];
            int c = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (table[i, 1] == n)
                {
                    for (int r = 0; r < res.GetLength(1); r++)
                    {
                        res[c, r] = table[i, r];
                    }
                    table[i, 1] = "";
                    c++;
                }
            }
            return res;
        }
    }
}

