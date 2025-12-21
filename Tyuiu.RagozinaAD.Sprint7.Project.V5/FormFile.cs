using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib;
namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)| *.csv | Все файлы(*.*) | *.* ";

            dataGridViewTab1.RowCount = 100;
            dataGridViewTab1.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewTab1.Columns[i].Width = 130;
            }
            dataGridViewTab1.Columns[2].Width = 180;
        }
        static int rows;
        static int columns;
        static string openFilePath;

        string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint7.Project.V5\DataSprint7\Товар.csv";

        DataService ds = new DataService();
        private void FormFile_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.ShowDialog();
                openFilePath = openFileDialogTask.FileName;

                string[,] matrix = ds.GetMatrix(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewTab1.RowCount = rows + 1;
                dataGridViewTab1.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewTab1.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewTab1.AutoResizeColumns();
                dataGridViewTab1.ScrollBars = ScrollBars.Both;
                for (int i = 0; i < dataGridViewTab1.RowCount - 1; i++)
                {

                    if (dataGridViewTab1.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridViewTab1.Rows.RemoveAt(i);
                        i--;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {

            saveFileDialogTask.FileName = "Измененные товары.csv";
            saveFileDialogTask.InitialDirectory = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint7.Project.V5\DataSprint7";
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTab1.RowCount;
            int columns = dataGridViewTab1.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTab1.Rows[i].Cells[j].Value + "; ";
                    }
                    else
                    {
                        str = str + dataGridViewTab1.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void buttonMin_Click(object sender, EventArgs e)
        {
            string[,] sort = ds.GetMatrix(path);
            string[,] SortMin = ds.SortMax(sort, 3);

            for (int r = 0; r < SortMin.GetLength(0); r++)
            {
                for (int c = 0; c < SortMin.GetLength(1); c++)
                {
                    dataGridViewTab1.Rows[r].Cells[c].Value = SortMin[r, c];
                }
            }
            buttonOpen.Enabled = true;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            string[,] sort = ds.GetMatrix(path);
            string[,] SortMax = ds.SortMin(sort, 2);

            for (int r = 0; r < SortMax.GetLength(0); r++)
            {
                for (int c = 0; c < SortMax.GetLength(1); c++)
                {
                    dataGridViewTab1.Rows[r].Cells[c].Value = SortMax[r, c];
                }
            }
            buttonOpen.Enabled = true;
        }
        public double[] GetArrayRow(int row)
        {
            double[] array = new double[dataGridViewTab1.Rows.Count];
            for (int i = 0; i < dataGridViewTab1.Rows.Count; i++)
            {
                array[i] = dataGridViewTab1.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewTab1.Rows[i].Cells[row].Value);
            }
            return array;
        }
        private void buttonMinPrice_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonMaxPrice_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindMaxValue(array).ToString();
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTab1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
    }
}

