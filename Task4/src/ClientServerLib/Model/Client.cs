﻿using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace ClientServerLib.Model
{
    public class Client
    {
        /// <summary>
        /// Client name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Host ip address.
        /// </summary>
        public string IpAddress { get; private set; }

        /// <summary>
        /// Host port.
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Tcp client for to connect to the server.
        /// </summary>
        public TcpClient TcpClient { get; private set; }

        /// <summary>
        /// Through this object, you can send messages to the server or, conversely, receive data from the server.
        /// </summary>
        public NetworkStream NetworkStream { get; private set; }

        /// <summary>
        /// Sending message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Constructor <see cref="Client"/>
        /// </summary>
        /// <param name="name">Client name.</param>
        /// <param name="ipAddress">Host ip address.</param>
        /// <param name="port">Host port.</param>
        public Client(string name, string ipAddress, int port)
        {
            Name = name;
            Port = port;
            IpAddress = ipAddress;

            try
            {
                TcpClient = new TcpClient(IpAddress, Port);
            }
            catch (SocketException)
            {
                throw new Exception("Connection Error");
            }
        }

        /// <summary>
        /// Method for exchanging messages with the server.
        /// </summary>
        public void OpenStream()
        {
            byte[] data = new byte[64];
            try
            {
                NetworkStream = TcpClient.GetStream();
                string message = string.Empty;
                while (true)
                {
                    message = string.Format("Client name: {0}; Client message: {1}", Name, Message);

                    data = Encoding.Unicode.GetBytes(message);
                    NetworkStream.Write(data, 0, data.Length);
                    break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Debug.WriteLine("Client stop");
                if (TcpClient != null)
                    TcpClient.Close();
            }
        }
    }
}