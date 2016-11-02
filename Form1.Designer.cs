namespace regular_languages_generator
{
    partial class Form1
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
            this.nonTermSequenceMaxLength = new System.Windows.Forms.NumericUpDown();
            this.listBox_nonterminals = new System.Windows.Forms.ListBox();
            this.listBox_sequences = new System.Windows.Forms.ListBox();
            this.chains_generation_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nonTermSequenceMinLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlphabet = new System.Windows.Forms.TextBox();
            this.textBoxSubstring = new System.Windows.Forms.TextBox();
            this.grammar_generation_button = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.textBoxMultiplicity = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nonTermSequenceMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonTermSequenceMinLength)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nonTermSequenceMaxLength
            // 
            this.nonTermSequenceMaxLength.Location = new System.Drawing.Point(324, 141);
            this.nonTermSequenceMaxLength.Name = "nonTermSequenceMaxLength";
            this.nonTermSequenceMaxLength.Size = new System.Drawing.Size(60, 20);
            this.nonTermSequenceMaxLength.TabIndex = 3;
            this.nonTermSequenceMaxLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // listBox_nonterminals
            // 
            this.listBox_nonterminals.BackColor = System.Drawing.Color.Gray;
            this.listBox_nonterminals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_nonterminals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_nonterminals.ForeColor = System.Drawing.Color.White;
            this.listBox_nonterminals.FormattingEnabled = true;
            this.listBox_nonterminals.ItemHeight = 20;
            this.listBox_nonterminals.Location = new System.Drawing.Point(15, 86);
            this.listBox_nonterminals.Name = "listBox_nonterminals";
            this.listBox_nonterminals.Size = new System.Drawing.Size(303, 240);
            this.listBox_nonterminals.TabIndex = 1;
            // 
            // listBox_sequences
            // 
            this.listBox_sequences.BackColor = System.Drawing.Color.Gray;
            this.listBox_sequences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_sequences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_sequences.ForeColor = System.Drawing.Color.White;
            this.listBox_sequences.FormattingEnabled = true;
            this.listBox_sequences.ItemHeight = 16;
            this.listBox_sequences.Location = new System.Drawing.Point(390, 86);
            this.listBox_sequences.Name = "listBox_sequences";
            this.listBox_sequences.Size = new System.Drawing.Size(315, 240);
            this.listBox_sequences.TabIndex = 1;
            this.listBox_sequences.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chains_generation_button
            // 
            this.chains_generation_button.BackColor = System.Drawing.Color.Goldenrod;
            this.chains_generation_button.FlatAppearance.BorderSize = 0;
            this.chains_generation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chains_generation_button.ForeColor = System.Drawing.Color.Black;
            this.chains_generation_button.Location = new System.Drawing.Point(324, 167);
            this.chains_generation_button.Name = "chains_generation_button";
            this.chains_generation_button.Size = new System.Drawing.Size(60, 23);
            this.chains_generation_button.TabIndex = 2;
            this.chains_generation_button.Text = ">>";
            this.chains_generation_button.UseVisualStyleBackColor = false;
            this.chains_generation_button.Click += new System.EventHandler(this.button_process_Click);
            this.chains_generation_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Целевой символ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Мин. длина";
            // 
            // nonTermSequenceMinLength
            // 
            this.nonTermSequenceMinLength.Location = new System.Drawing.Point(324, 196);
            this.nonTermSequenceMinLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nonTermSequenceMinLength.Name = "nonTermSequenceMinLength";
            this.nonTermSequenceMinLength.Size = new System.Drawing.Size(60, 20);
            this.nonTermSequenceMinLength.TabIndex = 3;
            this.nonTermSequenceMinLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nonTermSequenceMinLength.ValueChanged += new System.EventHandler(this.nonTermSequenceMinLength_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Макс. длина";
            // 
            // textBoxAlphabet
            // 
            this.textBoxAlphabet.Location = new System.Drawing.Point(210, 7);
            this.textBoxAlphabet.Name = "textBoxAlphabet";
            this.textBoxAlphabet.Size = new System.Drawing.Size(75, 20);
            this.textBoxAlphabet.TabIndex = 11;
            this.textBoxAlphabet.MouseHover += new System.EventHandler(this.textBoxAlphabet_MouseHover);
            // 
            // textBoxSubstring
            // 
            this.textBoxSubstring.Location = new System.Drawing.Point(210, 34);
            this.textBoxSubstring.Name = "textBoxSubstring";
            this.textBoxSubstring.Size = new System.Drawing.Size(75, 20);
            this.textBoxSubstring.TabIndex = 12;
            // 
            // grammar_generation_button
            // 
            this.grammar_generation_button.ForeColor = System.Drawing.Color.Black;
            this.grammar_generation_button.Location = new System.Drawing.Point(185, 466);
            this.grammar_generation_button.Name = "grammar_generation_button";
            this.grammar_generation_button.Size = new System.Drawing.Size(106, 62);
            this.grammar_generation_button.TabIndex = 13;
            this.grammar_generation_button.Text = "Выполнить построение правил";
            this.grammar_generation_button.UseVisualStyleBackColor = true;
            this.grammar_generation_button.Click += new System.EventHandler(this.grammar_generation_button_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(210, 59);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(75, 20);
            this.textBoxParameter.TabIndex = 14;
            // 
            // textBoxMultiplicity
            // 
            this.textBoxMultiplicity.Location = new System.Drawing.Point(210, 84);
            this.textBoxMultiplicity.Name = "textBoxMultiplicity";
            this.textBoxMultiplicity.Size = new System.Drawing.Size(75, 20);
            this.textBoxMultiplicity.TabIndex = 15;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 485);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Леволинейная";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 508);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Праволинейная";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Алфавит";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Конец цепочки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Символ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Кратность символа (от 1 до 10)";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Выбор Регулярной грамматики";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(117, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 23;
            // 
            // buttonRead
            // 
            this.buttonRead.ForeColor = System.Drawing.Color.Black;
            this.buttonRead.Location = new System.Drawing.Point(589, 466);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(106, 41);
            this.buttonRead.TabIndex = 24;
            this.buttonRead.Text = "Загрузить из файла";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(477, 466);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 41);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.авторToolStripMenuItem,
            this.темаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзФайлаToolStripMenuItem,
            this.сохранитьВФайлToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Данные";
            // 
            // загрузитьИзФайлаToolStripMenuItem
            // 
            this.загрузитьИзФайлаToolStripMenuItem.Name = "загрузитьИзФайлаToolStripMenuItem";
            this.загрузитьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.загрузитьИзФайлаToolStripMenuItem.Text = "Загрузить из файла";
            this.загрузитьИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.темаToolStripMenuItem.Text = "О программе";
            this.темаToolStripMenuItem.Click += new System.EventHandler(this.темаToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(355, 115);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор типа описания языка";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(7, 64);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(336, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Обязательная фиксированная подцепочка, кратность длины";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(7, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(294, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Начальная и конечная подцепочки, кратность длины";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(205, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Конец цепочки, кратность символа";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxAlphabet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxSubstring);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxParameter);
            this.panel1.Controls.Add(this.textBoxMultiplicity);
            this.panel1.Location = new System.Drawing.Point(390, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 115);
            this.panel1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(387, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Количество цепочек:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(506, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(717, 603);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.grammar_generation_button);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nonTermSequenceMinLength);
            this.Controls.Add(this.nonTermSequenceMaxLength);
            this.Controls.Add(this.chains_generation_button);
            this.Controls.Add(this.listBox_nonterminals);
            this.Controls.Add(this.listBox_sequences);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(106)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Генератор регулярных языков";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nonTermSequenceMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonTermSequenceMinLength)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nonTermSequenceMaxLength;
        private System.Windows.Forms.ListBox listBox_nonterminals;
        private System.Windows.Forms.ListBox listBox_sequences;
        private System.Windows.Forms.Button chains_generation_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nonTermSequenceMinLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlphabet;
        private System.Windows.Forms.TextBox textBoxSubstring;
        private System.Windows.Forms.Button grammar_generation_button;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.TextBox textBoxMultiplicity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

