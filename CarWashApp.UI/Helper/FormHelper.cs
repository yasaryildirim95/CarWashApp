using CarWashApp.BLL.Manager;
using CarWashApp.DAL.Concrete;
using CarWashApp.DAL.Context;
using CarWashApp.Entity.Abstract;

namespace CarWashApp.UI.Helper
{
    /// <summary>
    /// Utility class providing helper methods for WinForm components. Made by xxKralTr
    /// </summary>
    internal static class FormHelper
    {
        /// <summary>
        /// Holds the reference to the currently active button.
        /// </summary>
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

        /// <summary>
        /// Hides all panels within the specified control except the menu panel.
        /// </summary>
        /// <param name="control">The container control to look for panels.</param>
        public static void HidePanels(Control control)
        {
            var temp = control.Controls.OfType<Panel>().FirstOrDefault(x => x.Visible == true && x.Name != "menuPanel");
            if (temp != null)
            {
                temp.Visible = false;
            }
        }
        /// <summary>
        /// Creates and returns a BaseManager instance based on the provided type.
        /// </summary>
        /// <typeparam name="T">The type to be used by the BaseManager.</typeparam>
        /// <returns>A BaseManager instance working with the specified type.</returns>
        public static BaseManager<T> GetBaseManager<T>() where T : class, IEntity
        {
            return new BaseManager<T>(new GenericRepository<T>(new AppDbContext()));
        }

        /// <summary>
        /// Resets the input controls within the specified panel to their default values.
        /// </summary>
        /// <param name="activePanel">The panel containing input controls to be reset.</param>
        public static void ResetItems(Panel activePanel)
        {
            //todo metotlar gelince list eklencek ve listbox resetlencek
            foreach (var tempControl in activePanel.Controls.OfType<TextBox>())
            {
                tempControl.Text = string.Empty;
            }

            foreach (var comboBox in activePanel.Controls.OfType<ComboBox>())
            {
                comboBox.Text = string.Empty;
                comboBox.SelectedIndex = -1;
            }

            foreach (var numericUpDown in activePanel.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Text = "0";
            }

            foreach (var dateTimePicker in activePanel.Controls.OfType<DateTimePicker>())
            {
                dateTimePicker.Value = DateTime.Now;
            }

            foreach (var listBox in activePanel.Controls.OfType<ListBox>())
            {
                listBox.SelectedIndex = -1;
            }

            foreach (var checkBox in activePanel.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

        }
        /// <summary>
        /// Activates a specified button and updates its visual appearance.
        /// </summary>
        /// <param name="sender">The button being activated.</param>
        /// <param name="activePanel">The panel containing the buttons.</param>
        public static void ActivateButton(object sender, Panel activePanel)
        {
            if (sender != null)
            {
                DisableButton(activePanel);
                if (currentButton != (Button)sender)
                {
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(153, 145, 254);
                    currentButton.ForeColor = Color.White;
                    currentButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Disables and updates the visual style of buttons within a specified panel.
        /// </summary>
        /// <param name="activePanel">The panel containing the buttons to be disabled.</param>
        private static void DisableButton(Panel activePanel)
        {
            foreach (Control panelMenuControl in activePanel.Controls.OfType<Button>())
            {
                panelMenuControl.BackColor = Color.FromArgb(51, 51, 76);
                panelMenuControl.ForeColor = Color.LightGray;
                panelMenuControl.Enabled = true;
            }
        }

        /// <summary>
        /// Configures the visibility and enabled state of buttons based on their text content.
        /// </summary>
        /// <param name="IsGuncelleSilEnabled">Determines if 'Güncelle/Sil' buttons should be enabled/visible.</param>
        /// <param name="pnl">The panel containing the buttons to be configured.</param>
        public static void guncelleSilBtn(bool IsGuncelleSilEnabled, Panel pnl)
        {
            foreach (var button in pnl.Controls.OfType<Button>())
            {
                if (button.Text.Contains("Güncelle") || button.Text.Contains("güncelle"))
                    button.Visible = IsGuncelleSilEnabled;
                if (button.Text.Contains("Sil") || button.Text.Contains("sil"))
                    button.Visible = IsGuncelleSilEnabled;
                if (button.Text.Contains("Ekle") || button.Text.Contains("ekle"))
                    button.Enabled = !IsGuncelleSilEnabled;
            }
        }

        /// <summary>
        /// Validates the input fields within the provided panel.
        /// </summary>
        /// <param name="activePanel">The panel containing the input fields to be validated.</param>
        /// <returns>A string containing error messages for each invalid input field.</returns>
        public static string IsValid(Panel activePanel)
        {
            string tempString = "";
            foreach (var textBox in activePanel.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    tempString += textBox.Name.Replace('_', ' ').ToLower().Replace("textbox", "") + " boş bırakılamaz!\n";
            }

            foreach (var comboBox in activePanel.Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedIndex == -1)
                    tempString += comboBox.Name.Replace('_', ' ').ToLower().Replace("combobox", "") + " seçilmeli!\n";
            }

            foreach (var numericUpDown in activePanel.Controls.OfType<NumericUpDown>())
            {
                if (numericUpDown.Value == 0)
                    tempString += numericUpDown.Name.Replace('_', ' ').ToLower().Replace("numericupd", " ") + " 0 olamaz!\n";
            }
            return tempString;
        }
        /// <summary>
        /// Populates a ListBox or ComboBox control with items from the provided list.
        /// </summary>
        /// <typeparam name="T">The type of objects in the list.</typeparam>
        /// <param name="control">The control to populate (should be ListBox or ComboBox).</param>
        /// <param name="objects">The list of objects to populate the control with.</param>
        public static void ComboOrListBoxMaker<T>(Control control, List<T> objects) where T : class
        {
            if (control is ListBox listBox)
            {

                listBox.Items.Clear();
                foreach (var value in objects)
                {
                    listBox.Items.Add(new ListItem($"{value}", value));
                }
            }

            if (control is ComboBox comboBox)
            {
                comboBox.Items.Clear();
                foreach (var value in objects)
                {
                    comboBox.Items.Add(new ListItem($"{value}", value));
                }
            }
        }
        /// <summary>
        /// Converts the selected index value to a specific type of object.
        /// </summary>
        /// <typeparam name="T">The type to convert the selected index value to.</typeparam>
        /// <param name="item">The selected index value to be converted.</param>
        /// <returns>The selected index value converted to the specified type.</returns>
        public static T SelectedIndexTransform<T>(object item)
        {
            return (T)((ListItem)item).Value;
        }

    }
}
