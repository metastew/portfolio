using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Ass1SyncChat
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "-server")
            {
                //  Server mode, e.g. when '-server' is passed at command line
                TcpListener server = new TcpListener(IPAddress.Loopback, 1234);
                startServer(server);
            }
            else
            {
                // Client mode
                TcpClient client = new TcpClient();
                startClient(client);
            }
        }

        static void startServer(TcpListener server)
        {
            try
            {
                // start server
                server.Start();

                // initial welcome message
                Console.WriteLine("Server started on port 1234.\n\nWaiting for client connection...\n\n");
                // set up a channel between server and client       
                TcpClient client = server.AcceptTcpClient();

                // get data stream from client
                NetworkStream stream = client.GetStream();

                // enter chat and continue until input == 'quit'
                chatMode(stream, client);

                // close server and client
                stream.Close();
                client.Close();
            }
            catch (SocketException)
            {
                Console.WriteLine("This port number already has a process running on it!");
            }

        }

        static void startClient(TcpClient client)
        {
            // if client cannot connect to server, let this client know.
            try
            {
                // connect to the server
                client.Connect("localhost", 1234);
            } catch (SocketException) {
                Console.WriteLine("Failed to connect!");
            } 

            if (client.Connected)
            {
                // initial welcome message
                Console.WriteLine("Connected to server!\n\nPress 'i' to chat.\n\n");
                
                // accept data stream from server
                NetworkStream stream = client.GetStream();

                // enter chat and continue until input == 'quit'
                chatMode(stream, client);

                // close client
                stream.Close();
                client.Close();
            }
        }

        static void chatMode(NetworkStream stream, TcpClient client) {
            bool done = false;

            // continue chat until done == true
            while (!done)
            {
                // detect key inputs
                if (Console.KeyAvailable)
                {
                    // do not display key inputs
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.I)
                    {

                        // Outgoing message when 'i' key is pressed
                        // prefix is '>>', but not part of the message
                        Console.Write(">>");
                        string msg = Console.ReadLine();

                        // Exit the program when input == "quit"
                        if (msg != "quit")
                        {
                            // if other client is disconnected, let this client know
                            try
                            {
                                // a message can be up to 256 characters
                                byte[] outbuffer = Encoding.ASCII.GetBytes(msg);
                                stream.Write(outbuffer, 0, outbuffer.Length);
                            }
                            catch (System.IO.IOException)
                            {
                                // catch the exception and let client know that other client/server has been disconnected
                                Console.WriteLine("Client disconnected!");
                            }
                        }
                        else
                        {
                            done = true;
                        }
                    }
                }

                // Incoming messages
                byte[] inbuffer = new byte[256];

                while (stream.DataAvailable)
                {
                    // grab incoming stream from client and format it as a 256 characters message.
                    int numBytesRead = stream.Read(inbuffer, 0, inbuffer.Length);
                    string inmsg = Encoding.ASCII.GetString(inbuffer, 0, numBytesRead);

                    Console.WriteLine(inmsg);
                }
            }
        }
    }
}
