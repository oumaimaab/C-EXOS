using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceReference1.ConverterSoapClient proxy = new ServiceReference1.ConverterSoapClient();
        ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;

        string[] currencies = proxy.GetCurrencies();
        foreach(string s in currencies)
        {
            DropDownList1.Items.Add(s);
        }
        
    }
}