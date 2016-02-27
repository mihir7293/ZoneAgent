using System;
using System.Net.Sockets;
namespace ZoneAgent
{
    /// <summary>
    /// Class to maintain client information like networkstream,buffer,TCPClient and ClientId
    /// </summary>
    class Client
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tcpClient">TCPClient of client</param>
        /// <param name="buffer">buffer data</param>
        public Client(TcpClient tcpClient, byte[] buffer,int randomId)
        {
            if (tcpClient == null)
                throw new ArgumentNullException("tcpClient");
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            TcpClient = tcpClient;
            Buffer = buffer;
            UniqID = -randomId;
        }
        public TcpClient TcpClient { get; private set; } //stores and returns TCPClient

        public byte[] Buffer { get; private set; } // stores and returns byte[] data

        public NetworkStream NetworkStream // stores and returns networkstream
        {
            get { return TcpClient.GetStream(); }
        }
        public int UniqID { get; set; }//stores and returns clientid
    }
}
