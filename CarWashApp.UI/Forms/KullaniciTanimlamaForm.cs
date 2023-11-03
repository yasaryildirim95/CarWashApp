using CarWashApp.Entity.Concrete;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class KullaniciTanimlamaForm : Form
    {
        public KullaniciTanimlamaForm()
        {
            InitializeComponent();
            FormHelper.ComboOrListBoxMaker(personelComboBox, FormHelper.PersonelService.GetAll(1));
            FormHelper.ComboOrListBoxMaker(kullaniciListBox, FormHelper.GetBaseManager<LoginDetail>().GetAll());
        }
        private void KullaniciTanimlamaForm_Load(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            var IsValid = FormHelper.IsValid(kullaniciPanel);
            if (IsValid != string.Empty)
            {
                MessageBox.Show(IsValid);
                return;
            }
            FormHelper.GetBaseManager<LoginDetail>().Add(new() { IsAdmin = isAdminCheckBox.Checked, PersonelID = FormHelper.SelectedIndexTransform<Personel>(personelComboBox.SelectedItem).PersonelID, Password = sifreTextBox.Text, Username = kullanici_AdiTextBox.Text });
            //var loginDetails = FormHelper.PersonelService.AddLoginDetails(
            //    FormHelper.SelectedIndexTransform<Personel>((ListItem)personelComboBox.SelectedItem).PersonelID,
            //    kullanici_AdiTextBox.Text, sifreTextBox.Text, isAdminCheckBox.Checked);
            //MessageBox.Show(loginDetails);

            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.ComboOrListBoxMaker(personelComboBox, FormHelper.PersonelService.GetAll(1));
            FormHelper.ComboOrListBoxMaker(kullaniciListBox, FormHelper.GetBaseManager<LoginDetail>().GetAll());

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            personelComboBox.Enabled = true;
            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            personelComboBox.Enabled = true;
            FormHelper.GetBaseManager<LoginDetail>().Delete(FormHelper.SelectedIndexTransform<LoginDetail>(kullaniciListBox.SelectedItem));
            FormHelper.ComboOrListBoxMaker(personelComboBox, FormHelper.PersonelService.GetAll(1));
            FormHelper.ComboOrListBoxMaker(kullaniciListBox, FormHelper.GetBaseManager<LoginDetail>().GetAll());
            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        //todo sil butonunda bir değişikliğe gidilcek
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            personelComboBox.Enabled = true;
            var IsValid = FormHelper.IsValid(kullaniciPanel);
            if (IsValid != string.Empty && !IsValid.Contains("personel"))
            {
                MessageBox.Show(IsValid);
                return;
            }
            var tempLoginDetail = FormHelper.SelectedIndexTransform<LoginDetail>(kullaniciListBox.SelectedItem);



            //tempLoginDetail.PersonelID = FormHelper
            //    .SelectedIndexTransform<Personel>((ListItem)personelComboBox.SelectedItem).PersonelID;
            tempLoginDetail.IsAdmin = isAdminCheckBox.Checked;
            tempLoginDetail.Password = sifreTextBox.Text;
            tempLoginDetail.Username = kullanici_AdiTextBox.Text;


            FormHelper.GetBaseManager<LoginDetail>().Update(tempLoginDetail);
            FormHelper.ComboOrListBoxMaker(personelComboBox, FormHelper.PersonelService.GetAll(1));

            FormHelper.ResetItems(kullaniciPanel);
            FormHelper.guncelleSilBtn(false, kullaniciPanel);
        }

        private void kullaniciListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kullaniciListBox.SelectedIndex != -1)
            {
                personelComboBox.Enabled = false;
                FormHelper.guncelleSilBtn(true, kullaniciPanel);
                var tempLoginDetail =
                    FormHelper.SelectedIndexTransform<LoginDetail>(kullaniciListBox.SelectedItem);
                var tempPersonel = FormHelper.PersonelService.GetById(tempLoginDetail.PersonelID);
                string personelStringRepresentation = tempPersonel.ToString();

                ListItem newListItem = new ListItem(personelStringRepresentation, tempPersonel);


                personelComboBox.SelectedItem = newListItem;
                kullanici_AdiTextBox.Text = tempLoginDetail.Username;
                sifreTextBox.Text = tempLoginDetail.Password;
                isAdminCheckBox.Checked = tempLoginDetail.IsAdmin;
            }
        }
    }
}
