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

namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    public partial class FormFinding : Form
    {
        public FormFinding()
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

        private void buttonReadFile_PVV_Click(object sender, EventArgs e)
        {
            openFileDialog_PVV.ShowDialog();
            path = openFileDialog_PVV.FileName;


            string[,] matrix = Array(path);
            dataGridView_PVV.Columns.Clear();
            dataGridView_PVV.Rows.Clear();

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_PVV.ColumnCount = columns;
            dataGridView_PVV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_PVV.Columns[j].Width = 200;
                    dataGridView_PVV.Rows[i].Height = 20;
                    dataGridView_PVV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonFiltrBySubject_PVV.Enabled = true;
            buttonFiltrKafedra_PVV.Enabled = true;
            buttonSaveFile_PVV.Enabled = true;
            buttonSortAlph_PVV.Enabled = true;
            buttonNewRow_PVV.Enabled = true;
            buttonSearch_PVV.Enabled = true;
        }

        private void buttonSaveFile_PVV_Click(object sender, EventArgs e)
        {

            int rows = dataGridView_PVV.RowCount;
            int columns = dataGridView_PVV.ColumnCount;


            saveFileDialog_PVV.FileName = "Red_University.csv";
            saveFileDialog_PVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_PVV.ShowDialog();

            path = saveFileDialog_PVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_PVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_PVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void buttonSortAlph_PVV_Click(object sender, EventArgs e)
        {
            string[,] matrix = ds.SortAlhp(Array(path));
            dataGridView_PVV.Columns.Clear();
            dataGridView_PVV.Rows.Clear();

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_PVV.ColumnCount = columns;
            dataGridView_PVV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_PVV.Columns[j].Width = 200;
                    dataGridView_PVV.Rows[i].Height = 20;
                    dataGridView_PVV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonFiltrKafedra_PVV_Click(object sender, EventArgs e)
        {
            string text = textBoxFiltr_PVV.Text;
            if (text != null)
            {
                string[,] array = Array(path);
                int rowsArray = array.GetUpperBound(0) + 1;

                bool Flag = false;

                for (int i = 0; i < rowsArray; i++)
                {
                    if (array[i, 10] == text)
                    {
                        Flag = true;
                        break;
                    }

                }

                if (Flag == true && text != "Кафедра")
                {
                    string[,] matrix = ds.FiltrKaf(text, array);
                    dataGridView_PVV.Columns.Clear();
                    dataGridView_PVV.Rows.Clear();

                    int rows = matrix.GetUpperBound(0) + 1;
                    int columns = matrix.Length / rows;

                    dataGridView_PVV.ColumnCount = columns;
                    dataGridView_PVV.RowCount = rows;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridView_PVV.Columns[j].Width = 200;
                            dataGridView_PVV.Rows[i].Height = 20;
                            dataGridView_PVV.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Такой кафедры нет в базе данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonFiltrBySubject_PVV_Click(object sender, EventArgs e)
        {
            string text = textBoxFiltrRazd_PVV.Text;
            if (text != null)
            {
                string[,] array = Array(path);
                int rowsArray = array.GetUpperBound(0) + 1;

                bool flag = false;

                for (int i = 0; i < rowsArray; i++)
                {
                    if (array[i, 5] == text)
                    {
                        flag = true;
                        break;
                    }

                }

                if (flag == true && text != "Раздел")
                {
                    string[,] matrix = ds.FiltrRazd(text, array);
                    dataGridView_PVV.Columns.Clear();
                    dataGridView_PVV.Rows.Clear();

                    int rows = matrix.GetUpperBound(0) + 1;
                    int columns = matrix.Length / rows;

                    dataGridView_PVV.ColumnCount = columns;
                    dataGridView_PVV.RowCount = rows;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridView_PVV.Columns[j].Width = 200;
                            dataGridView_PVV.Rows[i].Height = 20;
                            dataGridView_PVV.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Такого раздела нет в базе данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_PVV_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch_PVV.Text;
            if (text != null)
            {
                string[,] array = Array(path);
                int rowsArray = array.GetUpperBound(0) + 1;

                bool flag = false;

                for (int i = 0; i < rowsArray; i++)
                {
                    if (array[i, 1] == text)
                    {
                        flag = true;
                        break;
                    }

                }

                if (flag == true && text != "ФИО")
                {
                    string[,] matrix = ds.Search(text, array);
                    dataGridView_PVV.Columns.Clear();
                    dataGridView_PVV.Rows.Clear();

                    int rows = matrix.GetUpperBound(0) + 1;
                    int columns = matrix.Length / rows;

                    dataGridView_PVV.ColumnCount = columns;
                    dataGridView_PVV.RowCount = rows;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridView_PVV.Columns[j].Width = 200;
                            dataGridView_PVV.Rows[i].Height = 20;
                            dataGridView_PVV.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Такого ФИО нет в базе данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatForm_PVV_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            formStatistic.ShowDialog();
        }

        private void buttonNewRow_PVV_Click(object sender, EventArgs e)
        {
            dataGridView_PVV.Rows.Add();

            int columns = dataGridView_PVV.ColumnCount;
            int rows = dataGridView_PVV.RowCount;

            for (int j = 0; j < columns; j++)
            {
                dataGridView_PVV.Rows[rows - 2].Cells[j].Value = dataGridView_PVV.Rows[rows - 1].Cells[j].Value;
            }

            for (int j = 0; j < columns; j++)
            {
                dataGridView_PVV.Rows[rows - 1].Cells[j].Value = "";
            }
        }
    }
}
