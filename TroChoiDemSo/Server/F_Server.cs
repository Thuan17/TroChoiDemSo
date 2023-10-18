using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server
{
    public partial class F_Server : Form
    {




        private TcpListener listener;
        private Thread serverThread;
        private TcpClient client1;
        private TcpClient client2;
        private BinaryReader reader1;
        private BinaryReader reader2;
        private BinaryWriter writer1;
        private BinaryWriter writer2;





        public F_Server()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Any, 3000); //
        }



        public delegate void dlgFunc(string text);

        public void invokeFn(string text)
        {
            this.Invoke(new dlgFunc(upChat), new object[] { text });

        }
        public void invokeFn2(string text)
        {
            this.Invoke(new dlgFunc(upChat), new object[] { text });

        }
        //up chat listbox
        public void upChat(string Text)
        {
            this.list_Client.Items.Add(Text);

        }

        private void StartServer()
        {
            listener.Start();

            client1 = listener.AcceptTcpClient();
            client2 = listener.AcceptTcpClient();
            UpdateServerStatus($"Đã kết nối với {((IPEndPoint)client1.Client.RemoteEndPoint).Address}:{((IPEndPoint)client1.Client.RemoteEndPoint).Port} và {((IPEndPoint)client2.Client.RemoteEndPoint).Address}:{((IPEndPoint)client2.Client.RemoteEndPoint).Port}");
            //DiemSo();


            NetworkStream stream1 = client1.GetStream();
            NetworkStream stream2 = client2.GetStream();

            Thread client1Thread = new Thread(() => HandleClient(client1, reader1, writer1));
            Thread client2Thread = new Thread(() => HandleClient(client2, reader2, writer2));

            reader1 = new BinaryReader(stream1);
            reader2 = new BinaryReader(stream2);

            client1Thread.Start();
            client2Thread.Start();

            writer1 = new BinaryWriter(stream1);
            writer2 = new BinaryWriter(stream2);
            writer1.Write("Chao client");
            writer2.Write("Chao client");

            while (true)
            {
                writer1.Write("Nhập Điểm");
                writer2.Write("Nhập Điểm");

                string receivedData = reader1.ReadString();
                string receivedData2 = reader2.ReadString();
              
                invokeFn("Điểm Client 1 :" + receivedData);
                invokeFn2("Điểm Client 2:" + receivedData2);
                Random(receivedData, receivedData2);
            }

        }
     



        public void Random(string reader1, string reader2)
        {
           

            int a, b;
           
            double kq, kq1;
            string text = txtDiemClient1.Text;
            a = Convert.ToInt32(reader1);
            b = Convert.ToInt32(reader2);

            Random random = new Random();
            int randomNumber = random.Next(1, 10000);

            double CL1_mod10 = randomNumber % 10;

            string C_RanDom = Convert.ToString(randomNumber);
            writer1.Write("Số ngẫu nhiên : " + randomNumber);
            writer1.Write("Kết quả số ngẫu nhiên" + CL1_mod10);

            Random random2 = new Random();
            int randomNumber2 = random.Next(1, 10000);
            double CL2_mod10 = randomNumber2 % 10;

            string C_RanDom2 = Convert.ToString(randomNumber2);
            writer2.Write("Số ngẫu nhiên" + randomNumber2);
            writer2.Write("Kết quả số ngẫu nhiên" + CL2_mod10);

            string thang = "Bạn đã thắng";
            string thua = "Bạn đã thua";
            string hoa = "Hai bạn đã hòa";
            string update = "Cập nhật số điểm ";
            if (CL1_mod10 > CL2_mod10)
            {
                //a>b
                int Cong = Tinh(10, b);
                int Tru = Tinh(10, -b);

                writer1.Write(thang);
                writer1.Write(update + Cong);
                writer2.Write(thua);
                writer2.Write(update + Tru);


            }
            else if (CL1_mod10 == CL2_mod10)
            {
                writer1.Write(hoa);
                writer2.Write(hoa);
            }
            else
            {
                
                int Cong = Tinh(10, a);
                int Tru = Tinh(10, -a);

                writer1.Write(thua);
                writer1.Write(update + Tru);
                writer2.Write(update + Cong);
                writer2.Write(thang);
            }
        }


        public int Tinh(int currentScore, int change)
        {
            int updatedScore = currentScore + change;
            return updatedScore;    
        }

        public void listenClient(string reader1, string reader2)
        {
            int a, b;
            int diem = 10;
            string text = txtDiemClient1.Text;
           
            a=Convert.ToInt32(reader1); 
            b=Convert.ToInt32(reader2);
            
            if (text != string.Empty)
            {
                writer1.Write("Điểm :" + text);
                writer2.Write("Điểm :" + text);
            }
            else
            {
                writer1.Write("Điểm :" + diem);
                writer2.Write("Điểm :" + diem);
            }
        }



        //2 client nhắn với nhau
        private void HandleClient(TcpClient client,BinaryReader reader, BinaryWriter writer)
        {
            while (true)
            {
                try
                {
                    string text;
                    text = reader.ToString();
                }
                catch (IOException ex)
                {
                    // Kết nối đã đóng.
                    UpdateServerStatus("Kết nối đã đóng.");
                    break;
                }
            }
        }

        private void UpdateServerStatus(string status)
        {
            if (serverStatusLabel.InvokeRequired)
            {

                serverStatusLabel.Invoke(new Action(() => serverStatusLabel.Text = status));
                //serverStatusLabel.Text = "Chưa có kết nối client";
             serverStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                serverStatusLabel.Text = status;
                serverStatusLabel.ForeColor = Color.Red;
            }
        }
        private void UpdateReceivedData(string data)
        {
            if (serverStatusLabel.InvokeRequired)
            {
                serverStatusLabel.Invoke(new Action(() => serverStatusLabel.Text = data)); 
            }
            else
            {
                serverStatusLabel.Text = data;
            }
        }

        private void UpdateSentData(string data)
        {
            if (txtDiemClient1.InvokeRequired)
            {
                txtDiemClient1.Invoke(new Action(() => txtDiemClient1.AppendText(data + Environment.NewLine)));
            }
            else
            {
                txtDiemClient1.AppendText(data + Environment.NewLine);
            }
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            serverThread = new Thread(StartServer);
            serverThread.Start();
            UpdateServerStatus("Máy chủ đang chạy...");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (client1.Connected || client2.Connected)
            {

                listener.Stop();
                UpdateServerStatus("Tạm dừng Máy chủ đang chạy...");
                writer1.Write("Máy chủ tạm dừng...");
                writer2.Write("Máy chủ tạm dừng...");
            }
            else
            {
                listener.Stop();
                UpdateServerStatus("Tạm dừng Máy chủ đang chạy...");
            }
            
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string noidung = txtNoiDung.Text;
            if (client1.Connected && client2.Connected)
            {
                writer1.Write("Server gửi:"+noidung);
                writer2.Write("Server gửi:" + noidung);
            }
            else
            {
                MessageBox.Show("khoong co ket noi");
            }
        }


        List<Client_List> list = new List<Client_List>();
        private void addList_Click(object sender, EventArgs e)
        {
            NetworkStream stream1 = client1.GetStream();
            NetworkStream stream2 = client2.GetStream();
            reader1 = new BinaryReader(stream1);
            reader2 = new BinaryReader(stream2);
            string name = reader1.ReadString();



            int diem = 50;
            list.Add(new Client_List { Name = name, Diem = diem });
            foreach (Client_List person in list)
            {
                MessageBox.Show($"Name: {person.Name} {person.Diem}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkStream stream1 = client1.GetStream();
            reader1 = new BinaryReader(stream1);
        }
    }
}
