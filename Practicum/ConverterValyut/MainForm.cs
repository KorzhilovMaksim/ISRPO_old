using System;
using System.Windows.Forms;

namespace ConverterValyut
{
    public partial class MainForm : Form
    {
        private const decimal
            USD = 79.45M,
            EUR = 93.23M,
            CNY = 11.22M,
            KRW = 0.053956M;

        private void cbxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPreviewTo.Text = getPreviewByName(cbxTo.Text);
            if (cbxTo.Text == cbxFrom.Text)
            {
                cbxFrom.SelectedIndex = -1;
            }
            txtSumm_TextChanged(this, EventArgs.Empty);
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int buffer = cbxFrom.SelectedIndex;
            cbxFrom.SelectedIndex = cbxTo.SelectedIndex;
            cbxTo.SelectedIndex = buffer;
            txtSumm_TextChanged(this, EventArgs.Empty);
        }

        private void txtSumm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal result = Convert.ToDecimal(txtSumm.Text);
                switch (cbxFrom.SelectedIndex)
                {
                    case 1:
                        result *= USD;
                        break;
                    case 2:
                        result *= EUR;
                        break;
                    case 3:
                        result *= CNY;
                        break;
                    case 4:
                        result *= KRW;
                        break;
                }
                switch (cbxTo.SelectedIndex)
                {
                    case 1:
                        result /= USD;
                        break;
                    case 2:
                        result /= EUR;
                        break;
                    case 3:
                        result /= CNY;
                        break;
                    case 4:
                        result /= KRW;
                        break;
                }
                txtResult.Text = Math.Round(result, 6).ToString();
            }
            catch 
            {
                txtResult.Text = "";
            }
        }

        private void cbxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPreviewFrom.Text = getPreviewByName(cbxFrom.Text);
            if (cbxFrom.Text == cbxTo.Text)
            {
                cbxTo.SelectedIndex = -1;
            }
            txtSumm_TextChanged(this, EventArgs.Empty);
        }



        private string getPreviewByName(string name)
        {
            switch (name)
            {
                case "Российский рубль":
                    return "₽";
                case "Доллар США":
                    return "$";
                case "Евро":
                    return "€";
                case "Китайский юань":
                    return "¥";
                case "Южнокорейская вона":
                    return "₩";
                default:
                    return "?";
            }
        }

        public MainForm()
        {
            InitializeComponent();
            lblEurToRub.Text = $"1 EUR = {EUR} RUB";
            lblUsdToRub.Text = $"1 USD = {USD} RUB";
            lblKrwToRub.Text = $"1 KRW = {KRW} RUB";
            lblCnyToRub.Text = $"1 CNY = {CNY} RUB";
            cbxFrom.SelectedIndex = 0;
            cbxTo.SelectedIndex = 1;
        }
    }
}
