using CarWashApp.Entity.Concrete;
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
            FormHelper.ComboOrListBoxMaker(aracTipleriListBox, FormHelper.GetBaseManager<VehicleType>().GetAll());
            FormHelper.ComboOrListBoxMaker(yikamaUrunListBox, FormHelper.GetBaseManager<WashType>().GetAll());
            FormHelper.ComboOrListBoxMaker(kirlilikAyarlariListBox,
        FormHelper.GetBaseManager<DirtinessLevel>().GetAll());
            FormHelper.ComboOrListBoxMaker(urunAyarlariListBox, FormHelper.WashTypeService.GetAllWashTypeProducts());

            FormHelper.ComboOrListBoxMaker(urunComboBox, FormHelper.ProductService.GetAll());
            FormHelper.ComboOrListBoxMaker(yikama_TipiComboBox, FormHelper.GetBaseManager<WashType>().GetAll());

        }


        #region menuPanel

        private void yıkamaAyarBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            yikamaPanel.Show();
        }

        private void aracTipiBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            aracTipiPanel.Show();
        }

        private void kirlilikAyarBtn_Click(object sender, EventArgs e)
        {
            FormHelper.HidePanels(this);
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            kirlilikPanel.Show();
        }
        private void urunAyarlariBtn_Click(object sender, EventArgs e)
        {

            FormHelper.ComboOrListBoxMaker(urunComboBox, FormHelper.ProductService.GetAll());
            FormHelper.ComboOrListBoxMaker(yikama_TipiComboBox, FormHelper.GetBaseManager<WashType>().GetAll());
            FormHelper.HidePanels(this);
            FormHelper.HighlightSelectedButton(sender, menuPanel);
            yıkamaUrunAyarlariPanel.Show();

        }
        #endregion

        #region yikamaPanel
        private void yikamaPanelEkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(yikamaPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }
            FormHelper.GetBaseManager<WashType>().Add(WashTypeEkleGuncelle(new WashType()));
            FormHelper.ResetItems(yikamaPanel);
            FormHelper.ComboOrListBoxMaker(yikamaUrunListBox, FormHelper.GetBaseManager<WashType>().GetAll());

        }



        private void yikamaPanelResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
        }

        private void silYikamaPanelBtn_Click(object sender, EventArgs e)
        {

            FormHelper.GetBaseManager<WashType>().Delete(FormHelper.SelectedIndexTransform<WashType>(yikamaUrunListBox.SelectedItem));
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
            FormHelper.ComboOrListBoxMaker(yikamaUrunListBox, FormHelper.GetBaseManager<WashType>().GetAll());

        }

        private void guncelleYikamaPanelBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(yikamaPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }
            var tempWashType = FormHelper.SelectedIndexTransform<WashType>(yikamaUrunListBox.SelectedItem);
            tempWashType = WashTypeEkleGuncelle(tempWashType);
            FormHelper.GetBaseManager<WashType>().Update(tempWashType);
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            FormHelper.ResetItems(yikamaPanel);
            FormHelper.ComboOrListBoxMaker(yikamaUrunListBox, FormHelper.GetBaseManager<WashType>().GetAll());

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yikamaUrunListBox.SelectedIndex != -1)
            {
                yikamaPanelDoldur(FormHelper.SelectedIndexTransform<WashType>(yikamaUrunListBox.SelectedItem));
                FormHelper.guncelleSilBtn(true, yikamaPanel);
            }
        }
        private WashType WashTypeEkleGuncelle(WashType? washType)
        {
            washType ??= new WashType();
            washType.WashTypeName = yikama_AdiTextBox.Text;
            washType.Duration = (int)yikama_SuresiNumericUpD.Value;
            washType.Price = (int)yikama_FiyatiNumericUpD.Value;
            return washType;
        }

        private void yikamaPanelDoldur(WashType washType)
        {
            yikama_AdiTextBox.Text = washType.WashTypeName;
            yikama_SuresiNumericUpD.Value = washType.Duration;
            yikama_FiyatiNumericUpD.Value = washType.Price;
        }

        #endregion

        #region AracTipiPanel
        private void aracTipEkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(aracTipiPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            VehicleType vehicleType = null;
            vehicleType = VehicleTypeEkleGuncelle(vehicleType);
            FormHelper.GetBaseManager<VehicleType>().Add(vehicleType);
            FormHelper.ResetItems(aracTipiPanel);

            FormHelper.ComboOrListBoxMaker<VehicleType>(aracTipleriListBox, FormHelper.GetBaseManager<VehicleType>().GetAll());
        }

        private void aracTipResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
        }

        private void aracTipSilBtn_Click(object sender, EventArgs e)
        {
            FormHelper.GetBaseManager<VehicleType>().Delete(FormHelper.SelectedIndexTransform<VehicleType>(aracTipleriListBox.SelectedItem));
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
            FormHelper.ComboOrListBoxMaker<VehicleType>(aracTipleriListBox, FormHelper.GetBaseManager<VehicleType>().GetAll());
        }

        private void guncelleAracTipBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(aracTipiPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            var vehicleType = FormHelper.SelectedIndexTransform<VehicleType>(aracTipleriListBox.SelectedItem);
            vehicleType = VehicleTypeEkleGuncelle(vehicleType);
            FormHelper.GetBaseManager<VehicleType>().Update(vehicleType);
            FormHelper.ResetItems(aracTipiPanel);
            FormHelper.guncelleSilBtn(false, aracTipiPanel);
            FormHelper.ComboOrListBoxMaker<VehicleType>(aracTipleriListBox, FormHelper.GetBaseManager<VehicleType>().GetAll());
        }

        private void aracTipleriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aracTipleriListBox.SelectedIndex != -1)
            {
                aracTipiPanelDoldur(FormHelper.SelectedIndexTransform<VehicleType>(aracTipleriListBox.SelectedItem));
                FormHelper.guncelleSilBtn(true, aracTipiPanel);
            }
        }

        private VehicleType VehicleTypeEkleGuncelle(VehicleType? vehicleType)
        {
            vehicleType ??= new VehicleType();
            vehicleType.VehicleTypeName = arac_TipiTextBox.Text;
            vehicleType.PriceMultiplier = (int)fiyat_CarpaniNumericUpD.Value;
            return vehicleType;
        }
        private void aracTipiPanelDoldur(VehicleType vehicleType)
        {
            arac_TipiTextBox.Text = vehicleType.VehicleTypeName;
            fiyat_CarpaniNumericUpD.Value = vehicleType.PriceMultiplier;
        }
        #endregion

        #region kirlilikPanel

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(kirlilikPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }
            DirtinessLevel tempDirtinessLevel = null;
            tempDirtinessLevel = dirtinessEkleGuncelle(tempDirtinessLevel);
            FormHelper.GetBaseManager<DirtinessLevel>().Add(tempDirtinessLevel);
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
            FormHelper.ComboOrListBoxMaker(kirlilikAyarlariListBox, FormHelper.GetBaseManager<DirtinessLevel>().GetAll());
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            FormHelper.GetBaseManager<DirtinessLevel>().Delete(FormHelper.SelectedIndexTransform<DirtinessLevel>(kirlilikAyarlariListBox.SelectedItem));
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
            FormHelper.ComboOrListBoxMaker(kirlilikAyarlariListBox, FormHelper.GetBaseManager<DirtinessLevel>().GetAll());
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(kirlilikPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            var tempDirtinessLevel =
                FormHelper.SelectedIndexTransform<DirtinessLevel>(kirlilikAyarlariListBox.SelectedItem);
            tempDirtinessLevel = dirtinessEkleGuncelle(tempDirtinessLevel);
            FormHelper.GetBaseManager<DirtinessLevel>().Update(tempDirtinessLevel);
            FormHelper.ResetItems(kirlilikPanel);
            FormHelper.guncelleSilBtn(false, kirlilikPanel);
            FormHelper.ComboOrListBoxMaker(kirlilikAyarlariListBox, FormHelper.GetBaseManager<DirtinessLevel>().GetAll());
        }

        private void kirlilikAyarlariListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kirlilikAyarlariListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, kirlilikPanel);
                kirlilikPanelDoldur(
                    FormHelper.SelectedIndexTransform<DirtinessLevel>(kirlilikAyarlariListBox.SelectedItem));
            }
        }
        private DirtinessLevel dirtinessEkleGuncelle(DirtinessLevel? dirtinessLevel)
        {
            dirtinessLevel ??= new DirtinessLevel();
            dirtinessLevel.DirtinessLevelName = kirlilik_AdiTextBox.Text;
            dirtinessLevel.AdditionalDuration = (int)kirlilik_SuresiNumericUpD.Value;
            return dirtinessLevel;
        }
        private void kirlilikPanelDoldur(DirtinessLevel dirtinessLevel)
        {
            kirlilik_AdiTextBox.Text = dirtinessLevel.DirtinessLevelName;
            kirlilik_SuresiNumericUpD.Value = dirtinessLevel.AdditionalDuration;
        }
        #endregion

        #region yıkamaUrunAyarlariPanel

        private void urunAyarlariEkleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(yıkamaUrunAyarlariPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            WashTypeProduct washTypeProduct = null;
            washTypeProduct = ekleWashTypeProduct(washTypeProduct);
            FormHelper.WashTypeService.AddWashTypeProduct(washTypeProduct);

            FormHelper.ResetItems(yıkamaUrunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, yıkamaUrunAyarlariPanel);

            FormHelper.ComboOrListBoxMaker(urunAyarlariListBox, FormHelper.WashTypeService.GetAllWashTypeProducts());
        }

        private void urunAyarlariSilBtn_Click(object sender, EventArgs e)
        {
            FormHelper.GetBaseManager<WashTypeProduct>().Delete(FormHelper.SelectedIndexTransform<WashTypeProduct>(urunAyarlariListBox.SelectedItem));
            FormHelper.ResetItems(yıkamaUrunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, yıkamaUrunAyarlariPanel);
            FormHelper.ComboOrListBoxMaker(urunAyarlariListBox, FormHelper.WashTypeService.GetAllWashTypeProducts());
        }

        private void urunAyarlariListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urunAyarlariListBox.SelectedIndex != -1)
            {
                FormHelper.guncelleSilBtn(true, yıkamaUrunAyarlariPanel);
                yikama_TipiComboBox.Enabled = false;
                urunComboBox.Enabled = false;
                adetNumericUpD.Enabled = false;
            }
            else
            {
                yikama_TipiComboBox.Enabled = true;
                urunComboBox.Enabled = true;
                adetNumericUpD.Enabled = true;
            }
        }

        private WashTypeProduct ekleWashTypeProduct(WashTypeProduct? washTypeProduct)
        {
            washTypeProduct ??= new WashTypeProduct();
            washTypeProduct.Quantity = (int)adetNumericUpD.Value;
            washTypeProduct.WashTypeID = FormHelper.SelectedIndexTransform<WashType>(yikama_TipiComboBox.SelectedItem).WashTypeID;
            washTypeProduct.ProductTypeID = FormHelper.SelectedIndexTransform<Product>(urunComboBox.SelectedItem).ProductID;
            return washTypeProduct;
        }

        private void urunAyarlariResetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(yıkamaUrunAyarlariPanel);
            FormHelper.guncelleSilBtn(false, yıkamaUrunAyarlariPanel);
        }
        #endregion
    }
}
