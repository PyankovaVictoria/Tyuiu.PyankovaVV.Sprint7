using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PyankovaVV.Sprint7.Project.V3.Lib;
using System.Windows.Forms.DataVisualization;

namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            openFileDialog_PVV.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }

        public static string path;

        DataService ds = new DataService();

        public static string[,] Array(string path)
        {

            string data = File.ReadAllText(path);
            string[] stroki = data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = stroki.Length;
            int columns = stroki[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = stroki[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = strok[j];
                }
            }
            return matrix;
        }

        private void buttonOen_PVV_Click(object sender, EventArgs e)
        {
            openFileDialog_PVV.ShowDialog();
            path = openFileDialog_PVV.FileName;

            int[] matrix = ds.Count(Array(path));

            textBoxFirst_PVV.Text = Convert.ToString(matrix[0]);
            textBoxSecond_PVV.Text = Convert.ToString(matrix[1]);
            textBoxThird_PVV.Text = Convert.ToString(matrix[2]);

            chartFunction_PVV.Series[0].Points.Clear();

            for (int i = 0; i < matrix.Length; i++)
            {
                chartFunction_PVV.Series[0].Points.AddXY(i, matrix[i]);
            }
        }
    }
}
