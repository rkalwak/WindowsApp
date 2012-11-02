using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;

using System.Data.SqlClient;
using System.Data.Sql;

namespace fileserwer
{
    /*
    public class MySpooler
        {
            //private static object _Lock = new object();

            //A shared static integer that all threads will 
            //increment.
            public static int SharedCounter { get { return _SharedCounter; } }
            public static int _SharedCounter = 0;

            //Step 1: Create a public *Static* method that
            //will be the entry point in the service class:
            public static void DoneWork(object myArg)
            {

                Console.WriteLine("Aktualny wynik:{0}",SharedCounter);
                Thread.Sleep(250);
                Console.WriteLine(
                        "Thread [Id:{0}]  [Name: {1}]  [Counter:{2}]",
                        Thread.CurrentThread.ManagedThreadId, myArg,
                        _SharedCounter
                        );
            }


            public static void DoWork(object myArg)
            {
                //Always check args first -- especially for threads:
                string threadName = myArg as string;
                if (threadName == null)
                {
                    throw new System.Exception(
                        "Was expecting a System.String as Parameter for thread.");
                }
                //Do some work...in 3 steps...handing off
                //to other threads in between the steps...
                    Console.WriteLine(
                        "Thread [Id:{0}]  [Name: {1}]  [Counter:{2}]",
                        Thread.CurrentThread.ManagedThreadId,myArg,
                        _SharedCounter
                        );

                        _SharedCounter += 1;

                    Random r = new Random();
                    // Slow down thread and let other threads work 
                    Thread.Sleep(r.Next(250));
                

                Console.WriteLine("Stopping Thread [Id:{0}] [Name:{1}] [Counter:{2}]",
                    Thread.CurrentThread.ManagedThreadId,
                    myArg,
                    _SharedCounter);
            }

        }//Class:End


        static void Main(string[] args)
        {

            ParameterizedThreadStart threadStart =
                new ParameterizedThreadStart(MySpooler.DoWork);
            ParameterizedThreadStart thread2Start =
                new ParameterizedThreadStart(MySpooler.DoneWork);
            Console.WriteLine("Main Thread: Starting threads...");

                Thread thread = new Thread(threadStart);
                thread.Start(string.Format("myParam_{0}",1));
                thread.Join();
                Thread t1 = new Thread(thread2Start);
                t1.Start(string.Format("myParam_{0}",1));
                t1.Join();
            
            Console.WriteLine("Main Thread: Waiting for input...");
            Console.ReadLine();
        }
    }//Class:End */
    public class FileServer
    {
        private static string hostName = "127.0.0.1";
        private static int port = 65000;
        private static IPAddress localAddr = IPAddress.Parse(hostName);
        private static string requestedFile = "andy1";
        public static bool rerun = false;
        public FileServer()
        {
            
            
            
            
        }
        public static bool Rerun
        {
            set { rerun = value; }
            get { return rerun; }
        }
        public string RequestedFile
        {
            get{return requestedFile;}
        }
        private void FetchFileFromDB()
        {
            string connString = @"Server=SQLSERVER;Database=musicserver;Integrated Security=SSPI";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            if (sqlConn.State == System.Data.ConnectionState.Open) 
            {
                try
                {
                    string request = "";
                    SqlCommand sqlCommand = new SqlCommand(request, sqlConn);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    //ds.Clear();
                    //da.Fill(ds, "music");                   
                    //dataGridView1.DataSource = ds.Tables["music"];            
                }
                catch (Exception ex)
                {
                    
                }


            }

        }
        
        public static void ListenForClients(object myArg) //czeka na wiadomosc
        {
            string threadName = myArg as string;
            Console.WriteLine(
                        "Thread [Id:{0}]  [Name: {1}]  [RequestedFile:{2}]",
                        Thread.CurrentThread.ManagedThreadId,myArg,
                        requestedFile
                        );

            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 30000);
            tcpListener.Start();
            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = tcpListener.AcceptTcpClient();

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
                if (requestedFile != "")
                {
                    break;

                }
            }
            tcpListener.Stop();
            Thread.Sleep(250);
            Console.WriteLine("Stopping Thread [Id:{0}] [Name:{1}] [RequestedFile: {2}]",
                    Thread.CurrentThread.ManagedThreadId,
                    myArg,
                    requestedFile);
        }
        private static void HandleClientComm(object client) //odbiera wiadomosc
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                
                requestedFile = encoder.GetString(message, 0, bytesRead);
                
                
            }

            tcpClient.Close();
            
            
        }

        public static void Start()
        {
            Console.WriteLine("hello from 2 thread : {0}",requestedFile);
            TcpListener tcpListner = new TcpListener(localAddr, port);
            tcpListner.Start(); //start listening to client request
            for (; ; ) //infinite loop
            {
                //blocks until a client request comes
                Socket socket = tcpListner.AcceptSocket();
                if (socket.Connected)
                {
                    //Delegate to the SendFileToClient method
                    SendFileToClient(socket);
                    socket.Close();
                }
            }
        }

        static void SendFileToClient(Socket socket)
        {
            
            NetworkStream netStream = new NetworkStream(socket);

            try
            {
                BufferedStream s_out = new BufferedStream(netStream);
                byte[] buffer = new byte[8192];
                int bytesRead;
                string filePath = @"C:\andy1.mp3";
                filePath = @"C:\" + requestedFile + ".mp3";
                Stream s_in = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

                Console.WriteLine("wysylam");
                while ((bytesRead = s_in.Read(buffer, 0, 8192)) > 0)
                {
                    s_out.Write(buffer, 0, bytesRead);
                }
                s_out.Flush();
                s_in.Close();
                s_out.Close();
                Console.WriteLine("wyslalem");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                ParameterizedThreadStart waitForMessage =
                        new ParameterizedThreadStart(FileServer.ListenForClients);
                Thread waitFMThread = new Thread(waitForMessage);
                waitFMThread.Start("Messaging");
                waitFMThread.Join();
                Console.WriteLine("odebrano wiadomosc");
                Thread t1 = new Thread(FileServer.Start);
                //new Thread(new ThreadStart(new FileServer().Start)).Start(); //to tez dziala
                t1.Start(); // to dziala
                while(FileServer.Rerun==false)
                {
                    waitFMThread = new Thread(waitForMessage);
                    waitFMThread.Start("Messaging");
                    waitFMThread.Join();
                    Console.WriteLine("odebrano wiadomosc");
                    
                    
                    Thread.Sleep(250);

                }
                

                Console.ReadLine();
            }   
           
        }
    
}
