namespace CarWash.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            uygulamaAyarlariBtn = new Button();
            personelBtn = new Button();
            stokBtn = new Button();
            yikamaBtn = new Button();
            aracKayitBtn = new Button();
            panel2 = new Panel();
            titleLbl = new Label();
            panelTitle = new Panel();
            FormName = new Label();
            desktopPanel = new Panel();
            girisPanel = new Panel();
            girisYapBtn = new Button();
            sifreLabel = new Label();
            kullaniciLabel = new Label();
            sifreTextbox = new TextBox();
            kullaniciTextbox = new TextBox();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panelTitle.SuspendLayout();
            girisPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(uygulamaAyarlariBtn);
            panelMenu.Controls.Add(personelBtn);
            panelMenu.Controls.Add(stokBtn);
            panelMenu.Controls.Add(yikamaBtn);
            panelMenu.Controls.Add(aracKayitBtn);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(164, 472);
            panelMenu.TabIndex = 0;
            // 
            // uygulamaAyarlariBtn
            // 
            uygulamaAyarlariBtn.Dock = DockStyle.Top;
            uygulamaAyarlariBtn.FlatAppearance.BorderSize = 0;
            uygulamaAyarlariBtn.FlatStyle = FlatStyle.Flat;
            uygulamaAyarlariBtn.ForeColor = Color.Gainsboro;
            uygulamaAyarlariBtn.Location = new Point(0, 320);
            uygulamaAyarlariBtn.Name = "uygulamaAyarlariBtn";
            uygulamaAyarlariBtn.Size = new Size(164, 60);
            uygulamaAyarlariBtn.TabIndex = 6;
            uygulamaAyarlariBtn.Text = "Uygulama Ayarları";
            uygulamaAyarlariBtn.UseVisualStyleBackColor = true;
            uygulamaAyarlariBtn.Click += uygulamaAyarlariBtn_Click;
            // 
            // personelBtn
            // 
            personelBtn.Dock = DockStyle.Top;
            personelBtn.FlatAppearance.BorderSize = 0;
            personelBtn.FlatStyle = FlatStyle.Flat;
            personelBtn.ForeColor = Color.Gainsboro;
            personelBtn.Location = new Point(0, 260);
            personelBtn.Name = "personelBtn";
            personelBtn.Size = new Size(164, 60);
            personelBtn.TabIndex = 5;
            personelBtn.Text = "Personel";
            personelBtn.UseVisualStyleBackColor = true;
            personelBtn.Click += personelBtn_Click;
            // 
            // stokBtn
            // 
            stokBtn.Dock = DockStyle.Top;
            stokBtn.FlatAppearance.BorderSize = 0;
            stokBtn.FlatStyle = FlatStyle.Flat;
            stokBtn.ForeColor = Color.Gainsboro;
            stokBtn.Location = new Point(0, 200);
            stokBtn.Name = "stokBtn";
            stokBtn.Size = new Size(164, 60);
            stokBtn.TabIndex = 4;
            stokBtn.Text = "Stok";
            stokBtn.UseVisualStyleBackColor = true;
            stokBtn.Click += stokBtn_Click;
            // 
            // yikamaBtn
            // 
            yikamaBtn.Dock = DockStyle.Top;
            yikamaBtn.FlatAppearance.BorderSize = 0;
            yikamaBtn.FlatStyle = FlatStyle.Flat;
            yikamaBtn.ForeColor = Color.Gainsboro;
            yikamaBtn.Location = new Point(0, 140);
            yikamaBtn.Name = "yikamaBtn";
            yikamaBtn.Size = new Size(164, 60);
            yikamaBtn.TabIndex = 3;
            yikamaBtn.Text = "Yıkama";
            yikamaBtn.UseVisualStyleBackColor = true;
            yikamaBtn.Click += yikamaBtn_Click;
            // 
            // aracKayitBtn
            // 
            aracKayitBtn.Dock = DockStyle.Top;
            aracKayitBtn.FlatAppearance.BorderSize = 0;
            aracKayitBtn.FlatStyle = FlatStyle.Flat;
            aracKayitBtn.ForeColor = Color.Gainsboro;
            aracKayitBtn.Location = new Point(0, 80);
            aracKayitBtn.Name = "aracKayitBtn";
            aracKayitBtn.Size = new Size(164, 60);
            aracKayitBtn.TabIndex = 2;
            aracKayitBtn.Text = "Araç Kayıt";
            aracKayitBtn.UseVisualStyleBackColor = true;
            aracKayitBtn.Click += aracKayitBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(titleLbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 80);
            panel2.TabIndex = 0;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.LightGray;
            titleLbl.Location = new Point(47, 32);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(52, 21);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "label2";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelTitle.Controls.Add(FormName);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.ForeColor = Color.White;
            panelTitle.Location = new Point(164, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(775, 80);
            panelTitle.TabIndex = 1;
            // 
            // FormName
            // 
            FormName.Anchor = AnchorStyles.None;
            FormName.AutoSize = true;
            FormName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FormName.Location = new Point(334, 25);
            FormName.Margin = new Padding(3, 25, 3, 25);
            FormName.Name = "FormName";
            FormName.Size = new Size(95, 30);
            FormName.TabIndex = 0;
            FormName.Text = "Giriş Yap";
            // 
            // desktopPanel
            // 
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(164, 80);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(775, 392);
            desktopPanel.TabIndex = 2;
            // 
            // girisPanel
            // 
            girisPanel.Controls.Add(girisYapBtn);
            girisPanel.Controls.Add(sifreLabel);
            girisPanel.Controls.Add(kullaniciLabel);
            girisPanel.Controls.Add(sifreTextbox);
            girisPanel.Controls.Add(kullaniciTextbox);
            girisPanel.Dock = DockStyle.Fill;
            girisPanel.Location = new Point(164, 80);
            girisPanel.Name = "girisPanel";
            girisPanel.Size = new Size(775, 392);
            girisPanel.TabIndex = 3;
            // 
            // girisYapBtn
            // 
            girisYapBtn.Location = new Point(337, 240);
            girisYapBtn.Name = "girisYapBtn";
            girisYapBtn.Size = new Size(165, 50);
            girisYapBtn.TabIndex = 7;
            girisYapBtn.Text = "Giriş Yap";
            girisYapBtn.UseVisualStyleBackColor = true;
            girisYapBtn.Click += girisYapBtn_Click;
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sifreLabel.Location = new Point(162, 149);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(60, 28);
            sifreLabel.TabIndex = 5;
            sifreLabel.Text = "Şifre :";
            // 
            // kullaniciLabel
            // 
            kullaniciLabel.AutoSize = true;
            kullaniciLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciLabel.Location = new Point(162, 84);
            kullaniciLabel.Name = "kullaniciLabel";
            kullaniciLabel.Size = new Size(129, 28);
            kullaniciLabel.TabIndex = 6;
            kullaniciLabel.Text = "Kullanıcı Adı :";
            // 
            // sifreTextbox
            // 
            sifreTextbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sifreTextbox.Location = new Point(334, 146);
            sifreTextbox.Name = "sifreTextbox";
            sifreTextbox.Size = new Size(247, 34);
            sifreTextbox.TabIndex = 3;
            // 
            // kullaniciTextbox
            // 
            kullaniciTextbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciTextbox.Location = new Point(337, 78);
            kullaniciTextbox.Name = "kullaniciTextbox";
            kullaniciTextbox.Size = new Size(244, 34);
            kullaniciTextbox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 472);
            Controls.Add(girisPanel);
            Controls.Add(desktopPanel);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            girisPanel.ResumeLayout(false);
            girisPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button uygulamaAyarlariBtn;
        private Button personelBtn;
        private Button stokBtn;
        private Button yikamaBtn;
        private Button aracKayitBtn;
        private Panel panel2;
        private Panel panelTitle;
        private Label FormName;
        private Label titleLbl;
        private Panel desktopPanel;
        private Panel girisPanel;
        private Button girisYapBtn;
        private Label sifreLabel;
        private Label kullaniciLabel;
        private TextBox sifreTextbox;
        private TextBox kullaniciTextbox;
    }
}
