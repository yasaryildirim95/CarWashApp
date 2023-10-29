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
            kayitEkleBtn = new Button();
            vardiyaComboBox = new ComboBox();
            maasTextBox = new TextBox();
            soyadTextBox = new TextBox();
            adTextBox = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            izinPanel = new Panel();
            izinEkleBtn = new Button();
            izinSuresiNumericUpD = new NumericUpDown();
            baslangicTarihiDTP = new DateTimePicker();
            personelComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            personelTakipPanel = new Panel();
            label3 = new Label();
            izinGunleriListBox = new ListBox();
            menuPanel.SuspendLayout();
            kayitPanel.SuspendLayout();
            izinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)izinSuresiNumericUpD).BeginInit();
            personelTakipPanel.SuspendLayout();
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
            kayitPanel.Controls.Add(kayitEkleBtn);
            kayitPanel.Controls.Add(vardiyaComboBox);
            kayitPanel.Controls.Add(maasTextBox);
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
            // 
            // kayitEkleBtn
            // 
            kayitEkleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kayitEkleBtn.Location = new Point(316, 328);
            kayitEkleBtn.Name = "kayitEkleBtn";
            kayitEkleBtn.Size = new Size(118, 37);
            kayitEkleBtn.TabIndex = 5;
            kayitEkleBtn.Text = "Ekle";
            kayitEkleBtn.UseVisualStyleBackColor = true;
            // 
            // vardiyaComboBox
            // 
            vardiyaComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            vardiyaComboBox.FormattingEnabled = true;
            vardiyaComboBox.Location = new Point(285, 260);
            vardiyaComboBox.Name = "vardiyaComboBox";
            vardiyaComboBox.Size = new Size(179, 36);
            vardiyaComboBox.TabIndex = 4;
            // 
            // maasTextBox
            // 
            maasTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            maasTextBox.Location = new Point(285, 194);
            maasTextBox.Name = "maasTextBox";
            maasTextBox.Size = new Size(179, 34);
            maasTextBox.TabIndex = 3;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            soyadTextBox.Location = new Point(285, 126);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(179, 34);
            soyadTextBox.TabIndex = 3;
            // 
            // adTextBox
            // 
            adTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            adTextBox.Location = new Point(285, 69);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(179, 34);
            adTextBox.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(168, 260);
            label9.Name = "label9";
            label9.Size = new Size(86, 28);
            label9.TabIndex = 2;
            label9.Text = "Vardiya :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(168, 200);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 2;
            label7.Text = "Maaş : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(168, 132);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 2;
            label6.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(168, 72);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
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
            izinPanel.Controls.Add(izinEkleBtn);
            izinPanel.Controls.Add(izinSuresiNumericUpD);
            izinPanel.Controls.Add(baslangicTarihiDTP);
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
            // 
            // izinEkleBtn
            // 
            izinEkleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izinEkleBtn.Location = new Point(213, 321);
            izinEkleBtn.Name = "izinEkleBtn";
            izinEkleBtn.Size = new Size(118, 37);
            izinEkleBtn.TabIndex = 7;
            izinEkleBtn.Text = "İzin Ekle";
            izinEkleBtn.UseVisualStyleBackColor = true;
            // 
            // izinSuresiNumericUpD
            // 
            izinSuresiNumericUpD.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izinSuresiNumericUpD.Location = new Point(183, 224);
            izinSuresiNumericUpD.Name = "izinSuresiNumericUpD";
            izinSuresiNumericUpD.Size = new Size(172, 34);
            izinSuresiNumericUpD.TabIndex = 6;
            // 
            // baslangicTarihiDTP
            // 
            baslangicTarihiDTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            baslangicTarihiDTP.Location = new Point(183, 162);
            baslangicTarihiDTP.Name = "baslangicTarihiDTP";
            baslangicTarihiDTP.Size = new Size(172, 34);
            baslangicTarihiDTP.TabIndex = 5;
            // 
            // personelComboBox
            // 
            personelComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            personelComboBox.FormattingEnabled = true;
            personelComboBox.Location = new Point(183, 102);
            personelComboBox.Name = "personelComboBox";
            personelComboBox.Size = new Size(172, 36);
            personelComboBox.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(24, 226);
            label11.Name = "label11";
            label11.Size = new Size(108, 28);
            label11.TabIndex = 3;
            label11.Text = "İzin Süresi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 162);
            label10.Name = "label10";
            label10.Size = new Size(153, 28);
            label10.TabIndex = 3;
            label10.Text = "Başlangıç Tarihi :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 105);
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
            personelTakipPanel.Controls.Add(label3);
            personelTakipPanel.Dock = DockStyle.Fill;
            personelTakipPanel.Location = new Point(128, 0);
            personelTakipPanel.Name = "personelTakipPanel";
            personelTakipPanel.Size = new Size(631, 400);
            personelTakipPanel.TabIndex = 0;
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
            // izinGunleriListBox
            // 
            izinGunleriListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            izinGunleriListBox.FormattingEnabled = true;
            izinGunleriListBox.ItemHeight = 28;
            izinGunleriListBox.Location = new Point(379, 94);
            izinGunleriListBox.Name = "izinGunleriListBox";
            izinGunleriListBox.Size = new Size(227, 256);
            izinGunleriListBox.TabIndex = 8;
            // 
            // personelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(izinPanel);
            Controls.Add(personelTakipPanel);
            Controls.Add(kayitPanel);
            Controls.Add(menuPanel);
            Name = "personelForm";
            Text = "Personel";
            menuPanel.ResumeLayout(false);
            kayitPanel.ResumeLayout(false);
            kayitPanel.PerformLayout();
            izinPanel.ResumeLayout(false);
            izinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)izinSuresiNumericUpD).EndInit();
            personelTakipPanel.ResumeLayout(false);
            personelTakipPanel.PerformLayout();
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
        private TextBox maasTextBox;
        private TextBox soyadTextBox;
        private Button kayitEkleBtn;
        private Button izinEkleBtn;
        private NumericUpDown izinSuresiNumericUpD;
        private DateTimePicker baslangicTarihiDTP;
        private ComboBox personelComboBox;
        private Label label11;
        private Label label10;
        private Label label8;
        private ListBox izinGunleriListBox;
    }
}