using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace KMC_Pallet_Info
{
    public class Excel1
    {

        public static void CreateExcel(string fileName, DataTable dt)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
               // MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range formatRange;
            formatRange = xlWorkSheet.get_Range("a1", $"e{dt.Rows.Count +1}");
            formatRange.NumberFormat = "@";
          //  xlWorkSheet.Cells[1, 1] = "098";
          


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (i == 0) 
                    {
                        xlWorkSheet.Cells[i+1, j + 1] = dt.Columns[j].ColumnName;
                        xlWorkSheet.Cells[i+2, j + 1] = dt.Rows[i][j];
                    }
                    else
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                    }
               
                }
          

            }
    



            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        public static void CreateExcel(string fileName, DataTable dt, List<string> palletIDs)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                // MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
           
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            

            for (int c = 0; c < palletIDs.Count; c++)
            {

                Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets.Add();
                xlWorkSheet.Name = palletIDs[c];
               // xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(c+1);

                Excel.Range formatRange;
                formatRange = xlWorkSheet.get_Range("a1", $"h{dt.Rows.Count + 1}");
                formatRange.NumberFormat = "@";
                //  xlWorkSheet.Cells[1, 1] = "098";



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (i == 0)
                        {
                            xlWorkSheet.Cells[i + 1, j + 1] = dt.Columns[j].ColumnName;
                          //  xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        }
                        //else
                        //{
                        //    xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        //}

                        if(dt.Rows[i]["PalletID"].ToString() == palletIDs[c])
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        }
                      
                    }


                }
                Marshal.ReleaseComObject(xlWorkSheet);
                //  xlWorkBook.Worksheets.Add(xlWorkSheet);
            }






            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

         
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
        public static void WriteExcelFile(string fileName, DataTable table)
        {



            //  DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(persons), (typeof(DataTable)));

            using (SpreadsheetDocument document = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                var sheetData = new SheetData();
                worksheetPart.Worksheet = new Worksheet(sheetData);

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                
                sheets.Append(sheet);

                Row headerRow = new Row();
                

                List<String> columns = new List<string>();
                foreach (System.Data.DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);

                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    
                    cell.CellValue = new CellValue(column.ColumnName);                  
                    headerRow.AppendChild(cell);
                }

                sheetData.AppendChild(headerRow);

                foreach (DataRow dsrow in table.Rows)
                {
                    Row newRow = new Row();
                    foreach (String col in columns)
                    {
                        Cell cell = new Cell();

                        if (col == "Weight")
                        {
                            cell.DataType = CellValues.Number;                            
                        }
                        else
                        {
                            cell.DataType = CellValues.String;
                        }
                       
                        cell.CellValue = new CellValue(dsrow[col].ToString());
                        newRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(newRow);
                }

                workbookPart.Workbook.Save();
            }
        }

        public static void WriteExcelFile(string fileName, DataTable table, List<string> pallets)
        {

            using (SpreadsheetDocument document = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
               

                for (int i = 0; i < pallets.Count; i++)                
                {
                    UInt32Value c = 0;
                    c++;
                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());

                    var sheetData = new SheetData();
                    worksheetPart.Worksheet = new Worksheet(sheetData);

                  
                    Sheet sheet = new Sheet() {  Name = pallets[i] };

                    sheets.Append(sheet);

                    Row headerRow = new Row();


                    List<String> columns = new List<string>();
                    foreach (System.Data.DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);

                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;

                        cell.CellValue = new CellValue(column.ColumnName);
                        headerRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(headerRow);

                    foreach (DataRow dsrow in table.Rows)
                    {
                        if(dsrow["PalletID"].ToString() == pallets[i])
                        {
                            Row newRow = new Row();
                            foreach (String col in columns)
                            {
                                Cell cell = new Cell();

                                if (col == "Weight")
                                {
                                    cell.DataType = CellValues.Number;
                                }
                                else
                                {
                                    cell.DataType = CellValues.String;
                                }

                                cell.CellValue = new CellValue(dsrow[col].ToString());
                                newRow.AppendChild(cell);
                            }

                            sheetData.AppendChild(newRow);
                        }
                   
                    }
                    workbookPart.Workbook.Save();
                }



              //  workbookPart.Workbook.Save();
            }
        }
    }
}
