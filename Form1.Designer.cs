namespace VideoTerminalControl
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nowVol = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.micMuteBtn = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "log";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(435, 19);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(419, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1.6.100.1",
            "1.6.20.1",
            "1.6.100.5",
            "1.6.20.2",
            "80.72.229.118"});
            this.listBox1.Location = new System.Drawing.Point(12, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // log
            // 
            this.log.ForeColor = System.Drawing.SystemColors.WindowText;
            this.log.Location = new System.Drawing.Point(12, 151);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(120, 114);
            this.log.TabIndex = 7;
            this.log.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "comand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Текущая громкость:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(225, 139);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 20);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 20);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(225, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nowVol
            // 
            this.nowVol.AutoSize = true;
            this.nowVol.Location = new System.Drawing.Point(334, 68);
            this.nowVol.Name = "nowVol";
            this.nowVol.Size = new System.Drawing.Size(52, 13);
            this.nowVol.TabIndex = 21;
            this.nowVol.Text = "получить";
            this.nowVol.Click += new System.EventHandler(this.nowVol_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "+2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "+5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(379, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 28);
            this.button6.TabIndex = 24;
            this.button6.Text = "+8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(301, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 28);
            this.button7.TabIndex = 25;
            this.button7.Text = "-2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(340, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 28);
            this.button8.TabIndex = 26;
            this.button8.Text = "-5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(379, 135);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 28);
            this.button9.TabIndex = 27;
            this.button9.Text = "-8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle__1_;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button15.Location = new System.Drawing.Point(559, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 27);
            this.button15.TabIndex = 35;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button14.Location = new System.Drawing.Point(518, 68);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 27);
            this.button14.TabIndex = 34;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle_1;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Location = new System.Drawing.Point(559, 134);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 27);
            this.button13.TabIndex = 33;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle_2;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Location = new System.Drawing.Point(518, 134);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 27);
            this.button12.TabIndex = 32;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle_4;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Location = new System.Drawing.Point(518, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 27);
            this.button11.TabIndex = 31;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::VideoTerminalControl.Properties.Resources.rectangle_3;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Location = new System.Drawing.Point(559, 101);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 27);
            this.button10.TabIndex = 30;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // micMuteBtn
            // 
            this.micMuteBtn.BackgroundImage = global::VideoTerminalControl.Properties.Resources.micMute;
            this.micMuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.micMuteBtn.Location = new System.Drawing.Point(452, 133);
            this.micMuteBtn.Name = "micMuteBtn";
            this.micMuteBtn.Size = new System.Drawing.Size(33, 28);
            this.micMuteBtn.TabIndex = 29;
            this.micMuteBtn.UseVisualStyleBackColor = true;
            this.micMuteBtn.Click += new System.EventHandler(this.micMuteBtn_Click);
            // 
            // muteBtn
            // 
            this.muteBtn.BackgroundImage = global::VideoTerminalControl.Properties.Resources.mute;
            this.muteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muteBtn.Location = new System.Drawing.Point(452, 101);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(33, 28);
            this.muteBtn.TabIndex = 28;
            this.muteBtn.UseVisualStyleBackColor = true;
            this.muteBtn.Click += new System.EventHandler(this.muteBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 307);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.micMuteBtn);
            this.Controls.Add(this.muteBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nowVol);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label nowVol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.Button micMuteBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

