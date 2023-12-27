
namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    partial class FormFinding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip_PVV = new System.Windows.Forms.ToolTip(this.components);
            this.buttonReadFile_PVV = new System.Windows.Forms.Button();
            this.buttonSortAlph_PVV = new System.Windows.Forms.Button();
            this.buttonFiltrKafedra_PVV = new System.Windows.Forms.Button();
            this.buttonFiltrBySubject_PVV = new System.Windows.Forms.Button();
            this.buttonSaveFile_PVV = new System.Windows.Forms.Button();
            this.buttonSearch_PVV = new System.Windows.Forms.Button();
            this.buttonNewRow_PVV = new System.Windows.Forms.Button();
            this.buttonStatForm_PVV = new System.Windows.Forms.Button();
            this.dataGridView_PVV = new System.Windows.Forms.DataGridView();
            this.openFileDialog_PVV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_PVV = new System.Windows.Forms.SaveFileDialog();
            this.labelFiltrKaf_PVV = new System.Windows.Forms.Label();
            this.labelFiltrRazd_PVV = new System.Windows.Forms.Label();
            this.textBoxFiltr_PVV = new System.Windows.Forms.TextBox();
            this.textBoxFiltrRazd_PVV = new System.Windows.Forms.TextBox();
            this.labelFIO_PVV = new System.Windows.Forms.Label();
            this.textBoxSearch_PVV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip_PVV
            // 
            this.toolTip_PVV.ToolTipTitle = "Подсказка";
            // 
            // buttonReadFile_PVV
            // 
            this.buttonReadFile_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonReadFile_PVV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReadFile_PVV.Location = new System.Drawing.Point(28, 12);
            this.buttonReadFile_PVV.Name = "buttonReadFile_PVV";
            this.buttonReadFile_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonReadFile_PVV.TabIndex = 1;
            this.buttonReadFile_PVV.Text = "Открыть файл";
            this.toolTip_PVV.SetToolTip(this.buttonReadFile_PVV, "Прочитать файл");
            this.buttonReadFile_PVV.UseVisualStyleBackColor = false;
            this.buttonReadFile_PVV.Click += new System.EventHandler(this.buttonReadFile_PVV_Click);
            // 
            // buttonSortAlph_PVV
            // 
            this.buttonSortAlph_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortAlph_PVV.Enabled = false;
            this.buttonSortAlph_PVV.ForeColor = System.Drawing.Color.Black;
            this.buttonSortAlph_PVV.Location = new System.Drawing.Point(28, 231);
            this.buttonSortAlph_PVV.Name = "buttonSortAlph_PVV";
            this.buttonSortAlph_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonSortAlph_PVV.TabIndex = 1;
            this.buttonSortAlph_PVV.Text = "Сортировка по алфовиту";
            this.toolTip_PVV.SetToolTip(this.buttonSortAlph_PVV, "Отсортировать таблицу по алфовиту");
            this.buttonSortAlph_PVV.UseVisualStyleBackColor = false;
            this.buttonSortAlph_PVV.Click += new System.EventHandler(this.buttonSortAlph_PVV_Click);
            // 
            // buttonFiltrKafedra_PVV
            // 
            this.buttonFiltrKafedra_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonFiltrKafedra_PVV.Enabled = false;
            this.buttonFiltrKafedra_PVV.ForeColor = System.Drawing.Color.Black;
            this.buttonFiltrKafedra_PVV.Location = new System.Drawing.Point(27, 384);
            this.buttonFiltrKafedra_PVV.Name = "buttonFiltrKafedra_PVV";
            this.buttonFiltrKafedra_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonFiltrKafedra_PVV.TabIndex = 1;
            this.buttonFiltrKafedra_PVV.Text = "Фильтрация по кафедре";
            this.toolTip_PVV.SetToolTip(this.buttonFiltrKafedra_PVV, "Отфильтровать таблицу по кафедре, \r\nк которой относится преподователь");
            this.buttonFiltrKafedra_PVV.UseVisualStyleBackColor = false;
            this.buttonFiltrKafedra_PVV.Click += new System.EventHandler(this.buttonFiltrKafedra_PVV_Click);
            // 
            // buttonFiltrBySubject_PVV
            // 
            this.buttonFiltrBySubject_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonFiltrBySubject_PVV.Enabled = false;
            this.buttonFiltrBySubject_PVV.ForeColor = System.Drawing.Color.Black;
            this.buttonFiltrBySubject_PVV.Location = new System.Drawing.Point(27, 544);
            this.buttonFiltrBySubject_PVV.Name = "buttonFiltrBySubject_PVV";
            this.buttonFiltrBySubject_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonFiltrBySubject_PVV.TabIndex = 1;
            this.buttonFiltrBySubject_PVV.Text = "Фильтрация по разделу";
            this.toolTip_PVV.SetToolTip(this.buttonFiltrBySubject_PVV, "Отсфильтровать таблицу по разделу предмета, \r\nкоторому учит преподаватель");
            this.buttonFiltrBySubject_PVV.UseVisualStyleBackColor = false;
            this.buttonFiltrBySubject_PVV.Click += new System.EventHandler(this.buttonFiltrBySubject_PVV_Click);
            // 
            // buttonSaveFile_PVV
            // 
            this.buttonSaveFile_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveFile_PVV.Enabled = false;
            this.buttonSaveFile_PVV.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveFile_PVV.Location = new System.Drawing.Point(1050, 12);
            this.buttonSaveFile_PVV.Name = "buttonSaveFile_PVV";
            this.buttonSaveFile_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonSaveFile_PVV.TabIndex = 1;
            this.buttonSaveFile_PVV.Text = "Сохранить файл";
            this.toolTip_PVV.SetToolTip(this.buttonSaveFile_PVV, "Сохранить файл");
            this.buttonSaveFile_PVV.UseVisualStyleBackColor = false;
            this.buttonSaveFile_PVV.Click += new System.EventHandler(this.buttonSaveFile_PVV_Click);
            // 
            // buttonSearch_PVV
            // 
            this.buttonSearch_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch_PVV.Enabled = false;
            this.buttonSearch_PVV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch_PVV.Location = new System.Drawing.Point(441, 11);
            this.buttonSearch_PVV.Name = "buttonSearch_PVV";
            this.buttonSearch_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonSearch_PVV.TabIndex = 5;
            this.buttonSearch_PVV.Text = "Поиск по ФИО";
            this.toolTip_PVV.SetToolTip(this.buttonSearch_PVV, "Введите полное ФИО преподователя,\r\nчтобы его/её найти");
            this.buttonSearch_PVV.UseVisualStyleBackColor = false;
            this.buttonSearch_PVV.Click += new System.EventHandler(this.buttonSearch_PVV_Click);
            // 
            // buttonNewRow_PVV
            // 
            this.buttonNewRow_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewRow_PVV.Enabled = false;
            this.buttonNewRow_PVV.ForeColor = System.Drawing.Color.Black;
            this.buttonNewRow_PVV.Location = new System.Drawing.Point(27, 127);
            this.buttonNewRow_PVV.Name = "buttonNewRow_PVV";
            this.buttonNewRow_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonNewRow_PVV.TabIndex = 7;
            this.buttonNewRow_PVV.Text = "Добавить ряд\r\n";
            this.toolTip_PVV.SetToolTip(this.buttonNewRow_PVV, "Добавляется ряд, в который можно \r\nвнести нового преподователя");
            this.buttonNewRow_PVV.UseVisualStyleBackColor = false;
            this.buttonNewRow_PVV.Click += new System.EventHandler(this.buttonNewRow_PVV_Click);
            // 
            // buttonStatForm_PVV
            // 
            this.buttonStatForm_PVV.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatForm_PVV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStatForm_PVV.Location = new System.Drawing.Point(924, 12);
            this.buttonStatForm_PVV.Name = "buttonStatForm_PVV";
            this.buttonStatForm_PVV.Size = new System.Drawing.Size(120, 60);
            this.buttonStatForm_PVV.TabIndex = 7;
            this.buttonStatForm_PVV.Text = "Статистика";
            this.toolTip_PVV.SetToolTip(this.buttonStatForm_PVV, "Переход на форму с суммой и графиком");
            this.buttonStatForm_PVV.UseVisualStyleBackColor = false;
            this.buttonStatForm_PVV.Click += new System.EventHandler(this.buttonStatForm_PVV_Click);
            // 
            // dataGridView_PVV
            // 
            this.dataGridView_PVV.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_PVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PVV.ColumnHeadersVisible = false;
            this.dataGridView_PVV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.dataGridView_PVV.Location = new System.Drawing.Point(184, 99);
            this.dataGridView_PVV.Name = "dataGridView_PVV";
            this.dataGridView_PVV.RowHeadersVisible = false;
            this.dataGridView_PVV.RowHeadersWidth = 51;
            this.dataGridView_PVV.RowTemplate.Height = 24;
            this.dataGridView_PVV.Size = new System.Drawing.Size(994, 552);
            this.dataGridView_PVV.TabIndex = 0;
            // 
            // openFileDialog_PVV
            // 
            this.openFileDialog_PVV.FileName = "openFileDialog1";
            // 
            // labelFiltrKaf_PVV
            // 
            this.labelFiltrKaf_PVV.AutoSize = true;
            this.labelFiltrKaf_PVV.ForeColor = System.Drawing.Color.Black;
            this.labelFiltrKaf_PVV.Location = new System.Drawing.Point(26, 319);
            this.labelFiltrKaf_PVV.Name = "labelFiltrKaf_PVV";
            this.labelFiltrKaf_PVV.Size = new System.Drawing.Size(133, 34);
            this.labelFiltrKaf_PVV.TabIndex = 2;
            this.labelFiltrKaf_PVV.Text = "Введите название \r\n        кафедры";
            // 
            // labelFiltrRazd_PVV
            // 
            this.labelFiltrRazd_PVV.AutoSize = true;
            this.labelFiltrRazd_PVV.ForeColor = System.Drawing.Color.Black;
            this.labelFiltrRazd_PVV.Location = new System.Drawing.Point(23, 479);
            this.labelFiltrRazd_PVV.Name = "labelFiltrRazd_PVV";
            this.labelFiltrRazd_PVV.Size = new System.Drawing.Size(129, 34);
            this.labelFiltrRazd_PVV.TabIndex = 2;
            this.labelFiltrRazd_PVV.Text = "Введите название\r\n         раздела";
            // 
            // textBoxFiltr_PVV
            // 
            this.textBoxFiltr_PVV.BackColor = System.Drawing.Color.White;
            this.textBoxFiltr_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltr_PVV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxFiltr_PVV.Location = new System.Drawing.Point(27, 356);
            this.textBoxFiltr_PVV.Name = "textBoxFiltr_PVV";
            this.textBoxFiltr_PVV.Size = new System.Drawing.Size(120, 22);
            this.textBoxFiltr_PVV.TabIndex = 3;
            // 
            // textBoxFiltrRazd_PVV
            // 
            this.textBoxFiltrRazd_PVV.BackColor = System.Drawing.Color.White;
            this.textBoxFiltrRazd_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltrRazd_PVV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxFiltrRazd_PVV.Location = new System.Drawing.Point(28, 516);
            this.textBoxFiltrRazd_PVV.Name = "textBoxFiltrRazd_PVV";
            this.textBoxFiltrRazd_PVV.Size = new System.Drawing.Size(120, 22);
            this.textBoxFiltrRazd_PVV.TabIndex = 3;
            // 
            // labelFIO_PVV
            // 
            this.labelFIO_PVV.AutoSize = true;
            this.labelFIO_PVV.ForeColor = System.Drawing.Color.Black;
            this.labelFIO_PVV.Location = new System.Drawing.Point(181, 12);
            this.labelFIO_PVV.Name = "labelFIO_PVV";
            this.labelFIO_PVV.Size = new System.Drawing.Size(215, 34);
            this.labelFIO_PVV.TabIndex = 4;
            this.labelFIO_PVV.Text = "Введите ФИО преподавателя, \r\n            чтобы его найти";
            // 
            // textBoxSearch_PVV
            // 
            this.textBoxSearch_PVV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxSearch_PVV.Location = new System.Drawing.Point(184, 49);
            this.textBoxSearch_PVV.Name = "textBoxSearch_PVV";
            this.textBoxSearch_PVV.Size = new System.Drawing.Size(251, 22);
            this.textBoxSearch_PVV.TabIndex = 6;
            // 
            // FormFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.buttonStatForm_PVV);
            this.Controls.Add(this.buttonNewRow_PVV);
            this.Controls.Add(this.textBoxSearch_PVV);
            this.Controls.Add(this.buttonSearch_PVV);
            this.Controls.Add(this.labelFIO_PVV);
            this.Controls.Add(this.textBoxFiltrRazd_PVV);
            this.Controls.Add(this.textBoxFiltr_PVV);
            this.Controls.Add(this.labelFiltrRazd_PVV);
            this.Controls.Add(this.labelFiltrKaf_PVV);
            this.Controls.Add(this.buttonFiltrBySubject_PVV);
            this.Controls.Add(this.buttonFiltrKafedra_PVV);
            this.Controls.Add(this.buttonSortAlph_PVV);
            this.Controls.Add(this.buttonSaveFile_PVV);
            this.Controls.Add(this.buttonReadFile_PVV);
            this.Controls.Add(this.dataGridView_PVV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormFinding";
            this.Text = "Поиск преподователя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_PVV;
        private System.Windows.Forms.DataGridView dataGridView_PVV;
        private System.Windows.Forms.Button buttonReadFile_PVV;
        private System.Windows.Forms.Button buttonSortAlph_PVV;
        private System.Windows.Forms.Button buttonFiltrKafedra_PVV;
        private System.Windows.Forms.Button buttonFiltrBySubject_PVV;
        private System.Windows.Forms.Button buttonSaveFile_PVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PVV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PVV;
        private System.Windows.Forms.Label labelFiltrKaf_PVV;
        private System.Windows.Forms.Label labelFiltrRazd_PVV;
        private System.Windows.Forms.TextBox textBoxFiltr_PVV;
        private System.Windows.Forms.TextBox textBoxFiltrRazd_PVV;
        private System.Windows.Forms.Label labelFIO_PVV;
        private System.Windows.Forms.Button buttonSearch_PVV;
        private System.Windows.Forms.TextBox textBoxSearch_PVV;
        private System.Windows.Forms.Button buttonNewRow_PVV;
        private System.Windows.Forms.Button buttonStatForm_PVV;
    }
}