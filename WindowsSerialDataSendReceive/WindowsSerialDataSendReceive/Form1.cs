using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsSerialDataSendReceive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool isConnect = serialConnect();
            if (!isConnect)
            {
                MessageBox.Show("SerialPort Open Error");
            }
            else
            {
                MessageBox.Show("SerialPort Open OK");
            }

        }

        public bool serialConnect()
        {
            serialPort.PortName = "COM1";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.RtsEnable = false;
            serialPort.DtrEnable = false;
            try
            {
                serialPort.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            int ReceiveData = serialPort.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            richTextBox_received.Text = richTextBox_received.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
        }


        private void button1_Click(object sender, EventArgs e)
        {
            byte[] datas = new byte[255];
            datas[0] = 0x31;
            if (serialPort.IsOpen) serialPort.Write(datas, 0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
