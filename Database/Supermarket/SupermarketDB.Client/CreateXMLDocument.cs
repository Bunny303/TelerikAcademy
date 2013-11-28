using SupermarketDB.Data;
using SupermarketDB.Models;
using System;
using System.Xml.Linq;
using System.Linq;

namespace SupermarketDB.Client
{
    public static class CreateXMLDocument
    {
        public static void AddDataToXML(SupermarketContext db)
        {
            XElement saleXML = new XElement("sales");
            
            foreach (var vendor in db.Vendors)
	        {
                XElement sale = new XElement("sale");
                sale.SetAttributeValue("vendor", vendor.VendorName);
                saleXML.Add(sale);
                foreach (var product in vendor.Products)
                {
                    foreach (var report in product.Reports)
                    {
                        XElement summary = new XElement("summary");
                        summary.Add(new XAttribute("date", report.ReportDate));
                        summary.Add(new XAttribute("total-sum", report.Sum));
                        sale.Add(summary);
                    }
                }
                
	        }

            saleXML.Save("../../../Sales-by-Vendors-report.xml");
        }
    }
}
