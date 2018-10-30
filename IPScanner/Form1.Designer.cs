namespace IPScanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Btn_Minisize = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.PictureBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ThreadCount = new System.Windows.Forms.TextBox();
            this.Lbl_ThreadCount = new System.Windows.Forms.Label();
            this.Btn_Scan = new System.Windows.Forms.Button();
            this.IPBox_EndAddress = new IPAddressControlLib.IPAddressControl();
            this.IPBox_BeginAddress = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_Title.Controls.Add(this.Btn_Minisize);
            this.Panel_Title.Controls.Add(this.Btn_Close);
            this.Panel_Title.Controls.Add(this.Lbl_Title);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(765, 35);
            this.Panel_Title.TabIndex = 0;
            // 
            // Btn_Minisize
            // 
            this.Btn_Minisize.Image = global::IPScanner.Properties.Resources.Btn_MiniSize;
            this.Btn_Minisize.Location = new System.Drawing.Point(697, 6);
            this.Btn_Minisize.Name = "Btn_Minisize";
            this.Btn_Minisize.Size = new System.Drawing.Size(25, 23);
            this.Btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Btn_Minisize.TabIndex = 4;
            this.Btn_Minisize.TabStop = false;
            this.Btn_Minisize.Click += new System.EventHandler(this.Btn_Minisize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Image = global::IPScanner.Properties.Resources.Btn_Close;
            this.Btn_Close.Location = new System.Drawing.Point(728, 6);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(25, 23);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Title.Location = new System.Drawing.Point(8, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(103, 17);
            this.Lbl_Title.TabIndex = 3;
            this.Lbl_Title.Text = "局域网IP扫描工具";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 64);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(765, 345);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "序号";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP地址";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAC地址";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "主机名";
            this.columnHeader5.Width = 180;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "online.png");
            this.imageList1.Images.SetKeyName(1, "offline.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBox_ThreadCount);
            this.panel2.Controls.Add(this.Lbl_ThreadCount);
            this.panel2.Controls.Add(this.Btn_Scan);
            this.panel2.Controls.Add(this.IPBox_EndAddress);
            this.panel2.Controls.Add(this.IPBox_BeginAddress);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 64);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // TextBox_ThreadCount
            // 
            this.TextBox_ThreadCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_ThreadCount.Location = new System.Drawing.Point(479, 20);
            this.TextBox_ThreadCount.Name = "TextBox_ThreadCount";
            this.TextBox_ThreadCount.Size = new System.Drawing.Size(54, 23);
            this.TextBox_ThreadCount.TabIndex = 4;
            this.TextBox_ThreadCount.Text = "2";
            this.TextBox_ThreadCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ThreadCount_KeyPress);
            // 
            // Lbl_ThreadCount
            // 
            this.Lbl_ThreadCount.AutoSize = true;
            this.Lbl_ThreadCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_ThreadCount.Location = new System.Drawing.Point(419, 23);
            this.Lbl_ThreadCount.Name = "Lbl_ThreadCount";
            this.Lbl_ThreadCount.Size = new System.Drawing.Size(56, 17);
            this.Lbl_ThreadCount.TabIndex = 3;
            this.Lbl_ThreadCount.Text = "线程数：";
            // 
            // Btn_Scan
            // 
            this.Btn_Scan.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Scan.FlatAppearance.BorderSize = 0;
            this.Btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Scan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Scan.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Scan.Location = new System.Drawing.Point(678, 16);
            this.Btn_Scan.Name = "Btn_Scan";
            this.Btn_Scan.Size = new System.Drawing.Size(75, 28);
            this.Btn_Scan.TabIndex = 2;
            this.Btn_Scan.Text = "扫描";
            this.Btn_Scan.UseVisualStyleBackColor = false;
            this.Btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // IPBox_EndAddress
            // 
            this.IPBox_EndAddress.AllowInternalTab = false;
            this.IPBox_EndAddress.AutoHeight = true;
            this.IPBox_EndAddress.BackColor = System.Drawing.SystemColors.Window;
            this.IPBox_EndAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPBox_EndAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPBox_EndAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPBox_EndAddress.Location = new System.Drawing.Point(257, 20);
            this.IPBox_EndAddress.MinimumSize = new System.Drawing.Size(99, 23);
            this.IPBox_EndAddress.Name = "IPBox_EndAddress";
            this.IPBox_EndAddress.ReadOnly = false;
            this.IPBox_EndAddress.Size = new System.Drawing.Size(130, 23);
            this.IPBox_EndAddress.TabIndex = 1;
            this.IPBox_EndAddress.Text = "192.168.1.10";
            // 
            // IPBox_BeginAddress
            // 
            this.IPBox_BeginAddress.AllowInternalTab = false;
            this.IPBox_BeginAddress.AutoHeight = true;
            this.IPBox_BeginAddress.BackColor = System.Drawing.SystemColors.Window;
            this.IPBox_BeginAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPBox_BeginAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPBox_BeginAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPBox_BeginAddress.Location = new System.Drawing.Point(101, 20);
            this.IPBox_BeginAddress.MinimumSize = new System.Drawing.Size(99, 23);
            this.IPBox_BeginAddress.Name = "IPBox_BeginAddress";
            this.IPBox_BeginAddress.ReadOnly = false;
            this.IPBox_BeginAddress.Size = new System.Drawing.Size(122, 23);
            this.IPBox_BeginAddress.TabIndex = 0;
            this.IPBox_BeginAddress.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "扫描的IP段：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Status, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 432);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Status.Location = new System.Drawing.Point(3, 409);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(759, 23);
            this.Lbl_Status.TabIndex = 3;
            this.Lbl_Status.Text = "...";
            this.Lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label label1;
        private IPAddressControlLib.IPAddressControl IPBox_BeginAddress;
        private IPAddressControlLib.IPAddressControl IPBox_EndAddress;
        private System.Windows.Forms.Button Btn_Scan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Btn_Close;
        private System.Windows.Forms.PictureBox Btn_Minisize;
        private System.Windows.Forms.TextBox TextBox_ThreadCount;
        private System.Windows.Forms.Label Lbl_ThreadCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

