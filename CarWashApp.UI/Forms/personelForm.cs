using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class personelForm : Form
    {
        public personelForm()
        {
            InitializeComponent();
            FormHelper.HidePanels(this);
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            kayitPanel.Show();
        }

        private void izinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            izinPanel.Show();
        }

        private void personelTakipBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ActivateButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            personelTakipPanel.Show();
        }
    }
}
