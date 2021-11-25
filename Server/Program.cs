using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    class Program
    {
        static private int localPort = 23456;
        static private List<int> remotePort = new List<int>();
        static private List<string> ip = new List<string>();

        static private void startServer()
        {
            UdpClient client = new UdpClient(localPort);
            while (true)
            {
                IPEndPoint IP = null;
                byte[] bytes = client.Receive(ref IP); 
                string message = Encoding.Default.GetString(bytes);
                string[] data = message.Split(' ');
                if (data[0] == "/conect")
                {
                    try
                    {
                        ip.Add(IP.Address.ToString());
                        remotePort.Add(Convert.ToInt32(data[1]));
                        Console.WriteLine($"User {IP.Address.ToString()}:{data[1]} ({data[2]}) conected");
                    }
                    catch { }
                }
                else if(data[0] == "/message")
                {
                    for (int i = 0; i < ip.Count; i++)
                    {
                        string str = "";
                        for(int j = 2; j < data.Length;j++)
                        {
                            str += data[j] + " ";
                        }
                        sendMessage($"{data[1]}: {str}\t\t\t\t{DateTime.Now}", ip[i], remotePort[i]);
                    }
                }
            }
        }
        static private void sendMessage(string message, string ip, int port)
        {
            UdpClient client = new UdpClient();
            byte[] bytes = Encoding.Default.GetBytes(message);
            client.Send(bytes, bytes.Length, ip, port);
            client.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Server started");

            startServer();
        }
    }
}