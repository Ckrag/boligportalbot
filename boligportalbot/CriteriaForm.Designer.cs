namespace boligportalbot
{
    partial class CriteriaForm
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
            this.amt_selection_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postnr_gb = new System.Windows.Forms.GroupBox();
            this.postnr_panel = new System.Windows.Forms.Panel();
            this.type_gb = new System.Windows.Forms.GroupBox();
            this.parking_cb = new System.Windows.Forms.CheckBox();
            this.house_villa_cb = new System.Windows.Forms.CheckBox();
            this.four_room_aprt_cb = new System.Windows.Forms.CheckBox();
            this.three_room_aprt_cb = new System.Windows.Forms.CheckBox();
            this.two_room_aprt_cb = new System.Windows.Forms.CheckBox();
            this.one_room_aprt_cb = new System.Windows.Forms.CheckBox();
            this.all_aprt_cb = new System.Windows.Forms.CheckBox();
            this.all_types_cb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.only_sharefriendly_cb = new System.Windows.Forms.CheckBox();
            this.only_furnished_cb = new System.Windows.Forms.CheckBox();
            this.pets_cb = new System.Windows.Forms.CheckBox();
            this.only_img_cb = new System.Windows.Forms.CheckBox();
            this.only_public = new System.Windows.Forms.CheckBox();
            this.only_sublets_cb = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.max_size_txt = new System.Windows.Forms.TextBox();
            this.min_size_txt = new System.Windows.Forms.TextBox();
            this.max_price_txt = new System.Windows.Forms.TextBox();
            this.min_price_txt = new System.Windows.Forms.TextBox();
            this.rent_priod_gb = new System.Windows.Forms.GroupBox();
            this.rent_period_all_cb = new System.Windows.Forms.CheckBox();
            this.rent_period_unlimited_cb = new System.Windows.Forms.CheckBox();
            this.rent_period_moreyears_cb = new System.Windows.Forms.CheckBox();
            this.rent_period_years_cb = new System.Windows.Forms.CheckBox();
            this.period_months_cb = new System.Windows.Forms.CheckBox();
            this.accept_settings_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.postnr_gb.SuspendLayout();
            this.type_gb.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rent_priod_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // amt_selection_cmb
            // 
            this.amt_selection_cmb.FormattingEnabled = true;
            this.amt_selection_cmb.Location = new System.Drawing.Point(12, 12);
            this.amt_selection_cmb.Name = "amt_selection_cmb";
            this.amt_selection_cmb.Size = new System.Drawing.Size(236, 21);
            this.amt_selection_cmb.TabIndex = 0;
            this.amt_selection_cmb.SelectedIndexChanged += new System.EventHandler(this.amt_selection_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amt/Region";
            // 
            // postnr_gb
            // 
            this.postnr_gb.Controls.Add(this.postnr_panel);
            this.postnr_gb.Location = new System.Drawing.Point(13, 40);
            this.postnr_gb.Name = "postnr_gb";
            this.postnr_gb.Size = new System.Drawing.Size(235, 442);
            this.postnr_gb.TabIndex = 2;
            this.postnr_gb.TabStop = false;
            this.postnr_gb.Text = "Post Districts";
            // 
            // postnr_panel
            // 
            this.postnr_panel.AutoScroll = true;
            this.postnr_panel.Location = new System.Drawing.Point(6, 13);
            this.postnr_panel.Name = "postnr_panel";
            this.postnr_panel.Size = new System.Drawing.Size(222, 423);
            this.postnr_panel.TabIndex = 3;
            // 
            // type_gb
            // 
            this.type_gb.Controls.Add(this.parking_cb);
            this.type_gb.Controls.Add(this.house_villa_cb);
            this.type_gb.Controls.Add(this.four_room_aprt_cb);
            this.type_gb.Controls.Add(this.three_room_aprt_cb);
            this.type_gb.Controls.Add(this.two_room_aprt_cb);
            this.type_gb.Controls.Add(this.one_room_aprt_cb);
            this.type_gb.Controls.Add(this.all_aprt_cb);
            this.type_gb.Controls.Add(this.all_types_cb);
            this.type_gb.Location = new System.Drawing.Point(257, 40);
            this.type_gb.Name = "type_gb";
            this.type_gb.Size = new System.Drawing.Size(151, 221);
            this.type_gb.TabIndex = 3;
            this.type_gb.TabStop = false;
            this.type_gb.Text = "Type";
            // 
            // parking_cb
            // 
            this.parking_cb.AutoSize = true;
            this.parking_cb.Location = new System.Drawing.Point(7, 198);
            this.parking_cb.Name = "parking_cb";
            this.parking_cb.Size = new System.Drawing.Size(62, 17);
            this.parking_cb.TabIndex = 7;
            this.parking_cb.Text = "Parking";
            this.parking_cb.UseVisualStyleBackColor = true;
            // 
            // house_villa_cb
            // 
            this.house_villa_cb.AutoSize = true;
            this.house_villa_cb.Location = new System.Drawing.Point(7, 174);
            this.house_villa_cb.Name = "house_villa_cb";
            this.house_villa_cb.Size = new System.Drawing.Size(79, 17);
            this.house_villa_cb.TabIndex = 6;
            this.house_villa_cb.Text = "House/Vila";
            this.house_villa_cb.UseVisualStyleBackColor = true;
            // 
            // four_room_aprt_cb
            // 
            this.four_room_aprt_cb.AutoSize = true;
            this.four_room_aprt_cb.Location = new System.Drawing.Point(7, 151);
            this.four_room_aprt_cb.Name = "four_room_aprt_cb";
            this.four_room_aprt_cb.Size = new System.Drawing.Size(112, 17);
            this.four_room_aprt_cb.TabIndex = 5;
            this.four_room_aprt_cb.Text = "4 Rooms or bigger";
            this.four_room_aprt_cb.UseVisualStyleBackColor = true;
            // 
            // three_room_aprt_cb
            // 
            this.three_room_aprt_cb.AutoSize = true;
            this.three_room_aprt_cb.Location = new System.Drawing.Point(7, 127);
            this.three_room_aprt_cb.Name = "three_room_aprt_cb";
            this.three_room_aprt_cb.Size = new System.Drawing.Size(118, 17);
            this.three_room_aprt_cb.TabIndex = 4;
            this.three_room_aprt_cb.Text = "3 Rooms apartment";
            this.three_room_aprt_cb.UseVisualStyleBackColor = true;
            // 
            // two_room_aprt_cb
            // 
            this.two_room_aprt_cb.AutoSize = true;
            this.two_room_aprt_cb.Location = new System.Drawing.Point(7, 103);
            this.two_room_aprt_cb.Name = "two_room_aprt_cb";
            this.two_room_aprt_cb.Size = new System.Drawing.Size(118, 17);
            this.two_room_aprt_cb.TabIndex = 3;
            this.two_room_aprt_cb.Text = "2 Rooms apartment";
            this.two_room_aprt_cb.UseVisualStyleBackColor = true;
            // 
            // one_room_aprt_cb
            // 
            this.one_room_aprt_cb.AutoSize = true;
            this.one_room_aprt_cb.Location = new System.Drawing.Point(7, 79);
            this.one_room_aprt_cb.Name = "one_room_aprt_cb";
            this.one_room_aprt_cb.Size = new System.Drawing.Size(113, 17);
            this.one_room_aprt_cb.TabIndex = 2;
            this.one_room_aprt_cb.Text = "1 Room apartment";
            this.one_room_aprt_cb.UseVisualStyleBackColor = true;
            // 
            // all_aprt_cb
            // 
            this.all_aprt_cb.AutoSize = true;
            this.all_aprt_cb.Location = new System.Drawing.Point(7, 55);
            this.all_aprt_cb.Name = "all_aprt_cb";
            this.all_aprt_cb.Size = new System.Drawing.Size(74, 17);
            this.all_aprt_cb.TabIndex = 1;
            this.all_aprt_cb.Text = "Apartment";
            this.all_aprt_cb.UseVisualStyleBackColor = true;
            // 
            // all_types_cb
            // 
            this.all_types_cb.AutoSize = true;
            this.all_types_cb.Location = new System.Drawing.Point(7, 31);
            this.all_types_cb.Name = "all_types_cb";
            this.all_types_cb.Size = new System.Drawing.Size(65, 17);
            this.all_types_cb.TabIndex = 0;
            this.all_types_cb.Text = "All types";
            this.all_types_cb.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.only_sharefriendly_cb);
            this.groupBox4.Controls.Add(this.only_furnished_cb);
            this.groupBox4.Controls.Add(this.pets_cb);
            this.groupBox4.Controls.Add(this.only_img_cb);
            this.groupBox4.Controls.Add(this.only_public);
            this.groupBox4.Controls.Add(this.only_sublets_cb);
            this.groupBox4.Location = new System.Drawing.Point(414, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 286);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other options";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(65, 243);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(31, 20);
            this.textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(38, 243);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(21, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Latest acquisition date";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 243);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(21, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text Search (min 4 characters)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // only_sharefriendly_cb
            // 
            this.only_sharefriendly_cb.AutoSize = true;
            this.only_sharefriendly_cb.Location = new System.Drawing.Point(10, 135);
            this.only_sharefriendly_cb.Name = "only_sharefriendly_cb";
            this.only_sharefriendly_cb.Size = new System.Drawing.Size(140, 17);
            this.only_sharefriendly_cb.TabIndex = 5;
            this.only_sharefriendly_cb.Text = "Show only share friendly";
            this.only_sharefriendly_cb.UseVisualStyleBackColor = true;
            // 
            // only_furnished_cb
            // 
            this.only_furnished_cb.AutoSize = true;
            this.only_furnished_cb.Location = new System.Drawing.Point(10, 112);
            this.only_furnished_cb.Name = "only_furnished_cb";
            this.only_furnished_cb.Size = new System.Drawing.Size(199, 17);
            this.only_furnished_cb.TabIndex = 4;
            this.only_furnished_cb.Text = "Show only furnished accommodation";
            this.only_furnished_cb.UseVisualStyleBackColor = true;
            // 
            // pets_cb
            // 
            this.pets_cb.AutoSize = true;
            this.pets_cb.Location = new System.Drawing.Point(10, 89);
            this.pets_cb.Name = "pets_cb";
            this.pets_cb.Size = new System.Drawing.Size(86, 17);
            this.pets_cb.TabIndex = 3;
            this.pets_cb.Text = "Pets allowed";
            this.pets_cb.UseVisualStyleBackColor = true;
            // 
            // only_img_cb
            // 
            this.only_img_cb.AutoSize = true;
            this.only_img_cb.Location = new System.Drawing.Point(10, 66);
            this.only_img_cb.Name = "only_img_cb";
            this.only_img_cb.Size = new System.Drawing.Size(153, 17);
            this.only_img_cb.TabIndex = 2;
            this.only_img_cb.Text = "Show only ads with images";
            this.only_img_cb.UseVisualStyleBackColor = true;
            // 
            // only_public
            // 
            this.only_public.AutoSize = true;
            this.only_public.Location = new System.Drawing.Point(10, 43);
            this.only_public.Name = "only_public";
            this.only_public.Size = new System.Drawing.Size(146, 17);
            this.only_public.TabIndex = 1;
            this.only_public.Text = "Show only public housing";
            this.only_public.UseVisualStyleBackColor = true;
            // 
            // only_sublets_cb
            // 
            this.only_sublets_cb.AutoSize = true;
            this.only_sublets_cb.Location = new System.Drawing.Point(10, 20);
            this.only_sublets_cb.Name = "only_sublets_cb";
            this.only_sublets_cb.Size = new System.Drawing.Size(159, 17);
            this.only_sublets_cb.TabIndex = 0;
            this.only_sublets_cb.Text = "Show only sublets (Fremleje)";
            this.only_sublets_cb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.max_size_txt);
            this.groupBox2.Controls.Add(this.min_size_txt);
            this.groupBox2.Controls.Add(this.max_price_txt);
            this.groupBox2.Controls.Add(this.min_price_txt);
            this.groupBox2.Location = new System.Drawing.Point(257, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size and price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Size m2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min. Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min. Price";
            // 
            // max_size_txt
            // 
            this.max_size_txt.Location = new System.Drawing.Point(6, 150);
            this.max_size_txt.MaxLength = 4;
            this.max_size_txt.Name = "max_size_txt";
            this.max_size_txt.Size = new System.Drawing.Size(79, 20);
            this.max_size_txt.TabIndex = 3;
            // 
            // min_size_txt
            // 
            this.min_size_txt.Location = new System.Drawing.Point(6, 123);
            this.min_size_txt.MaxLength = 4;
            this.min_size_txt.Name = "min_size_txt";
            this.min_size_txt.Size = new System.Drawing.Size(79, 20);
            this.min_size_txt.TabIndex = 2;
            // 
            // max_price_txt
            // 
            this.max_price_txt.Location = new System.Drawing.Point(6, 71);
            this.max_price_txt.MaxLength = 6;
            this.max_price_txt.Name = "max_price_txt";
            this.max_price_txt.Size = new System.Drawing.Size(79, 20);
            this.max_price_txt.TabIndex = 1;
            // 
            // min_price_txt
            // 
            this.min_price_txt.Location = new System.Drawing.Point(6, 45);
            this.min_price_txt.MaxLength = 6;
            this.min_price_txt.Name = "min_price_txt";
            this.min_price_txt.Size = new System.Drawing.Size(79, 20);
            this.min_price_txt.TabIndex = 0;
            // 
            // rent_priod_gb
            // 
            this.rent_priod_gb.Controls.Add(this.rent_period_all_cb);
            this.rent_priod_gb.Controls.Add(this.rent_period_unlimited_cb);
            this.rent_priod_gb.Controls.Add(this.rent_period_moreyears_cb);
            this.rent_priod_gb.Controls.Add(this.rent_period_years_cb);
            this.rent_priod_gb.Controls.Add(this.period_months_cb);
            this.rent_priod_gb.Location = new System.Drawing.Point(414, 40);
            this.rent_priod_gb.Name = "rent_priod_gb";
            this.rent_priod_gb.Size = new System.Drawing.Size(134, 144);
            this.rent_priod_gb.TabIndex = 5;
            this.rent_priod_gb.TabStop = false;
            this.rent_priod_gb.Text = "Min. period of renting";
            // 
            // rent_period_all_cb
            // 
            this.rent_period_all_cb.AutoSize = true;
            this.rent_period_all_cb.Location = new System.Drawing.Point(10, 112);
            this.rent_period_all_cb.Name = "rent_period_all_cb";
            this.rent_period_all_cb.Size = new System.Drawing.Size(76, 17);
            this.rent_period_all_cb.TabIndex = 4;
            this.rent_period_all_cb.Text = "Everything";
            this.rent_period_all_cb.UseVisualStyleBackColor = true;
            // 
            // rent_period_unlimited_cb
            // 
            this.rent_period_unlimited_cb.AutoSize = true;
            this.rent_period_unlimited_cb.Location = new System.Drawing.Point(10, 89);
            this.rent_period_unlimited_cb.Name = "rent_period_unlimited_cb";
            this.rent_period_unlimited_cb.Size = new System.Drawing.Size(69, 17);
            this.rent_period_unlimited_cb.TabIndex = 3;
            this.rent_period_unlimited_cb.Text = "Unlimited";
            this.rent_period_unlimited_cb.UseVisualStyleBackColor = true;
            // 
            // rent_period_moreyears_cb
            // 
            this.rent_period_moreyears_cb.AutoSize = true;
            this.rent_period_moreyears_cb.Location = new System.Drawing.Point(10, 66);
            this.rent_period_moreyears_cb.Name = "rent_period_moreyears_cb";
            this.rent_period_moreyears_cb.Size = new System.Drawing.Size(68, 17);
            this.rent_period_moreyears_cb.TabIndex = 2;
            this.rent_period_moreyears_cb.Text = "+2 Years";
            this.rent_period_moreyears_cb.UseVisualStyleBackColor = true;
            // 
            // rent_period_years_cb
            // 
            this.rent_period_years_cb.AutoSize = true;
            this.rent_period_years_cb.Location = new System.Drawing.Point(10, 43);
            this.rent_period_years_cb.Name = "rent_period_years_cb";
            this.rent_period_years_cb.Size = new System.Drawing.Size(71, 17);
            this.rent_period_years_cb.TabIndex = 1;
            this.rent_period_years_cb.Text = "1-2 Years";
            this.rent_period_years_cb.UseVisualStyleBackColor = true;
            // 
            // period_months_cb
            // 
            this.period_months_cb.AutoSize = true;
            this.period_months_cb.Location = new System.Drawing.Point(10, 20);
            this.period_months_cb.Name = "period_months_cb";
            this.period_months_cb.Size = new System.Drawing.Size(85, 17);
            this.period_months_cb.TabIndex = 0;
            this.period_months_cb.Text = "2-12 Months";
            this.period_months_cb.UseVisualStyleBackColor = true;
            // 
            // accept_settings_btn
            // 
            this.accept_settings_btn.Location = new System.Drawing.Point(19, 515);
            this.accept_settings_btn.Name = "accept_settings_btn";
            this.accept_settings_btn.Size = new System.Drawing.Size(75, 23);
            this.accept_settings_btn.TabIndex = 7;
            this.accept_settings_btn.Text = "Accept";
            this.accept_settings_btn.UseVisualStyleBackColor = true;
            this.accept_settings_btn.Click += new System.EventHandler(this.accept_settings_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.accept_settings_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rent_priod_gb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.type_gb);
            this.Controls.Add(this.postnr_gb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amt_selection_cmb);
            this.Name = "CriteriaForm";
            this.Text = "CriteriaForm";
            this.postnr_gb.ResumeLayout(false);
            this.type_gb.ResumeLayout(false);
            this.type_gb.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.rent_priod_gb.ResumeLayout(false);
            this.rent_priod_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox amt_selection_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox postnr_gb;
        private System.Windows.Forms.Panel postnr_panel;
        private System.Windows.Forms.GroupBox type_gb;
        private System.Windows.Forms.CheckBox all_aprt_cb;
        private System.Windows.Forms.CheckBox all_types_cb;
        private System.Windows.Forms.CheckBox parking_cb;
        private System.Windows.Forms.CheckBox house_villa_cb;
        private System.Windows.Forms.CheckBox four_room_aprt_cb;
        private System.Windows.Forms.CheckBox three_room_aprt_cb;
        private System.Windows.Forms.CheckBox two_room_aprt_cb;
        private System.Windows.Forms.CheckBox one_room_aprt_cb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox max_size_txt;
        private System.Windows.Forms.TextBox min_size_txt;
        private System.Windows.Forms.TextBox max_price_txt;
        private System.Windows.Forms.TextBox min_price_txt;
        private System.Windows.Forms.GroupBox rent_priod_gb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox rent_period_all_cb;
        private System.Windows.Forms.CheckBox rent_period_unlimited_cb;
        private System.Windows.Forms.CheckBox rent_period_moreyears_cb;
        private System.Windows.Forms.CheckBox rent_period_years_cb;
        private System.Windows.Forms.CheckBox period_months_cb;
        private System.Windows.Forms.CheckBox only_sharefriendly_cb;
        private System.Windows.Forms.CheckBox only_furnished_cb;
        private System.Windows.Forms.CheckBox pets_cb;
        private System.Windows.Forms.CheckBox only_img_cb;
        private System.Windows.Forms.CheckBox only_public;
        private System.Windows.Forms.CheckBox only_sublets_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button accept_settings_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}