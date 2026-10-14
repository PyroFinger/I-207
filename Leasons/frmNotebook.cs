using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leasons
{
    public partial class frmNotebook : Form
    {
        public frmNotebook()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog.FileName).Close();
                MessageBox.Show("Документ создан!");
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmNotebook_Load(object sender, EventArgs e)
        {

        }
    }
}
