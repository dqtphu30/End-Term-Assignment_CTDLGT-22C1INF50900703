namespace ThuatToanDijkstra
{
    partial class fDijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDijkstra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachDiem = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SGMap = new System.Windows.Forms.PictureBox();
            this.btTinhDuongDi = new System.Windows.Forms.Button();
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.cbbDiemDau = new System.Windows.Forms.ComboBox();
            this.cbbDiemCuoi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SGMap)).BeginInit();
            this.mnMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDanhSachDiem);
            this.groupBox1.Location = new System.Drawing.Point(8, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(604, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biểu diễn đường đi";
            // 
            // lvDanhSachDiem
            // 
            this.lvDanhSachDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachDiem.GridLines = true;
            this.lvDanhSachDiem.HideSelection = false;
            this.lvDanhSachDiem.Location = new System.Drawing.Point(16, 23);
            this.lvDanhSachDiem.Margin = new System.Windows.Forms.Padding(4);
            this.lvDanhSachDiem.Name = "lvDanhSachDiem";
            this.lvDanhSachDiem.Size = new System.Drawing.Size(584, 195);
            this.lvDanhSachDiem.TabIndex = 9;
            this.lvDanhSachDiem.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDiem.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Điểm đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Điểm cuối:";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.FloralWhite;
            this.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlowLayoutPanel1.Controls.Add(this.SGMap);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(584, 339);
            this.FlowLayoutPanel1.TabIndex = 0;
            // 
            // SGMap
            // 
            this.SGMap.BackgroundImage = global::ThuatToanDijkstra.Properties.Resources.Anh_Chup_Man_Hinh_20_06;
            this.SGMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SGMap.Image = global::ThuatToanDijkstra.Properties.Resources.Anh_Chup_Man_Hinh_20_06;
            this.SGMap.Location = new System.Drawing.Point(3, 3);
            this.SGMap.Name = "SGMap";
            this.SGMap.Size = new System.Drawing.Size(568, 325);
            this.SGMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SGMap.TabIndex = 3;
            this.SGMap.TabStop = false;
            this.SGMap.Paint += new System.Windows.Forms.PaintEventHandler(this.SGMap_Point);
            // 
            // btTinhDuongDi
            // 
            this.btTinhDuongDi.Location = new System.Drawing.Point(498, 49);
            this.btTinhDuongDi.Name = "btTinhDuongDi";
            this.btTinhDuongDi.Size = new System.Drawing.Size(75, 24);
            this.btTinhDuongDi.TabIndex = 2;
            this.btTinhDuongDi.Text = "Tính";
            this.btTinhDuongDi.UseVisualStyleBackColor = true;
            this.btTinhDuongDi.Click += new System.EventHandler(this.btTinhDuongDi_Click);
            // 
            // mnMenu
            // 
            this.mnMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(625, 28);
            this.mnMenu.TabIndex = 11;
            this.mnMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbLog);
            this.groupBox3.Location = new System.Drawing.Point(13, 472);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(604, 106);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(16, 23);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(584, 72);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // cbbDiemDau
            // 
            this.cbbDiemDau.FormattingEnabled = true;
            this.cbbDiemDau.Location = new System.Drawing.Point(21, 49);
            this.cbbDiemDau.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemDau.Name = "cbbDiemDau";
            this.cbbDiemDau.Size = new System.Drawing.Size(185, 24);
            this.cbbDiemDau.TabIndex = 1;
            // 
            // cbbDiemCuoi
            // 
            this.cbbDiemCuoi.FormattingEnabled = true;
            this.cbbDiemCuoi.Location = new System.Drawing.Point(266, 49);
            this.cbbDiemCuoi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDiemCuoi.Name = "cbbDiemCuoi";
            this.cbbDiemCuoi.Size = new System.Drawing.Size(185, 24);
            this.cbbDiemCuoi.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbDiemCuoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbDiemDau);
            this.groupBox2.Controls.Add(this.btTinhDuongDi);
            this.groupBox2.Location = new System.Drawing.Point(13, 379);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(604, 85);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính Đường Đi";
            // 
            // fDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Controls.Add(this.mnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDijkstra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Shortest Path";
            this.Load += new System.EventHandler(this.fDijkstra_Load);
            this.groupBox1.ResumeLayout(false);
            this.FlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SGMap)).EndInit();
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SGMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDanhSachDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        private System.Windows.Forms.Button btTinhDuongDi;
        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbDiemDau;
        private System.Windows.Forms.ComboBox cbbDiemCuoi;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

