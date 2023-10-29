using CarWashApp.UI.Forms;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelMenuHideOrShow(false);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        #region CustomMethods

        private void panelMenuHideOrShow(bool IsShow)
        {
            foreach (var control in menuPanel.Controls)
            {
                if (control is Button btn)
                {
                    if (IsShow)
                        btn.Show();
                    else
                        btn.Hide();
                }

            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            FormHelper.ActivateButton(sender, menuPanel);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.Show();
            FormName.Text = childForm.Text;

        }
        #endregion

        #region clickEvents

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in girisPanel.Controls)
            {
                if (item is TextBox txt)
                    txt.Hide();


                if (item is Button btn)
                    btn.Hide();

                if (item is Label lbl)
                    lbl.Hide();
            }
            FormName.Text = "Home";
            panelMenuHideOrShow(true);
            girisPanel.Hide();
        }

        private void aracKayitBtn_Click(object sender, EventArgs e)
        {
            var tempAracForm = new AracKayitForm();
            OpenChildForm(tempAracForm, sender);

        }

        private void yikamaBtn_Click(object sender, EventArgs e)
        {
            var tempYikamaForm = new yikamaForm();
            OpenChildForm(tempYikamaForm, sender);
        }

        private void stokBtn_Click(object sender, EventArgs e)
        {
            var tempStokForm = new stokForm();
            OpenChildForm(tempStokForm, sender);
        }

        private void personelBtn_Click(object sender, EventArgs e)
        {
            var tempPersonelForm = new personelForm();
            OpenChildForm(tempPersonelForm, sender);
        }

        private void uygulamaAyarlariBtn_Click(object sender, EventArgs e)
        {
            var tempUygulamaAyarlariForm = new uygulamaAyarlariForm();
            OpenChildForm(tempUygulamaAyarlariForm, sender);
        }
        #endregion

        private void uygulamaKullaniciBtn_Click(object sender, EventArgs e)
        {
            var tempUygulamaKullaniciForm = new uygulamaKullaniciForm();
            OpenChildForm(tempUygulamaKullaniciForm, sender);
        }
    }
}