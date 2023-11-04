using CarWashApp.Entity.Concrete;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class AracKayitForm : Form
    {
        public MainForm mainForm;
        public Button btn;
        public AracKayitForm()
        {
            InitializeComponent();
        }

        private void AracKayitForm_Load(object sender, EventArgs e)
        {
        }

        #region Menu Panel
        private void aramaBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            FormHelper.ResetItems(aramaPanel);
            aramaPanel.Show();
        }

        private void aracKayitBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);
            aracKayitPanel.Show();
            FormHelper.ResetItems(aracKayitPanel);
            FormHelper.ComboOrListBoxMaker<VehicleOwner>(arac_SahipComboBox, FormHelper.OwnerVehicleService.GetAll());
            FormHelper.ComboOrListBoxMaker<VehicleType>(arac_TipComboBox, FormHelper.GetBaseManager<VehicleType>().GetAll());
        }

        private void aracSahibiBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            FormHelper.HidePanels(this);

            FormHelper.ResetItems(aracSahibiPanel);
            aracSahibiPanel.Show();
        }

        #endregion

        #region Arama Panel

        private void araBtn_Click(object sender, EventArgs e)
        {

            var tempString = FormHelper.OwnerVehicleService.SearchByPlate(plaka_AramaTextBox.Text);
            MessageBox.Show(tempString);
            if (tempString.Contains("bulundu"))
                mainForm.yikamaBtn_Click(btn, e);
        }

        #endregion

        #region Araç Sahibi Panel
        private void aracSahibiEkle_Click(object sender, EventArgs e)
        {
            var temp = FormHelper.IsValid(aracSahibiPanel);
            if (temp == string.Empty)
            {

                var tempx = FormHelper.OwnerVehicleService.AddOwner(adTextBox.Text, soyadTextBox.Text, telefonTextBox.Text,
                    mailTextBox.Text);
                MessageBox.Show(tempx);
                FormHelper.ResetItems(aracKayitPanel);
                return;
            }
            MessageBox.Show(temp);
        }


        #endregion


        private void AracEkleBtn_Click(object sender, EventArgs e)
        {
            var temp = FormHelper.IsValid(aracKayitPanel);
            if (temp == string.Empty)
            {
                var vehicleOwner = FormHelper.SelectedIndexTransform<VehicleOwner>(arac_SahipComboBox.SelectedItem);

                var vehicleType = FormHelper.SelectedIndexTransform<VehicleType>(arac_TipComboBox.SelectedItem);

                var tempx = FormHelper.OwnerVehicleService.AddVehicle(vehicleOwner.PhoneNumber, arac_PlakaTextBox.Text,
                     arac_MarkaTextBox.Text, arac_ModelTextBox.Text, arac_RenkTextBox.Text, vehicleType.VehicleTypeName);
                FormHelper.ResetItems(aracKayitPanel);
                MessageBox.Show(tempx);
                return;
            }

            MessageBox.Show(temp);
        }
    }
}
