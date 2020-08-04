﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ClientServerLib.Repositories;

namespace ClientServerLib.Model
{
    public class Server
    {
        /// <summary>
        /// Field TcpListener's class.
        /// </summary>
        static TcpListener tcpListener;

        /// <summary>
        /// Server port.
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// List of client connections on the server.
        /// </summary>
        public List<ClientsConnections> ServersClients { get; private set; }

        /// <summary>
        /// A list to store each client’s messages.
        /// </summary>
        public List<ClientMessageRepository> MessagesFromClients { get; private set; }

        /// <summary>
        /// Constructor <see cref="Server"/>
        /// </summary>
        /// <param name="port">Server port.</param>
        public Server(int port)
        {
            Port = port;
        }

        /// <summary>
        /// Server launch.
        /// </summary>
        public void Start()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, Port);
                tcpListener.Start();
                Debug.WriteLine("Waiting for connection... ");
                int clientId = 0;

                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Debug.WriteLine(String.Format("Client with id: {0} connected.", clientId));
                    ClientsConnections serverClient = new ClientsConnections(client, this, clientId);
                    Thread listenThread = new Thread(new ThreadStart(serverClient.OpenStream));
                    listenThread.Start();

                    MessagesFromClients.Add(new ClientMessageRepository(serverClient));
                    clientId++;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (tcpListener != null)
                {
                    Debug.WriteLine("Server stop");
                    tcpListener.Stop();
                }
            }
        }

        /// <summary>
        /// Adding a new connected client to the collection.
        /// </summary>
        /// <param name="newClientOnTheServer"> A new client on the server.</param>
        internal void AddClientConnection(ClientsConnections newClientOnTheServer)
        {
            ServersClients.Add(newClientOnTheServer);
        }
    }
}
