namespace travo
{
    partial class FormAdminPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPelanggan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.labelpelanggan = new System.Windows.Forms.Label();
            this.btlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbidpelanggan = new System.Windows.Forms.TextBox();
            this.tbnamapelanggan = new System.Windows.Forms.TextBox();
            this.tbnotelp = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.cbkewarganegaraan = new System.Windows.Forms.ComboBox();
            this.rbfalseupdate = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pbback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 332);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cellclick);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btupdate.Location = new System.Drawing.Point(565, 317);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 5;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.btinsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btinsert.Location = new System.Drawing.Point(643, 361);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 6;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = false;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdelete.Location = new System.Drawing.Point(706, 317);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 7;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // labelpelanggan
            // 
            this.labelpelanggan.AutoSize = true;
            this.labelpelanggan.BackColor = System.Drawing.Color.DarkCyan;
            this.labelpelanggan.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpelanggan.Location = new System.Drawing.Point(405, 9);
            this.labelpelanggan.Name = "labelpelanggan";
            this.labelpelanggan.Size = new System.Drawing.Size(235, 55);
            this.labelpelanggan.TabIndex = 9;
            this.labelpelanggan.Text = "Pelanggan";
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(706, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(82, 26);
            this.btlogout.TabIndex = 10;
            this.btlogout.Text = "Log Out";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(556, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(556, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(561, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "No Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(556, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kewarganegaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(556, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nama Pelanggan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(561, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(561, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delete";
            // 
            // tbidpelanggan
            // 
            this.tbidpelanggan.Enabled = false;
            this.tbidpelanggan.Location = new System.Drawing.Point(647, 73);
            this.tbidpelanggan.Name = "tbidpelanggan";
            this.tbidpelanggan.Size = new System.Drawing.Size(145, 20);
            this.tbidpelanggan.TabIndex = 18;
            // 
            // tbnamapelanggan
            // 
            this.tbnamapelanggan.Location = new System.Drawing.Point(648, 106);
            this.tbnamapelanggan.Name = "tbnamapelanggan";
            this.tbnamapelanggan.Size = new System.Drawing.Size(144, 20);
            this.tbnamapelanggan.TabIndex = 1;
            // 
            // tbnotelp
            // 
            this.tbnotelp.Location = new System.Drawing.Point(635, 139);
            this.tbnotelp.Name = "tbnotelp";
            this.tbnotelp.Size = new System.Drawing.Size(157, 20);
            this.tbnotelp.TabIndex = 2;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(648, 178);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(144, 20);
            this.tbemail.TabIndex = 3;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(635, 242);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(157, 20);
            this.tbpassword.TabIndex = 5;
            // 
            // cbkewarganegaraan
            // 
            this.cbkewarganegaraan.FormattingEnabled = true;
            this.cbkewarganegaraan.Items.AddRange(new object[] {
            "Afganistan",
            "Afrika Selatan",
            "Afrika Tengah",
            "Albania",
            "Aljazair",
            "Amerika Serikat",
            "Andorra",
            "Angola",
            "Antigua dan Barbuda",
            "Arab Saudi",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahama",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belanda",
            "Belarus",
            "Belgia",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia dan Herzegovina",
            "Botswana",
            "Brasil",
            "Britania Raya",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Ceko",
            "Chad",
            "Chili",
            "China",
            "Denmark",
            "Djibouti",
            "Dominika",
            "Ekuador",
            "El Salvador",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Filipina",
            "Finlandia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guinea Khatulistiwa",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hongaria",
            "India",
            "Indonesia",
            "Irak",
            "Iran",
            "Irlandia",
            "Islandia",
            "Israel",
            "Italia",
            "Jamaika",
            "Jepang",
            "Jerman",
            "Kamboja",
            "Kamerun",
            "Kanada",
            "Kazakhstan",
            "Kenya",
            "Kirgizstan",
            "Kiribati",
            "Kolombia",
            "Komoro",
            "Republik Kongo",
            "Korea Selatan",
            "Korea Utara",
            "Kosta Rika",
            "Kroasia",
            "Kuba",
            "Kuwait",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lituania",
            "Luksemburg",
            "Madagaskar",
            "Makedonia",
            "Maladewa",
            "Malawi",
            "Malaysia",
            "Mali",
            "Malta",
            "Maroko",
            "Marshall",
            "Mauritania",
            "Mauritius",
            "Meksiko",
            "Mesir",
            "Mikronesia",
            "Moldova",
            "Monako",
            "Mongolia",
            "Montenegro",
            "Mozambik",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Niger",
            "Nigeria",
            "Nikaragua",
            "Norwegia",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Pantai Gading",
            "Papua Nugini",
            "Paraguay",
            "Perancis",
            "Peru",
            "Polandia",
            "Portugal",
            "Qatar",
            "Republik Demokratik Kongo",
            "Republik Dominika",
            "Rumania",
            "Rusia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Selandia Baru",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapura",
            "Siprus",
            "Slovenia",
            "Slowakia",
            "Solomon",
            "Somalia",
            "Spanyol",
            "Sri Lanka",
            "Sudan",
            "Sudan Selatan",
            "Suriah",
            "Suriname",
            "Swaziland",
            "Swedia",
            "Swiss",
            "Tajikistan",
            "Tanjung Verde",
            "Tanzania",
            "Thailand",
            "Timor Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turki",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraina",
            "Uni Emirat Arab",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yaman",
            "Yordania",
            "Yunani",
            "Zambia",
            "Zimbabwe"});
            this.cbkewarganegaraan.Location = new System.Drawing.Point(656, 212);
            this.cbkewarganegaraan.Name = "cbkewarganegaraan";
            this.cbkewarganegaraan.Size = new System.Drawing.Size(135, 21);
            this.cbkewarganegaraan.TabIndex = 4;
            // 
            // rbfalseupdate
            // 
            this.rbfalseupdate.AutoSize = true;
            this.rbfalseupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.rbfalseupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbfalseupdate.Location = new System.Drawing.Point(734, 281);
            this.rbfalseupdate.Name = "rbfalseupdate";
            this.rbfalseupdate.Size = new System.Drawing.Size(47, 17);
            this.rbfalseupdate.TabIndex = 28;
            this.rbfalseupdate.Text = "false";
            this.rbfalseupdate.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(635, 281);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.Text = "true";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(666, 9);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 30;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // FormAdminPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbfalseupdate);
            this.Controls.Add(this.cbkewarganegaraan);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbnotelp);
            this.Controls.Add(this.tbnamapelanggan);
            this.Controls.Add(this.tbidpelanggan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.labelpelanggan);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminPelanggan";
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.FormAdminPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label labelpelanggan;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbidpelanggan;
        private System.Windows.Forms.TextBox tbnamapelanggan;
        private System.Windows.Forms.TextBox tbnotelp;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.ComboBox cbkewarganegaraan;
        private System.Windows.Forms.RadioButton rbfalseupdate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pbback;
    }
}