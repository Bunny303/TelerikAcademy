using System;
using System.Data.SqlClient;

namespace Nortwind_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            
            using (dbCon)
            {
                // 1. Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(CategoryID) FROM Categories", dbCon);
                int rowsCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Rows in Categories: {0}", rowsCount);
                Console.WriteLine();
                
                // 2. Write a program that retrieves the name and description of all categories in the Northwind DB.
                SqlCommand cmdShowAllCategories = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = cmdShowAllCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0}: {1}", categoryName, description);
                    }
                    Console.WriteLine();
                }

                // 3. Write a program that retrieves from the Northwind database all product categories and the 
                // names of the products in each category. Can you do this with a single SQL query (with table join)?
                
                SqlCommand cmdShowAllProducts = new SqlCommand(
                    @"SELECT c.CategoryName, p.ProductName
                    FROM Categories c 
                    JOIN Products p 
                    ON p.CategoryID=c.CategoryID
                    GROUP BY CategoryName, p.ProductName", dbCon);

                SqlDataReader readerProducts = cmdShowAllProducts.ExecuteReader();
                using (readerProducts)
                {
                    while (readerProducts.Read())
                    {
                        string categoryName = (string)readerProducts["CategoryName"];
                        string productName = (string)readerProducts["ProductName"];
                        Console.WriteLine("{0:10}: {1}", categoryName, productName);
                    }
                    Console.WriteLine();
                }

                // 4. Test method
                AddProduct("Test", null, null, null, null, null, null, null, true, dbCon);

            }
        }

        // 4. Write a method that adds a new product in the products table in the Northwind database. 
        // Use a parameterized SQL command.
        public static void AddProduct(string productName, int? supplierID, int? categoryID,  string quantityPerUnit, 
            decimal? unitPrice, short? unitsInStock, short? unitsOnOrder, short? reorderLevel, bool discontinued, SqlConnection dbCon)
        {
            SqlCommand cmdAddProduct = new SqlCommand(
                @"INSERT INTO Products 
                (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES 
                (@productName, @supplierID, @categoryID,  @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbCon);
            cmdAddProduct.Parameters.AddWithValue("@productName", productName);
            cmdAddProduct.Parameters.AddWithValue("@discontinued", discontinued);
            
            SqlParameter sqlParamSupplier = new SqlParameter("@supplierID", supplierID);
            if (supplierID == null)
            {
                sqlParamSupplier.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamSupplier);

            SqlParameter sqlParamCategory = new SqlParameter("@categoryID", categoryID);
            if (categoryID == null)
            {
                sqlParamCategory.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamCategory);

            SqlParameter sqlParamQuantity = new SqlParameter("@quantityPerUnit", quantityPerUnit);
            if (quantityPerUnit == null)
            {
                sqlParamQuantity.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamQuantity);

            SqlParameter sqlParamUnitPrice = new SqlParameter("@unitPrice", unitPrice);
            if (unitPrice == null)
            {
                sqlParamUnitPrice.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamUnitPrice);

            SqlParameter sqlParamUnitInStock= new SqlParameter("@unitsInStock", unitsInStock);
            if (unitsInStock == null)
            {
                sqlParamUnitInStock.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamUnitInStock);

            SqlParameter sqlParamUnitsOnOrder = new SqlParameter("@unitsOnOrder", unitsOnOrder);
            if (unitsOnOrder == null)
            {
                sqlParamUnitsOnOrder.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamUnitsOnOrder);

            SqlParameter sqlParamReorderLevel = new SqlParameter("@reorderLevel", reorderLevel);
            if (reorderLevel == null)
            {
                sqlParamReorderLevel.Value = DBNull.Value;
            }
            cmdAddProduct.Parameters.Add(sqlParamReorderLevel);
                                              
            cmdAddProduct.ExecuteNonQuery();
        }
    }
}
