using System;
using StudentSystem.Data;
using StudentSystem.Models;
using System.Data.Entity;
using StudentSystem.Data.Migrations;

namespace StudentSystem.Client
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
            
            var db = new StudentSystemContext();
            db.SaveChanges();

            
        }
    }
}
