using System;
using Ionic.Zip;

namespace SupermarketDB.Client
{
    // Using DotNetZip
    public static class ZipDataReader
    {
        public static void ExtractData(string fileName, string targetDirectory)
        {
            using (ZipFile zip = ZipFile.Read(fileName))
            {
                zip.ExtractAll(targetDirectory, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
