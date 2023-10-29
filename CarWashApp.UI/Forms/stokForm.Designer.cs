namespace CarWashApp.UI.Forms
{
    partial class stokForm
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
            stokPanel = new Panel();
            stokUrunListBox = new ListBox();
            urunAdıTextBox = new TextBox();
            silBtn = new Button();
            guncelleBtn = new Button();
            ekleBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            stokAdetNumericUpD = new NumericUpDown();
            stokPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stokAdetNumericUpD).BeginInit();
            SuspendLayout();
            // 
            // stokPanel
            // 
            stokPanel.Controls.Add(stokAdetNumericUpD);
            stokPanel.Controls.Add(stokUrunListBox);
            stokPanel.Controls.Add(urunAdıTextBox);
            stokPanel.Controls.Add(silBtn);
            stokPanel.Controls.Add(guncelleBtn);
            stokPanel.Controls.Add(ekleBtn);
            stokPanel.Controls.Add(label2);
            stokPanel.Controls.Add(label1);
            stokPanel.Dock = DockStyle.Fill;
            stokPanel.Location = new Point(0, 0);
            stokPanel.Name = "stokPanel";
            stokPanel.Size = new Size(759, 400);
            stokPanel.TabIndex = 5;
            // 
            // stokUrunListBox
            // 
            stokUrunListBox.FormattingEnabled = true;
            stokUrunListBox.ItemHeight = 28;
            stokUrunListBox.Items.AddRange(new object[] { "31" });
            stokUrunListBox.Location = new Point(497, 16);
            stokUrunListBox.Name = "stokUrunListBox";
            stokUrunListBox.Size = new Size(250, 368);
            stokUrunListBox.TabIndex = 12;
            stokUrunListBox.SelectedIndexChanged += stokUrunListBox_SelectedIndexChanged;
            // 
            // urunAdıTextBox
            // 
            urunAdıTextBox.Location = new Point(136, 72);
            urunAdıTextBox.Name = "urunAdıTextBox";
            urunAdıTextBox.Size = new Size(176, 34);
            urunAdıTextBox.TabIndex = 10;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(294, 219);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(135, 42);
            silBtn.TabIndex = 7;
            silBtn.Text = "Sil";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Location = new Point(153, 219);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(135, 42);
            guncelleBtn.TabIndex = 8;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(12, 219);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(135, 42);
            ekleBtn.TabIndex = 9;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 5;
            label2.Text = "Stok Adet :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 6;
            label1.Text = "Ürün Adı : ";
            // 
            // stokAdetNumericUpD
            // 
            stokAdetNumericUpD.Location = new Point(136, 136);
            stokAdetNumericUpD.Name = "stokAdetNumericUpD";
            stokAdetNumericUpD.Size = new Size(176, 34);
            stokAdetNumericUpD.TabIndex = 13;
            // 
            // stokForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(stokPanel);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "stokForm";
            Text = "Stok";
            stokPanel.ResumeLayout(false);
            stokPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stokAdetNumericUpD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel stokPanel;
        private ListBox stokUrunListBox;
        private TextBox urunAdıTextBox;
        private Button silBtn;
        private Button guncelleBtn;
        private Button ekleBtn;
        private Label label2;
        private Label label1;
        private NumericUpDown stokAdetNumericUpD;
    }
}