﻿namespace LLHelper_AutoPlay
{
    partial class MainForm
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
            this.btn_HookListen = new System.Windows.Forms.Button();
            this.lab_State_HookListen = new System.Windows.Forms.Label();
            this.btn_NetCatch = new System.Windows.Forms.Button();
            this.btn_ShowHttpLog = new System.Windows.Forms.Button();
            this.text_Log = new System.Windows.Forms.TextBox();
            this.lab_State_NetCatch = new System.Windows.Forms.Label();
            this.text_Setting = new System.Windows.Forms.TextBox();
            this.lab_State_Running = new System.Windows.Forms.Label();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_ShowColorPlayForm = new System.Windows.Forms.Button();
            this.btn_LoadListFromFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_GetLivelist = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_HookListen
            // 
            this.btn_HookListen.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_HookListen.Location = new System.Drawing.Point(12, 45);
            this.btn_HookListen.Name = "btn_HookListen";
            this.btn_HookListen.Size = new System.Drawing.Size(120, 40);
            this.btn_HookListen.TabIndex = 0;
            this.btn_HookListen.Text = "监听按键";
            this.btn_HookListen.UseVisualStyleBackColor = true;
            this.btn_HookListen.Click += new System.EventHandler(this.Btn_HookListen_Click);
            // 
            // lab_State_HookListen
            // 
            this.lab_State_HookListen.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold);
            this.lab_State_HookListen.ForeColor = System.Drawing.Color.Red;
            this.lab_State_HookListen.Location = new System.Drawing.Point(12, 9);
            this.lab_State_HookListen.Name = "lab_State_HookListen";
            this.lab_State_HookListen.Size = new System.Drawing.Size(120, 33);
            this.lab_State_HookListen.TabIndex = 1;
            this.lab_State_HookListen.Text = "未监听";
            this.lab_State_HookListen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NetCatch
            // 
            this.btn_NetCatch.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_NetCatch.Location = new System.Drawing.Point(172, 45);
            this.btn_NetCatch.Name = "btn_NetCatch";
            this.btn_NetCatch.Size = new System.Drawing.Size(120, 40);
            this.btn_NetCatch.TabIndex = 3;
            this.btn_NetCatch.Text = "抓包";
            this.btn_NetCatch.UseVisualStyleBackColor = true;
            this.btn_NetCatch.Click += new System.EventHandler(this.Btn_NetCatch_Click);
            // 
            // btn_ShowHttpLog
            // 
            this.btn_ShowHttpLog.Location = new System.Drawing.Point(12, 632);
            this.btn_ShowHttpLog.Name = "btn_ShowHttpLog";
            this.btn_ShowHttpLog.Size = new System.Drawing.Size(78, 37);
            this.btn_ShowHttpLog.TabIndex = 4;
            this.btn_ShowHttpLog.Text = "显示Http包\r\n(调试用)";
            this.btn_ShowHttpLog.UseVisualStyleBackColor = true;
            this.btn_ShowHttpLog.Click += new System.EventHandler(this.Btn_ShowHttpLog_Click);
            // 
            // text_Log
            // 
            this.text_Log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Log.Location = new System.Drawing.Point(12, 323);
            this.text_Log.Multiline = true;
            this.text_Log.Name = "text_Log";
            this.text_Log.ReadOnly = true;
            this.text_Log.Size = new System.Drawing.Size(280, 303);
            this.text_Log.TabIndex = 5;
            // 
            // lab_State_NetCatch
            // 
            this.lab_State_NetCatch.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold);
            this.lab_State_NetCatch.ForeColor = System.Drawing.Color.Red;
            this.lab_State_NetCatch.Location = new System.Drawing.Point(172, 9);
            this.lab_State_NetCatch.Name = "lab_State_NetCatch";
            this.lab_State_NetCatch.Size = new System.Drawing.Size(120, 33);
            this.lab_State_NetCatch.TabIndex = 1;
            this.lab_State_NetCatch.Text = "未抓包";
            this.lab_State_NetCatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_Setting
            // 
            this.text_Setting.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Setting.Location = new System.Drawing.Point(12, 155);
            this.text_Setting.Multiline = true;
            this.text_Setting.Name = "text_Setting";
            this.text_Setting.ReadOnly = true;
            this.text_Setting.Size = new System.Drawing.Size(280, 162);
            this.text_Setting.TabIndex = 5;
            // 
            // lab_State_Running
            // 
            this.lab_State_Running.Font = new System.Drawing.Font("黑体", 32F, System.Drawing.FontStyle.Bold);
            this.lab_State_Running.ForeColor = System.Drawing.Color.Red;
            this.lab_State_Running.Location = new System.Drawing.Point(12, 88);
            this.lab_State_Running.Name = "lab_State_Running";
            this.lab_State_Running.Size = new System.Drawing.Size(280, 64);
            this.lab_State_Running.TabIndex = 1;
            this.lab_State_Running.Text = "未运行";
            this.lab_State_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(206, 675);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(40, 37);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.Text = "设置";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.Btn_ShowSetting_Click);
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(252, 675);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(40, 37);
            this.btn_About.TabIndex = 6;
            this.btn_About.Text = "关于";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // btn_ShowColorPlayForm
            // 
            this.btn_ShowColorPlayForm.Location = new System.Drawing.Point(96, 632);
            this.btn_ShowColorPlayForm.Name = "btn_ShowColorPlayForm";
            this.btn_ShowColorPlayForm.Size = new System.Drawing.Size(104, 37);
            this.btn_ShowColorPlayForm.TabIndex = 7;
            this.btn_ShowColorPlayForm.Text = "图色打歌工具\r\n(测试)";
            this.btn_ShowColorPlayForm.UseVisualStyleBackColor = true;
            this.btn_ShowColorPlayForm.Click += new System.EventHandler(this.Btn_ShowColorPlayForm_Click);
            // 
            // btn_LoadListFromFile
            // 
            this.btn_LoadListFromFile.Location = new System.Drawing.Point(206, 632);
            this.btn_LoadListFromFile.Name = "btn_LoadListFromFile";
            this.btn_LoadListFromFile.Size = new System.Drawing.Size(86, 37);
            this.btn_LoadListFromFile.TabIndex = 8;
            this.btn_LoadListFromFile.Text = "选谱";
            this.btn_LoadListFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadListFromFile.Click += new System.EventHandler(this.Btn_LoadListFromFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "更新 : 2018-12-22 21:30";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "谱面数据";
            // 
            // btn_GetLivelist
            // 
            this.btn_GetLivelist.Location = new System.Drawing.Point(12, 675);
            this.btn_GetLivelist.Name = "btn_GetLivelist";
            this.btn_GetLivelist.Size = new System.Drawing.Size(78, 37);
            this.btn_GetLivelist.TabIndex = 10;
            this.btn_GetLivelist.Text = "获取谱面";
            this.btn_GetLivelist.UseVisualStyleBackColor = true;
            this.btn_GetLivelist.Click += new System.EventHandler(this.Btn_GetLivelist_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 737);
            this.Controls.Add(this.btn_GetLivelist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LoadListFromFile);
            this.Controls.Add(this.btn_ShowColorPlayForm);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.text_Setting);
            this.Controls.Add(this.text_Log);
            this.Controls.Add(this.btn_ShowHttpLog);
            this.Controls.Add(this.btn_NetCatch);
            this.Controls.Add(this.lab_State_Running);
            this.Controls.Add(this.lab_State_NetCatch);
            this.Controls.Add(this.lab_State_HookListen);
            this.Controls.Add(this.btn_HookListen);
            this.Name = "MainForm";
            this.Text = "LLHelper_AutoPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HookListen;
        private System.Windows.Forms.Label lab_State_HookListen;
        private System.Windows.Forms.Button btn_NetCatch;
        private System.Windows.Forms.Button btn_ShowHttpLog;
        private System.Windows.Forms.TextBox text_Log;
        private System.Windows.Forms.Label lab_State_NetCatch;
        private System.Windows.Forms.TextBox text_Setting;
        private System.Windows.Forms.Label lab_State_Running;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_ShowColorPlayForm;
        private System.Windows.Forms.Button btn_LoadListFromFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_GetLivelist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

