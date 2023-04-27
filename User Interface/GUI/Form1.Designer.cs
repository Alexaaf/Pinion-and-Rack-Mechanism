namespace GUI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.setSpeed_button = new System.Windows.Forms.Button();
            this.goToPosition_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_textSent = new System.Windows.Forms.TextBox();
            this.richTextBox_textRecived = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM10";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // setSpeed_button
            // 
            this.setSpeed_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setSpeed_button.Location = new System.Drawing.Point(672, 230);
            this.setSpeed_button.Name = "setSpeed_button";
            this.setSpeed_button.Size = new System.Drawing.Size(102, 46);
            this.setSpeed_button.TabIndex = 2;
            this.setSpeed_button.Text = "Set Speed";
            this.setSpeed_button.UseVisualStyleBackColor = false;
            this.setSpeed_button.Click += new System.EventHandler(this.setSpeed_button_Click);
            // 
            // goToPosition_button
            // 
            this.goToPosition_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goToPosition_button.Location = new System.Drawing.Point(498, 230);
            this.goToPosition_button.Name = "goToPosition_button";
            this.goToPosition_button.Size = new System.Drawing.Size(102, 46);
            this.goToPosition_button.TabIndex = 7;
            this.goToPosition_button.Text = "Go to Position";
            this.goToPosition_button.UseVisualStyleBackColor = false;
            this.goToPosition_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "COM PORT:";
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(123, 31);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 24);
            this.comPortComboBox.TabIndex = 9;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(123, 84);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.baudRateComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "BAUD RATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "STATUS:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(130, 184);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(114, 16);
            this.label_status.TabIndex = 13;
            this.label_status.Text = "DISCONNECTED";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(123, 135);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(121, 23);
            this.statusBar.TabIndex = 14;
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_open.ForeColor = System.Drawing.Color.White;
            this.button_open.Location = new System.Drawing.Point(30, 230);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(102, 46);
            this.button_open.TabIndex = 15;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(142, 230);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(102, 46);
            this.button_close.TabIndex = 16;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_textSent
            // 
            this.textBox_textSent.Location = new System.Drawing.Point(498, 34);
            this.textBox_textSent.Name = "textBox_textSent";
            this.textBox_textSent.Size = new System.Drawing.Size(276, 22);
            this.textBox_textSent.TabIndex = 17;
            // 
            // richTextBox_textRecived
            // 
            this.richTextBox_textRecived.Location = new System.Drawing.Point(498, 84);
            this.richTextBox_textRecived.Name = "richTextBox_textRecived";
            this.richTextBox_textRecived.Size = new System.Drawing.Size(276, 96);
            this.richTextBox_textRecived.TabIndex = 18;
            this.richTextBox_textRecived.Text = "";
            this.richTextBox_textRecived.TextChanged += new System.EventHandler(this.richTextBox_textRecived_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.richTextBox_textRecived);
            this.Controls.Add(this.textBox_textSent);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goToPosition_button);
            this.Controls.Add(this.setSpeed_button);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button setSpeed_button;
        private System.Windows.Forms.Button goToPosition_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_textSent;
        private System.Windows.Forms.RichTextBox richTextBox_textRecived;
    }
}

