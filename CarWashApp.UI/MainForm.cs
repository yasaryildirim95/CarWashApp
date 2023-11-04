using CarWashApp.UI.Forms;
using CarWashApp.UI.Helper;
using CarWashApp.UI.Properties;

namespace CarWashApp.UI
{
    public partial class MainForm : Form
    {
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
                    {
                        girisPanel.Hide();
                        FormName.Text = "Home";
                        foreach (var item in girisPanel.Controls)
                        {
                            if (item is TextBox txt)
                                txt.Hide();


                            if (item is Button tempBtn)
                                tempBtn.Hide();

                            if (item is Label lbl)
                                lbl.Hide();
                        }
                        btn.Show();
                    }
                    else
                    {
                        btn.Hide();
                    }
                }

            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            FormHelper.HighlightSelectedButton(sender, menuPanel);
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
            var IsValid = FormHelper.IsValid(girisPanel);
            if (IsValid != string.Empty)
            {
                MessageBox.Show(IsValid);
                return;
            }
            var checkLoginInfo = FormHelper.PersonelService.CheckLoginInfo(kullaniciTextBox.Text, sifreTextBox.Text);
            if (!checkLoginInfo.Item1 || !checkLoginInfo.Item2)
            {
                panelMenuHideOrShow(true);
                titleLbl.Text = "Kullanıcı";
                personelBtn.Visible = false;
                uygulamaKullaniciBtn.Visible = false;
            }
            else if (checkLoginInfo.Item1 && checkLoginInfo.Item2)
            {
                panelMenuHideOrShow(true);
                titleLbl.Text = "Admin";
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void aracKayitBtn_Click(object sender, EventArgs e)
        {
            var tempAracForm = new AracKayitForm();
            tempAracForm.mainForm = this;
            tempAracForm.btn = yikamaBtn;
            OpenChildForm(tempAracForm, sender);

        }

        public void yikamaBtn_Click(object sender, EventArgs e)
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
            var tempUygulamaAyarlariForm = new AyarlarForm();
            OpenChildForm(tempUygulamaAyarlariForm, sender);
        }
        #endregion

        private void uygulamaKullaniciBtn_Click(object sender, EventArgs e)
        {
            var tempUygulamaKullaniciForm = new KullaniciTanimlamaForm();
            OpenChildForm(tempUygulamaKullaniciForm, sender);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            sifreTextBox.PasswordChar = '\0';
            eyeImg.Image = Resources.eye;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            sifreTextBox.PasswordChar = '*';
            eyeImg.Image = Resources.Eye_icon;
        }
    }
}