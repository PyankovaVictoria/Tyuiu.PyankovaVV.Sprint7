
namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_PVV = new System.Windows.Forms.Button();
            this.buttonSearch_PVV = new System.Windows.Forms.Button();
            this.pictureBoxImageUniversity_PVV = new System.Windows.Forms.PictureBox();
            this.toolTip_PVV = new System.Windows.Forms.ToolTip(this.components);
            this.labelUnik_PVV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUniversity_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_PVV
            // 
            this.buttonHelp_PVV.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonHelp_PVV.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonHelp_PVV.FlatAppearance.BorderSize = 0;
            this.buttonHelp_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PVV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_PVV.Location = new System.Drawing.Point(12, 419);
            this.buttonHelp_PVV.Name = "buttonHelp_PVV";
            this.buttonHelp_PVV.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp_PVV.TabIndex = 3;
            this.buttonHelp_PVV.Text = "Справка";
            this.toolTip_PVV.SetToolTip(this.buttonHelp_PVV, "О разработчике");
            this.buttonHelp_PVV.UseVisualStyleBackColor = false;
            this.buttonHelp_PVV.Click += new System.EventHandler(this.buttonHelp_PVV_Click);
            // 
            // buttonSearch_PVV
            // 
            this.buttonSearch_PVV.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSearch_PVV.FlatAppearance.BorderSize = 0;
            this.buttonSearch_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_PVV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch_PVV.Location = new System.Drawing.Point(435, 418);
            this.buttonSearch_PVV.Name = "buttonSearch_PVV";
            this.buttonSearch_PVV.Size = new System.Drawing.Size(100, 60);
            this.buttonSearch_PVV.TabIndex = 3;
            this.buttonSearch_PVV.Text = "Поиск";
            this.toolTip_PVV.SetToolTip(this.buttonSearch_PVV, "Поиск преподователя");
            this.buttonSearch_PVV.UseVisualStyleBackColor = false;
            this.buttonSearch_PVV.Click += new System.EventHandler(this.buttonSearch_PVV_Click);
            // 
            // pictureBoxImageUniversity_PVV
            // 
            this.pictureBoxImageUniversity_PVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImageUniversity_PVV.Image")));
            this.pictureBoxImageUniversity_PVV.Location = new System.Drawing.Point(12, 72);
            this.pictureBoxImageUniversity_PVV.Name = "pictureBoxImageUniversity_PVV";
            this.pictureBoxImageUniversity_PVV.Size = new System.Drawing.Size(523, 340);
            this.pictureBoxImageUniversity_PVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageUniversity_PVV.TabIndex = 2;
            this.pictureBoxImageUniversity_PVV.TabStop = false;
            // 
            // toolTip_PVV
            // 
            this.toolTip_PVV.ToolTipTitle = "Подсказка";
            // 
            // labelUnik_PVV
            // 
            this.labelUnik_PVV.AutoSize = true;
            this.labelUnik_PVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnik_PVV.Location = new System.Drawing.Point(197, 13);
            this.labelUnik_PVV.Name = "labelUnik_PVV";
            this.labelUnik_PVV.Size = new System.Drawing.Size(166, 29);
            this.labelUnik_PVV.TabIndex = 4;
            this.labelUnik_PVV.Text = "Университет";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(551, 491);
            this.Controls.Add(this.labelUnik_PVV);
            this.Controls.Add(this.buttonSearch_PVV);
            this.Controls.Add(this.buttonHelp_PVV);
            this.Controls.Add(this.pictureBoxImageUniversity_PVV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 600);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Начальная страница";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageUniversity_PVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxImageUniversity_PVV;
        private System.Windows.Forms.Button buttonHelp_PVV;
        private System.Windows.Forms.Button buttonSearch_PVV;
        private System.Windows.Forms.ToolTip toolTip_PVV;
        private System.Windows.Forms.Label labelUnik_PVV;
    }
}



