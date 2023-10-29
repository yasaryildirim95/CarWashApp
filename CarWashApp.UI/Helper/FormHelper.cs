namespace CarWashApp.UI.Helper
{
    internal static class FormHelper
    {
        public static Button currentButton;
        public static bool xxkraltr;
        public static void HidePanels(Control control)
        {
            foreach (Control tempControl in control.Controls)
            {
                if (tempControl is Panel pnl && pnl.Name != "menuPanel")
                    pnl.Hide();
            }
        }
        public static void ResetItems(Panel temp)
        {
            foreach (Control tempControl in temp.Controls)
            {
                if (tempControl is ComboBox tempComboBox)
                    tempComboBox.SelectedIndex = -1;
                if (tempControl is TextBox tempTextBox)
                    tempTextBox.Text = string.Empty;
                if (tempControl is ListBox tempListBox)
                    tempListBox.SelectedIndex = -1;
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
            foreach (Control panelMenuControl in pnl.Controls)
            {
                if (panelMenuControl.GetType() == typeof(Button))
                {
                    panelMenuControl.BackColor = Color.FromArgb(51, 51, 76);
                    panelMenuControl.ForeColor = Color.LightGray;
                    panelMenuControl.Enabled = true;
                }
            }
        }
    }
}
