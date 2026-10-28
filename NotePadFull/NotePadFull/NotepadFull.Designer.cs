using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NotePadFull
{
    partial class NotepadFull
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносПоСловамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаСостоянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.параметрыСтраницыToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.сохранитьКакToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click_1);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.параметрыСтраницыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы";
            this.параметрыСтраницыToolStripMenuItem.Click += new System.EventHandler(this.параметрыСтраницыToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.печатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.печатьToolStripMenuItem.Text = "Печать...";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // правкToolStripMenuItem
            // 
            this.правкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.найтиДалееToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.правкToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.правкToolStripMenuItem.Name = "правкToolStripMenuItem";
            this.правкToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкToolStripMenuItem.Text = "Правка";
            this.правкToolStripMenuItem.Click += new System.EventHandler(this.правкToolStripMenuItem_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.отменитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.вырезатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.копироватьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.вставитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.найтиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.найтиToolStripMenuItem.Text = "Найти...";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // найтиДалееToolStripMenuItem
            // 
            this.найтиДалееToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.найтиДалееToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            this.найтиДалееToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.найтиДалееToolStripMenuItem.Text = "Найти далее";
            this.найтиДалееToolStripMenuItem.Click += new System.EventHandler(this.найтиДалееToolStripMenuItem_Click);
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.перейтиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.перейтиToolStripMenuItem.Text = "Перейти...";
            this.перейтиToolStripMenuItem.Click += new System.EventHandler(this.перейтиToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.выделитьВсеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносПоСловамToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.форматToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            this.форматToolStripMenuItem.Click += new System.EventHandler(this.форматToolStripMenuItem_Click);
            // 
            // переносПоСловамToolStripMenuItem
            // 
            this.переносПоСловамToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.переносПоСловамToolStripMenuItem.Checked = true;
            this.переносПоСловамToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.переносПоСловамToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            this.переносПоСловамToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            this.переносПоСловамToolStripMenuItem.Click += new System.EventHandler(this.переносПоСловамToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.шрифтToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem,
            this.строкаСостоянияToolStripMenuItem});
            this.видToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.масштабToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            this.масштабToolStripMenuItem.Click += new System.EventHandler(this.масштабToolStripMenuItem_Click);
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.изменитьToolStripMenuItem.Text = "Восстановить масштаб по состоянию";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            this.строкаСостоянияToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.строкаСостоянияToolStripMenuItem.Checked = true;
            this.строкаСостоянияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.строкаСостоянияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            this.строкаСостоянияToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            this.строкаСостоянияToolStripMenuItem.Click += new System.EventHandler(this.строкаСостоянияToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel6.Text = "100%                                    ";
            this.toolStripStatusLabel6.Click += new System.EventHandler(this.toolStripStatusLabel6_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(142, 17);
            this.toolStripStatusLabel5.Text = "Стр 1, стлб 1                      ";
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel4.Text = "Windows (CRLF)                  ";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(343, 17);
            this.toolStripStatusLabel2.Text = "                                                                                 " +
    "                               ";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // NotepadFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotepadFull";
            this.Text = "Notebook";
            this.Load += new System.EventHandler(this.NotepadFull_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правкToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem найтиДалееToolStripMenuItem;
        private ToolStripMenuItem перейтиToolStripMenuItem;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem20;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripMenuItem toolStripMenuItem25;
        private ToolStripMenuItem toolStripMenuItem26;
        private ToolStripMenuItem toolStripMenuItem27;
        private ToolStripMenuItem toolStripMenuItem28;
        private ToolStripMenuItem toolStripMenuItem29;
        private ToolStripMenuItem toolStripMenuItem30;
        private ToolStripMenuItem toolStripMenuItem31;
        private ToolStripMenuItem toolStripMenuItem32;
        private ToolStripMenuItem toolStripMenuItem33;
    }
}