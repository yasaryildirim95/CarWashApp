using CarWashApp.Entity.Concrete;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class personelForm : Form
    {
        public personelForm()
        {
            InitializeComponent();
        }
        private void personelForm_Load(object sender, EventArgs e)
        {
            FormHelper.ComboOrListBoxMaker(personelListBox, FormHelper.PersonelService.GetAll());
            FormHelper.ComboOrListBoxMaker(izinGunleriListBox, FormHelper.PersonelService.GetAllPersonelLeaves());
            FormHelper.ComboOrListBoxMaker(personelComboBox, FormHelper.GetBaseManager<Personel>().GetAll());
            FormHelper.ComboOrListBoxMaker(vardiyaComboBox, FormHelper.GetBaseManager<Shift>().GetAll());
            baslangic_TarihiDTP.MinDate = DateTime.Now;
            baslangic_TarihiDTP.MaxDate = DateTime.Now.AddYears(1);

        }
        #region menuPanel
        private void kayitBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            kayitPanel.Show();
        }

        private void izinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            izinPanel.Show();
        }

        private void personelTakipBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            var temp = FormHelper.PersonelService.ShowPersonelavailability();
            calisanlarDataGrid.DataSource = temp.Item1;
            bostakilerDataGrid.DataSource = temp.Item2;

            personelTakipPanel.Show();
        }
        #endregion

        #region izinPanel
        private void izinEkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(izinPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            PersonelLeave personelLeave = null;
            personelLeave = personelLeaveMaker(personelLeave);
            FormHelper.PersonelService.AddPersonelLeave(personelLeave);
            FormHelper.ComboOrListBoxMaker(izinGunleriListBox, FormHelper.PersonelService.GetAllPersonelLeaves());
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void silIzinBtn_Click(object sender, EventArgs e)
        {


            PersonelLeave personelLeave = FormHelper.SelectedIndexTransform<PersonelLeave>(izinGunleriListBox.SelectedItem);
            FormHelper.GetBaseManager<PersonelLeave>().Delete(personelLeave);

            FormHelper.ComboOrListBoxMaker(izinGunleriListBox, FormHelper.PersonelService.GetAllPersonelLeaves());
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void guncelleIzinBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(izinPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            PersonelLeave personelLeave = FormHelper.SelectedIndexTransform<PersonelLeave>(izinGunleriListBox.SelectedItem);
            personelLeave = personelLeaveMaker(personelLeave);

            FormHelper.GetBaseManager<PersonelLeave>().Update(personelLeave);
            FormHelper.PersonelService.AddPersonelLeave(personelLeave);
            FormHelper.ComboOrListBoxMaker(izinGunleriListBox, FormHelper.PersonelService.GetAllPersonelLeaves());
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private void izinGunleriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izinGunleriListBox.SelectedIndex != -1)
            {
                izinPanelDoldur(FormHelper.SelectedIndexTransform<PersonelLeave>(izinGunleriListBox.SelectedItem));
                FormHelper.guncelleSilBtn(true, izinPanel);
            }
        }

        private void resetIzinBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(izinPanel);
            FormHelper.guncelleSilBtn(false, izinPanel);
        }

        private PersonelLeave personelLeaveMaker(PersonelLeave? personelLeave)
        {
            //todo sil güncelle 2sinden biri yada 2side override edilcek personel izin sürelerine geri vermiyo ama özel sektöre uyan bir tavır böylede bırakabiliriz.
            personelLeave ??= new PersonelLeave();
            personelLeave.NumOfDays = (int)izin_SuresiNumericUpD.Value;
            personelLeave.StartDate = baslangic_TarihiDTP.Value;
            personelLeave.PersonelID = FormHelper.SelectedIndexTransform<Personel>(personelComboBox.SelectedItem).PersonelID;
            return personelLeave;
        }

        private void izinPanelDoldur(PersonelLeave personelLeave)
        {
            personelComboBox.SelectedIndex = personelComboBox.FindString(personelLeave.Personel.ToString());
            izin_SuresiNumericUpD.Value = personelLeave.NumOfDays;
        }
        #endregion

        #region kayitPanel


        private void kayitEkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(kayitPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }
            Personel temp = null;
            temp = PersonelGuncelleOlustur(temp);
            FormHelper.PersonelService.Add(temp);
            FormHelper.ComboOrListBoxMaker(personelListBox, FormHelper.PersonelService.GetAll());
            FormHelper.ResetItems(kayitPanel);
            FormHelper.guncelleSilBtn(false, kayitPanel);
        }


        private void silKayitBtn_Click(object sender, EventArgs e)
        {


            var value = FormHelper.SelectedIndexTransform<Personel>(personelListBox.SelectedItem);
            FormHelper.PersonelService.Delete(value);
            FormHelper.ComboOrListBoxMaker(personelListBox, FormHelper.PersonelService.GetAll());
            FormHelper.ResetItems(kayitPanel);
            FormHelper.guncelleSilBtn(false, kayitPanel);
        }


        private void guncelleKayitBtn_Click(object sender, EventArgs e)
        {

            var value = FormHelper.SelectedIndexTransform<Personel>(personelListBox.SelectedItem);
            value = PersonelGuncelleOlustur(value);
            FormHelper.PersonelService.Update(value);
            FormHelper.ComboOrListBoxMaker(personelListBox, FormHelper.PersonelService.GetAll());

            FormHelper.ResetItems(kayitPanel);
            FormHelper.guncelleSilBtn(false, kayitPanel);
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kayitPanel);
            FormHelper.guncelleSilBtn(false, kayitPanel);
        }
        private void personelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personelListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, kayitPanel);
                var value = FormHelper.SelectedIndexTransform<Personel>(personelListBox.SelectedItem);
                personelGuncelleBind(value);
            }
        }

        private void personelGuncelleBind(Personel personel)
        {
            adTextBox.Text = personel.Name;
            soyadTextBox.Text = personel.Surname;
            maasNumericUpD.Value = personel.Salary;
            vardiyaComboBox.SelectedIndex = personel.ShifTypeID - 1;
            yikamaciCheckBox.Checked = personel.IsWasher;
        }
        private Personel PersonelGuncelleOlustur(Personel? personel)
        {
            personel ??= new Personel();
            personel.Name = adTextBox.Text;
            personel.Surname = soyadTextBox.Text;
            personel.Salary = (int)maasNumericUpD.Value;
            personel.ShifTypeID = vardiyaComboBox.SelectedIndex + 1;
            personel.IsWasher = yikamaciCheckBox.Checked;

            return personel;


        }
        #endregion

    }
}
