using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ExcelReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void TestReadExcel()
        {
            /*from nuget package add 
            1. ExcelDataReader
               ExcelDataReader.DataSet
            2. Add reference -> search for 
                System.xml ->Checked
             */

            //FileStream stream = new FileStream(@"C:\Users\Nadeem\Desktop\test.xlsx",FileMode.Open,FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataTable table = reader.AsDataSet().Tables["Sheet1"];
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    var col = table.Rows[i];
            //    for (int j = 0; j < col.ItemArray.Length; j++)
            //    {
            //        Console.WriteLine("Data : {0},", col.ItemArray[j]);
            //    }
            //}
            //Console.WriteLine("Data : {0},{1}", table.Rows[1][0], table.Rows[1][1]);
            string xlPath = @"C:\Users\Nadeem\Desktop\test.xlsx";
            Console.Write(ExcelReader.GetCellData(xlPath, "Sheet1",0,0));
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "Sheet1",0,1 ));
            Console.Write(ExcelReader.GetCellData(xlPath, "Sheet1", 1, 0));
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "Sheet1", 1, 1));
        }

    }
}
