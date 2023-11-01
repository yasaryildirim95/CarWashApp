using CarWashApp.BLL.Manager;
using CarWashApp.DAL.Concrete;
using CarWashApp.DAL.Context;

namespace CarWashApp.UI.Helper
{
    internal static class FormHelper
    {
        public static Button currentButton;

        public static OwnerVehicleManager
            OwnerVehicleService = new OwnerVehicleManager(new OwnerVehicleRepository(new AppDbContext()));

        public static PersonelManager
            PersonelService = new PersonelManager(new PersonelRepository(new AppDbContext()));

        public static ProductManager
            ProductService = new ProductManager(new ProductRepository(new AppDbContext()));

        public static WashManager
            WashService = new WashManager(new WashRepository(new AppDbContext()));

        public static WashTypeManager
            WashTypeService = new WashTypeManager(new WashTypeRepository(new AppDbContext()));

        public static void HidePanels(Control control)
        {
            var temp = control.Controls.OfType<Panel>().FirstOrDefault(x => x.Visible == true && x.Name != "menuPanel");
            if (temp != null)
            {
                temp.Visible = false;
            }
        }
        public static void ResetItems(Panel temp)
        {
            //todo metotlar gelince list eklencek ve listbox resetlencek
            foreach (var tempControl in temp.Controls.OfType<TextBox>())
            {
                tempControl.Text = string.Empty;
            }

            foreach (var comboBox in temp.Controls.OfType<ComboBox>())
            {
                comboBox.Text = string.Empty;
                comboBox.SelectedIndex = -1;
            }

            foreach (var numericUpDown in temp.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Text = "0";
            }

            foreach (var dateTimePicker in temp.Controls.OfType<DateTimePicker>())
            {
                dateTimePicker.Value = DateTime.Now;
            }

            foreach (var listBox in temp.Controls.OfType<ListBox>())
            {
                listBox.SelectedIndex = -1;
            }

            foreach (var checkBox in temp.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

        }
        public static void ActivateButton(object sender, Panel pnl)
        {
            if (sender != null)
            {
                DisableButton(pnl);
                if (currentButton != (Button)sender)
                {
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(153, 145, 254);
                    currentButton.ForeColor = Color.White;
                    currentButton.Enabled = false;
                }
            }
        }
        public static void DisableButton(Panel pnl)
        {
            foreach (Control panelMenuControl in pnl.Controls.OfType<Button>())
            {
                panelMenuControl.BackColor = Color.FromArgb(51, 51, 76);
                panelMenuControl.ForeColor = Color.LightGray;
                panelMenuControl.Enabled = true;
            }
        }
        public static void guncelleSilBtn(bool temp, Panel pnl)
        {
            foreach (var button in pnl.Controls.OfType<Button>())
            {
                if (button.Text.Contains("Güncelle") || button.Text.Contains("güncelle"))
                    button.Visible = temp;
                if (button.Text.Contains("Sil") || button.Text.Contains("sil"))
                    button.Visible = temp;
                if (button.Text.Contains("Ekle") || button.Text.Contains("ekle"))
                    button.Enabled = !temp;
            }
        }

        public static string IsValid(bool temp, Panel pnl)
        {
            string tempString = "";
            foreach (var textBox in pnl.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    tempString += textBox.Name + " boş bırakılamaz!\n";
            }

            foreach (var comboBox in pnl.Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedIndex == -1)
                    tempString += comboBox.Name + " seçilmeli!\n";
            }

            foreach (var numericUpDown in pnl.Controls.OfType<NumericUpDown>())
            {
                if (numericUpDown.Value == 0)
                    tempString += numericUpDown.Name + " 0 olamaz!\n";
            }
            return tempString;
        }
    }
}
