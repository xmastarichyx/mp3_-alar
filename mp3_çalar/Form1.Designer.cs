namespace mp3_çalar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button music_ekle;
        private System.Windows.Forms.ListBox list_music;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.music_ekle = new System.Windows.Forms.Button();
            this.list_music = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.stop_button = new System.Windows.Forms.Button();
            this.devam_button = new System.Windows.Forms.Button();
            this.delete_music = new System.Windows.Forms.Button();
            this.geri_button = new System.Windows.Forms.Button();
            this.ileri_button = new System.Windows.Forms.Button();
            this.sn5 = new System.Windows.Forms.RadioButton();
            this.sn10 = new System.Windows.Forms.RadioButton();
            this.sn15 = new System.Windows.Forms.RadioButton();
            this.sn20 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressbar1 = new System.Windows.Forms.ProgressBar();
            this.now_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.next_time = new System.Windows.Forms.Label();
            this.music_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(171, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oynat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(233, 133);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(107, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Klasör Seç";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // music_ekle
            // 
            this.music_ekle.Location = new System.Drawing.Point(233, 75);
            this.music_ekle.Name = "music_ekle";
            this.music_ekle.Size = new System.Drawing.Size(107, 23);
            this.music_ekle.TabIndex = 2;
            this.music_ekle.Text = "Müzik Ekle";
            this.music_ekle.UseVisualStyleBackColor = true;
            this.music_ekle.Click += new System.EventHandler(this.music_ekle_Click);
            // 
            // list_music
            // 
            this.list_music.FormattingEnabled = true;
            this.list_music.ItemHeight = 16;
            this.list_music.Location = new System.Drawing.Point(27, 75);
            this.list_music.Name = "list_music";
            this.list_music.Size = new System.Drawing.Size(200, 100);
            this.list_music.TabIndex = 3;
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.IndianRed;
            this.stop_button.Location = new System.Drawing.Point(9, 215);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 38);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "Durdur";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // devam_button
            // 
            this.devam_button.AllowDrop = true;
            this.devam_button.BackColor = System.Drawing.Color.Orange;
            this.devam_button.Location = new System.Drawing.Point(90, 215);
            this.devam_button.Name = "devam_button";
            this.devam_button.Size = new System.Drawing.Size(75, 23);
            this.devam_button.TabIndex = 5;
            this.devam_button.Text = "Devam";
            this.devam_button.UseVisualStyleBackColor = false;
            this.devam_button.Click += new System.EventHandler(this.devam_button_Click);
            // 
            // delete_music
            // 
            this.delete_music.Location = new System.Drawing.Point(233, 104);
            this.delete_music.Name = "delete_music";
            this.delete_music.Size = new System.Drawing.Size(107, 23);
            this.delete_music.TabIndex = 6;
            this.delete_music.Text = "Müzik Sil";
            this.delete_music.UseVisualStyleBackColor = true;
            this.delete_music.Click += new System.EventHandler(this.delete_music_Click);
            // 
            // geri_button
            // 
            this.geri_button.BackColor = System.Drawing.SystemColors.Info;
            this.geri_button.Location = new System.Drawing.Point(27, 181);
            this.geri_button.Name = "geri_button";
            this.geri_button.Size = new System.Drawing.Size(75, 23);
            this.geri_button.TabIndex = 7;
            this.geri_button.Text = "Geri Sar";
            this.geri_button.UseVisualStyleBackColor = false;
            this.geri_button.Click += new System.EventHandler(this.geri_button_Click);
            // 
            // ileri_button
            // 
            this.ileri_button.BackColor = System.Drawing.SystemColors.Info;
            this.ileri_button.Location = new System.Drawing.Point(143, 181);
            this.ileri_button.Name = "ileri_button";
            this.ileri_button.Size = new System.Drawing.Size(75, 23);
            this.ileri_button.TabIndex = 8;
            this.ileri_button.Text = "İleri sar";
            this.ileri_button.UseVisualStyleBackColor = false;
            this.ileri_button.Click += new System.EventHandler(this.ileri_button_Click);
            // 
            // sn5
            // 
            this.sn5.AutoSize = true;
            this.sn5.Checked = true;
            this.sn5.Location = new System.Drawing.Point(424, 155);
            this.sn5.Name = "sn5";
            this.sn5.Size = new System.Drawing.Size(75, 20);
            this.sn5.TabIndex = 9;
            this.sn5.TabStop = true;
            this.sn5.Text = "5 saniye";
            this.sn5.UseVisualStyleBackColor = true;
            // 
            // sn10
            // 
            this.sn10.AutoSize = true;
            this.sn10.Location = new System.Drawing.Point(424, 181);
            this.sn10.Name = "sn10";
            this.sn10.Size = new System.Drawing.Size(82, 20);
            this.sn10.TabIndex = 10;
            this.sn10.Text = "10 saniye";
            this.sn10.UseVisualStyleBackColor = true;
            // 
            // sn15
            // 
            this.sn15.AutoSize = true;
            this.sn15.Location = new System.Drawing.Point(424, 207);
            this.sn15.Name = "sn15";
            this.sn15.Size = new System.Drawing.Size(82, 20);
            this.sn15.TabIndex = 11;
            this.sn15.Text = "15 saniye";
            this.sn15.UseVisualStyleBackColor = true;
            // 
            // sn20
            // 
            this.sn20.AutoSize = true;
            this.sn20.Location = new System.Drawing.Point(424, 233);
            this.sn20.Name = "sn20";
            this.sn20.Size = new System.Drawing.Size(82, 20);
            this.sn20.TabIndex = 12;
            this.sn20.Text = "20 saniye";
            this.sn20.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sardırma Süresi Ayarlama";
            // 
            // progressbar1
            // 
            this.progressbar1.Location = new System.Drawing.Point(86, 23);
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(267, 18);
            this.progressbar1.TabIndex = 14;
            // 
            // now_time
            // 
            this.now_time.AutoSize = true;
            this.now_time.Location = new System.Drawing.Point(83, 44);
            this.now_time.Name = "now_time";
            this.now_time.Size = new System.Drawing.Size(0, 16);
            this.now_time.TabIndex = 15;
            // 
            // next_time
            // 
            this.next_time.AutoSize = true;
            this.next_time.Location = new System.Drawing.Point(309, 44);
            this.next_time.Name = "next_time";
            this.next_time.Size = new System.Drawing.Size(0, 16);
            this.next_time.TabIndex = 16;
            // 
            // music_name
            // 
            this.music_name.AutoSize = true;
            this.music_name.Location = new System.Drawing.Point(12, 4);
            this.music_name.Name = "music_name";
            this.music_name.Size = new System.Drawing.Size(83, 16);
            this.music_name.TabIndex = 17;
            this.music_name.Text = "music_name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mp3_çalar.Properties.Resources.sss;
            this.pictureBox1.Location = new System.Drawing.Point(388, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 104);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(670, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.music_name);
            this.Controls.Add(this.next_time);
            this.Controls.Add(this.now_time);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sn20);
            this.Controls.Add(this.sn15);
            this.Controls.Add(this.sn10);
            this.Controls.Add(this.sn5);
            this.Controls.Add(this.ileri_button);
            this.Controls.Add(this.geri_button);
            this.Controls.Add(this.delete_music);
            this.Controls.Add(this.devam_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.list_music);
            this.Controls.Add(this.music_ekle);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button devam_button;
        private System.Windows.Forms.Button delete_music;
        private System.Windows.Forms.Button geri_button;
        private System.Windows.Forms.Button ileri_button;
        private System.Windows.Forms.RadioButton sn5;
        private System.Windows.Forms.RadioButton sn10;
        private System.Windows.Forms.RadioButton sn15;
        private System.Windows.Forms.RadioButton sn20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressbar1;
        private System.Windows.Forms.Label now_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label next_time;
        private System.Windows.Forms.Label music_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
