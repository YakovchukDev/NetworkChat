using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace ClientConsole
{
    class Program
    {
        static private string ip = "127.0.0.1";
        static private int localPort;
        static private int remotePort;
        static private int str = 5;
        static private void sendMessage(string message)
        {
            UdpClient client = new UdpClient();
            byte[] bytes = Encoding.Default.GetBytes(message);
            client.Send(bytes, bytes.Length, ip, remotePort);
            
            client.Close();
        }
        static private string receiveMessage()
        {
            UdpClient client = new UdpClient(localPort);
            IPEndPoint remoteEP = null;
            byte[] bytes = client.Receive(ref remoteEP);
            string data = Encoding.Default.GetString(bytes);
            Console.SetCursorPosition(0, str++);
            Console.WriteLine(data);
            Console.SetCursorPosition(15, 0);
            client.Close();
            return data;
        }
        static void Main(string[] args)
        {
            Console.Write("Local port: ");
            localPort = Convert.ToInt32(Console.ReadLine());
            Console.Write("Remote port(23456): ");
            remotePort = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write Your Name(1 word): ");
            string name = Console.ReadLine();

            sendMessage($"/conect {localPort} {name}");


            Task.Run(() => 
            {
                while (true)
                {
                    receiveMessage();
                }
            });

            Console.Clear();

            Console.Write("Your message: ");
            while (true)
            {
                Console.SetCursorPosition(15, 0);
                Console.WriteLine("\t\t\t\t\t\t");
                Console.SetCursorPosition(15, 0);
                string message = Console.ReadLine();

                sendMessage($"/message {name} {message}");
            }
        }
    }
}
