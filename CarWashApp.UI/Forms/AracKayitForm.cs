using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class AracKayitForm : Form
    {
        public MainForm mainForm;
        public AracKayitForm()
        {
            InitializeComponent();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            //TODO arama mantığı yazılcak
            mainForm.yikamaBtn_Click(sender,e);
        }

        private void aramaBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            aramaPanel.Show();
        }

        private void aracKayitBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            aracKayitPanel.Show();
        }

        private void aracSahibiBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            aracSahibiPanel.Show();
        }

        private void AracKayitForm_Load(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
        }
    }
}
