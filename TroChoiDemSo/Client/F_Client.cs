using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class F_Client : Form
    {
        public F_Client()
        {
            InitializeComponent();
        }

        private TcpClient client;
        private BinaryReader reader;
        private BinaryWriter writer;
        public Thread thread;
        public delegate void dlgFunc(string text);

        public void invokeFn(string text)
        {
            this.Invoke(new dlgFunc(upChat), new object[] { text });
        }
        public void upChat(string Text)
        {
            this.list_Client.Items.Add(Text);


        }
        private void UpdateClientStatus(string status)
        {
            if (clientStatusLabel.InvokeRequired)
            {
                clientStatusLabel.Invoke(new Action(() => clientStatusLabel.Text = status));
            }
            else
            {
                clientStatusLabel.Text = status;
            }
        }
        //private void UpdateReceivedData(string data)
        //{
        //    if (receivedDataTextBox.InvokeRequired)
        //    {
        //        receivedDataTextBox.Invoke(new Action(() => receivedDataTextBox.AppendText(data + Environment.NewLine)));
        //    }
        //    else
        //    {
        //        receivedDataTextBox.AppendText(data + Environment.NewLine);
        //    }
        //}

        //private void UpdateSentData(string data)
        //{
        //    if (sentDataTextBox.InvokeRequired)
        //    {
        //        sentDataTextBox.Invoke(new Action(() => sentDataTextBox.AppendText(data + Environment.NewLine)));
        //    }
        //    else
        //    {
        //        sentDataTextBox.AppendText(data + Environment.NewLine);
        //    }
        //}

        //listenServer
        public void listenServer()
        {
            while (true)
            {
                try
                {
                    string text;
                    while ((text = reader.ReadString()) != string.Empty)
                    {
                        invokeFn("\n");
                        invokeFn(text);

                    }
                }
                catch
                {
                    invokeFn("Mất kết nối");
                }
            }

        }
        //connectServer
        public void conServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 3000);
                if (client.Connected && client != null)
                {
                     // Đổi thành địa chỉ IP và cổng của máy chủ.

                    NetworkStream stream = client.GetStream();
                    reader = new BinaryReader(stream);
                    writer = new BinaryWriter(stream);

                    //string receivedData = reader.ReadString();
                    //invokeFn(receivedData);

                    thread = new Thread(listenServer);
                    thread.Start();
                    UpdateClientStatus("Đã kết nối đến máy chủ.");
                }
                else
                { 
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối đến máy chủ: {ex.Message}");
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.conServer();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

            if (client != null && client.Connected)
            {
                string dataToSend = sendDataTextBox.Text;
                int chuyen = Convert.ToInt32(dataToSend);
                if (chuyen <= 5)
                {
                    writer.Write(dataToSend);
                }
                else
                {
                    MessageBox.Show("Điểm bé hơn 5 ");
                }
            }
            else
            {
                MessageBox.Show("Chưa có kết nối với máy chủ.");
            }
        }
    }
}
