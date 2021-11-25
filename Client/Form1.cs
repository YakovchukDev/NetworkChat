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
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        static public string UserName;
        static public int RemotePort;
        static public int LocalPort;

        static private string ip = "127.0.0.1";
        public Form1()
        {
            InitializeComponent();
        }
        static private void sendMessage(string message)
        {
            UdpClient client = new UdpClient();
            byte[] bytes = Encoding.Default.GetBytes(message);
            client.Send(bytes, bytes.Length, ip, RemotePort);

            client.Close();
        }

        private void Conect_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text != "" && RemotePortTB.Text != "" && LocalPortTB.Text != "")
            {
                UserName = UserNameTB.Text;
                RemotePort = Convert.ToInt32(RemotePortTB.Text);
                LocalPort = Convert.ToInt32(LocalPortTB.Text);

                sendMessage($"/conect {LocalPort} {UserName}");

                Form2 form2 = new Form2();
                form2.Show();

                this.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
