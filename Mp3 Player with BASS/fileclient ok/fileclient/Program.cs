using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;


namespace fileserwer
{
    public class Client
    {
        //modify the host name if you are running the server in a different machine
        
        static string hostName = "127.0.0.1";
        static int port = 65000;
        private string requestedFile = "andy1";
            //"Andy Moor & Ashley Wallbridge feat. Gabriela-World To Turn";
        
        public void SendMessage()
        {
            TcpClient client = new TcpClient();

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30000);
            try
            {
                client.Connect(serverEndPoint);
                Console.WriteLine("lacze");
            }
            catch
            {
                Console.WriteLine("blad polaczenia");
                Console.ReadLine();

            }

            NetworkStream clientStream = client.GetStream();

            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(requestedFile);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            Console.WriteLine("wyslano!");
            //Console.ReadLine();
        }
        public void FetchFileFromServer()
        {

            TcpClient client = new TcpClient(hostName, port);
            if (client.Connected)
            {

                NetworkStream netStream = client.GetStream();

                try
                {

                    BufferedStream s_in = new BufferedStream(netStream);
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    string filePath = @"C:\"+requestedFile+"kopia.mp3";
                    Stream s_out = File.OpenWrite(filePath);
                    Console.WriteLine("Odbieram");
                    while ((bytesRead = s_in.Read(buffer, 0, 8192)) > 0)
                    {
                        s_out.Write(buffer, 0, bytesRead);
                    }
                    s_out.Flush();
                    s_in.Close();
                    s_out.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.WriteLine("Odebralem");
            
        }
      
                
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
          
            Thread client1 = new Thread(new ThreadStart(c.SendMessage));
            client1.Start();
            client1.Join();
            Console.WriteLine("wyslano wiadomosc");
            Thread.Sleep(2000);
            //Thread client2 = new Thread(new ThreadStart(c.FetchFileFromServer));
            //client2.Start();
            Thread client = new Thread(new ThreadStart(new Client().FetchFileFromServer));
            client.Start();
            client.Join();
            
            //the Server Thread keeps running
            Console.ReadLine();
        }


    }
}