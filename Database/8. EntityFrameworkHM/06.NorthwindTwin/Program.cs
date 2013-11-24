using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Library;
using System.IO;

namespace _06.NorthwindTwin
{
    class Program
    {
        // 6. Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext. 
        //Find for the API for schema generation in MSDN or in Google.

        static void Main()
        {
            //NorthwindEntities db = new NorthwindEntities();
            //CreatingNewDataBase(db);
        }

        //private static void CreatingNewDataBase(NorthwindEntities db)
        //{
        //    string script = db.CreateDatabaseScript();
        //    script = "CREATE DATABASE [NorthwindTwin] \n GO \nUSE [NorthwindTwin] \n" + script;

        //    StreamWriter northwindTwinFile = new StreamWriter("NorthwindTwin.sql");
        //    using (northwindTwinFile)
        //    {
        //        northwindTwinFile.WriteLine(script);
        //    }
        //    Console.WriteLine(script);
        //}
    }
}
