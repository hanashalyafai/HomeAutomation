using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace HomeAutomation
{
    static class Socket
    {
        public static TcpListener tcpListener = null;
        public static NetworkStream stream = null;
        public static int port = 8888;
        public static TcpClient tcpClient { get; set; }
        public static byte[] msgBytes { get; set; }

        public static TcpClient client { get; set; }

        public static string serverIP = "localhost";

        internal static void init_socket()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                if (client != null)
                {
                  //  MessageBox.Show("clinet not null");
                }
                stream = client.GetStream();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        internal static void Close()
        {
            try
            {
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         
           public static void Write(string command)
        {
            NetworkStream stream;
            try
            {
                client = new TcpClient("localhost", 8888);
                data = System.Text.Encoding.ASCII.GetBytes(command);
                stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

            }
            catch (Exception ex)
            {

            }
        }
         */

        internal static void Read()
        {
            string str = "";

            byte[] msgBytes;
            while (true)
            {
                msgBytes = new byte[256];
                try
                {
                    stream.Read(msgBytes, 0, msgBytes.Length);

                }
                catch (Exception ex)
                {
                 //   MessageBox.Show("closing");
                    Application.Exit();
                }
                str = Encoding.ASCII.GetString(msgBytes, 0, msgBytes.Length);
                str = str.Substring(0, str.IndexOf('\0'));
              //  MessageBox.Show(str);
                if (str[0] != '\0')
                {
                 //   MessageBox.Show(str);
                    //MessageBox.Show(str.Length.ToString());
                  //  MessageBox.Show("sending ahooooooooooo");
                    Serial.write(str); // write any recieved data to serial port "no matter what!"..
                }

            }


        }

        internal static void Write(string data)
        {

            byte[] msgBytes = Encoding.ASCII.GetBytes(data);
            stream.Write(msgBytes, 0, msgBytes.Length);


        }


    }
}
