using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetRates_Click(object sender, EventArgs e)
        {
            if(currencyCombo.SelectedItem.ToString()=="EUR")
            {
                resultLable.Visible = true;
                resultTextBox.Visible = true;
                BitCoinRates bitcoin = GetRates();
                float result = Int32.Parse(amountOfCoinBox.Text) * bitcoin.bpi.EUR.rate_float;
                resultTextBox.Text = $"{result.ToString()}{bitcoin.bpi.EUR.code}";

            }
            if (currencyCombo.SelectedItem.ToString() == "USD")
            {
                resultLable.Visible = true;
                resultTextBox.Visible = true;
                BitCoinRates bitcoin = GetRates();
                float result = Int32.Parse(amountOfCoinBox.Text) * bitcoin.bpi.USD.rate_float;
                resultTextBox.Text = $"{result.ToString()}{bitcoin.bpi.USD.code}";
            }
            if (currencyCombo.SelectedItem.ToString() == "GBP")
            {
                resultLable.Visible = true;
                resultTextBox.Visible = true;
                BitCoinRates bitcoin = GetRates();
                float result = Int32.Parse(amountOfCoinBox.Text) * bitcoin.bpi.GBP.rate_float;
                resultTextBox.Text = $"{result.ToString()}{bitcoin.bpi.GBP.code}";
            }

        }

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitCoinRates bitcoin;

            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }
            return bitcoin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void currencyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
