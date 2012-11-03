using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Un4seen.Bass.Misc;
namespace Mp3_Player_with_BASS
{
    public partial class Form1 : Form
    {
        private Player player;
        private int playState, songLenght,selectedSong,songNumber;
        private bool looping, shuffling;
     
        SqlConnection sqlConn;
        private DataSet ds=new DataSet();
        private string request = "";
        private DatabaseManager db;
        private Visuals _vis = new Visuals();
        private int specIdx = 15;
        private int voicePrintIdx = 0;

        [DllImport ("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public Form1()
        {
            InitializeComponent();
            player = new Player();
            playState = 1;
            songLenght = 0;
            selectedSong = 0;
            
            songNumber = 0;
            shuffling = false;
            looping = false;
            db = new DatabaseManager("SQLSERVER", "musicclient");
            // funkcje z WINAPI bo pod win7 byly problemy z regulacja dzwieku
            //player.SetVolume((float)trackBar2.Value);
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 100 (to fit the trackbar)
            trackBar2.Value = CalcVol / (ushort.MaxValue / 100);
            timerSpectrum.Enabled = true;
            timerSpectrum.Interval = 50;
        }

        private void DrawSpectrum()
        {
            switch (specIdx)
            {
                // normal spectrum (width = resolution)
                case 0:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrum(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Black, false, false, false);
                    break;
                // normal spectrum (full resolution)
                case 1:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrum(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Black, false, true, true);
                    break;
                // line spectrum (width = resolution)
                case 2:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLine(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Black, 2, 2, false, false, false);
                    break;
                // line spectrum (full resolution)
                case 3:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLine(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Black, 16, 4, false, true, true);
                    break;
                // ellipse spectrum (width = resolution)
                case 4:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumEllipse(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Black, 1, 2, false, false, false);
                    break;
                // ellipse spectrum (full resolution)
                case 5:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumEllipse(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Black, 2, 4, false, true, true);
                    break;
                // dot spectrum (width = resolution)
                case 6:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumDot(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Black, 1, 0, false, false, false);
                    break;
                // dot spectrum (full resolution)
                case 7:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumDot(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Black, 2, 1, false, false, true);
                    break;
                // peak spectrum (width = resolution)
                case 8:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLinePeak(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SeaGreen, Color.LightGreen, Color.Orange, Color.Black, 2, 1, 2, 10, false, false, false);
                    break;
                // peak spectrum (full resolution)
                case 9:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLinePeak(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.GreenYellow, Color.RoyalBlue, Color.DarkOrange, Color.Black, 23, 5, 3, 5, false, true, true);
                    break;
                // wave spectrum (width = resolution)
                case 10:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumWave(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Yellow, Color.Orange, Color.Black, 1, false, false, false);
                    break;
                // dancing beans spectrum (width = resolution)
                case 11:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumBean(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Chocolate, Color.DarkGoldenrod, Color.Black, 4, false, false, true);
                    break;
                // dancing text spectrum (width = resolution)
                case 12:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumText(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.White, Color.Tomato, Color.Black, "BASS .NET IS GREAT PIECE! UN4SEEN ROCKS...", false, false, true);
                    break;
                // frequency detection
                case 13:
                    float amp = _vis.DetectFrequency(player.Stream, 10, 500, true);
                    if (amp > 0.3)
                        this.pictureBoxSpectrum.BackColor = Color.Red;
                    else
                        this.pictureBoxSpectrum.BackColor = Color.Black;
                    break;
                // 3D voice print
                case 14:
                    // we need to draw directly directly on the picture box...
                    // normally you would encapsulate this in your own custom control
                    Graphics g = Graphics.FromHwnd(this.pictureBoxSpectrum.Handle);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    _vis.CreateSpectrum3DVoicePrint(player.Stream, g, new Rectangle(0, 0, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height), Color.Black, Color.White, voicePrintIdx, false, false);
                    g.Dispose();
                    // next call will be at the next pos
                    voicePrintIdx++;
                    if (voicePrintIdx > this.pictureBoxSpectrum.Width - 1)
                        voicePrintIdx = 0;
                    break;
                // WaveForm
                case 15:
                    this.pictureBoxSpectrum.Image = _vis.CreateWaveForm(player.Stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Green, Color.Red, Color.Gray, Color.Black, 1, true, false, true);
                    break;
            }
        }

        private void pictureBoxSpectrum_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                specIdx++;
            else
                specIdx--;

            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;

            this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    selectedSong = e.RowIndex;

                }
            }
           
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    selectedSong = e.RowIndex;
                    player.StopSong();
                    player.LoadSong(dataGridView1.Rows[selectedSong].Cells["FileName"].Value.ToString());
                    trackBar1.Value = 0;
                    trackBar1.Maximum = int.Parse(dataGridView1.Rows[selectedSong].Cells["Duration"].Value.ToString());
                    player.PlaySong();
                    player.Playing = true;
                    timer1.Enabled = true;
                    
                }


            }
        }
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            player.SeekSong(trackBar1.Value);
                   
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentPosition=player.CurrentPossition();
            trackBar1.Value = currentPosition;
            //label1.Text = GetTimeMinutsAndSeconds(currentPosition)+" / " +GetTimeMinutsAndSeconds((int)dataGridView1.Rows[selectedSong].Cells["Duration"].Value);
            label1.Text = GetTimeMinutsAndSeconds(currentPosition)+" / " +GetTimeMinutsAndSeconds(trackBar1.Maximum);
            //if (currentPosition > (int)dataGridView1.Rows[selectedSong].Cells["Duration"].Value - 1)
            if (currentPosition > (trackBar1.Maximum-2))
            {
                song_change("next");
            }
            
        }
        private string GetTimeMinutsAndSeconds(int seconds)
        {
            int  minut = 0;           
            minut = seconds / 60;

            return String.Format("{0:00}", (float)minut) + ":" + String.Format("{0:00}", (float)(seconds % 60));
        }
        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            player.SetBalance((float)trackBar3.Value);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
         
            if (cbMute.Checked == true)
            {
                SetVolume(0);
            }
            else
            {
                SetVolume(trackBar2.Value);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoop.Checked && !looping)
            {
                looping = true;
            }
            else if (!cbLoop.Checked && looping)
            {
                looping = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShuffle.Checked && !shuffling)
            {
                shuffling = true;
            }
            else if (!cbShuffle.Checked && shuffling)
            {
                shuffling = false;
            }
        }
        private void trackBar2_MouseDown(object sender, MouseEventArgs e)
        {
            player.SetVolume((float)trackBar2.Value);
        }
        private void SetVolume(int volume)
        {
            // Calculate the volume that's being set
            int NewVolume = ((ushort.MaxValue / 100) * volume);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            SetVolume(trackBar2.Value);
        }
        private void song_change(string key)
        {
            if (looping)
            {
                player.PlaySong();
            }
            else if (shuffling)
            {
                Random rand = new Random();
                int i = rand.Next(0, dataGridView1.RowCount);
                dataGridView1.Rows[selectedSong].Selected = false;

                player.StopSong();
                player.LoadSong(dataGridView1.Rows[i].Cells["FileName"].Value.ToString());
                trackBar1.Value = 0;
                trackBar1.Maximum = int.Parse(dataGridView1.Rows[i].Cells["Duration"].Value.ToString());
                player.PlaySong();
                player.Playing = true;
                timer1.Enabled = true;
                timerSpectrum.Enabled = true;


                selectedSong = i;
                dataGridView1.Rows[i].Selected = true;
            }
                
            else if ((dataGridView1.Rows.Count >= 2 && (selectedSong + 1) < dataGridView1.Rows.Count) && key == "next")
            {
                
                player.StopSong();
                player.LoadSong(dataGridView1.Rows[selectedSong + 1].Cells["FileName"].Value.ToString());
                trackBar1.Value = 0;
                trackBar1.Maximum = int.Parse(dataGridView1.Rows[selectedSong+1].Cells["Duration"].Value.ToString());
                timer1.Enabled=true;
                timerSpectrum.Enabled = true;
                player.PlaySong();
              
                player.Playing = true;
                dataGridView1.Rows[selectedSong].Selected = false;
                selectedSong++;
                dataGridView1.Rows[selectedSong].Selected = true;

            }
                
            else if ((dataGridView1.Rows.Count >= 2 && (selectedSong - 1) >= 0) && key == "prev")
            {
                player.StopSong();
                player.LoadSong(dataGridView1.Rows[selectedSong - 1].Cells["FileName"].Value.ToString());
                trackBar1.Value = 0;
                trackBar1.Maximum = int.Parse(dataGridView1.Rows[selectedSong-1].Cells["Duration"].Value.ToString());
                player.PlaySong();
                timer1.Enabled=true;
                timerSpectrum.Enabled = true;
                dataGridView1.Rows[selectedSong].Selected = false;
                selectedSong--;
                dataGridView1.Rows[selectedSong].Selected = true;
            }
            else if (dataGridView1.Rows[selectedSong].Index == (dataGridView1.Rows.Count - 1) && key == "next")
            {
                // nastepna piosenka to jest 1 
                dataGridView1.Rows[selectedSong].Selected = false;
                player.StopSong();
                player.LoadSong(dataGridView1.Rows[0].Cells["FileName"].Value.ToString());
                trackBar1.Value = 0;
                trackBar1.Maximum = int.Parse(dataGridView1.Rows[0].Cells["Duration"].Value.ToString());
                player.PlaySong();
                selectedSong = 0;
                dataGridView1.Rows[0].Selected = true;
            }
            else if (dataGridView1.Rows[selectedSong].Index == 0 && key == "prev")
            {
                //poprzednia bedzie ostatnia na liscie
                dataGridView1.Rows[selectedSong].Selected = false;
                player.StopSong();
                player.LoadSong(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["FileName"].Value.ToString());
                trackBar1.Value = 0;
                trackBar1.Maximum = int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells["Duration"].Value.ToString());
                player.PlaySong();
                selectedSong = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[selectedSong].Selected = true;

            }
            // zapisywac glosnosc

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.contextMenuStrip1.Show(dataGridView1, e.Location);
                
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentCellAddress.Y;
            MessageBox.Show(n.ToString());
            dataGridView1.Rows.Remove(dataGridView1.Rows[n]);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Number"].Value = dataGridView1.Rows[i].Index + 1;
            }
            
        }   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            request = textBox2.Text;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && textBox2.Text != "")
            {
                dataGridView1.DataSource = db.getQueryFromDB(textBox2.Text);
            }

        }
        private string getFileFromServer(string file)
        {

            textBox1.Text = "";
            Network net = new Network();
            net.RequestedFile = file;
            //net.RequestedFile = "Andy Moor & Ashley Wallbridge feat. Gabriela-World To Turn";
            net.FolderPath = @"C:\mp3\";
            Thread client1 = new Thread(new ThreadStart(net.SendMessage));
            client1.Start();
            client1.Join();

            Thread.Sleep(5000);
            Thread client = new Thread(new ThreadStart(net.FetchFileFromServer));
            client.Start();
            client.Join();
            

            return net.RequestedFilePath;
        }
        private void fetchFromServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzic czy tabela jest z servera a nie z klienta... 
            int n = dataGridView1.CurrentCellAddress.Y;
            string requestedFile=dataGridView1.Rows[n].Cells["Artist"].Value.ToString()
                +"-"+
                dataGridView1.Rows[n].Cells["Title"].Value.ToString();
            string filePath=getFileFromServer(requestedFile);
            Song song = new Song(filePath);
            songLenght = song.Duration;
            song.Number = songNumber;

            string request = String.Format("insert into music (Artist,Title,FileName,Duration) values ('{0}','{1}','{2}',{3});", song.Artist.Replace("'", "''"), song.Title.Replace("'", "''"), song.FileName.Replace("'", "''"), song.Duration);
            db = new DatabaseManager("SQLSERVER", "musicclient");
            db.insertDataIntoDB(request);

        }
        
        #region buttonsClick
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mp3 files|*.mp3";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Song song = new Song(fd.FileName);
                songLenght = song.Duration;
                song.Number = songNumber;

                request = String.Format("insert into music (Artist,Title,FileName,Duration) values ('{0}','{1}','{2}',{3});", song.Artist, song.Title, song.FileName, song.Duration);
                textBox1.Text = request;
                db.insertDataIntoDB(request);
                request = "select * from music;";
                dataGridView1.DataSource=db.getQueryFromDB(request);


            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
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
                        song.Number = songNumber;
                       ;
                        if (song.Artist == null || song.Title == null)
                        {
                        }
                        else
                        {
                            request = "insert into music (Artist,Title,FileName,Duration) values ('" + song.Artist.Replace("'", "''") + "','" + song.Title.Replace("'", "''") + "','" + song.FileName.Replace("'", "''") + "'," + song.Duration + ")";
                            textBox1.Text = request;
                            db.insertDataIntoDB(request);
                        }

                    }

                }
                request = "select * from music;";
                dataGridView1.DataSource=db.getQueryFromDB(request);
               


            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[selectedSong] != null)
            {
                if (player.Paused)
                {
                    player.PlaySong();
                    player.Playing = true;
                    player.Paused = false;

                }
                else
                {
                    player.StopSong();
                    player.LoadSong(dataGridView1.Rows[selectedSong].Cells["FileName"].Value.ToString());
                    trackBar1.Value = 0;
                    trackBar1.Maximum = int.Parse(dataGridView1.Rows[selectedSong].Cells["Duration"].Value.ToString());
                    player.PlaySong();
                    player.Playing = true;
                }

                timer1.Enabled = true;
                timerSpectrum.Enabled = true;
                
            }
            timerSpectrum.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (player.Paused)
            {
                player.PlaySong();
                player.Playing = true;
                player.Paused = false;
                timer1.Enabled = true;
                timerSpectrum.Enabled = true;
            }
            else
            {
                player.PauseSong();
                playState = player.CurrentPossition();
                player.Paused = true;
                timer1.Enabled = false;
                timerSpectrum.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.StopSong();
            timer1.Enabled = false;
            timer1.Stop();
            timerSpectrum.Enabled = false;
            timerSpectrum.Stop();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            song_change("prev");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            song_change("next");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            db = new DatabaseManager("SQLSERVER", "musicserver");
            dataGridView1.DataSource = db.getQueryFromDB("select * from music");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DatabaseManager("SQLSERVER", "musicclient");
            dataGridView1.DataSource = db.getQueryFromDB("select * from music");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

                dataGridView1.DataSource = db.getQueryFromDB(textBox2.Text);
                dataGridView1.Columns["FileName"].Visible = false;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ds.Clear();
        }
        #endregion

        private void timerSpectrum_Tick(object sender, EventArgs e)
        {
            DrawSpectrum();
            textBox1.Text = "dziala";
        }

        



    }
}
