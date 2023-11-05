namespace CarWashApp.UI.Forms
{
    partial class yikamaForm
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
            components = new System.ComponentModel.Container();
            yikamaPanel = new Panel();
            yikamaTextBox = new TextBox();
            label4 = new Label();
            sureComboBox = new ComboBox();
            resetBtn = new Button();
            guncelleBtn = new Button();
            SilBtn = new Button();
            ekleBtn = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            yikamaDataGrid = new DataGridView();
            kirlilikComboBox = new ComboBox();
            yikama_TipiComboBox = new ComboBox();
            plakaComboBox = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            yikamaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yikamaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // yikamaPanel
            // 
            yikamaPanel.Controls.Add(yikamaTextBox);
            yikamaPanel.Controls.Add(label4);
            yikamaPanel.Controls.Add(sureComboBox);
            yikamaPanel.Controls.Add(resetBtn);
            yikamaPanel.Controls.Add(guncelleBtn);
            yikamaPanel.Controls.Add(SilBtn);
            yikamaPanel.Controls.Add(ekleBtn);
            yikamaPanel.Controls.Add(label5);
            yikamaPanel.Controls.Add(label3);
            yikamaPanel.Controls.Add(label2);
            yikamaPanel.Controls.Add(label1);
            yikamaPanel.Controls.Add(yikamaDataGrid);
            yikamaPanel.Controls.Add(kirlilikComboBox);
            yikamaPanel.Controls.Add(yikama_TipiComboBox);
            yikamaPanel.Controls.Add(plakaComboBox);
            yikamaPanel.Dock = DockStyle.Fill;
            yikamaPanel.Location = new Point(0, 0);
            yikamaPanel.Name = "yikamaPanel";
            yikamaPanel.Size = new Size(759, 400);
            yikamaPanel.TabIndex = 0;
            // 
            // yikamaTextBox
            // 
            yikamaTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            yikamaTextBox.Location = new Point(124, 220);
            yikamaTextBox.Name = "yikamaTextBox";
            yikamaTextBox.ReadOnly = true;
            yikamaTextBox.Size = new Size(140, 34);
            yikamaTextBox.TabIndex = 19;
            yikamaTextBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 11);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 18;
            label4.Text = "Güncelleme Süresi:";
            // 
            // sureComboBox
            // 
            sureComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sureComboBox.FormattingEnabled = true;
            sureComboBox.Items.AddRange(new object[] { "1", "5", "15", "30" });
            sureComboBox.Location = new Point(434, 8);
            sureComboBox.Name = "sureComboBox";
            sureComboBox.Size = new Size(121, 23);
            sureComboBox.TabIndex = 8;
            sureComboBox.SelectedIndexChanged += sureComboBox_SelectedIndexChanged;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(146, 291);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(118, 37);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guncelleBtn.Location = new Point(12, 350);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(118, 37);
            guncelleBtn.TabIndex = 6;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Visible = false;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // SilBtn
            // 
            SilBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SilBtn.Location = new Point(146, 350);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(118, 37);
            SilBtn.TabIndex = 7;
            SilBtn.Text = "Sil";
            SilBtn.UseVisualStyleBackColor = true;
            SilBtn.Visible = false;
            SilBtn.Click += SilBtn_Click;
            // 
            // ekleBtn
            // 
            ekleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ekleBtn.Location = new Point(12, 291);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(118, 37);
            ekleBtn.TabIndex = 4;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 15;
            label5.Text = "YıkamaID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 15;
            label3.Text = "Kirlilik : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 14;
            label2.Text = "Yıkama Tipi : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 13;
            label1.Text = "Plaka : ";
            // 
            // yikamaDataGrid
            // 
            yikamaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yikamaDataGrid.Location = new Point(270, 37);
            yikamaDataGrid.MultiSelect = false;
            yikamaDataGrid.Name = "yikamaDataGrid";
            yikamaDataGrid.ReadOnly = true;
            yikamaDataGrid.RowTemplate.Height = 25;
            yikamaDataGrid.Size = new Size(477, 357);
            yikamaDataGrid.TabIndex = 11;
            yikamaDataGrid.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // kirlilikComboBox
            // 
            kirlilikComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kirlilikComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kirlilikComboBox.FormattingEnabled = true;
            kirlilikComboBox.Location = new Point(124, 160);
            kirlilikComboBox.Name = "kirlilikComboBox";
            kirlilikComboBox.Size = new Size(140, 36);
            kirlilikComboBox.TabIndex = 3;
            // 
            // yikama_TipiComboBox
            // 
            yikama_TipiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yikama_TipiComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            yikama_TipiComboBox.FormattingEnabled = true;
            yikama_TipiComboBox.Location = new Point(124, 97);
            yikama_TipiComboBox.Name = "yikama_TipiComboBox";
            yikama_TipiComboBox.Size = new Size(140, 36);
            yikama_TipiComboBox.TabIndex = 2;
            // 
            // plakaComboBox
            // 
            plakaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            plakaComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            plakaComboBox.FormattingEnabled = true;
            plakaComboBox.Location = new Point(124, 37);
            plakaComboBox.Name = "plakaComboBox";
            plakaComboBox.Size = new Size(140, 36);
            plakaComboBox.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // yikamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(yikamaPanel);
            Name = "yikamaForm";
            Text = "Yıkama";
            Load += yikamaForm_Load;
            yikamaPanel.ResumeLayout(false);
            yikamaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yikamaDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel yikamaPanel;
        private Button ekleBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DataGridView yikamaDataGrid;
        private ComboBox kirlilikComboBox;
        private ComboBox yikama_TipiComboBox;
        private ComboBox plakaComboBox;
        private Button resetBtn;
        private Button guncelleBtn;
        private Button SilBtn;
        private Label label4;
        private ComboBox sureComboBox;
        private System.Windows.Forms.Timer timer1;
        private TextBox yikamaTextBox;
        private Label label5;
    }
}