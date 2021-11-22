
namespace LabCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.діїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиРядокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиСтовпчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиРядокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиСтовпчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.завантажитиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.діїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // діїToolStripMenuItem
            // 
            this.діїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиРядокToolStripMenuItem,
            this.додатиСтовпчикToolStripMenuItem,
            this.видалитиРядокToolStripMenuItem,
            this.видалитиСтовпчикToolStripMenuItem,
            this.зберегтиТаблицюToolStripMenuItem,
            this.завантажитиТаблицюToolStripMenuItem});
            this.діїToolStripMenuItem.Name = "діїToolStripMenuItem";
            this.діїToolStripMenuItem.Size = new System.Drawing.Size(48, 29);
            this.діїToolStripMenuItem.Text = "Дії";
            // 
            // додатиРядокToolStripMenuItem
            // 
            this.додатиРядокToolStripMenuItem.Name = "додатиРядокToolStripMenuItem";
            this.додатиРядокToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.додатиРядокToolStripMenuItem.Text = "Додати рядок";
            this.додатиРядокToolStripMenuItem.Click += new System.EventHandler(this.додатиРядокToolStripMenuItem_Click);
            // 
            // додатиСтовпчикToolStripMenuItem
            // 
            this.додатиСтовпчикToolStripMenuItem.Name = "додатиСтовпчикToolStripMenuItem";
            this.додатиСтовпчикToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.додатиСтовпчикToolStripMenuItem.Text = "Додати стовпчик";
            this.додатиСтовпчикToolStripMenuItem.Click += new System.EventHandler(this.додатиСтовпчикToolStripMenuItem_Click);
            // 
            // видалитиРядокToolStripMenuItem
            // 
            this.видалитиРядокToolStripMenuItem.Name = "видалитиРядокToolStripMenuItem";
            this.видалитиРядокToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.видалитиРядокToolStripMenuItem.Text = "Видалити рядок";
            this.видалитиРядокToolStripMenuItem.Click += new System.EventHandler(this.видалитиРядокToolStripMenuItem_Click);
            // 
            // видалитиСтовпчикToolStripMenuItem
            // 
            this.видалитиСтовпчикToolStripMenuItem.Name = "видалитиСтовпчикToolStripMenuItem";
            this.видалитиСтовпчикToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.видалитиСтовпчикToolStripMenuItem.Text = "Видалити стовпчик";
            this.видалитиСтовпчикToolStripMenuItem.Click += new System.EventHandler(this.видалитиСтовпчикToolStripMenuItem_Click);
            // 
            // зберегтиТаблицюToolStripMenuItem
            // 
            this.зберегтиТаблицюToolStripMenuItem.Name = "зберегтиТаблицюToolStripMenuItem";
            this.зберегтиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.зберегтиТаблицюToolStripMenuItem.Text = "Зберегти таблицю";
            this.зберегтиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.зберегтиТаблицюToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Допомога";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 31);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(870, 406);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // завантажитиТаблицюToolStripMenuItem
            // 
            this.завантажитиТаблицюToolStripMenuItem.Name = "завантажитиТаблицюToolStripMenuItem";
            this.завантажитиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.завантажитиТаблицюToolStripMenuItem.Text = "Завантажити таблицю";
            this.завантажитиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.завантажитиТаблицюToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторна робота 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem діїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиРядокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиСтовпчикToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem видалитиРядокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиСтовпчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиТаблицюToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem завантажитиТаблицюToolStripMenuItem;
    }
}

