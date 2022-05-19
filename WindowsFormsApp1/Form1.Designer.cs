
namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBOriginal = new System.Windows.Forms.RichTextBox();
            this.rTBEdit = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифроватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оригинальныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.всеПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTBOriginal
            // 
            this.rTBOriginal.Location = new System.Drawing.Point(12, 67);
            this.rTBOriginal.Name = "rTBOriginal";
            this.rTBOriginal.Size = new System.Drawing.Size(447, 534);
            this.rTBOriginal.TabIndex = 0;
            this.rTBOriginal.Text = "";
            this.rTBOriginal.TextChanged += new System.EventHandler(this.rTBOriginal_TextChanged);
            // 
            // rTBEdit
            // 
            this.rTBEdit.Enabled = false;
            this.rTBEdit.Location = new System.Drawing.Point(526, 67);
            this.rTBEdit.Name = "rTBEdit";
            this.rTBEdit.ReadOnly = true;
            this.rTBEdit.Size = new System.Drawing.Size(447, 534);
            this.rTBEdit.TabIndex = 1;
            this.rTBEdit.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дешифроватьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // дешифроватьToolStripMenuItem
            // 
            this.дешифроватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem,
            this.дешифроватьToolStripMenuItem1});
            this.дешифроватьToolStripMenuItem.Name = "дешифроватьToolStripMenuItem";
            this.дешифроватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.дешифроватьToolStripMenuItem.Text = "Шифрование";
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать";
            this.зашифроватьToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьToolStripMenuItem_Click);
            // 
            // дешифроватьToolStripMenuItem1
            // 
            this.дешифроватьToolStripMenuItem1.Name = "дешифроватьToolStripMenuItem1";
            this.дешифроватьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.дешифроватьToolStripMenuItem1.Text = "Дешифровать";
            this.дешифроватьToolStripMenuItem1.Click += new System.EventHandler(this.дешифроватьToolStripMenuItem1_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оригинальныйТекстToolStripMenuItem,
            this.редактированныйТекстToolStripMenuItem,
            this.всеПоляToolStripMenuItem});
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // оригинальныйТекстToolStripMenuItem
            // 
            this.оригинальныйТекстToolStripMenuItem.Name = "оригинальныйТекстToolStripMenuItem";
            this.оригинальныйТекстToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.оригинальныйТекстToolStripMenuItem.Text = "Оригинальный текст";
            this.оригинальныйТекстToolStripMenuItem.Click += new System.EventHandler(this.оригинальныйТекстToolStripMenuItem_Click);
            // 
            // редактированныйТекстToolStripMenuItem
            // 
            this.редактированныйТекстToolStripMenuItem.Name = "редактированныйТекстToolStripMenuItem";
            this.редактированныйТекстToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редактированныйТекстToolStripMenuItem.Text = "Редактированный текст";
            this.редактированныйТекстToolStripMenuItem.Click += new System.EventHandler(this.редактированныйТекстToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пользователь: Юрий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Файл:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Зашифрованный файл tte|*.tte|Нешифрованный файл ttd|*.ttd\"";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(384, 29);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(465, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Скопировать в основное окно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // всеПоляToolStripMenuItem
            // 
            this.всеПоляToolStripMenuItem.Name = "всеПоляToolStripMenuItem";
            this.всеПоляToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.всеПоляToolStripMenuItem.Text = "Все поля";
            this.всеПоляToolStripMenuItem.Click += new System.EventHandler(this.всеПоляToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTBEdit);
            this.Controls.Add(this.rTBOriginal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBOriginal;
        private System.Windows.Forms.RichTextBox rTBEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифроватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem оригинальныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированныйТекстToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem всеПоляToolStripMenuItem;
    }
}

