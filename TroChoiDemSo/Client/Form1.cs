using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Client
{
    public partial class Form1 : Form
    {
        public TcpClient client;
        public TcpListener listener;
        public Thread thread;
        public BinaryReader reder;
        public BinaryWriter writer;
        public NetworkStream stream;



      
        public Form1()
        {
            InitializeComponent();
        }


        public delegate void dlgFunc(string text);

        public void invokeFn(string text)
        {
            this.Invoke(new dlgFunc(upChat), new object[] { text });
        }
        public void upChat(string Text)
        {
            this.list_Client.Items.Add(Text);

        }

        //ket noi Server
        public void conectServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 3000);
                stream = client.GetStream();
                reder = new BinaryReader(stream, Encoding.UTF8);
                writer = new BinaryWriter(stream);


                thread = new Thread(listenServer);
                thread.Start();

                //receivedDataTextBox.Text = reder.ReadString();

                clientStatusLabel.Text = "Đã kết nối với máy chủ";


            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến máy chủ");

            }
        }

        //listenServer
        public void listenServer() 
        {
            try {
                string text;
                while ((text = reder.ReadString()) != string.Empty)
                {
                    invokeFn(text);
                }
            }catch 
            {
                invokeFn("Mất kết nối");
            }
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.conectServer();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                string dataToSend = sendDataTextBox.Text;
                writer.Write(dataToSend);
                MessageBox.Show("Đã gửi thành công");
            }
            else
            {
                MessageBox.Show("Chưa kết nối máy chủ");
            }
        }


        // nhan du lieu tu Server
        public void nhanServer(string text)
        {
            if (receivedDataTextBox.InvokeRequired)
            {
                receivedDataTextBox.Invoke(new Action(() => receivedDataTextBox.AppendText(text + Environment.NewLine)));
            }
            else 
            {
                receivedDataTextBox.AppendText((text + Environment.NewLine));   
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sentDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhận số");

            }   
            
        }
    }
}
