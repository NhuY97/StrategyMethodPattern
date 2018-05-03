using DemoStrategy.ConcreteStrategy;
using DemoStrategy.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStrategy
{
	// Author: YZENNY 05/03/2018 21:03
    public partial class FormMain : Form
    {
        private ContextConverter contextConverter;

        private const string EUR_TITLE = "EURO/EUR";
        private const string JPY_TITLE = "YEN/JPY";
        private const string USD_TITLE = "DOLLA/USD";

        public FormMain()
        {
            InitializeComponent();
            contextConverter = new ContextConverter();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            contextConverter.StrategyConverter = new EURConverter();
            changeImage_EUR(true);
            lbCurrencyName.Text = EUR_TITLE;
            doConvert();
        }

        private void pbEUR_Click(object sender, EventArgs e)
        {
            contextConverter.StrategyConverter = new EURConverter();
            changeImage_EUR(true);
            lbCurrencyName.Text = EUR_TITLE;
            doConvert();
        }

        private void pbJPY_Click(object sender, EventArgs e)
        {
            contextConverter.StrategyConverter = new JPYConverter();
            changeImage_JPY(true);
            lbCurrencyName.Text = JPY_TITLE;
            doConvert();
        }

        private void pbUSD_Click(object sender, EventArgs e)
        {
            contextConverter.StrategyConverter = new USDConverter();
            changeImage_USD(true);
            lbCurrencyName.Text = USD_TITLE;
            doConvert();
        }

        private void doConvert()
        {
            decimal result = 0M;
            decimal inputDecimal;
            string input = txtInput.Text.Trim();
            if (!input.Equals(""))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(input, "[^0-9.]") || !Decimal.TryParse(input, out inputDecimal))
                {
                    MessageBox.Show(this,"Invalidate Input!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                    return;
                }
                result = contextConverter.doConvert(inputDecimal);
            }
            lbResult.Text = String.Format(new System.Globalization.CultureInfo("vi-VN", false), "{0:c}", result);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            doConvert();
        }

        private void changeImage_EUR(bool isActive)
        {
            pbEUR.Image = isActive ? Properties.Resources.icons8_euro_80 : Properties.Resources.eur;
            if (isActive)
            {
                changeImage_JPY(false);
                changeImage_USD(false);
            }
        }
        private void changeImage_JPY(bool isActive)
        {
            pbJPY.Image = isActive ? Properties.Resources.icons8_japanese_yen_80 : Properties.Resources.jpy_64;
            if (isActive)
            {
                changeImage_EUR(false);
                changeImage_USD(false);
            }
        }
        private void changeImage_USD(bool isActive)
        {
            pbUSD.Image = isActive ? Properties.Resources.icons8_us_dollar_80 : Properties.Resources.usd;
            if (isActive)
            {
                changeImage_JPY(false);
                changeImage_EUR(false);
            }
        }

    }
}
