using CarWashApp.Entity.Concrete;
using CarWashApp.UI.Helper;

namespace CarWashApp.UI.Forms
{
    public partial class yikamaForm : Form
    {
        private int tempSure;
        private int TimerCount = 0;
        private int tempId;
        public yikamaForm()
        {
            InitializeComponent();
            sureComboBox.SelectedIndex = 0;
        }
        private void yikamaForm_Load(object sender, EventArgs e)
        {
            FormHelper.ComboOrListBoxMaker(plakaComboBox, FormHelper.GetBaseManager<Vehicle>().GetAll());
            FormHelper.ComboOrListBoxMaker(yikama_TipiComboBox, FormHelper.GetBaseManager<WashType>().GetAll());
            FormHelper.ComboOrListBoxMaker(kirlilikComboBox, FormHelper.GetBaseManager<DirtinessLevel>().GetAll());
            yikamaDataGrid.DataSource = FormHelper.WashService.RunCarWash();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            var isValid = FormHelper.IsValid(yikamaPanel);
            if (isValid != String.Empty)
            {
                MessageBox.Show(isValid);
                return;
            }

            FormHelper.WashService.AddWash(yikama_TipiComboBox.Text, plakaComboBox.Text,
                kirlilikComboBox.Text);
            yikamaDataGrid.DataSource = FormHelper.WashService.RunCarWash();
            FormHelper.ResetItems(yikamaPanel);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            FormHelper.guncelleSilBtn(false, yikamaPanel);

            FormHelper.ResetItems(yikamaPanel);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            FormHelper.WashService.UpdateWash(Convert.ToInt32(yikamaTextBox.Text), yikama_TipiComboBox.Text, plakaComboBox.Text,
                kirlilikComboBox.Text);
            yikamaDataGrid.DataSource = FormHelper.WashService.RunCarWash();
            FormHelper.ResetItems(yikamaPanel);
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {

            FormHelper.WashService.RemoveWashByID(Convert.ToInt32(yikamaTextBox.Text));
            FormHelper.guncelleSilBtn(false, yikamaPanel);
            yikamaDataGrid.DataSource = FormHelper.WashService.RunCarWash();

            FormHelper.ResetItems(yikamaPanel);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormHelper.ResetItems(yikamaPanel);
                DataGridViewRow selectedRow = yikamaDataGrid.Rows[e.RowIndex];
                selectedRow.Selected = true;
                tempId = int.Parse(yikamaDataGrid.SelectedRows[0].Cells[1].Value.ToString());
                yikamaTextBox.Text = tempId.ToString();
                FormHelper.guncelleSilBtn(true, yikamaPanel);


            }
        }

        private void sureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempSure = int.Parse(sureComboBox.Text);
            timer1.Interval = tempSure * 60 * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            yikamaDataGrid.DataSource = FormHelper.WashService.RunCarWash();
        }
    }
}
