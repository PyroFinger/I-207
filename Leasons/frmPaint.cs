using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO; 
using System.Windows.Forms;

namespace Leasons
{
    public partial class frmPaint : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        private Color currentColor = Color.Transparent;
        private Pen pen;

        private string currentFilePath = null;

        public frmPaint()
        {
            InitializeComponent();
            InitializeCanvas(); 
            pen = new Pen(Color.Black, 3f);
        }

        private void InitializeCanvas()
        {
            if (pctpaint.Image != null) pctpaint.Image.Dispose();

            Bitmap bmp = new Bitmap(pctpaint.Width, pctpaint.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); 
            }
            pctpaint.Image = bmp;
        }

        private void правкToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            pen.Color = Color.Black;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
            pen.Color = Color.White;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Создать новый рисунок? Несохраненные изменения будут потеряны.",
                "Новый файл", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                InitializeCanvas();
                currentFilePath = null; 
                this.Text = "frmPaint"; 
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения PNG|*.png|Изображения JPEG|*.jpg;*.jpeg|Все файлы|*.*";
                openFileDialog.Title = "Открыть рисунок";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            Image loadedImage = Image.FromStream(fs);
                            Bitmap bmp = new Bitmap(pctpaint.Width, pctpaint.Height);

                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                g.Clear(Color.White);
                                g.DrawImage(loadedImage, 0, 0, pctpaint.Width, pctpaint.Height);
                            }

                            if (pctpaint.Image != null) pctpaint.Image.Dispose();
                            pctpaint.Image = bmp;
                        }

                        currentFilePath = openFileDialog.FileName;
                        this.Text = "Paint - " + Path.GetFileName(currentFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось открыть файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Изображение PNG|*.png|Изображение JPEG|*.jpg";
                saveFileDialog.Title = "Сохранить как...";
                saveFileDialog.DefaultExt = "png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveImageToFile(saveFileDialog.FileName);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveImageToFile(currentFilePath);
            }
        }
        private void SaveImageToFile(string path)
        {
            try
            {
                ImageFormat format = ImageFormat.Png;
                if (Path.GetExtension(path).ToLower() == ".jpg" || Path.GetExtension(path).ToLower() == ".jpeg")
                {
                    format = ImageFormat.Jpeg;
                }

                string tempPath = path + ".tmp";
                pctpaint.Image.Save(tempPath, format);

                if (File.Exists(path)) File.Delete(path);
                File.Move(tempPath, path);

                currentFilePath = path;
                this.Text = "Paint - " + Path.GetFileName(currentFilePath);
                MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pctpaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentColor != Color.Transparent && e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pctpaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(pctpaint.Image))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(pen, lastPoint, e.Location);
                }
                pctpaint.Invalidate();
                lastPoint = e.Location;
            }
        }

        private void pctpaint_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_MouseEnter(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
    }
}