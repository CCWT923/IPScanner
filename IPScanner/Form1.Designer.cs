﻿namespace IPScanner
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
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IPBox_BeginAddress = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.IPBox_EndAddress = new IPAddressControlLib.IPAddressControl();
            this.Btn_Scan = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel_Title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_Title.Controls.Add(this.Lbl_Title);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(812, 35);
            this.Panel_Title.TabIndex = 0;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Title.Location = new System.Drawing.Point(8, 8);
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
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(812, 396);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Scan);
            this.panel2.Controls.Add(this.IPBox_EndAddress);
            this.panel2.Controls.Add(this.IPBox_BeginAddress);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 59);
            this.panel2.TabIndex = 2;
            // 
            // IPBox_BeginAddress
            // 
            this.IPBox_BeginAddress.AllowInternalTab = false;
            this.IPBox_BeginAddress.AutoHeight = true;
            this.IPBox_BeginAddress.BackColor = System.Drawing.SystemColors.Window;
            this.IPBox_BeginAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPBox_BeginAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPBox_BeginAddress.Location = new System.Drawing.Point(92, 20);
            this.IPBox_BeginAddress.MinimumSize = new System.Drawing.Size(96, 21);
            this.IPBox_BeginAddress.Name = "IPBox_BeginAddress";
            this.IPBox_BeginAddress.ReadOnly = false;
            this.IPBox_BeginAddress.Size = new System.Drawing.Size(135, 21);
            this.IPBox_BeginAddress.TabIndex = 0;
            this.IPBox_BeginAddress.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "扫描的IP段：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPBox_EndAddress
            // 
            this.IPBox_EndAddress.AllowInternalTab = false;
            this.IPBox_EndAddress.AutoHeight = true;
            this.IPBox_EndAddress.BackColor = System.Drawing.SystemColors.Window;
            this.IPBox_EndAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPBox_EndAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPBox_EndAddress.Location = new System.Drawing.Point(233, 20);
            this.IPBox_EndAddress.MinimumSize = new System.Drawing.Size(96, 21);
            this.IPBox_EndAddress.Name = "IPBox_EndAddress";
            this.IPBox_EndAddress.ReadOnly = false;
            this.IPBox_EndAddress.Size = new System.Drawing.Size(135, 21);
            this.IPBox_EndAddress.TabIndex = 1;
            this.IPBox_EndAddress.Text = "...";
            // 
            // Btn_Scan
            // 
            this.Btn_Scan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Scan.FlatAppearance.BorderSize = 0;
            this.Btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Scan.Location = new System.Drawing.Point(734, 6);
            this.Btn_Scan.Name = "Btn_Scan";
            this.Btn_Scan.Size = new System.Drawing.Size(75, 47);
            this.Btn_Scan.TabIndex = 2;
            this.Btn_Scan.Text = "扫描";
            this.Btn_Scan.UseVisualStyleBackColor = false;
            this.Btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MAC";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HostName";
            this.columnHeader4.Width = 177;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

