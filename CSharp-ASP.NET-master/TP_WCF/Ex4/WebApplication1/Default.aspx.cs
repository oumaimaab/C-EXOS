using GestionEtudiant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WebApplication1.ServiceReference2;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        ExchangeRatesSoapClient client;
        protected void Page_Load(object sender, EventArgs e)
        {   
            client = new ExchangeRatesSoapClient("ExchangeRatesSoap1");

            XmlNode data = client.getListOfCurrencies();

            //result.Text = data.Attributes["Currencies"].ChildNodes.Count.ToString();


            foreach (XmlElement currency in data.SelectNodes("item"))
            {
                string name = currency.SelectSingleNode("currency").InnerText;
                string desc = currency.SelectSingleNode("description").InnerText;
                //ComboBoxItem item = new ComboBoxItem(name, desc);
                currencyFrom.Items.Add(name);
                currencyTo.Items.Add(name);
            }



        }
        protected void convert(object sender, EventArgs e)
        {


            decimal res = client.getExchangeRate(currencyFrom.SelectedValue.ToString(),"2019-12-01") ;
            result.Text = res.ToString();

        }
    }
}