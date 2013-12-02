namespace boligportalbot
{
    partial class OfferForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.created_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rent_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.go_to_web_btn = new System.Windows.Forms.Button();
            this.rooms_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // title_txt
            // 
            this.title_txt.Location = new System.Drawing.Point(75, 5);
            this.title_txt.Name = "title_txt";
            this.title_txt.ReadOnly = true;
            this.title_txt.Size = new System.Drawing.Size(274, 20);
            this.title_txt.TabIndex = 1;
            this.title_txt.TabStop = false;
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(75, 31);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.ReadOnly = true;
            this.description_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_txt.Size = new System.Drawing.Size(274, 121);
            this.description_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // created_txt
            // 
            this.created_txt.Location = new System.Drawing.Point(75, 158);
            this.created_txt.Name = "created_txt";
            this.created_txt.ReadOnly = true;
            this.created_txt.Size = new System.Drawing.Size(274, 20);
            this.created_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Created";
            // 
            // rent_txt
            // 
            this.rent_txt.Location = new System.Drawing.Point(75, 184);
            this.rent_txt.Name = "rent_txt";
            this.rent_txt.ReadOnly = true;
            this.rent_txt.Size = new System.Drawing.Size(274, 20);
            this.rent_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rent";
            // 
            // go_to_web_btn
            // 
            this.go_to_web_btn.Location = new System.Drawing.Point(151, 235);
            this.go_to_web_btn.Name = "go_to_web_btn";
            this.go_to_web_btn.Size = new System.Drawing.Size(198, 44);
            this.go_to_web_btn.TabIndex = 0;
            this.go_to_web_btn.Text = "See the offer on boligportal.dk";
            this.go_to_web_btn.UseVisualStyleBackColor = true;
            this.go_to_web_btn.Click += new System.EventHandler(this.go_to_web_btn_Click);
            // 
            // rooms_txt
            // 
            this.rooms_txt.Location = new System.Drawing.Point(75, 209);
            this.rooms_txt.Name = "rooms_txt";
            this.rooms_txt.ReadOnly = true;
            this.rooms_txt.Size = new System.Drawing.Size(274, 20);
            this.rooms_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "m2";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(75, 235);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(70, 44);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 289);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.rooms_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.go_to_web_btn);
            this.Controls.Add(this.rent_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.created_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.label1);
            this.Name = "OfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Offer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox created_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rent_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button go_to_web_btn;
        private System.Windows.Forms.TextBox rooms_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_btn;
    }
}