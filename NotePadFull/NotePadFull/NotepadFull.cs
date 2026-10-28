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
using System.Drawing.Printing;

namespace NotePadFull
{
    public partial class NotepadFull : Form
    {
        string fileName = "";
        public NotepadFull()
        {
            InitializeComponent();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            fileName = "";
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Âñå ôàéëû (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                fileName = openFileDialog.FileName;
            }
        }
        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                ñîõğàíèòüêàêToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(fileName, richTextBox1.Text);
                MessageBox.Show("Äîêóìåíò ñîõğàí¸í!");
            }
        }
        private void ñîõğàíèòüêàêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ïàğàìåòğûToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ïå÷àòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void øğèôòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = richTextBox1.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
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

        private void NotepadFull_Load(object sender, EventArgs e)
        {

        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ñîõğàíèòüÊàêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ïàğàìåòğûÑòğàíèöûToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïå÷àòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void âûõîäToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ïğàâêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void îòìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âûğåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void êîïèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void íàéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void íàéòèÄàëååToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïåğåéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âûäåëèòüÂñåToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ôîğìàòToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïåğåíîñÏîÑëîâàìToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âèäToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ìàñøòàáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void óâåëè÷èòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void óìåíüøèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void èçìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ñòğîêàÑîñòîÿíèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
