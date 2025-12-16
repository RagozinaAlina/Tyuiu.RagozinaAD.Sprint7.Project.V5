namespace Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib
{
    public class DataService
    {
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
                for (int j = 0; j < strArr.Length; j++)
                {
                    matrix[i, j] = strArr[j];
                }
            }
            return matrix;
        }

        public string[,] SortMax(string[,] matrix, int NumberColumn)
        {
            int[] col = new int[matrix.GetLength(0) - 1];
            col[col.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < col.Length - 1; i++)
            {
                col[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(col, (x, y) => y.CompareTo(x));

            string[,] Sort = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < Sort.GetLength(1); i++)
            {
                Sort[0, i] = matrix[0, i];
            }

            for (int i = 0; i < Sort.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (col[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < Sort.GetLength(1); c++)
                        {
                            Sort[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return Sort;
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

