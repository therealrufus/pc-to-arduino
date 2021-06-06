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

namespace PC_to_Arduino__form_
{
    public partial class Form1 : Form
    {
        bool isConnected1 = false;
        bool isConnected2 = false;
        String[] ports;
        SerialPort port1;
        SerialPort port2;      

        public Form1()
        {   
            RichTextBox.CheckForIllegalCrossThreadCalls = true;            
            InitializeComponent();
            getAvailableComPorts();
            timer.reset(Timer, timerLabel, labSpeed);
            consoleRichText1.AppendText("Aviable ports:\n");

            void getAvailableComPorts()
            {
                disableControls(sendBtn1, ConnectBtn1, PortComBox1);
                disableControls(sendBtn2, ConnectBtn2, PortComBox2);
                ports = SerialPort.GetPortNames();
                Array.Sort(ports);
            }
            //nalezeni portu
            foreach (string port in ports)
            {
                PortComBox1.Items.Add(port);
                consoleRichText1.AppendText($"{port}\n");
                if (ports[0] != null)
                {
                    PortComBox1.SelectedItem = ports[0];
                }

                PortComBox2.Items.Add(port);
                consoleRichText2.AppendText($"{port}\n");
                if (ports[0] != null)
                {
                    PortComBox2.SelectedItem = ports[0];
                }
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (!isConnected1)
            {
                port1 = connectToArduino(PortComBox1, ConnectBtn1, consoleRichText1, sendBtn1, 1, port1);
            }
            else
            {
                port1 = disconnectFromArduino(ConnectBtn1, consoleRichText1, port1, sendBtn1, PortComBox1, 1);
            }
        }

        private void ConnectBtn2_Click(object sender, EventArgs e)
        {
            if (!isConnected2)
            {
                port2 = connectToArduino(PortComBox2, ConnectBtn2, consoleRichText2, sendBtn2, 2, port2);
            }
            else
            {
                port2 = disconnectFromArduino(ConnectBtn2, consoleRichText2, port2, sendBtn2, PortComBox2, 2);
            }
        }

        //pripojit k arduinu
        private SerialPort connectToArduino(ComboBox cbx, Button ConnectBtn, RichTextBox consoleRichText, Button sendBtn, int order, SerialPort port)
        {
            string selectedPort = cbx.GetItemText(cbx.SelectedItem);
            try
            {
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                if (order == 1)
                {
                    isConnected1 = true;
                }
                else
                {
                    isConnected2 = true;
                }
                port.Write("#STAR\n");
                ConnectBtn.Text = "Disconnect";
                enableControls(sendBtn, ConnectBtn, cbx);
                consoleRichText.AppendText($"connected to port {port.PortName}\n");
                consoleRichText.ScrollToCaret();
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception)
            {
                if (order == 1)
                {
                    isConnected1 = false;
                }
                else
                {
                    isConnected2 = false;
                }
                ConnectBtn.Text = "Connect";
                isConnected1 = false;
                MessageBox.Show("Přístup na port byl odepřen!", "Chyba" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return port;
        }

        //odpojit od arduina
        private SerialPort disconnectFromArduino(Button ConnectBtn, RichTextBox consoleRichText, SerialPort port, Button sendBtn, ComboBox cbx, int order)
        {
            if (order == 1)
            {
                isConnected1 = false;
            }
            else
            {
                isConnected2 = false;
            }
            disableControls(sendBtn, ConnectBtn, cbx);
            port.Write("#STOP\n");
            port.DiscardOutBuffer();
            port.Close();            
            ConnectBtn.Text = "Connect";
            consoleRichText.AppendText($"disconnected from port {port.PortName}\n");
            consoleRichText.ScrollToCaret();
            return port;
        }

        //prijimani dat
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (isConnected1)
            {
                consoleRichText1.AppendText(port1.ReadExisting());
                //consoleRichText1.ScrollToCaret();
            }
            if (isConnected2)
            {
                consoleRichText2.AppendText(port2.ReadExisting());
                //consoleRichText2.ScrollToCaret();
            }
        }

        //zapinani a vypinani controls
        private void disableControls(Button sendBtn, Button connectBtn, ComboBox portComBox)
        {
            sendBtn.Enabled = false;
            portComBox.Enabled = true;
            connectBtn.Enabled = true;
        }
        private void enableControls(Button sendBtn, Button connectBtn, ComboBox portComBox)
        {
            sendBtn.Enabled = true;
            portComBox.Enabled = false;
            connectBtn.Enabled = true;
        }

        //clear a send
        private void clearBtn_Click(object sender, EventArgs e)
        {
            consoleRichText1.Clear();
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            port1.Write(sendBox1.Text + "\n");
            consoleRichText1.AppendText(sendBox1.Text + "\n");
            sendBox1.Clear();
        }

        //clear 2 a send 2
        private void clearBtn2_Click(object sender, EventArgs e)
        {
            consoleRichText1.Clear();
        }
        private void sendBtn2_Click(object sender, EventArgs e)
        {
            port2.Write(sendBox2.Text + "\n");
            consoleRichText2.AppendText(sendBox2.Text + "\n");
            sendBox2.Clear();
        }

        //timer buttons
        private void button1_Click(object sender, EventArgs e)
        {
            timer.enable(Timer);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.disable(Timer);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            timer.reset(Timer, timerLabel, labSpeed);
        }

        //timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            double lenght = 0;
            if (rbTH.Checked)
            {
                lenght = Convert.ToDouble(6.4);
            }
            else
            {
                lenght = Convert.ToDouble(nudLenght.Value);
            }
            timer.tick(timerLabel, labSpeed, lenght);
        }

        private void rbTH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTH.Checked)
            {
                nudLenght.Enabled = false;
            }
            else
            {
                nudLenght.Enabled = true;
            }
        }
    }
}
