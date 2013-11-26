using System;
using System.Data.OleDb;
using SupermarketDB.Data;
using System.Data;
using System.IO;
using SupermarketDB.Models;
using System.Collections.Generic;

namespace SupermarketDB.Client
{
    public static class ExcelDataReader
    {
        public static void TransferDataFromExcelToDB(SupermarketContext DBconn, string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            var directories = dir.GetDirectories();

            foreach (var d in directories)
            {
                var date = DateTime.Parse(d.Name);
                var files = d.GetFiles();

                foreach (var f in files)
                {
                    string excelFile = f.FullName; 

                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                @"Data Source=" + excelFile + ";" +
                                                @"Extended Properties='Excel 12.0 Xml;HDR=YES'";

                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();
                    DataSet newDataSet = new DataSet();

                    using (conn)
                    {
                        OleDbCommand cmd = new OleDbCommand("SELECT * from [Sales$]", conn);
                        OleDbDataAdapter newDataAdapter = new OleDbDataAdapter(cmd);
                        newDataAdapter.Fill(newDataSet, "Sales");
                    }

                    DataTable table = newDataSet.Tables[0];

                    // Get supermarket name
                    DataRow row = table.Rows[0];
                    DataColumn col = table.Columns[0];
                    string line = row[col].ToString();
                    int spaceIndex = line.IndexOf(' ');
                    string supermarketName = line.Substring(spaceIndex + 1);

                    decimal sum = decimal.Parse(table.Rows[table.Rows.Count - 1][table.Columns.Count - 1].ToString());

                    List<decimal[]> allData = new List<decimal[]>();

                    for (int r = 2; r < table.Rows.Count - 1; r++)
                    {
                        DataRow dataRow = table.Rows[r];
                        var productData = new decimal[4];
                        decimal result = 0;
                        for (int c = 0; c < 4; c++)
                        {
                            DataColumn dataCol = table.Columns[c];

                            decimal.TryParse(dataRow[dataCol].ToString(), out result);
                            productData[c] = result;
                        }
                        if (result != 0)
                        {
                            allData.Add(productData);
                        }
                    }
                    
                    foreach (var report in allData)
                    {
                        var productId = (int)report[0];
                        var quantity = (int)report[1];
                        var unitPrice = report[2];
                        var reportSum = report[3];

                        var saleReport = new SaleReport
                        {
                            ProductID = productId,
                            Quantity = quantity,
                            UnitPrice = unitPrice,
                            Sum = reportSum,
                            SupermarketName = supermarketName,
                            ReportDate = date
                        };

                        DBconn.SalesReports.Add(saleReport);
                        DBconn.SaveChanges();
                        
                    }
                }
            }
           
            
        }

        
    }
}
