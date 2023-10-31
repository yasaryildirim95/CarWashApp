using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class KullaniciTanimlamaForm : Form
    {
        public KullaniciTanimlamaForm()
        {
            InitializeComponent();
        }
        private void KullaniciTanimlamaForm_Load(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kullaniciPanel);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void kullaniciListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kullaniciListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, kullaniciPanel);
            }
        }
    }
}
