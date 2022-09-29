namespace LibraryDataBase
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.библиоткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВЧёрныйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОтзывToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взятиеКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрогроммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВидToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Location = new System.Drawing.Point(0, 887);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1266, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.библиоткаToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.взятиеКнигToolStripMenuItem,
            this.оПрогроммеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // библиоткаToolStripMenuItem
            // 
            this.библиоткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.добавитьВЧёрныйСписокToolStripMenuItem});
            this.библиоткаToolStripMenuItem.Name = "библиоткаToolStripMenuItem";
            this.библиоткаToolStripMenuItem.Size = new System.Drawing.Size(165, 45);
            this.библиоткаToolStripMenuItem.Text = "Читатель";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(556, 54);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // добавитьВЧёрныйСписокToolStripMenuItem
            // 
            this.добавитьВЧёрныйСписокToolStripMenuItem.Name = "добавитьВЧёрныйСписокToolStripMenuItem";
            this.добавитьВЧёрныйСписокToolStripMenuItem.Size = new System.Drawing.Size(556, 54);
            this.добавитьВЧёрныйСписокToolStripMenuItem.Text = "Добавить в чёрный список";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.добавитьОтзывToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(121, 45);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(448, 54);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // добавитьОтзывToolStripMenuItem
            // 
            this.добавитьОтзывToolStripMenuItem.Name = "добавитьОтзывToolStripMenuItem";
            this.добавитьОтзывToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.добавитьОтзывToolStripMenuItem.Text = "Добавить отзыв";
            // 
            // взятиеКнигToolStripMenuItem
            // 
            this.взятиеКнигToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem});
            this.взятиеКнигToolStripMenuItem.Name = "взятиеКнигToolStripMenuItem";
            this.взятиеКнигToolStripMenuItem.Size = new System.Drawing.Size(200, 45);
            this.взятиеКнигToolStripMenuItem.Text = "Взятие книг";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            // 
            // оПрогроммеToolStripMenuItem
            // 
            this.оПрогроммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добаToolStripMenuItem,
            this.добавитьВидToolStripMenuItem});
            this.оПрогроммеToolStripMenuItem.Name = "оПрогроммеToolStripMenuItem";
            this.оПрогроммеToolStripMenuItem.Size = new System.Drawing.Size(307, 45);
            this.оПрогроммеToolStripMenuItem.Text = "Платные операцые";
            this.оПрогроммеToolStripMenuItem.Click += new System.EventHandler(this.оПрогроммеToolStripMenuItem_Click);
            // 
            // добаToolStripMenuItem
            // 
            this.добаToolStripMenuItem.Name = "добаToolStripMenuItem";
            this.добаToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.добаToolStripMenuItem.Text = "Добавить";
            // 
            // добавитьВидToolStripMenuItem
            // 
            this.добавитьВидToolStripMenuItem.Name = "добавитьВидToolStripMenuItem";
            this.добавитьВидToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.добавитьВидToolStripMenuItem.Text = "Добавить вид";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(228, 45);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 635);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 909);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem библиоткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВЧёрныйСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьОтзывToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem взятиеКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрогроммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВидToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

