
namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_PVV = new System.Windows.Forms.PictureBox();
            this.labelAbout_PVV = new System.Windows.Forms.Label();
            this.labelAbout_PVV = new System.Windows.Forms.Label();
            this.buttonOK_PVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PVV
            // 
            this.pictureBoxAvatar_PVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PVV.Image")));
            this.pictureBoxAvatar_PVV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_PVV.Name = "pictureBoxAvatar_PVV";
            this.pictureBoxAvatar_PVV.Size = new System.Drawing.Size(150, 200);
            this.pictureBoxAvatar_PVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PVV.TabIndex = 0;
            this.pictureBoxAvatar_PVV.TabStop = false;
            // 
            // labelAbout_PVV
            // 
            this.labelAbout_PVV.Location = new System.Drawing.Point(0, 0);
            this.labelAbout_PVV.Name = "labelAbout_PVV";
            this.labelAbout_PVV.Size = new System.Drawing.Size(100, 23);
            this.labelAbout_PVV.TabIndex = 3;
            // 
            // labelAbout_PVV
            // 
            this.labelAbout_PVV.AutoSize = true;
            this.labelAbout_PVV.Location = new System.Drawing.Point(169, 13);
            this.labelAbout_PVV.Name = "labelAbout_PVV";
            this.labelAbout_PVV.Size = new System.Drawing.Size(363, 170);
            this.labelAbout_PVV.TabIndex = 4;
            this.labelAbout_PVV.Text = resources.GetString("labelAbout_PVV.Text");
            // 
            // buttonOK_PVV
            // 
            this.buttonOK_PVV.Location = new System.Drawing.Point(456, 187);
            this.buttonOK_PVV.Name = "buttonOK_PVV";
            this.buttonOK_PVV.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_PVV.TabIndex = 5;
            this.buttonOK_PVV.Text = "Ok";
            this.buttonOK_PVV.UseVisualStyleBackColor = true;
            this.buttonOK_PVV.Click += new System.EventHandler(this.buttonOK_PVV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 222);
            this.Controls.Add(this.buttonOK_PVV);
            this.Controls.Add(this.labelAbout_PVV);
            this.Controls.Add(this.labelAbout_PVV);
            this.Controls.Add(this.pictureBoxAvatar_PVV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 269);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PVV;
        private System.Windows.Forms.Label labelAbout_PVV;
       
        private System.Windows.Forms.Button buttonOK_PVV;
    }
}