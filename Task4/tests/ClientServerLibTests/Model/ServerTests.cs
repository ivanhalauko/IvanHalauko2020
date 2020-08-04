using NUnit.Framework;
using System.Threading;

namespace ClientServerLib.Model.Tests
{
    [TestFixture()]
    public class ServerTest
    {
        [TestCase("Ivan", "127.0.0.1", 8895)]
        public void GivenServerWhenInitInstancTheOutIsTwoClients(string actualNameOne, string actualIp, int actualPort)
        {
            //Arrange
            Server tcpServer = new Server(actualPort);
            Thread serverThread = new Thread(new ThreadStart(tcpServer.Start));
            serverThread.Start();

            Client tcpClientOne = new Client(actualNameOne, actualIp, actualPort);
            Thread clientThreadOne = new Thread(new ThreadStart(tcpClientOne.OpenStream));
            clientThreadOne.Start();

            tcpClientOne.OpenStream();

            //Assert
            Assert.AreEqual(tcpServer.ServersClients.Count, 1);
        }
    }
}