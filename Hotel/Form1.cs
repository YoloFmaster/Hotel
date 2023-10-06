namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFinalRate.Text = "0";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        { 

        }

        private void rdEconom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSingleRoom.Checked) txtRate.Text = "1500";
            if (rdDoubleRoom.Checked) txtRate.Text = "2000";
            if (rdTripleRoom.Checked) txtRate.Text = "2500";
        }

        private void rdStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSingleRoom.Checked) txtRate.Text = "5000";
            if (rdDoubleRoom.Checked) txtRate.Text = "7000";
            if (rdTripleRoom.Checked) txtRate.Text = "9000";
        }

        private void rdLux_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSingleRoom.Checked) txtRate.Text = "12000";
            if (rdDoubleRoom.Checked) txtRate.Text = "16000";
            if (rdTripleRoom.Checked) txtRate.Text = "20000";
        }
        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtRate.Text) * Convert.ToInt32(txtPeriodOfStay.Text));
            if (ckPool.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 1500);
            if (ckWiFi.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 500);
            if (ckSPA.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 2000);
            if (ckElectricRefueling.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 5000);
            if (ckBreakfast.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 1000);
            if (ckLunch.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 1500);
            if (ckDinner.Checked) txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + 1250);
        }
    }
}