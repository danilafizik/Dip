namespace Dip
{
    partial class MOB
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOB));
            this.num = new System.Windows.Forms.TextBox();
            this.kol = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouttheprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dalee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCoeff3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCoeff2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCoeff1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.значенияВТаблицу = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(195, 26);
            this.num.Margin = new System.Windows.Forms.Padding(4);
            this.num.MaxLength = 50;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(205, 23);
            this.num.TabIndex = 0;
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kol
            // 
            this.kol.AutoSize = true;
            this.kol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kol.Location = new System.Drawing.Point(8, 29);
            this.kol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(174, 15);
            this.kol.TabIndex = 2;
            this.kol.Text = "Введите количество отраслей:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(844, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem1,
            this.writeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem1
            // 
            this.saveasToolStripMenuItem1.Name = "saveasToolStripMenuItem1";
            this.saveasToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveasToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.saveasToolStripMenuItem1.Text = "Сохранить как...";
            this.saveasToolStripMenuItem1.Click += new System.EventHandler(this.saveasКакToolStripMenuItem1_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.writeToolStripMenuItem.Text = "Печать";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceToolStripMenuItem,
            this.abouttheprogramToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.helpToolStripMenuItem.Text = "Поддержка";
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("referenceToolStripMenuItem.Image")));
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.referenceToolStripMenuItem.Text = "Справка";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
            // 
            // abouttheprogramToolStripMenuItem
            // 
            this.abouttheprogramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abouttheprogramToolStripMenuItem.Image")));
            this.abouttheprogramToolStripMenuItem.Name = "abouttheprogramToolStripMenuItem";
            this.abouttheprogramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.abouttheprogramToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.abouttheprogramToolStripMenuItem.Text = "О программе";
            this.abouttheprogramToolStripMenuItem.Click += new System.EventHandler(this.abouttheprogramToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dalee);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridViewArray);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCoeff3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCoeff2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCoeff1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.kol);
            this.groupBox1.Controls.Add(this.значенияВТаблицу);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 423);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод исходных данных:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(7, 361);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Количество знаков после запятой:";
            // 
            // dalee
            // 
            this.dalee.AutoSize = true;
            this.dalee.BackColor = System.Drawing.Color.GhostWhite;
            this.dalee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dalee.Location = new System.Drawing.Point(438, 26);
            this.dalee.Margin = new System.Windows.Forms.Padding(4);
            this.dalee.Name = "dalee";
            this.dalee.Size = new System.Drawing.Size(166, 28);
            this.dalee.TabIndex = 26;
            this.dalee.Text = "Далее";
            this.dalee.UseVisualStyleBackColor = false;
            this.dalee.Click += new System.EventHandler(this.dalee_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(438, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Построить решение";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArray.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(6, 63);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(599, 183);
            this.dataGridViewArray.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(424, 333);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "%";
            // 
            // textBoxCoeff3
            // 
            this.textBoxCoeff3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCoeff3.Location = new System.Drawing.Point(371, 330);
            this.textBoxCoeff3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoeff3.MaxLength = 10;
            this.textBoxCoeff3.Name = "textBoxCoeff3";
            this.textBoxCoeff3.Size = new System.Drawing.Size(45, 23);
            this.textBoxCoeff3.TabIndex = 22;
            this.textBoxCoeff3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoeff3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoeff3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(342, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "на:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(211, 327);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 23);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(424, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "%";
            // 
            // textBoxCoeff2
            // 
            this.textBoxCoeff2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCoeff2.Location = new System.Drawing.Point(371, 301);
            this.textBoxCoeff2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoeff2.MaxLength = 10;
            this.textBoxCoeff2.Name = "textBoxCoeff2";
            this.textBoxCoeff2.Size = new System.Drawing.Size(45, 23);
            this.textBoxCoeff2.TabIndex = 18;
            this.textBoxCoeff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoeff2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoeff2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(342, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "на:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(211, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 23);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(424, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // textBoxCoeff1
            // 
            this.textBoxCoeff1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCoeff1.Location = new System.Drawing.Point(371, 272);
            this.textBoxCoeff1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoeff1.MaxLength = 10;
            this.textBoxCoeff1.Name = "textBoxCoeff1";
            this.textBoxCoeff1.Size = new System.Drawing.Size(45, 23);
            this.textBoxCoeff1.TabIndex = 14;
            this.textBoxCoeff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoeff1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoeff1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(342, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "на:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Как меняются коэффициенты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Как меняются коэффициенты:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // значенияВТаблицу
            // 
            this.значенияВТаблицу.AutoSize = true;
            this.значенияВТаблицу.ForeColor = System.Drawing.SystemColors.ControlText;
            this.значенияВТаблицу.Location = new System.Drawing.Point(7, 272);
            this.значенияВТаблицу.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.значенияВТаблицу.Name = "значенияВТаблицу";
            this.значенияВТаблицу.Size = new System.Drawing.Size(175, 15);
            this.значенияВТаблицу.TabIndex = 8;
            this.значенияВТаблицу.Text = "Как меняются коэффициенты:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(623, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 423);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(197, 395);
            this.textBox2.TabIndex = 0;
            // 
            // MOB
            // 
            this.AcceptButton = this.dalee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MOB";
            this.Text = "Межотраслевой баланс";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MOB_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label kol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouttheprogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label значенияВТаблицу;
        private System.Windows.Forms.TextBox textBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCoeff1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCoeff3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCoeff2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button dalee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}

