using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using SupermarketDB.Data;
using SupermarketDB.Models;
using System.Linq;
using System.Data.SqlClient;

namespace SupermarketDB.Client
{
    public static class CreatePdf
    {
        public static void AddDataToPdf(SupermarketContext db)
        {
            Document doc = new Document();
            PdfAWriter.GetInstance(doc, new FileStream(@"../../.." + "/Aggregated-Sales-Report.pdf", FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(5);
            Font fontBold = new Font(Font.FontFamily.HELVETICA, 14f);
            fontBold.SetStyle("bold");
            Font fontNormal = new Font(Font.FontFamily.HELVETICA, 12f);

            PdfPCell header = new PdfPCell(new Phrase("Aggregated Sales Report", fontBold));
            header.Colspan = 5;
            header.HorizontalAlignment = 1;
            table.AddCell(header);

            using (db)
            {
                var dates =
                    (from d in db.SalesReports
                     select d.ReportDate).Distinct();

                decimal grandTotal = 0;

                foreach (var date in dates)
                {
                    PdfPCell cellDate = new PdfPCell(new Phrase("Date : " + date.ToShortDateString()));
                    cellDate.Colspan = 5;
                    table.AddCell(cellDate);

                    PdfPCell cellProduct = new PdfPCell(new Phrase("Products", fontBold));
                    table.AddCell(cellProduct);
                    
                    PdfPCell cellQuantity = new PdfPCell(new Phrase("Quantity", fontBold));
                    table.AddCell(cellQuantity);
                    
                    PdfPCell cellUnitPrice = new PdfPCell(new Phrase("Unit Price", fontBold));
                    table.AddCell(cellUnitPrice);
                    
                    PdfPCell cellLocation = new PdfPCell(new Phrase("Location", fontBold));
                    table.AddCell(cellLocation);
                    
                    PdfPCell cellSum = new PdfPCell(new Phrase("Sum", fontBold));
                    table.AddCell(cellSum);

                    var sales =
                        (from s in db.SalesReports
                         where s.ReportDate == date
                         select s);

                    decimal totalSum = 0;

                    foreach (var sale in sales)
                    {
                        if (sale.Product.ProductName != null)
                        {
                            table.AddCell(sale.Product.ProductName);
                            table.AddCell(sale.Quantity.ToString() + " " + db.Measures
                                                                                .Where(x => x.MeasureID == sale.Product.MeasureID)
                                                                                .Select(x => x.MeasureName).First().ToString());
                            table.AddCell(sale.UnitPrice.ToString());
                            table.AddCell(sale.SupermarketName);
                            table.AddCell(sale.Sum.ToString());

                            totalSum += sale.Sum;
                        }
                    }

                    string text = string.Format("Total sum for {0} :", date.ToShortDateString());
                    PdfPCell cellTotal = new PdfPCell(new Phrase(text, fontNormal));
                    cellTotal.Colspan = 4;
                    cellTotal.HorizontalAlignment = 2;
                    table.AddCell(cellTotal);
                    table.AddCell(totalSum.ToString());

                    grandTotal += totalSum;
                }

                string grand = string.Format("Grand Total: ");
                PdfPCell cellGrand = new PdfPCell(new Phrase(grand));
                cellGrand.Colspan = 4;
                cellGrand.HorizontalAlignment = 2;
                table.AddCell(cellGrand);
                table.AddCell(grandTotal.ToString());

                doc.Add(table);
            }

            doc.Close();
        }
    }
}
