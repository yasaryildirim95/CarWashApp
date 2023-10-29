namespace CarWashApp.UI.Forms
{
    partial class uygulamaKullaniciForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            personelComBox = new ComboBox();
            kullaniciAdiTextBox = new TextBox();
            sifreTextBox = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 103);
            label1.Margin = new Padding(3, 10, 3, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(3, 0, 3, 15);
            label1.Size = new Size(135, 43);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 166);
            label2.Margin = new Padding(3, 10, 3, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 0, 3, 15);
            label2.Size = new Size(71, 43);
            label2.TabIndex = 0;
            label2.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 229);
            label3.Margin = new Padding(3, 10, 3, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 0, 3, 15);
            label3.Size = new Size(137, 43);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Tipi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(179, 40);
            label4.Margin = new Padding(3, 10, 3, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 0, 3, 15);
            label4.Size = new Size(100, 43);
            label4.TabIndex = 0;
            label4.Text = "Personel :";
            // 
            // personelComBox
            // 
            personelComBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            personelComBox.FormattingEnabled = true;
            personelComBox.Location = new Point(348, 37);
            personelComBox.Name = "personelComBox";
            personelComBox.Size = new Size(176, 36);
            personelComBox.TabIndex = 1;
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciAdiTextBox.Location = new Point(348, 100);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(176, 34);
            kullaniciAdiTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sifreTextBox.Location = new Point(348, 163);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(176, 34);
            sifreTextBox.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(389, 228);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 32);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(366, 286);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // uygulamaKullaniciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(sifreTextBox);
            Controls.Add(kullaniciAdiTextBox);
            Controls.Add(personelComBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "uygulamaKullaniciForm";
            Text = "Kullanıcı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox personelComBox;
        private TextBox kullaniciAdiTextBox;
        private TextBox sifreTextBox;
        private CheckBox checkBox1;
        private Button button1;
    }
}