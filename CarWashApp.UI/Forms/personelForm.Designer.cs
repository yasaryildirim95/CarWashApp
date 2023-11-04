namespace CarWashApp.UI.Forms
{
    partial class personelForm
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
            menuPanel = new Panel();
            izinBtn = new Button();
            personelTakipBtn = new Button();
            kayitBtn = new Button();
            kayitPanel = new Panel();
            maasNumericUpD = new NumericUpDown();
            yikamaciCheckBox = new CheckBox();
            label12 = new Label();
            personelListBox = new ListBox();
            guncelleKayitBtn = new Button();
            resetKayitBtn = new Button();
            silKayitBtn = new Button();
            kayitEkleBtn = new Button();
            vardiyaComboBox = new ComboBox();
            soyadTextBox = new TextBox();
            adTextBox = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            izinPanel = new Panel();
            izinGunleriListBox = new ListBox();
            guncelleIzinBtn = new Button();
            silIzinBtn = new Button();
            resetIzinBtn = new Button();
            izinEkleBtn = new Button();
            izin_SuresiNumericUpD = new NumericUpDown();
            baslangic_TarihiDTP = new DateTimePicker();
            personelComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            personelTakipPanel = new Panel();
            bostakilerDataGrid = new DataGridView();
            calisanlarDataGrid = new DataGridView();
            label14 = new Label();
            label13 = new Label();
            label3 = new Label();
            menuPanel.SuspendLayout();
            kayitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maasNumericUpD).BeginInit();
            izinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)izin_SuresiNumericUpD).BeginInit();
            personelTakipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bostakilerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calisanlarDataGrid).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(izinBtn);
            menuPanel.Controls.Add(personelTakipBtn);
            menuPanel.Controls.Add(kayitBtn);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(10, 3, 3, 3);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(128, 400);
            menuPanel.TabIndex = 0;
            // 
            // izinBtn
            // 
            izinBtn.BackColor = Color.FromArgb(51, 51, 76);
            izinBtn.Dock = DockStyle.Top;
            izinBtn.FlatAppearance.BorderSize = 0;
            izinBtn.FlatStyle = FlatStyle.Flat;
            izinBtn.ForeColor = Color.White;
            izinBtn.Location = new Point(0, 266);
            izinBtn.Name = "izinBtn";
            izinBtn.Size = new Size(128, 133);
            izinBtn.TabIndex = 3;
            izinBtn.Text = "İzin Yönetim";
            izinBtn.UseVisualStyleBackColor = false;
            izinBtn.Click += izinBtn_Click;
            // 
            // personelTakipBtn
            // 
            personelTakipBtn.BackColor = Color.FromArgb(51, 51, 76);
            personelTakipBtn.Dock = DockStyle.Top;
            personelTakipBtn.FlatAppearance.BorderSize = 0;
            personelTakipBtn.FlatStyle = FlatStyle.Flat;
            personelTakipBtn.ForeColor = Color.White;
            personelTakipBtn.Location = new Point(0, 133);
            personelTakipBtn.Name = "personelTakipBtn";
            personelTakipBtn.Size = new Size(128, 133);
            personelTakipBtn.TabIndex = 1;
            personelTakipBtn.Text = "Personel Takip";
            personelTakipBtn.UseVisualStyleBackColor = false;
            personelTakipBtn.Click += personelTakipBtn_Click;
            // 
            // kayitBtn
            // 
            kayitBtn.BackColor = Color.FromArgb(51, 51, 76);
            kayitBtn.Dock = DockStyle.Top;
            kayitBtn.FlatAppearance.BorderSize = 0;
            kayitBtn.FlatStyle = FlatStyle.Flat;
            kayitBtn.ForeColor = Color.White;
            kayitBtn.Location = new Point(0, 0);
            kayitBtn.Name = "kayitBtn";
            kayitBtn.Size = new Size(128, 133);
            kayitBtn.TabIndex = 0;
            kayitBtn.Text = "Kayıt";
            kayitBtn.UseVisualStyleBackColor = false;
            kayitBtn.Click += kayitBtn_Click;
            // 
            // kayitPanel
            // 
            kayitPanel.Controls.Add(maasNumericUpD);
            kayitPanel.Controls.Add(yikamaciCheckBox);
            kayitPanel.Controls.Add(label12);
            kayitPanel.Controls.Add(personelListBox);
            kayitPanel.Controls.Add(guncelleKayitBtn);
            kayitPanel.Controls.Add(resetKayitBtn);
            kayitPanel.Controls.Add(silKayitBtn);
            kayitPanel.Controls.Add(kayitEkleBtn);
            kayitPanel.Controls.Add(vardiyaComboBox);
            kayitPanel.Controls.Add(soyadTextBox);
            kayitPanel.Controls.Add(adTextBox);
            kayitPanel.Controls.Add(label9);
            kayitPanel.Controls.Add(label7);
            kayitPanel.Controls.Add(label6);
            kayitPanel.Controls.Add(label5);
            kayitPanel.Controls.Add(label2);
            kayitPanel.Dock = DockStyle.Fill;
            kayitPanel.Location = new Point(128, 0);
            kayitPanel.Name = "kayitPanel";
            kayitPanel.Size = new Size(631, 400);
            kayitPanel.TabIndex = 1;
            kayitPanel.Visible = false;
            // 
            // maasNumericUpD
            // 
            maasNumericUpD.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            maasNumericUpD.Location = new Point(140, 177);
            maasNumericUpD.Name = "maasNumericUpD";
            maasNumericUpD.Size = new Size(179, 31);
            maasNumericUpD.TabIndex = 30;
            // 
            // yikamaciCheckBox
            // 
            yikamaciCheckBox.AutoSize = true;
            yikamaciCheckBox.Location = new Point(225, 288);
            yikamaciCheckBox.Name = "yikamaciCheckBox";
            yikamaciCheckBox.Size = new Size(15, 14);
            yikamaciCheckBox.TabIndex = 29;
            yikamaciCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(23, 282);
            label12.Name = "label12";
            label12.Size = new Size(95, 25);
            label12.TabIndex = 28;
            label12.Text = "Yıkamacı : ";
            // 
            // personelListBox
            // 
            personelListBox.FormattingEnabled = true;
            personelListBox.ItemHeight = 15;
            personelListBox.Location = new Point(392, 76);
            personelListBox.Name = "personelListBox";
            personelListBox.Size = new Size(227, 304);
            personelListBox.TabIndex = 27;
            personelListBox.SelectedIndexChanged += personelListBox_SelectedIndexChanged;
            // 
            // guncelleKayitBtn
            // 
            guncelleKayitBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guncelleKayitBtn.Location = new Point(201, 353);
            guncelleKayitBtn.Name = "guncelleKayitBtn";
            guncelleKayitBtn.Size = new Size(118, 37);
            guncelleKayitBtn.TabIndex = 5;
            guncelleKayitBtn.Text = "Güncelle";
            guncelleKayitBtn.UseVisualStyleBackColor = true;
            guncelleKayitBtn.Visible = false;
            guncelleKayitBtn.Click += guncelleKayitBtn_Click;
            // 
            // resetKayitBtn
            // 
            resetKayitBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resetKayitBtn.Location = new Point(201, 310);
            resetKayitBtn.Name = "resetKayitBtn";
            resetKayitBtn.Size = new Size(118, 37);
            resetKayitBtn.TabIndex = 5;
            resetKayitBtn.Text = "Reset";
            resetKayitBtn.UseVisualStyleBackColor = true;
            resetKayitBtn.Click += resetBtn_Click;
            // 
            // silKayitBtn
            // 
            silKayitBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            silKayitBtn.Location = new Point(59, 353);
            silKayitBtn.Name = "silKayitBtn";
            silKayitBtn.Size = new Size(118, 37);
            silKayitBtn.TabIndex = 5;
            silKayitBtn.Text = "Sil";
            silKayitBtn.UseVisualStyleBackColor = true;
            silKayitBtn.Visible = false;
            silKayitBtn.Click += silKayitBtn_Click;
            // 
            // kayitEkleBtn
            // 
            kayitEkleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kayitEkleBtn.Location = new Point(59, 310);
            kayitEkleBtn.Name = "kayitEkleBtn";
            kayitEkleBtn.Size = new Size(118, 37);
            kayitEkleBtn.TabIndex = 5;
            kayitEkleBtn.Text = "Ekle";
            kayitEkleBtn.UseVisualStyleBackColor = true;
            kayitEkleBtn.Click += kayitEkleBtn_Click;
            // 
            // vardiyaComboBox
            // 
            vardiyaComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            vardiyaComboBox.FormattingEnabled = true;
            vardiyaComboBox.Location = new Point(140, 239);
            vardiyaComboBox.Name = "vardiyaComboBox";
            vardiyaComboBox.Size = new Size(179, 31);
            vardiyaComboBox.TabIndex = 4;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            soyadTextBox.Location = new Point(140, 105);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(179, 31);
            soyadTextBox.TabIndex = 3;
            // 
            // adTextBox
            // 
            adTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            adTextBox.Location = new Point(140, 48);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(179, 31);
            adTextBox.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 239);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 2;
            label9.Text = "Vardiya :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 179);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 2;
            label7.Text = "Maaş : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 111);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 2;
            label6.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 51);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 2;
            label5.Text = "Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 1;
            label2.Text = "Kayıt";
            // 
            // izinPanel
            // 
            izinPanel.Controls.Add(izinGunleriListBox);
            izinPanel.Controls.Add(guncelleIzinBtn);
            izinPanel.Controls.Add(silIzinBtn);
            izinPanel.Controls.Add(resetIzinBtn);
            izinPanel.Controls.Add(izinEkleBtn);
            izinPanel.Controls.Add(izin_SuresiNumericUpD);
            izinPanel.Controls.Add(baslangic_TarihiDTP);
            izinPanel.Controls.Add(personelComboBox);
            izinPanel.Controls.Add(label11);
            izinPanel.Controls.Add(label10);
            izinPanel.Controls.Add(label8);
            izinPanel.Controls.Add(label4);
            izinPanel.Dock = DockStyle.Fill;
            izinPanel.Location = new Point(128, 0);
            izinPanel.Name = "izinPanel";
            izinPanel.Size = new Size(631, 400);
            izinPanel.TabIndex = 0;
            izinPanel.Visible = false;
            // 
            // izinGunleriListBox
            // 
            izinGunleriListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izinGunleriListBox.FormattingEnabled = true;
            izinGunleriListBox.ItemHeight = 28;
            izinGunleriListBox.Location = new Point(392, 76);
            izinGunleriListBox.Name = "izinGunleriListBox";
            izinGunleriListBox.Size = new Size(227, 312);
            izinGunleriListBox.TabIndex = 8;
            izinGunleriListBox.SelectedIndexChanged += izinGunleriListBox_SelectedIndexChanged;
            // 
            // guncelleIzinBtn
            // 
            guncelleIzinBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guncelleIzinBtn.Location = new Point(225, 343);
            guncelleIzinBtn.Name = "guncelleIzinBtn";
            guncelleIzinBtn.Size = new Size(118, 37);
            guncelleIzinBtn.TabIndex = 7;
            guncelleIzinBtn.Text = "Güncelle";
            guncelleIzinBtn.UseVisualStyleBackColor = true;
            guncelleIzinBtn.Visible = false;
            guncelleIzinBtn.Click += guncelleIzinBtn_Click;
            // 
            // silIzinBtn
            // 
            silIzinBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            silIzinBtn.Location = new Point(84, 343);
            silIzinBtn.Name = "silIzinBtn";
            silIzinBtn.Size = new Size(118, 37);
            silIzinBtn.TabIndex = 7;
            silIzinBtn.Text = "Sil";
            silIzinBtn.UseVisualStyleBackColor = true;
            silIzinBtn.Visible = false;
            silIzinBtn.Click += silIzinBtn_Click;
            // 
            // resetIzinBtn
            // 
            resetIzinBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resetIzinBtn.Location = new Point(225, 288);
            resetIzinBtn.Name = "resetIzinBtn";
            resetIzinBtn.Size = new Size(118, 37);
            resetIzinBtn.TabIndex = 7;
            resetIzinBtn.Text = "Reset";
            resetIzinBtn.UseVisualStyleBackColor = true;
            resetIzinBtn.Click += resetIzinBtn_Click;
            // 
            // izinEkleBtn
            // 
            izinEkleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izinEkleBtn.Location = new Point(84, 288);
            izinEkleBtn.Name = "izinEkleBtn";
            izinEkleBtn.Size = new Size(118, 37);
            izinEkleBtn.TabIndex = 7;
            izinEkleBtn.Text = "Ekle";
            izinEkleBtn.UseVisualStyleBackColor = true;
            izinEkleBtn.Click += izinEkleBtn_Click;
            // 
            // izin_SuresiNumericUpD
            // 
            izin_SuresiNumericUpD.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izin_SuresiNumericUpD.Location = new Point(171, 195);
            izin_SuresiNumericUpD.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            izin_SuresiNumericUpD.Name = "izin_SuresiNumericUpD";
            izin_SuresiNumericUpD.Size = new Size(172, 34);
            izin_SuresiNumericUpD.TabIndex = 6;
            // 
            // baslangic_TarihiDTP
            // 
            baslangic_TarihiDTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            baslangic_TarihiDTP.Location = new Point(171, 133);
            baslangic_TarihiDTP.Name = "baslangic_TarihiDTP";
            baslangic_TarihiDTP.Size = new Size(172, 34);
            baslangic_TarihiDTP.TabIndex = 5;
            // 
            // personelComboBox
            // 
            personelComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            personelComboBox.FormattingEnabled = true;
            personelComboBox.Location = new Point(171, 73);
            personelComboBox.Name = "personelComboBox";
            personelComboBox.Size = new Size(172, 36);
            personelComboBox.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 197);
            label11.Name = "label11";
            label11.Size = new Size(108, 28);
            label11.TabIndex = 3;
            label11.Text = "İzin Süresi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 133);
            label10.Name = "label10";
            label10.Size = new Size(153, 28);
            label10.TabIndex = 3;
            label10.Text = "Başlangıç Tarihi :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 76);
            label8.Name = "label8";
            label8.Size = new Size(94, 28);
            label8.TabIndex = 3;
            label8.Text = "Personel :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 2;
            label4.Text = "İzin Yönetim";
            // 
            // personelTakipPanel
            // 
            personelTakipPanel.Controls.Add(bostakilerDataGrid);
            personelTakipPanel.Controls.Add(calisanlarDataGrid);
            personelTakipPanel.Controls.Add(label14);
            personelTakipPanel.Controls.Add(label13);
            personelTakipPanel.Controls.Add(label3);
            personelTakipPanel.Dock = DockStyle.Fill;
            personelTakipPanel.Location = new Point(128, 0);
            personelTakipPanel.Name = "personelTakipPanel";
            personelTakipPanel.Size = new Size(631, 400);
            personelTakipPanel.TabIndex = 0;
            personelTakipPanel.Visible = false;
            // 
            // bostakilerDataGrid
            // 
            bostakilerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bostakilerDataGrid.Location = new Point(325, 105);
            bostakilerDataGrid.MultiSelect = false;
            bostakilerDataGrid.Name = "bostakilerDataGrid";
            bostakilerDataGrid.ReadOnly = true;
            bostakilerDataGrid.RowTemplate.Height = 25;
            bostakilerDataGrid.Size = new Size(294, 275);
            bostakilerDataGrid.TabIndex = 5;
            // 
            // calisanlarDataGrid
            // 
            calisanlarDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calisanlarDataGrid.Location = new Point(23, 105);
            calisanlarDataGrid.MultiSelect = false;
            calisanlarDataGrid.Name = "calisanlarDataGrid";
            calisanlarDataGrid.ReadOnly = true;
            calisanlarDataGrid.RowTemplate.Height = 25;
            calisanlarDataGrid.Size = new Size(296, 275);
            calisanlarDataGrid.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(352, 63);
            label14.Name = "label14";
            label14.Size = new Size(97, 28);
            label14.TabIndex = 4;
            label14.Text = "Boştakiler";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(62, 63);
            label13.Name = "label13";
            label13.Size = new Size(95, 28);
            label13.TabIndex = 4;
            label13.Text = "Çalışanlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 2;
            label3.Text = "Personel Takip";
            // 
            // personelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(personelTakipPanel);
            Controls.Add(izinPanel);
            Controls.Add(kayitPanel);
            Controls.Add(menuPanel);
            Name = "personelForm";
            Text = "Personel";
            Load += personelForm_Load;
            menuPanel.ResumeLayout(false);
            kayitPanel.ResumeLayout(false);
            kayitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maasNumericUpD).EndInit();
            izinPanel.ResumeLayout(false);
            izinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)izin_SuresiNumericUpD).EndInit();
            personelTakipPanel.ResumeLayout(false);
            personelTakipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bostakilerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)calisanlarDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Panel kayitPanel;
        private Button izinBtn;
        private Button personelTakipBtn;
        private Button kayitBtn;
        private Panel maasPanel;
        private Panel izinPanel;
        private Panel personelTakipPanel;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox adTextBox;
        private ComboBox vardiyaComboBox;
        private TextBox soyadTextBox;
        private Button kayitEkleBtn;
        private Button izinEkleBtn;
        private NumericUpDown izin_SuresiNumericUpD;
        private DateTimePicker baslangic_TarihiDTP;
        private ComboBox personelComboBox;
        private Label label11;
        private Label label10;
        private Label label8;
        private ListBox izinGunleriListBox;
        private Button guncelleIzinBtn;
        private Button silIzinBtn;
        private Button resetKayitBtn;
        private Button resetIzinBtn;
        private Button guncelleKayitBtn;
        private Button silKayitBtn;
        private ListBox personelListBox;
        private CheckBox yikamaciCheckBox;
        private Label label12;
        private NumericUpDown maasNumericUpD;
        private Label label14;
        private Label label13;
        private DataGridView bostakilerDataGrid;
        private DataGridView calisanlarDataGrid;
    }
}