using App.ServiceReferenceConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Convertisseur : Form
    {
        ConverterSoapClient client;
        public Convertisseur()
        {
            InitializeComponent();
        }

        private void Convertisseur_Load(object sender, EventArgs e)
        {
            client = new ConverterSoapClient("ConverterSoap12");
            string[] currencies = client.GetCurrencies();

            foreach(string currency in currencies)
            {
                currenciesFrom.Items.Add(currency);
                currenciesTo.Items.Add(currency);
            }
        }
    }
}
