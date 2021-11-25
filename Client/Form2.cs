using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Form2 : Form
    {
        static private string ip = "127.0.0.1";
        static private int localPort = Form1.LocalPort;
        static private int remotePort = Form1.RemotePort;
        static private string userName = Form1.UserName;

        static private void sendMessage(string message)
        {
            UdpClient client = new UdpClient();
            byte[] bytes = Encoding.Default.GetBytes(message);
            client.Send(bytes, bytes.Length, ip, remotePort);

            client.Close();
        }
        private string receiveMessage()
        {
            UdpClient client = new UdpClient(localPort);
            IPEndPoint remoteEP = null;
            byte[] bytes = client.Receive(ref remoteEP);
            string data = Encoding.Default.GetString(bytes);

            client.Close();
            return data;
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMessage($"/message {userName} {textBox1.Text}");
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                while (true)
                {
                    string message = receiveMessage();
                    listBox1.Invoke(new Action(() =>
                    {
                        listBox1.Items.Add(message);
                    }));
                }
            });
        }
    }
}
