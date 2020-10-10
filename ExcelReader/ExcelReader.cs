using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ExcelReader
{
    public class ExcelReader
    {
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static IExcelDataReader reader;
        
        //constructor
        static ExcelReader()
        {
            _cache = new Dictionary<string, IExcelDataReader>();
        }
        public static string GetCellData(string xlPath, string sheetName,  int row, int column)

        {
            if (_cache.ContainsKey(sheetName))
            {
                //It's checking that the sheet is already exist in cache/memeory or not
                reader = _cache[sheetName];
            }
            else
            {
                //it's allowing to open the file
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                // it's allowing to reader the file
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                //it's loading the sheet into dictionary/data structure
                _cache.Add(sheetName, reader);
            }
            // data table is collection of rows and columns
            DataTable table = reader.AsDataSet().Tables[sheetName];
            return table.Rows[row][column].ToString();
        }
    }
}
