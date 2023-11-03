using CarWashApp.Entity.Concrete;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class stokForm : Form
    {
        public stokForm()
        {
            InitializeComponent();
            FormHelper.guncelleSilBtn(false, stokPanel);
            FormHelper.ComboOrListBoxMaker(stokUrunListBox, FormHelper.ProductService.GetAll());
        }

        #region Custom Methods

        #endregion

        #region Click Events

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var IsValid = FormHelper.IsValid(stokPanel);
            if (IsValid != string.Empty)
            {
                MessageBox.Show(IsValid);
                return;
            }
            var product = FormHelper.SelectedIndexTransform<Product>(stokUrunListBox.SelectedItem);
            var update = FormHelper.ProductService.Update(urun_AdıTextBox.Text, (int)stok_AdetNumericUpD.Value, (int)uyari_EsigiNumericUpD.Value);
            FormHelper.guncelleSilBtn(false, stokPanel);
            FormHelper.ResetItems(stokPanel);
            FormHelper.ComboOrListBoxMaker(stokUrunListBox, FormHelper.ProductService.GetAll());
            MessageBox.Show(update);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            var IsValid = FormHelper.IsValid(stokPanel);
            if (IsValid != string.Empty)
            {
                MessageBox.Show(IsValid);
                return;
            }

            var product = FormHelper.SelectedIndexTransform<Product>(stokUrunListBox.SelectedItem);
            FormHelper.ProductService.Delete(product);
            FormHelper.guncelleSilBtn(false, stokPanel);
            FormHelper.ResetItems(stokPanel);
            FormHelper.ComboOrListBoxMaker(stokUrunListBox, FormHelper.ProductService.GetAll());
        }

        private void stokUrunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stokUrunListBox.SelectedIndex != -1)
            {
                ProductGuncelleBind(FormHelper.SelectedIndexTransform<Product>(stokUrunListBox.SelectedItem));
                FormHelper.guncelleSilBtn(true, stokPanel);
            }

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(stokPanel);
            if (isValid != string.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }
            var IsAdded = FormHelper.ProductService.Add(urun_AdıTextBox.Text, (int)stok_AdetNumericUpD.Value, (int)uyari_EsigiNumericUpD.Value);
            MessageBox.Show(IsAdded);
            FormHelper.ResetItems(stokPanel);
            FormHelper.ComboOrListBoxMaker(stokUrunListBox, FormHelper.ProductService.GetAll());
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.ResetItems(stokPanel);
            FormHelper.guncelleSilBtn(false, stokPanel);
        }

        private void ProductGuncelleBind(Product product)
        {
            urun_AdıTextBox.Text = product.ProductName;
            stok_AdetNumericUpD.Value = product.Stock;
            uyari_EsigiNumericUpD.Value = product.StockWarningThreshold;
        }
        private Product ProductGuncelleOlustur(Product? product)
        {
            product ??= new Product();
            product.ProductName = urun_AdıTextBox.Text;
            product.Stock = (int)stok_AdetNumericUpD.Value;
            product.StockWarningThreshold = (int)uyari_EsigiNumericUpD.Value;

            return product;


        }
        #endregion

    }
}
