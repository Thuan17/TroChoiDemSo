using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server
{
    public partial class Form1 : Form
    {
        public TcpClient client;
        public TcpListener listener;
        public Thread thread;
        public BinaryReader reader;
        public BinaryWriter writer;
        public NetworkStream stream;


        //client 2 
        private TcpClient client1;
        private BinaryReader reader1;
        private BinaryWriter writer1;
        public NetworkStream stream1;

        public Form1()
        {
            InitializeComponent();

            listener = new TcpListener(IPAddress.Any, 3000);

        }


        public delegate void dlgFunc(string text);

        public void invokeFn(string text)
        {
            this.Invoke(new dlgFunc(upChat), new object[] { text });
        }
        //up chat listbox
        public void upChat(string Text)
        {
            this.list_Client.Items.Add(Text);

        }
        
        //cap nhat trang thai server
        public void upTrangThai(string text)
        {
            if (serverStatusLabel.InvokeRequired)
            {
                serverStatusLabel.Invoke(new Action(() => serverStatusLabel.Text = text));
                serverStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                //string loi = "Lỗi trjang thái";
                serverStatusLabel.ForeColor = Color.Green;
                serverStatusLabel.Text = text;


            }
        }
        //nhan tu client
        public void nhanClient(string dulieu)
        {
            if (receivedDataTextBox.InvokeRequired)
            {
                receivedDataTextBox.Invoke(new Action(() => receivedDataTextBox.AppendText(dulieu + Environment.NewLine)));
                upChat(dulieu); 
            }
            else 
            {
                receivedDataTextBox.AppendText(dulieu + Environment.NewLine);
            }
        }
        //mod 10 
        public int Mod10(int num)
        {
            int kq = num % 10;
            return kq;
        }
        //Tinh diem 
        public void DiemSo(int number)
        {
            ////string chuoi = receivedDataTextBox.Text.Trim();
            ////double number = Convert.ToDouble(chuoi);

            if (number < 1 || number > 9999)
            {
                string xinchao = "Lỗi Số";
                writer.Write(xinchao);
            }
            else 
            {
                int kq = Mod10(number);
                string chuyen1=Convert.ToString(kq);  
                MessageBox.Show(chuyen1);
            }


            //    string chuyen = Convert.ToString(diem);
            //MessageBox.Show(chuyen);

        }

        //start Server
        public void startServer() 
        {
            listener.Start();
            client=listener.AcceptTcpClient();
            stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);
            while (true)
            {
                try
                {

                    if (client.Connected)
                    {
                        string xinchao = txtNoiDung.Text;
                        writer.Write(xinchao);


                        string text;
                        while ((text = reader.ReadString()) != string.Empty)
                        {
                            invokeFn(text);
                            //string receivedData = reader.ReadString();
                            //nhanClient(receivedData);
                            //upChat(receivedData);
                        }
                     

                    }
                    
                    else
                    {
                        MessageBox.Show("Không có client");

                    }
                    
                }
                catch (Exception e)
                {
                    upTrangThai("Kết nối đã đóng.");
                    break;
                }
            }

          


        }
       
       



        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(startServer);
            thread.Start();
            upTrangThai("Máy chủ hoạt động");
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string xinchao = txtNoiDung.Text;

            if (xinchao != string.Empty)
            {
                writer.Write(xinchao);
            }
            //if (client.Connected)
            //{
            //    string xinchao = txtNoiDung.Text;

            //    if (xinchao != string.Empty)
            //    {
            //        writer.Write(xinchao);
            //    }
            //    else
            //    {
            //        upChat("Không có client");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không có client");

            //}
            //string receivedData = reader.ReadString();
            //nhanClient(receivedData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receivedData = receivedDataTextBox.Text;
            int diem = Convert.ToInt32(receivedData);
            DiemSo(diem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
