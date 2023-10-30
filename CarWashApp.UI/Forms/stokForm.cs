using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class stokForm : Form
    {
        public stokForm()
        {
            InitializeComponent();
            FormHelper.guncelleSilBtn(false, stokPanel);
        }

        #region Custom Methods

        #endregion

        #region Click Events

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, stokPanel);
            FormHelper.ResetItems(stokPanel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, stokPanel);
            FormHelper.ResetItems(stokPanel);
        }

        private void stokUrunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stokUrunListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, stokPanel);
            }

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(stokPanel);
        }

        #endregion
        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(stokPanel);
            FormHelper.guncelleSilBtn(false, stokPanel);
        }
    }
}
