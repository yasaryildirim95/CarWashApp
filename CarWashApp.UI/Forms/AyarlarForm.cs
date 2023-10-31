using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class AyarlarForm : Form
    {
        public AyarlarForm()
        {
            InitializeComponent();
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
            FormHelper.guncelleSilBtn(false, urunAyarlariPanel);
        }


        #region menuPanel

        private void yıkamaAyarBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.ActivateButton(sender, menuPanel);
            yikamaPanel.Show();
        }

        private void aracTipiBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.ActivateButton(sender, menuPanel);
            aracTipiPanel.Show();
        }

        private void kirlilikAyarBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.ActivateButton(sender, menuPanel);
            kirlilikPanel.Show();
        }
        private void urunAyarlariBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.ActivateButton(sender, menuPanel);
            urunAyarlariPanel.Show();

        }
        #endregion

        #region yikamaPanel
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yikamaUrunListBox.SelectedIndex != -1)
                FormHelper.guncelleSilBtn(true, yikamaPanel);
        }
        private void yikamaPanelEkleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(yikamaPanel);
        }

        private void yikamaPanelResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
        }

        private void silYikamaPanelBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
        }

        private void guncelleYikamaPanelBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
        }

        #endregion

        #region AracTipiPanel
        private void aracTipEkleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(aracTipiPanel);
        }

        private void aracTipResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
        }

        private void aracTipSilBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
        }

        private void guncelleAracTipBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
        }

        private void aracTipleriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aracTipleriListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, aracTipiPanel);
            }
        }

        #endregion

        #region kirlilikPanel

        private void izinEkleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kirlilikPanel);
        }

        private void resetIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
        }

        private void silIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
        }

        private void guncelleIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
        }

        private void kirlilikAyarlariListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kirlilikAyarlariListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, kirlilikPanel);
            }
        }

        #endregion

        #region urunAyarlariPanel

        private void urunAyarlariEkleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(urunAyarlariPanel);
        }

        private void urunAyarlariResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(urunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, urunAyarlariPanel);
        }

        private void urunAyarlariSilBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(urunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, urunAyarlariPanel);
        }

        private void urunAyarlariGuncelleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(urunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, urunAyarlariPanel);
        }

        private void urunAyarlariListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urunAyarlariListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, urunAyarlariPanel);
            }
        }

        #endregion

    }
}
