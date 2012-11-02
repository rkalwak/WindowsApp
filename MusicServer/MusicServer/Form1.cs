using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Data.SqlClient;
using System.Data.Sql;


namespace MusicServer
{
    public partial class Form1 : Form
    {
        private static string hostName = "127.0.0.1";
        private static int port = 65000;
        private static IPAddress localAddr = IPAddress.Parse(hostName);
        private static string requestedFile = "andy1";
        public static bool rerun = false;
        private static string requestedFilePath = "";
    
     
      
        private DataSet dataSet = new DataSet();
        
        private string sqlRequest;
        private SqlConnection sqlConn;
        public Form1()
        {
            InitializeComponent();
           
            sqlRequest = "select * from music";
            string cs = @"Server=SQLSERVER;Database=musicserver;Integrated Security=SSPI";
            sqlConn = new SqlConnection(cs);
            executeRequest();
            
            
            
        }
        public static bool Rerun
        {
            set { rerun = value; }
            get { return rerun; }
        }
        public string RequestedFile
        {
            get { return requestedFile; }
        }
        public static  void ListenForMessage(object myArg) //czeka na wiadomosc
        {
            string threadName = myArg as string;
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
                requestedFile = encoder.GetString(message, 0, bytesRead);
                requestedFilePath = FetchFileFromDB();
                
            }

            tcpClient.Close();


        }

        public static void FileServer()
        {
            
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
                Stream s_in = File.Open(requestedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);

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
                MessageBox.Show(ex.ToString());
            }


        }
        private static string FetchFileFromDB()
        {
            string connString = @"Server=SQLSERVER;Database=musicserver;Integrated Security=SSPI";
            SqlConnection sqlConn = new SqlConnection(connString);
            string filePath = "";
            sqlConn.Open();
            if (sqlConn.State == System.Data.ConnectionState.Open) 
            {
                try
                {
                    //requestedFile = "Andy Moor & Ashley Wallbridge feat. Gabriela-World To Turn";
                    char[] delimiter=new char[1];
                    delimiter[0] = '-';
                    string [] tmp=requestedFile.Split(delimiter);
                    string artist=tmp[0];
                    string title=tmp[1];
                    //artist = artist.ToUpper();
                    //title = title.ToUpper();
                    string request = String.Format(@"select * from music where Artist='{0}'and Title='{1}'",artist.Replace("'","''"),title.Replace("'","''"));    
                    

                    SqlCommand sqlCommand = new SqlCommand(request, sqlConn);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                   
                    DataSet ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"music");
                    DataRow dataRow = ds.Tables["music"].Rows[0];
                    filePath = dataRow["FileName"].ToString();
                   
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                

            }
            return filePath;
        }
        
        
                
       
        

        private void executeRequest()
        {
            sqlConn.Open();
            if (sqlConn.State.ToString() == "Open")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlRequest, sqlConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dataSet.Clear();
                    da.Fill(dataSet, "music");
                    dataGridView1.DataSource = dataSet.Tables["music"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //dataGridView1.Columns["FileName"].Visible = false;
            }
            else
                MessageBox.Show("Brak połączenia z bazą danych");
            sqlConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mp3 files|*.mp3";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Song song = new Song(fd.FileName);
                sqlRequest = String.Format("insert into music (Artist,Title,FileName,Duration) values ('{0}','{1}','{2}',{3});", song.Artist, song.Title, song.FileName, song.Duration);
                executeRequest();
                sqlRequest = "select * from music;";
                executeRequest();
                /*
                songList.Add(song);
                
                dataGridView1.DataSource = songList;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Number"].Value = dataGridView1.Rows[i].Index + 1;
                }
                */


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                System.Collections.Specialized.StringCollection fileCol = new System.Collections.Specialized.StringCollection();
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fbd.SelectedPath);

                fileCol.Add(fbd.SelectedPath);
                FileInfo[] files = dir.GetFiles("*.mp3");
                Song song;
                foreach (FileInfo fi in files)
                {
                    if (fi.Extension == ".mp3")
                    {
                        song = new Song(fi.FullName);
                        
                        if (song.Artist == null || song.Title == null)
                        {
                        }
                        else
                        {
                            sqlRequest = "insert into music (Artist,Title,FileName,Duration) values ('" + song.Artist.Replace("'", "''") + "','" + song.Title.Replace("'", "''") + "','" + song.FileName.Replace("'", "''") + "'," + song.Duration + ")";
                       
                            executeRequest();
                        }

                    }

                }
                sqlRequest = "select * from music;";
                executeRequest();
                //dataGridView1.DataSource = songList;



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ParameterizedThreadStart waitForMessage =
                        new ParameterizedThreadStart(Form1.ListenForMessage);
            Thread waitFMThread = new Thread(waitForMessage);
            waitFMThread.Start("Messaging");
            waitFMThread.Join();
            
          
            Thread t1 = new Thread(Form1.FileServer);
            //new Thread(new ThreadStart(new FileServer().Start)).Start(); //to tez dziala
            t1.Start(); // to dziala
            
            while (Form1.Rerun == false)
            {
                waitFMThread = new Thread(waitForMessage);
                waitFMThread.Start("Messaging");
                waitFMThread.Join();
                
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FetchFileFromDB();
        }
    }
}
