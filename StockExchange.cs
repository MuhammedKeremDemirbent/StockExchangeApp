using StockExchangeApp.yahoo_api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchangeApp
{
    public partial class StockExchange : Form
    {
        public static readonly HttpClient client = new HttpClient(); //Web apileri için nesne oluşturduk. Nugetten çekiyoruz gerek yok şuanlık.
        public StockExchange()
        {
            InitializeComponent();
        }
        private async void StockExchange_Load(object sender, EventArgs e)
        {
            while (true)
            {
                lblAKSEN.Text = await pull_datas.GetQuoteAsync(txtbxVeri_isteme.Text);
                lblGARAN.Text = await pull_datas.GetQuoteAsync("GARAN.IS");
                await Task.Delay(5000);
            }
        }
    }
}
