
namespace AutoClicker
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.turnPicture = new System.Windows.Forms.PictureBox();
            this.closePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupBoxButton2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxButton1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxForY = new System.Windows.Forms.TextBox();
            this.textBoxForX = new System.Windows.Forms.TextBox();
            this.buttonPickLoc = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxForWrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.groupBoxButton2.SuspendLayout();
            this.groupBoxButton1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.turnPicture);
            this.TopPanel.Controls.Add(this.closePicture);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(300, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // turnPicture
            // 
            this.turnPicture.BackgroundImage = global::AutoClicker.Properties.Resources.turn_picture;
            this.turnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnPicture.Image = global::AutoClicker.Properties.Resources.turn_picture;
            this.turnPicture.Location = new System.Drawing.Point(253, 5);
            this.turnPicture.Name = "turnPicture";
            this.turnPicture.Size = new System.Drawing.Size(25, 25);
            this.turnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turnPicture.TabIndex = 2;
            this.turnPicture.TabStop = false;
            this.turnPicture.Click += new System.EventHandler(this.turnPicture_Click);
            // 
            // closePicture
            // 
            this.closePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.closePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePicture.Image = global::AutoClicker.Properties.Resources.close_picture;
            this.closePicture.Location = new System.Drawing.Point(275, 5);
            this.closePicture.Name = "closePicture";
            this.closePicture.Size = new System.Drawing.Size(25, 25);
            this.closePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePicture.TabIndex = 1;
            this.closePicture.TabStop = false;
            this.closePicture.Click += new System.EventHandler(this.closePicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("The Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bot for fishing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MainPanel.Controls.Add(this.groupBoxButton2);
            this.MainPanel.Controls.Add(this.groupBoxButton1);
            this.MainPanel.Controls.Add(this.labelY);
            this.MainPanel.Controls.Add(this.labelX);
            this.MainPanel.Controls.Add(this.textBoxForY);
            this.MainPanel.Controls.Add(this.textBoxForX);
            this.MainPanel.Controls.Add(this.buttonPickLoc);
            this.MainPanel.Controls.Add(this.buttonStop);
            this.MainPanel.Controls.Add(this.buttonStart);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.textBoxForWrite);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(300, 270);
            this.MainPanel.TabIndex = 1;
            // 
            // groupBoxButton2
            // 
            this.groupBoxButton2.Controls.Add(this.radioButton4);
            this.groupBoxButton2.Controls.Add(this.radioButton3);
            this.groupBoxButton2.Location = new System.Drawing.Point(153, 157);
            this.groupBoxButton2.Name = "groupBoxButton2";
            this.groupBoxButton2.Size = new System.Drawing.Size(140, 31);
            this.groupBoxButton2.TabIndex = 14;
            this.groupBoxButton2.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(64, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "DOUBLE";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtonDoubleClick_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(10, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ONE";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonOneClick_CheckedChanged);
            // 
            // groupBoxButton1
            // 
            this.groupBoxButton1.Controls.Add(this.radioButton2);
            this.groupBoxButton1.Controls.Add(this.radioButton1);
            this.groupBoxButton1.Location = new System.Drawing.Point(7, 157);
            this.groupBoxButton1.Name = "groupBoxButton1";
            this.groupBoxButton1.Size = new System.Drawing.Size(140, 31);
            this.groupBoxButton1.TabIndex = 13;
            this.groupBoxButton1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(73, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "RIGHT";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(10, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LEFT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Panton", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.ForeColor = System.Drawing.Color.White;
            this.labelY.Location = new System.Drawing.Point(249, 124);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 22);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Panton", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(186, 124);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 22);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxForY
            // 
            this.textBoxForY.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxForY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForY.Font = new System.Drawing.Font("Panton SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForY.ForeColor = System.Drawing.Color.White;
            this.textBoxForY.Location = new System.Drawing.Point(232, 93);
            this.textBoxForY.Name = "textBoxForY";
            this.textBoxForY.ReadOnly = true;
            this.textBoxForY.Size = new System.Drawing.Size(53, 26);
            this.textBoxForY.TabIndex = 10;
            this.textBoxForY.Text = "0";
            this.textBoxForY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxForX
            // 
            this.textBoxForX.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxForX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForX.Font = new System.Drawing.Font("Panton SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForX.ForeColor = System.Drawing.Color.White;
            this.textBoxForX.Location = new System.Drawing.Point(167, 93);
            this.textBoxForX.Name = "textBoxForX";
            this.textBoxForX.ReadOnly = true;
            this.textBoxForX.Size = new System.Drawing.Size(53, 26);
            this.textBoxForX.TabIndex = 9;
            this.textBoxForX.Text = "0";
            this.textBoxForX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPickLoc
            // 
            this.buttonPickLoc.AutoSize = true;
            this.buttonPickLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPickLoc.ForeColor = System.Drawing.Color.White;
            this.buttonPickLoc.Location = new System.Drawing.Point(167, 47);
            this.buttonPickLoc.Name = "buttonPickLoc";
            this.buttonPickLoc.Size = new System.Drawing.Size(118, 36);
            this.buttonPickLoc.TabIndex = 8;
            this.buttonPickLoc.Text = "PICK LOCATION (F4)";
            this.buttonPickLoc.UseVisualStyleBackColor = true;
            this.buttonPickLoc.Click += new System.EventHandler(this.buttonPickLoc_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.AutoSize = true;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(174, 222);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(111, 36);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "STOP (F3)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(16, 222);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(111, 36);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "START (F2)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Panton", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "write the number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxForWrite
            // 
            this.textBoxForWrite.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxForWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForWrite.Font = new System.Drawing.Font("Panton SemiBold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForWrite.ForeColor = System.Drawing.Color.White;
            this.textBoxForWrite.Location = new System.Drawing.Point(16, 42);
            this.textBoxForWrite.Name = "textBoxForWrite";
            this.textBoxForWrite.Size = new System.Drawing.Size(100, 36);
            this.textBoxForWrite.TabIndex = 4;
            this.textBoxForWrite.Text = "1";
            this.textBoxForWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForWrite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxForWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForMins_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Panton ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Panton ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Click Interval";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Bot For Fishing";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBoxButton2.ResumeLayout(false);
            this.groupBoxButton2.PerformLayout();
            this.groupBoxButton1.ResumeLayout(false);
            this.groupBoxButton1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closePicture;
        private System.Windows.Forms.PictureBox turnPicture;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxForWrite;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPickLoc;
        private System.Windows.Forms.TextBox textBoxForX;
        private System.Windows.Forms.TextBox textBoxForY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBoxButton1;
        private System.Windows.Forms.GroupBox groupBoxButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

