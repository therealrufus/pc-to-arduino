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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PortComBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBtn1 = new System.Windows.Forms.Button();
            this.consoleRichText1 = new System.Windows.Forms.RichTextBox();
            this.sendBtn1 = new System.Windows.Forms.Button();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.sendBox1 = new System.Windows.Forms.TextBox();
            this.led1Box1 = new System.Windows.Forms.CheckBox();
            this.led1Box2 = new System.Windows.Forms.CheckBox();
            this.sendBox2 = new System.Windows.Forms.TextBox();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.sendBtn2 = new System.Windows.Forms.Button();
            this.consoleRichText2 = new System.Windows.Forms.RichTextBox();
            this.ConnectBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortComBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PortComBox1
            // 
            this.PortComBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortComBox1.FormattingEnabled = true;
            this.PortComBox1.Location = new System.Drawing.Point(61, 10);
            this.PortComBox1.Name = "PortComBox1";
            this.PortComBox1.Size = new System.Drawing.Size(140, 23);
            this.PortComBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "port:";
            // 
            // ConnectBtn1
            // 
            this.ConnectBtn1.Location = new System.Drawing.Point(206, 9);
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
            this.consoleRichText1.Location = new System.Drawing.Point(12, 43);
            this.consoleRichText1.Name = "consoleRichText1";
            this.consoleRichText1.ReadOnly = true;
            this.consoleRichText1.Size = new System.Drawing.Size(366, 183);
            this.consoleRichText1.TabIndex = 6;
            this.consoleRichText1.Text = "";
            this.consoleRichText1.TextChanged += new System.EventHandler(this.consoleRichText_TextChanged);
            // 
            // sendBtn1
            // 
            this.sendBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendBtn1.Location = new System.Drawing.Point(14, 262);
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
            this.clearBtn1.Location = new System.Drawing.Point(111, 262);
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
            this.sendBox1.Location = new System.Drawing.Point(12, 232);
            this.sendBox1.Name = "sendBox1";
            this.sendBox1.Size = new System.Drawing.Size(366, 23);
            this.sendBox1.TabIndex = 9;
            // 
            // led1Box1
            // 
            this.led1Box1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.led1Box1.AutoSize = true;
            this.led1Box1.Location = new System.Drawing.Point(299, 12);
            this.led1Box1.Name = "led1Box1";
            this.led1Box1.Size = new System.Drawing.Size(55, 19);
            this.led1Box1.TabIndex = 10;
            this.led1Box1.Text = "ready";
            this.led1Box1.UseVisualStyleBackColor = true;
            this.led1Box1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // led1Box2
            // 
            this.led1Box2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led1Box2.AutoSize = true;
            this.led1Box2.Location = new System.Drawing.Point(680, 11);
            this.led1Box2.Name = "led1Box2";
            this.led1Box2.Size = new System.Drawing.Size(55, 19);
            this.led1Box2.TabIndex = 18;
            this.led1Box2.Text = "ready";
            this.led1Box2.UseVisualStyleBackColor = true;
            // 
            // sendBox2
            // 
            this.sendBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBox2.Location = new System.Drawing.Point(395, 232);
            this.sendBox2.Name = "sendBox2";
            this.sendBox2.Size = new System.Drawing.Size(365, 23);
            this.sendBox2.TabIndex = 17;
            // 
            // clearBtn2
            // 
            this.clearBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn2.Location = new System.Drawing.Point(491, 262);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearBtn2.Size = new System.Drawing.Size(87, 27);
            this.clearBtn2.TabIndex = 16;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            // 
            // sendBtn2
            // 
            this.sendBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn2.Location = new System.Drawing.Point(394, 262);
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
            this.consoleRichText2.Location = new System.Drawing.Point(394, 43);
            this.consoleRichText2.Name = "consoleRichText2";
            this.consoleRichText2.ReadOnly = true;
            this.consoleRichText2.Size = new System.Drawing.Size(366, 183);
            this.consoleRichText2.TabIndex = 14;
            this.consoleRichText2.Text = "";
            // 
            // ConnectBtn2
            // 
            this.ConnectBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn2.Location = new System.Drawing.Point(587, 8);
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
            this.label2.Location = new System.Drawing.Point(392, 12);
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
            this.PortComBox2.Location = new System.Drawing.Point(442, 9);
            this.PortComBox2.Name = "PortComBox2";
            this.PortComBox2.Size = new System.Drawing.Size(140, 23);
            this.PortComBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 301);
            this.Controls.Add(this.led1Box2);
            this.Controls.Add(this.sendBox2);
            this.Controls.Add(this.clearBtn2);
            this.Controls.Add(this.sendBtn2);
            this.Controls.Add(this.consoleRichText2);
            this.Controls.Add(this.ConnectBtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortComBox2);
            this.Controls.Add(this.led1Box1);
            this.Controls.Add(this.sendBox1);
            this.Controls.Add(this.clearBtn1);
            this.Controls.Add(this.sendBtn1);
            this.Controls.Add(this.consoleRichText1);
            this.Controls.Add(this.ConnectBtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortComBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 340);
            this.Name = "Form1";
            this.Text = "Curling Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortComBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectBtn1;
        private System.Windows.Forms.RichTextBox consoleRichText1;
        private System.Windows.Forms.Button sendBtn1;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.TextBox sendBox1;
        private System.Windows.Forms.CheckBox led1Box1;
        private System.Windows.Forms.CheckBox led1Box2;
        private System.Windows.Forms.TextBox sendBox2;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.Button sendBtn2;
        private System.Windows.Forms.RichTextBox consoleRichText2;
        private System.Windows.Forms.Button ConnectBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortComBox2;
    }
}

