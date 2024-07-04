using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mp3_çalar
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer player;
        private string[] mp3Files;
        private string defaultFolderPath = @"C:\Users\mastarichy\Desktop\yazılımlar\mp3_çalar\müzik";  // Varsayılan klasör.
        private double durdurma_pozisyonu;
        private int şarkı_seç;
        private double sarma_süresi = 0;

        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.PlayStateChange += Player_PlayStateChange;
            player.MediaChange += Player_MediaChange;

            progressbar1.Minimum = 0;
            progressbar1.Maximum = 100;
            timer1.Interval = 1000; // Timer her saniye tetiklenecek
            timer1.Tick += timer1_Tick;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMp3FilesFromFolder(defaultFolderPath);
        }

        private void LoadMp3FilesFromFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                list_music.Items.Clear();
                mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                foreach (string file in mp3Files)
                {
                    list_music.Items.Add(Path.GetFileName(file));
                }
            }
            else
            {
                MessageBox.Show("Belirtilen klasör bulunamadı.");
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;
                LoadMp3FilesFromFolder(selectedPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list_music.SelectedIndex != -1)
            {
              
                string selectedFile = mp3Files[list_music.SelectedIndex];
                
               
                player.URL = selectedFile;
                player.controls.play();
                timer1.Start();
                UpdateNowPlayingLabel();
            }
            else
            {
                MessageBox.Show("Lütfen bir müzik seçin.");
            }
        }

        private void music_ekle_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;
                LoadMp3FilesFromFolder(selectedPath);
            }
            if (list_music.SelectedIndex != -1)
            {
                string selectedFile = mp3Files[list_music.SelectedIndex];
                string destinationPath = Path.Combine(defaultFolderPath, Path.GetFileName(selectedFile));

                try
                {
                    File.Copy(selectedFile, destinationPath, true);
                    MessageBox.Show("Dosya başarıyla kopyalandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kopyalanırken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şarkı seçin.");
               
                   
                    LoadMp3FilesFromFolder(@"C:\Users\mastarichy\Desktop\yazılımlar\mp3_çalar\müzik");
                
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            durdurma_pozisyonu = player.controls.currentPosition;  // Mevcut pozisyonu sakla
            player.controls.stop();
            timer1.Stop();
            UpdateNowPlayingLabel();

        }

        private void devam_button_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsStopped && durdurma_pozisyonu > 0)
            {
                player.controls.currentPosition = durdurma_pozisyonu;  // Kaldığı yerden devam et
                player.controls.play();
                timer1.Start();
            }
        }

        private void delete_music_Click(object sender, EventArgs e)
        {
            if (list_music.SelectedIndex != -1)
            {
                string selectedFile = mp3Files[list_music.SelectedIndex];
                DialogResult result = MessageBox.Show("Bu dosyayı silmek istediğinizden emin misiniz?", "Dosya Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(selectedFile);
                        MessageBox.Show("Dosya başarıyla silindi.");
                        LoadMp3FilesFromFolder(defaultFolderPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya silinirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şarkı seçin.");
            }
        }

        private void geri_button_Click(object sender, EventArgs e)
        {
            int sn = 0;
            if (sn5.Checked)
            {
                sn = 5;
            }
            else if (sn10.Checked)
            {
                sn = 10;
            }
            else if (sn15.Checked)
            {
                sn = 15;
            }
            else if (sn20.Checked)
            {
                sn = 20;
            }
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.currentPosition -= sarma_süresi+sn;
                if (player.controls.currentPosition < 0)
                {
                    player.controls.currentPosition = 0;
                }
            }
        }

        private void ileri_button_Click(object sender, EventArgs e)
        {
            int sn = 0;
            if (sn5.Checked)
            {
                sn = 5;
            }
            else if (sn10.Checked)
            {
                sn = 10;
            }
            else if (sn15.Checked)
            {
                sn = 15;
            }
            else if (sn20.Checked)
            {
                sn = 20;
            }
            
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.currentPosition += sarma_süresi+sn;
                if (player.controls.currentPosition > player.currentMedia.duration)
                {
                    player.controls.currentPosition = player.currentMedia.duration;
                }
            }
        }
        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                
                PlayNextTrack();




            }
        }
        

        


        private void Player_MediaChange(object pMediaObject)
        {
          
            if (player.currentMedia != null)
            {
                progressbar1.Maximum = (int)player.currentMedia.duration;
                progressbar1.Value = 0;
                UpdateTimeLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                progressbar1.Value = (int)player.controls.currentPosition;
                UpdateTimeLabels();
            }
        }

        private void UpdateTimeLabels()
        {
            now_time.Text = FormatTime(player.controls.currentPosition);
            next_time.Text = FormatTime(player.currentMedia.duration);
        }

        private string FormatTime(double seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return timeSpan.ToString(@"mm\:ss");
        }
        private void UpdateNowPlayingLabel()
        {
            if (player.currentMedia != null)
            {
                music_name.Text = "Şu Anda Çalan: " + Path.GetFileName(player.currentMedia.sourceURL);
                
            }
        }
       
        private void PlayNextTrack()
        {
            if (list_music.SelectedIndex != -1)
            {
                int selectedIndex = list_music.SelectedIndex;
                int nextIndex = selectedIndex + 1;
                if (nextIndex < mp3Files.Length)
                {
                    list_music.SelectedIndex = nextIndex;
                    string nextFile = mp3Files[nextIndex];
                    player.URL = nextFile;
                    player.controls.play();
                    player.controls.currentPosition = 1;
                   
                    UpdateNowPlayingLabel();
                    UpdateTimeLabels();
                    timer1.Start();              
                }
                else
                {
                    MessageBox.Show("Listenin sonuna geldiniz.");
                }
            }
        }



    }
}
