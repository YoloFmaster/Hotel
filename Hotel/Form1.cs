namespace Hotel
{
    public partial class Form1 : Form
    {
        int[,] price =
        {
           { 1500, 2000, 2500 },
           { 5000, 7000, 9000 },
           { 12000, 16000, 20000 },
        };
        int[] priceService = { 1500, 500, 2000, 5000, 1000, 1500, 1250 };
        public Form1()
        {
            InitializeComponent();
            txtFinalRate.Text = "0";
        }

        private void rdEconom_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0; int j = 0;
            if (rdSingleRoom.Checked) j = 0;
            if (rdDoubleRoom.Checked) j = 1;
            if (rdTripleRoom.Checked) j = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }

        private void rdStandart_CheckedChanged(object sender, EventArgs e)
        {
            int i = 1; int j = 0;
            if (rdSingleRoom.Checked) j = 0;
            if (rdDoubleRoom.Checked) j = 1;
            if (rdTripleRoom.Checked) j = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }

        private void rdLux_CheckedChanged(object sender, EventArgs e)
        {
            int i = 2; int j = 0;
            if (rdSingleRoom.Checked) j = 0;
            if (rdDoubleRoom.Checked) j = 1;
            if (rdTripleRoom.Checked) j = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }
        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            int i = 0;
            txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtRate.Text) * Convert.ToInt32(txtPeriodOfStay.Text));
            if (ckPool.Checked) {
                i = 0;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]);
            };
            if (ckWiFi.Checked) {
                i = 1;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]);
            };
            if (ckSPA.Checked) {
                i = 2;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]);
            };
            if (ckElectricRefueling.Checked) {
                i = 3;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]); 
            };
            if (ckBreakfast.Checked) {
                i = 4;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]);
            };
            if (ckLunch.Checked) {
                i = 5;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]); 
            };
            if (ckDinner.Checked) {
                i = 6;
                txtFinalRate.Text = Convert.ToString(Convert.ToInt32(txtFinalRate.Text) + priceService[i]);
            };
        }

        private void rdSingleRoom_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0; int j = 0;
            if (rdEconom.Checked) i = 0;
            if (rdStandart.Checked) i = 1;
            if (rdLux.Checked) i = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }

        private void rdDoubleRoom_CheckedChanged(object sender, EventArgs e)
        {
            int j = 1; int i = 0;
            if (rdEconom.Checked) i = 0;
            if (rdStandart.Checked) i = 1;
            if (rdLux.Checked) i = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }

        private void rdTripleRoom_CheckedChanged(object sender, EventArgs e)
        {
            int j = 2; int i = 0;
            if (rdEconom.Checked) i = 0;
            if (rdStandart.Checked) i = 1;
            if (rdLux.Checked) i = 2;
            txtRate.Text = Convert.ToString(price[i, j]);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRate.Text = "";
            txtPeriodOfStay.Text = "";
            txtFinalRate.Text = "";
            ckPool.Checked = false;
            ckWiFi.Checked = false;
            ckSPA.Checked = false;
            ckElectricRefueling.Checked = false;
            ckBreakfast.Checked = false;
            ckLunch.Checked = false;
            ckDinner.Checked = false;
            rdEconom.Checked = false;
            rdStandart.Checked = false;
            rdLux.Checked = false;
            rdSingleRoom.Checked = false;
            rdDoubleRoom.Checked = false;
            rdTripleRoom.Checked = false;
        }
    }
}