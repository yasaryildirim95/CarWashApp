namespace CarWashApp.UI.Helper
{
    internal static class FormHelper
    {
        public static Button currentButton;
        public static void HidePanels(Control control)
        {
            foreach (Panel tempControl in control.Controls.OfType<Panel>())
            {
                if (tempControl.Name != "menuPanel")
                    tempControl.Hide();
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
                if (button.Name.Contains("guncelle"))
                    button.Visible = temp;
                if (button.Name.Contains("sil"))
                    button.Visible = temp;
                if (button.Name.Contains("ekle"))
                    button.Enabled = !temp;
            }
        }

        public static string IsValid(bool temp, Panel pnl)
        {
            string tempString = "";
            foreach (var textBox in pnl.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    tempString += textBox.Name + " boş bırakılamaz!";
            }

            foreach (var comboBox in pnl.Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedIndex == -1)
                    tempString += comboBox.Name + " seçilmeli!";
            }

            foreach (var numericUpDown in pnl.Controls.OfType<NumericUpDown>())
            {
                if (numericUpDown.Value == 0)
                    tempString += numericUpDown.Name + " 0 olamaz!";
            }
            return tempString;
        }
    }
}
