namespace OggToMp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.select_floder = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.delete_files = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convert = new System.Windows.Forms.Button();
            this.add_files = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.OutFolderPath = new System.Windows.Forms.TextBox();
            this.select_out_floder = new System.Windows.Forms.Button();
            this.custom_folder_button = new System.Windows.Forms.RadioButton();
            this.original_folder_button = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_floder
            // 
            this.select_floder.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.select_floder.Location = new System.Drawing.Point(334, 58);
            this.select_floder.Name = "select_floder";
            this.select_floder.Size = new System.Drawing.Size(57, 24);
            this.select_floder.TabIndex = 0;
            this.select_floder.Text = "选择";
            this.select_floder.UseVisualStyleBackColor = true;
            this.select_floder.Click += new System.EventHandler(this.select_folder_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FolderPath.Location = new System.Drawing.Point(45, 58);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            this.FolderPath.Size = new System.Drawing.Size(283, 23);
            this.FolderPath.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.Enabled = false;
            this.checkBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox.Location = new System.Drawing.Point(470, 61);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(99, 21);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "包含子文件夹";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "目录:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReadFolder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FolderPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.select_floder);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 85);
            this.panel1.TabIndex = 4;
            // 
            // ReadFolder
            // 
            this.ReadFolder.Enabled = false;
            this.ReadFolder.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ReadFolder.Location = new System.Drawing.Point(397, 58);
            this.ReadFolder.Name = "ReadFolder";
            this.ReadFolder.Size = new System.Drawing.Size(57, 24);
            this.ReadFolder.TabIndex = 5;
            this.ReadFolder.Text = "读取";
            this.ReadFolder.UseVisualStyleBackColor = true;
            this.ReadFolder.Click += new System.EventHandler(this.ReadFolder_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "这是一款免费的将Ogg格式的音频转化为最高质量的Mp3音频工具，它可以保留Ogg音频的元数据。此工具需要FFmpeg来运行。";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.about);
            this.panel2.Controls.Add(this.delete_files);
            this.panel2.Controls.Add(this.dataview);
            this.panel2.Controls.Add(this.convert);
            this.panel2.Controls.Add(this.add_files);
            this.panel2.Location = new System.Drawing.Point(12, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 224);
            this.panel2.TabIndex = 5;
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.about.Location = new System.Drawing.Point(334, 193);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(114, 24);
            this.about.TabIndex = 5;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // delete_files
            // 
            this.delete_files.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.delete_files.Location = new System.Drawing.Point(123, 193);
            this.delete_files.Name = "delete_files";
            this.delete_files.Size = new System.Drawing.Size(114, 24);
            this.delete_files.TabIndex = 4;
            this.delete_files.Text = "去除文件";
            this.delete_files.UseVisualStyleBackColor = true;
            this.delete_files.Click += new System.EventHandler(this.delete_files_Click);
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataview.Location = new System.Drawing.Point(3, 3);
            this.dataview.MultiSelect = false;
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.RowHeadersVisible = false;
            this.dataview.RowTemplate.Height = 23;
            this.dataview.Size = new System.Drawing.Size(565, 185);
            this.dataview.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 5F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 25F;
            this.Column2.HeaderText = "文件名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "路径";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 15F;
            this.Column4.HeaderText = "结果";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.convert.Location = new System.Drawing.Point(454, 193);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(114, 24);
            this.convert.TabIndex = 2;
            this.convert.Text = "开始转换";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // add_files
            // 
            this.add_files.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.add_files.Location = new System.Drawing.Point(3, 193);
            this.add_files.Name = "add_files";
            this.add_files.Size = new System.Drawing.Size(114, 24);
            this.add_files.TabIndex = 1;
            this.add_files.Text = "添加文件";
            this.add_files.UseVisualStyleBackColor = true;
            this.add_files.Click += new System.EventHandler(this.add_files_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.OutFolderPath);
            this.panel3.Controls.Add(this.select_out_floder);
            this.panel3.Controls.Add(this.custom_folder_button);
            this.panel3.Controls.Add(this.original_folder_button);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 79);
            this.panel3.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutFolderPath
            // 
            this.OutFolderPath.Enabled = false;
            this.OutFolderPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.OutFolderPath.Location = new System.Drawing.Point(214, 3);
            this.OutFolderPath.Name = "OutFolderPath";
            this.OutFolderPath.ReadOnly = true;
            this.OutFolderPath.Size = new System.Drawing.Size(291, 23);
            this.OutFolderPath.TabIndex = 8;
            // 
            // select_out_floder
            // 
            this.select_out_floder.Enabled = false;
            this.select_out_floder.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.select_out_floder.Location = new System.Drawing.Point(511, 3);
            this.select_out_floder.Name = "select_out_floder";
            this.select_out_floder.Size = new System.Drawing.Size(57, 24);
            this.select_out_floder.TabIndex = 7;
            this.select_out_floder.Text = "选择";
            this.select_out_floder.UseVisualStyleBackColor = true;
            this.select_out_floder.Click += new System.EventHandler(this.select_out_floder_Click);
            // 
            // custom_folder_button
            // 
            this.custom_folder_button.AutoSize = true;
            this.custom_folder_button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.custom_folder_button.Location = new System.Drawing.Point(146, 5);
            this.custom_folder_button.Name = "custom_folder_button";
            this.custom_folder_button.Size = new System.Drawing.Size(62, 21);
            this.custom_folder_button.TabIndex = 6;
            this.custom_folder_button.Text = "自定义";
            this.custom_folder_button.UseVisualStyleBackColor = true;
            this.custom_folder_button.CheckedChanged += new System.EventHandler(this.custom_folder_button_CheckedChanged);
            // 
            // original_folder_button
            // 
            this.original_folder_button.AutoSize = true;
            this.original_folder_button.Checked = true;
            this.original_folder_button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.original_folder_button.Location = new System.Drawing.Point(68, 5);
            this.original_folder_button.Name = "original_folder_button";
            this.original_folder_button.Size = new System.Drawing.Size(62, 21);
            this.original_folder_button.TabIndex = 5;
            this.original_folder_button.TabStop = true;
            this.original_folder_button.Text = "原目录";
            this.original_folder_button.UseVisualStyleBackColor = true;
            this.original_folder_button.CheckedChanged += new System.EventHandler(this.original_folder_button_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "输出目录:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ogg To Mp3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button select_floder;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button add_files;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Button ReadFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button delete_files;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton custom_folder_button;
        private System.Windows.Forms.RadioButton original_folder_button;
        private System.Windows.Forms.TextBox OutFolderPath;
        private System.Windows.Forms.Button select_out_floder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button about;
    }
}

