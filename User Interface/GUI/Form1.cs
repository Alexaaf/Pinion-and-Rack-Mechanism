using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            statusBar.Value = 0;
            label_status.Text = "DISCONNECTED";
            label_status.ForeColor = Color.Red;

            baudRateComboBox.Text = "9600";
            string[] portList = SerialPort.GetPortNames();
            comPortComboBox.Items.AddRange(portList);

        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPortComboBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudRateComboBox.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                statusBar.Value = 100;
                label_status.Text = "CONNECTED";
                label_status.ForeColor = Color.Green;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    button_open.Enabled = true;
                    button_close.Enabled = false;
                    statusBar.Value = 0;
                    label_status.Text = "DISCONNECTED";
                    label_status.ForeColor = Color.Red;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSent.Text + "S");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            richTextBox_textRecived.Text += serialDataIn;
        }

        private void richTextBox_textRecived_TextChanged(object sender, EventArgs e)
        {
            richTextBox_textRecived.SelectionStart = richTextBox_textRecived.Text.Length;
            richTextBox_textRecived.ScrollToCaret();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSent.Text + "P");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setSpeed_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSent.Text + "S");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
