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
        #region menuPanel
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
        #endregion
        #region izinPanel
        private void izinEkleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void silIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void guncelleIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void izinGunleriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izinGunleriListBox.SelectedIndex != -1)
                FormHelper.guncelleSilBtn(true, izinPanel);
        }
        private void resetIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        #endregion

        #region kayitPanel

        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kayitPanel);
        }

        #endregion

    }
}
