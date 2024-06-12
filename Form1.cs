using ATL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OggToMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            OutFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        private string selectedFolder;//转换的文件夹
        private string outFolder;//输出文件夹
        private List<string> convertfiles = new List<string>();//要转换的文件列表


        private void select_folder_Click(object sender, EventArgs e)//点击选择文件夹事件
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "选择一个内有Ogg文件的文件夹：";
            folderBrowser.ShowNewFolderButton = false;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //选择的文件夹路径
                selectedFolder = folderBrowser.SelectedPath;
                FolderPath.Text = selectedFolder;
                ReadFolder.Enabled = true;
                checkBox.Enabled = true;
            }

        }

        private void add_files_Click(object sender, EventArgs e)//点击添加文件按钮事件
        {
            if (convertfiles.Count == 0)
            {
                dataview.Rows.Clear();
                progressBar1.Value = 0;
                label4.Text = "...";
            }
            OpenFileDialog path = new OpenFileDialog();
            path.Title = "请选择Ogg文件：";
            path.Filter = "Ogg音频文件|*.ogg";
            path.Multiselect = true;
            if (path.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < path.FileNames.Length; i++)
                {
                    if (convertfiles.Contains(path.FileNames[i]))
                    {
                        MessageBox.Show("已经有此文件：" + Path.GetFileName(path.FileNames[i]));
                    }
                    else
                    {
                        int index = dataview.Rows.Add();
                        convertfiles.Add(path.FileNames[i]);
                        dataview.Rows[index].Cells[0].Value = index + 1;
                        dataview.Rows[index].Cells[1].Value = Path.GetFileName(convertfiles[i]);
                        dataview.Rows[index].Cells[2].Value = Path.GetDirectoryName(convertfiles[i]);
                    }

                }

            }


        }


        private void ReadFolder_Click(object sender, EventArgs e)//点击读取按钮的事件
        {

            dataview.Rows.Clear();
            convertfiles.Clear();
            progressBar1.Value = 0;
            label4.Text = "...";
            DirectoryInfo direction = new DirectoryInfo(selectedFolder);
            FileInfo[] files=null;
            if (checkBox.Checked)
            {

                files = direction.GetFiles("*.ogg", SearchOption.AllDirectories);

            }
            else
            {
                files = direction.GetFiles("*.ogg", SearchOption.TopDirectoryOnly);

            }
            for (int i = 0; i < files.Length; i++)
            {
                convertfiles.Add(files[i].FullName);
                dataview.Rows.Add();
                dataview.Rows[i].Cells[1].Value = files[i].Name;
                dataview.Rows[i].Cells[2].Value = files[i].DirectoryName;
                dataview.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void original_folder_button_CheckedChanged(object sender, EventArgs e)//输出原文件夹
        {
            OutFolderPath.Enabled = false;
            select_out_floder.Enabled = false;
        }

        private void custom_folder_button_CheckedChanged(object sender, EventArgs e)//自定义输出文件夹
        {
            OutFolderPath.Enabled = true;
            select_out_floder.Enabled = true;
        }

        private void select_out_floder_Click(object sender, EventArgs e)//点击选择输出文件夹
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "选择输出文件夹：";
            folderBrowser.ShowNewFolderButton = false;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //选择的文件夹路径
                outFolder = folderBrowser.SelectedPath;
                OutFolderPath.Text = outFolder;
            }
        }

        private void delete_files_Click(object sender, EventArgs e)//点击去除文件
        {
            if (dataview.CurrentCell != null & convertfiles.Count!=0)
            {
                convertfiles.RemoveAt(dataview.CurrentCell.RowIndex);
                dataview.Rows.RemoveAt(dataview.CurrentCell.RowIndex);
                foreach (DataGridViewRow row in dataview.Rows)
                {
                    row.Cells[0].Value = row.Index + 1;
                }
                foreach (var file in convertfiles) { Console.WriteLine(file); }
            }

        }

        private async void convert_Click(object sender, EventArgs e)//点击开始转换
        {
            progressBar1.Maximum = convertfiles.Count;
            progressBar1.Value = 0;
            Process p = new Process(); p.StartInfo.FileName = "ffmpeg.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            int number = 0;
            for (int i = 0; i < convertfiles.Count; i++)
            {
                number = i + 1;
                string file = convertfiles[i];
                label4.Text = "正在处理第 " + number + " 个文件";
                await Task.Run(() => ConvertFile(file, p));
                dataview.Rows[i].Cells[3].Value = "完成";
                progressBar1.Value = number;

            }
            p.Close();
            MessageBox.Show("已完成");
            label4.Text = "已完成 " + number + " 个文件。";
            convertfiles.Clear();

        }


        private void ConvertFile(string file, Process p)//转换处理
        {
            Track track = new Track(file);
            string outfile;
            if (original_folder_button.Checked)
            {
                outfile = file.Replace(".ogg", ".mp3");
            }
            else
            {
                outfile = outFolder + @"\" + Path.GetFileName(file).Replace(".ogg", ".mp3");
            }
            p.StartInfo.Arguments = "-n -i \"" + file + "\" -b:a 320k -acodec libmp3lame \"" + outfile + "\"";
            p.Start();
            p.WaitForExit();
            Track outtrack = new Track(outfile);
            outtrack.Album = track.Album;
            outtrack.Artist = track.Artist;
            outtrack.Title = track.Title;
            outtrack.Description = track.Description;
            outtrack.TrackNumber = track.TrackNumber;
            outtrack.AlbumArtist = track.AlbumArtist;
            outtrack.Date = track.Date;
            outtrack.DiscTotal = track.DiscTotal;
            outtrack.Lyrics = track.Lyrics;
            outtrack.TrackTotal = track.TrackTotal;
            outtrack.Publisher = track.Publisher;
            outtrack.DiscNumber = track.DiscNumber;
            outtrack.Save();

        }

        private void open_outfolder_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
