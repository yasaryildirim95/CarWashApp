namespace CarWash.UI.Forms
{
    public partial class AracKayitForm : Form
    {
        public AracKayitForm()
        {
            InitializeComponent();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            aracEkleBtn.Show();
        }

        private void aracEkleBtn_Click(object sender, EventArgs e)
        {
            HidePanels();
            aracKayitPanel.Show();
        }

        private void AracKayitForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            aramaPanel.Show();
        }

        private void aracSahibiEklePanelBtn_Click(object sender, EventArgs e)
        {
            HidePanels();
            aracSahibiPanel.Show();
        }

        private void aramaAracSahibiBtn_Click(object sender, EventArgs e)
        {
            HidePanels();
            aramaPanel.Show();
        }

        private void aramaAracKayitBtn_Click(object sender, EventArgs e)
        {
            HidePanels();
            aramaPanel.Show();
        }

        private void aracEklePanelBtn_Click_1(object sender, EventArgs e)
        {
            HidePanels();
            aracKayitPanel.Show();
        }
        private void HidePanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel pnl)
                    pnl.Hide();
            }
        }

        private void ResetButton(Panel temp)
        {
            foreach (Control tempControl in temp.Controls)
            {
                if (tempControl is ComboBox tempComboBox)
                    tempComboBox.SelectedIndex = -1;

                if (tempControl is TextBox tempTextBox)
                    tempTextBox.Text = string.Empty;

            }
        }
    }
}
