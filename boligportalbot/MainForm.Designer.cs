namespace boligportalbot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.query_worker = new System.ComponentModel.BackgroundWorker();
            this.start_scan_btn = new System.Windows.Forms.Button();
            this.stop_scan_btn = new System.Windows.Forms.Button();
            this.search_criteria_btn = new System.Windows.Forms.Button();
            this.system_message_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.system_info_groupbox = new System.Windows.Forms.GroupBox();
            this.scan_status_txt = new System.Windows.Forms.TextBox();
            this.offer_groupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loading_pic = new System.Windows.Forms.PictureBox();
            this.fixed_output_btn = new System.Windows.Forms.Button();
            this.system_info_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // query_worker
            // 
            this.query_worker.WorkerSupportsCancellation = true;
            this.query_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.query_worker_DoWork);
            this.query_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.query_worker_RunWorkerCompleted);
            // 
            // start_scan_btn
            // 
            this.start_scan_btn.Location = new System.Drawing.Point(12, 88);
            this.start_scan_btn.Name = "start_scan_btn";
            this.start_scan_btn.Size = new System.Drawing.Size(231, 39);
            this.start_scan_btn.TabIndex = 0;
            this.start_scan_btn.TabStop = false;
            this.start_scan_btn.Text = "Start Scanning";
            this.start_scan_btn.UseVisualStyleBackColor = true;
            this.start_scan_btn.Click += new System.EventHandler(this.start_scan_btn_Click);
            // 
            // stop_scan_btn
            // 
            this.stop_scan_btn.Enabled = false;
            this.stop_scan_btn.Location = new System.Drawing.Point(12, 133);
            this.stop_scan_btn.Name = "stop_scan_btn";
            this.stop_scan_btn.Size = new System.Drawing.Size(231, 39);
            this.stop_scan_btn.TabIndex = 1;
            this.stop_scan_btn.Text = "Stop Scanning";
            this.stop_scan_btn.UseVisualStyleBackColor = true;
            this.stop_scan_btn.Click += new System.EventHandler(this.stop_scan_btn_Click);
            // 
            // search_criteria_btn
            // 
            this.search_criteria_btn.Location = new System.Drawing.Point(12, 43);
            this.search_criteria_btn.Name = "search_criteria_btn";
            this.search_criteria_btn.Size = new System.Drawing.Size(231, 39);
            this.search_criteria_btn.TabIndex = 0;
            this.search_criteria_btn.Text = "Set Search Criteria";
            this.search_criteria_btn.UseVisualStyleBackColor = true;
            this.search_criteria_btn.Click += new System.EventHandler(this.search_criteria_btn_Click);
            // 
            // system_message_txt
            // 
            this.system_message_txt.Location = new System.Drawing.Point(6, 25);
            this.system_message_txt.Multiline = true;
            this.system_message_txt.Name = "system_message_txt";
            this.system_message_txt.ReadOnly = true;
            this.system_message_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.system_message_txt.Size = new System.Drawing.Size(219, 108);
            this.system_message_txt.TabIndex = 3;
            this.system_message_txt.TextChanged += new System.EventHandler(this.system_message_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // system_info_groupbox
            // 
            this.system_info_groupbox.Controls.Add(this.system_message_txt);
            this.system_info_groupbox.Location = new System.Drawing.Point(12, 178);
            this.system_info_groupbox.Name = "system_info_groupbox";
            this.system_info_groupbox.Size = new System.Drawing.Size(231, 139);
            this.system_info_groupbox.TabIndex = 5;
            this.system_info_groupbox.TabStop = false;
            this.system_info_groupbox.Text = "System Log";
            // 
            // scan_status_txt
            // 
            this.scan_status_txt.Location = new System.Drawing.Point(48, 12);
            this.scan_status_txt.Name = "scan_status_txt";
            this.scan_status_txt.ReadOnly = true;
            this.scan_status_txt.Size = new System.Drawing.Size(164, 20);
            this.scan_status_txt.TabIndex = 6;
            this.scan_status_txt.Text = "Stopped";
            // 
            // offer_groupbox
            // 
            this.offer_groupbox.Location = new System.Drawing.Point(249, 12);
            this.offer_groupbox.Name = "offer_groupbox";
            this.offer_groupbox.Size = new System.Drawing.Size(375, 474);
            this.offer_groupbox.TabIndex = 7;
            this.offer_groupbox.TabStop = false;
            this.offer_groupbox.Text = "Offers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // loading_pic
            // 
            this.loading_pic.Image = ((System.Drawing.Image)(resources.GetObject("loading_pic.Image")));
            this.loading_pic.Location = new System.Drawing.Point(218, 12);
            this.loading_pic.Name = "loading_pic";
            this.loading_pic.Size = new System.Drawing.Size(25, 29);
            this.loading_pic.TabIndex = 9;
            this.loading_pic.TabStop = false;
            this.loading_pic.Visible = false;
            // 
            // fixed_output_btn
            // 
            this.fixed_output_btn.Location = new System.Drawing.Point(48, 404);
            this.fixed_output_btn.Name = "fixed_output_btn";
            this.fixed_output_btn.Size = new System.Drawing.Size(75, 23);
            this.fixed_output_btn.TabIndex = 10;
            this.fixed_output_btn.Text = "TEST";
            this.fixed_output_btn.UseVisualStyleBackColor = true;
            this.fixed_output_btn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 491);
            this.Controls.Add(this.fixed_output_btn);
            this.Controls.Add(this.loading_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offer_groupbox);
            this.Controls.Add(this.scan_status_txt);
            this.Controls.Add(this.system_info_groupbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_criteria_btn);
            this.Controls.Add(this.stop_scan_btn);
            this.Controls.Add(this.start_scan_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Boligportal Scanner";
            this.system_info_groupbox.ResumeLayout(false);
            this.system_info_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker query_worker;
        private System.Windows.Forms.Button start_scan_btn;
        private System.Windows.Forms.Button stop_scan_btn;
        private System.Windows.Forms.Button search_criteria_btn;
        private System.Windows.Forms.TextBox system_message_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox system_info_groupbox;
        private System.Windows.Forms.TextBox scan_status_txt;
        private System.Windows.Forms.GroupBox offer_groupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox loading_pic;
        private System.Windows.Forms.Button fixed_output_btn;





    }
}

