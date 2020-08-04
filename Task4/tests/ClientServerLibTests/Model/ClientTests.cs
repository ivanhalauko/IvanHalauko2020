using NUnit.Framework;
using ClientServerLib.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClientServerLibTests.Model
{
    /// <summary>
    /// Class for testing client class.
    /// </summary>
    [TestFixture()]
    public class ClientTests
    {
        /// <summary>
        /// Test for testing client class.
        /// </summary>
        [TestCase()]
        public void GivenOpenStreamWhenServerIsStartedTheOutIsConnectedTrue()
        {
            //Arrange
            Server tcpServer = new Server(8889);
            Thread serverThread = new Thread(new ThreadStart(tcpServer.Start));
            serverThread.Start();

            Client tcpClient = new Client("ClientOne", "127.0.0.1", 8889);
            Thread clientThread = new Thread(new ThreadStart(tcpClient.OpenStream));
            clientThread.Start();

            //Assert
            Assert.AreEqual(true, tcpClient.TcpClient.Connected);
        }

        /// <summary>
        /// Test for testing client class.
        /// </summary>
        /// <param name="actualName">Client name.</param>
        /// <param name="actualIp">Ip-adress.</param>
        /// <param name="actualPort">Port connection.</param>
        [TestCase("Ivan", "127.0.0.1", 8887)]
        public void GivenClientWhenInitInstancTheOutString(string actualName, string actualIp, int actualPort)
        {
            //Arrange
            Server tcpServer = new Server(8887);
            Thread serverThread = new Thread(new ThreadStart(tcpServer.Start));
            serverThread.Start();

            Client tcpClient = new Client(actualName, actualIp, actualPort);

            //Assert
            Assert.AreEqual("Ivan 127.0.0.1 8887", string.Format("{0} {1} {2}", actualName, actualIp, actualPort));
        }
    }
}