using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDControllerApplication
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshSerialPorts();
        }

        private void RefreshSerialPorts()
        {
            try
            {
                serialDevices.Items.Clear();
                foreach (string portName in SerialPort.GetPortNames())
                {
                    serialDevices.Items.Add(portName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ConnectToSerialDevice(string portName)
        {
            try
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                MessageBox.Show("Conectado a porta: " + portName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar: " + ex.Message);
            }
        }

        private void KdTracker_Scroll(object sender, EventArgs e)
        {
            KdNumeric.Value = KdTracker.Value; 
        }

        private void KiTracker_Scroll(object sender, EventArgs e)
        {
            KiNumeric.Value = KiTracker.Value;
        }

        private void KpTracker_Scroll(object sender, EventArgs e)
        {
            KpNumeric.Value = KpTracker.Value;
        }

        private void KpNumeric_ValueChanged(object sender, EventArgs e)
        {
            KpTracker.Value = (int)KpNumeric.Value;
        }

        private void KiNumeric_ValueChanged(object sender, EventArgs e)
        {
            KiTracker.Value = (int)KiNumeric.Value;
        }

        private void KdNumeric_ValueChanged(object sender, EventArgs e)
        {
            KdTracker.Value = (int)KdNumeric.Value;
        }
        private ConstantsProtocol GenerateProtocol()
        {
            ConstantsProtocol protocol = new ConstantsProtocol();
            double kp = (double)KpNumeric.Value;
            double ki = (double)KiNumeric.Value;
            double kd = (double)KdNumeric.Value;
            protocol.UpdateKP(kp);
            protocol.UpdateKI(ki);
            protocol.UpdateKD(kd);

            return protocol;
        }
        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    MessageBox.Show("Você esqueceu de se connectar ao robô");
                    return;
                }
                string toSend = GenerateProtocol().GenerateProtocolString();
                MessageBox.Show(toSend);
                serialPort.Write(toSend);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            string selectedPort = serialDevices.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Conecte-se ao robô");
                return;
            }

            ConnectToSerialDevice(selectedPort);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshSerialPorts();
        }
    }
}
