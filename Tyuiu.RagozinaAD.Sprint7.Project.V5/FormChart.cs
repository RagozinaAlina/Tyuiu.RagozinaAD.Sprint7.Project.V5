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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint7.Project.V5\DataSprint7\Товар.csv";
        private void buttonChart_Click(object sender, EventArgs e)
        {
            chartInfo.Series[0].Points.Clear();

            this.chartInfo.ChartAreas[0].AxisX.Title = "";
            this.chartInfo.ChartAreas[0].AxisY.Title = "";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrElements(DataTable, 3);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartInfo.Series[0].Points.AddXY(ArrayWords[i], [i]);
            }


        }
    }
}
