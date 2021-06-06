namespace PC_to_Arduino__form_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PortComBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBtn1 = new System.Windows.Forms.Button();
            this.consoleRichText1 = new System.Windows.Forms.RichTextBox();
            this.sendBtn1 = new System.Windows.Forms.Button();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.sendBox1 = new System.Windows.Forms.TextBox();
            this.sendBox2 = new System.Windows.Forms.TextBox();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.sendBtn2 = new System.Windows.Forms.Button();
            this.consoleRichText2 = new System.Windows.Forms.RichTextBox();
            this.ConnectBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortComBox2 = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.rbTee1 = new System.Windows.Forms.RadioButton();
            this.rbHog1 = new System.Windows.Forms.RadioButton();
            this.rbHog2 = new System.Windows.Forms.RadioButton();
            this.rbTee2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbTH = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Sek = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // PortComBox1
            // 
            this.PortComBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortComBox1.FormattingEnabled = true;
            this.PortComBox1.Location = new System.Drawing.Point(58, 15);
            this.PortComBox1.Name = "PortComBox1";
            this.PortComBox1.Size = new System.Drawing.Size(140, 23);
            this.PortComBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "port:";
            // 
            // ConnectBtn1
            // 
            this.ConnectBtn1.Location = new System.Drawing.Point(203, 14);
            this.ConnectBtn1.Name = "ConnectBtn1";
            this.ConnectBtn1.Size = new System.Drawing.Size(87, 24);
            this.ConnectBtn1.TabIndex = 2;
            this.ConnectBtn1.Text = "Connect";
            this.ConnectBtn1.UseVisualStyleBackColor = true;
            this.ConnectBtn1.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // consoleRichText1
            // 
            this.consoleRichText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consoleRichText1.Location = new System.Drawing.Point(12, 56);
            this.consoleRichText1.Name = "consoleRichText1";
            this.consoleRichText1.ReadOnly = true;
            this.consoleRichText1.Size = new System.Drawing.Size(384, 150);
            this.consoleRichText1.TabIndex = 6;
            this.consoleRichText1.Text = "";
            // 
            // sendBtn1
            // 
            this.sendBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendBtn1.Location = new System.Drawing.Point(8, 242);
            this.sendBtn1.Name = "sendBtn1";
            this.sendBtn1.Size = new System.Drawing.Size(87, 27);
            this.sendBtn1.TabIndex = 7;
            this.sendBtn1.Text = "Send";
            this.sendBtn1.UseVisualStyleBackColor = true;
            this.sendBtn1.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn1
            // 
            this.clearBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn1.Location = new System.Drawing.Point(105, 242);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearBtn1.Size = new System.Drawing.Size(87, 27);
            this.clearBtn1.TabIndex = 8;
            this.clearBtn1.Text = "Clear";
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sendBox1
            // 
            this.sendBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendBox1.Location = new System.Drawing.Point(6, 212);
            this.sendBox1.Name = "sendBox1";
            this.sendBox1.Size = new System.Drawing.Size(384, 23);
            this.sendBox1.TabIndex = 9;
            // 
            // sendBox2
            // 
            this.sendBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBox2.Location = new System.Drawing.Point(7, 212);
            this.sendBox2.Name = "sendBox2";
            this.sendBox2.Size = new System.Drawing.Size(384, 23);
            this.sendBox2.TabIndex = 17;
            // 
            // clearBtn2
            // 
            this.clearBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn2.Location = new System.Drawing.Point(103, 242);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearBtn2.Size = new System.Drawing.Size(87, 27);
            this.clearBtn2.TabIndex = 16;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // sendBtn2
            // 
            this.sendBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn2.Location = new System.Drawing.Point(6, 242);
            this.sendBtn2.Name = "sendBtn2";
            this.sendBtn2.Size = new System.Drawing.Size(87, 27);
            this.sendBtn2.TabIndex = 15;
            this.sendBtn2.Text = "Send";
            this.sendBtn2.UseVisualStyleBackColor = true;
            this.sendBtn2.Click += new System.EventHandler(this.sendBtn2_Click);
            // 
            // consoleRichText2
            // 
            this.consoleRichText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleRichText2.Location = new System.Drawing.Point(6, 56);
            this.consoleRichText2.Name = "consoleRichText2";
            this.consoleRichText2.ReadOnly = true;
            this.consoleRichText2.Size = new System.Drawing.Size(385, 150);
            this.consoleRichText2.TabIndex = 14;
            this.consoleRichText2.Text = "";
            // 
            // ConnectBtn2
            // 
            this.ConnectBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn2.Location = new System.Drawing.Point(205, 16);
            this.ConnectBtn2.Name = "ConnectBtn2";
            this.ConnectBtn2.Size = new System.Drawing.Size(87, 24);
            this.ConnectBtn2.TabIndex = 13;
            this.ConnectBtn2.Text = "Connect";
            this.ConnectBtn2.UseVisualStyleBackColor = true;
            this.ConnectBtn2.Click += new System.EventHandler(this.ConnectBtn2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "port:";
            // 
            // PortComBox2
            // 
            this.PortComBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortComBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortComBox2.FormattingEnabled = true;
            this.PortComBox2.Location = new System.Drawing.Point(62, 17);
            this.PortComBox2.Name = "PortComBox2";
            this.PortComBox2.Size = new System.Drawing.Size(140, 23);
            this.PortComBox2.TabIndex = 11;
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // rbTee1
            // 
            this.rbTee1.AutoSize = true;
            this.rbTee1.Location = new System.Drawing.Point(296, 17);
            this.rbTee1.Name = "rbTee1";
            this.rbTee1.Size = new System.Drawing.Size(44, 19);
            this.rbTee1.TabIndex = 18;
            this.rbTee1.TabStop = true;
            this.rbTee1.Text = "Tee";
            this.rbTee1.UseVisualStyleBackColor = true;
            // 
            // rbHog1
            // 
            this.rbHog1.AutoSize = true;
            this.rbHog1.Location = new System.Drawing.Point(346, 17);
            this.rbHog1.Name = "rbHog1";
            this.rbHog1.Size = new System.Drawing.Size(45, 19);
            this.rbHog1.TabIndex = 19;
            this.rbHog1.TabStop = true;
            this.rbHog1.Text = "Hog";
            this.rbHog1.UseVisualStyleBackColor = true;
            // 
            // rbHog2
            // 
            this.rbHog2.AutoSize = true;
            this.rbHog2.Location = new System.Drawing.Point(346, 21);
            this.rbHog2.Name = "rbHog2";
            this.rbHog2.Size = new System.Drawing.Size(45, 19);
            this.rbHog2.TabIndex = 21;
            this.rbHog2.TabStop = true;
            this.rbHog2.Text = "Hog";
            this.rbHog2.UseVisualStyleBackColor = true;
            // 
            // rbTee2
            // 
            this.rbTee2.AutoSize = true;
            this.rbTee2.Location = new System.Drawing.Point(298, 20);
            this.rbTee2.Name = "rbTee2";
            this.rbTee2.Size = new System.Drawing.Size(44, 19);
            this.rbTee2.TabIndex = 20;
            this.rbTee2.TabStop = true;
            this.rbTee2.Text = "Tee";
            this.rbTee2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTee1);
            this.groupBox1.Controls.Add(this.rbHog1);
            this.groupBox1.Controls.Add(this.ConnectBtn1);
            this.groupBox1.Controls.Add(this.PortComBox1);
            this.groupBox1.Controls.Add(this.sendBox1);
            this.groupBox1.Controls.Add(this.clearBtn1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sendBtn1);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 280);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectBtn2);
            this.groupBox2.Controls.Add(this.consoleRichText2);
            this.groupBox2.Controls.Add(this.sendBtn2);
            this.groupBox2.Controls.Add(this.clearBtn2);
            this.groupBox2.Controls.Add(this.rbHog2);
            this.groupBox2.Controls.Add(this.sendBox2);
            this.groupBox2.Controls.Add(this.rbTee2);
            this.groupBox2.Controls.Add(this.PortComBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(423, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 280);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerLabel.Location = new System.Drawing.Point(30, 19);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(310, 90);
            this.timerLabel.TabIndex = 26;
            this.timerLabel.Text = "00:00:00";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(143, 101);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudLenght);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labSpeed);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rbCustom);
            this.groupBox3.Controls.Add(this.rbTH);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Sek);
            this.groupBox3.Controls.Add(this.Min);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.timerLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(5, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 193);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // nudLenght
            // 
            this.nudLenght.Enabled = false;
            this.nudLenght.Location = new System.Drawing.Point(710, 17);
            this.nudLenght.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(76, 23);
            this.nudLenght.TabIndex = 38;
            this.nudLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLenght.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(475, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Rychlost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(772, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "m/s";
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSpeed.Location = new System.Drawing.Point(553, 46);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(210, 90);
            this.labSpeed.TabIndex = 37;
            this.labSpeed.Text = "00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(473, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Vzdálenost:";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(643, 19);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 19);
            this.rbCustom.TabIndex = 34;
            this.rbCustom.Text = "Vlastní";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbTH
            // 
            this.rbTH.AutoSize = true;
            this.rbTH.Checked = true;
            this.rbTH.Location = new System.Drawing.Point(573, 19);
            this.rbTH.Name = "rbTH";
            this.rbTH.Size = new System.Drawing.Size(63, 19);
            this.rbTH.TabIndex = 33;
            this.rbTH.TabStop = true;
            this.rbTH.Text = "tee-hog";
            this.rbTH.UseVisualStyleBackColor = true;
            this.rbTH.CheckedChanged += new System.EventHandler(this.rbTH_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Čas:";
            // 
            // Sek
            // 
            this.Sek.AutoSize = true;
            this.Sek.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sek.Location = new System.Drawing.Point(160, 19);
            this.Sek.Name = "Sek";
            this.Sek.Size = new System.Drawing.Size(38, 23);
            this.Sek.TabIndex = 30;
            this.Sek.Text = "Sek";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Min.Location = new System.Drawing.Point(67, 19);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(38, 23);
            this.Min.TabIndex = 29;
            this.Min.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(792, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.consoleRichText1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 340);
            this.Name = "Form1";
            this.Text = "Curling Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortComBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectBtn1;
        private System.Windows.Forms.RichTextBox consoleRichText1;
        private System.Windows.Forms.Button sendBtn1;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.TextBox sendBox1;
        private System.Windows.Forms.TextBox sendBox2;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.Button sendBtn2;
        private System.Windows.Forms.RichTextBox consoleRichText2;
        private System.Windows.Forms.Button ConnectBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortComBox2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton rbTee1;
        private System.Windows.Forms.RadioButton rbHog1;
        private System.Windows.Forms.RadioButton rbHog2;
        private System.Windows.Forms.RadioButton rbTee2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sek;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.NumericUpDown nudLenght;
    }
}

