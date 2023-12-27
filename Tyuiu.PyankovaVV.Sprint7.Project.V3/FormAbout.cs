using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }


        private void buttonOK_PVV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
