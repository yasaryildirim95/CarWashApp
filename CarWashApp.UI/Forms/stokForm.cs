using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class stokForm : Form
    {
        public stokForm()
        {
            InitializeComponent();
            guncelleSilBtn(false);
        }

        #region Custom Methods
        private void guncelleSilBtn(bool temp)
        {
            guncelleBtn.Visible = temp;
            silBtn.Visible = temp;
            ekleBtn.Enabled = !temp;
        }

        #endregion

        #region Click Events

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            guncelleSilBtn(false);
            FormHelper.ResetItems(stokPanel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            guncelleSilBtn(false);
            FormHelper.ResetItems(stokPanel);
        }

        private void stokUrunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stokUrunListBox.SelectedIndex != -1)
            {
                guncelleSilBtn(true);
            }

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(stokPanel);
        }

        #endregion

    }
}
