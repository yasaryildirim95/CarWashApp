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


        private void kayitEkleBtn_Click(object sender, EventArgs e)
        {

            //var temp = PersonelOlustur();

            //FormHelper.PersonelService
            //    .AddUser(adTextBox.Text, soyadTextBox.Text, int.Parse(maasTextBox.Text), "Sabah", yikamaciCheckBox.Checked);
            //Personel temp;
            //temp = PersonelOlustur(temp);
            //FormHelper.PersonelService.Add(temp);
            //personelListBox.Items.Add(new ListItem(temp.Name + temp.Surname, temp));
            ////personelListBox.Items.Clear();
            ////foreach (var personel in FormHelper.PersonelService.GetAll())
            ////{
            ////    personelListBox.Items.Add(new ListItem($"{personel.Name} {personel.Surname}", personel));
            ////}
            FormHelper.ResetItems(kayitPanel);
        }


        private void silKayitBtn_Click(object sender, EventArgs e)
        {

            var value = ((ListItem)personelListBox.SelectedItem).Value;
            FormHelper.PersonelService.Delete((Personel)value);
            personelListBox.Items.Clear();
            foreach (var personel in FormHelper.PersonelService.GetAll())
            {
                personelListBox.Items.Add(new ListItem($"{personel.Name} {personel.Surname}", personel));
            }



            FormHelper.ResetItems(kayitPanel);
            FormHelper.guncelleSilBtn(false, kayitPanel);
        }

        private void guncelleKayitBtn_Click(object sender, EventArgs e)
        {

            var value = (Personel)((ListItem)personelListBox.SelectedItem).Value;
            var temp = FormHelper.PersonelService.GetById(value.PersonelID);
            temp = PersonelOlustur(temp);
            //personelGuncelleBind(temp);
            FormHelper.PersonelService.Update(temp);
            //personelListBox.Items.Clear();
            //foreach (var personel in FormHelper.PersonelService.GetAll())
            //{
            //    personelListBox.Items.Add(new ListItem($"{personel.Name} {personel.Surname}", personel));
            //}




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
                var value = ((ListItem)personelListBox.SelectedItem).Value;
                personelGuncelleBind((Personel)value);
            }
        }

        private void personelGuncelleBind(Personel personel)
        {
            adTextBox.Text = personel.Name;
            soyadTextBox.Text = personel.Surname;
            maasTextBox.Text = personel.Salary.ToString();
            vardiyaComboBox.SelectedIndex = personel.ShifTypeID - 1;
            yikamaciCheckBox.Checked = personel.IsWasher;
        }
        private Personel PersonelOlustur(Personel personel)
        {
            personel.Name = adTextBox.Text;
            personel.Surname = soyadTextBox.Text;
            personel.Salary = int.Parse(maasTextBox.Text);
            personel.ShifTypeID = vardiyaComboBox.SelectedIndex + 1;
            personel.IsWasher = yikamaciCheckBox.Checked;

            return personel;


        }

        #endregion

        private void personelForm_Load(object sender, EventArgs e)
        {
            foreach (var personel in FormHelper.PersonelService.GetAll())
            {
                personelListBox.Items.Add(new ListItem($"{personel.Name} {personel.Surname}", personel));
            }

            vardiyaComboBox.Items.Add("Sabah");
            vardiyaComboBox.Items.Add("Akşam");
        }
    }
}
