using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using SertificateManager.BLL.DTO;

namespace ExcelGenerator
{
    public class ExcelGenerator
    {
        public static void DisplayInExcel(SertificateDTO sertificate)
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned  
            // by property Workbooks. The new workbook becomes the active workbook. 
            // Add has an optional parameter for specifying a praticular template.  
            // Because no argument is sent in this example, Add creates a new workbook. 
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            Excel.Workbook workBook = excelApp.Workbooks.Open(path+"/target.xls");

            // This example uses a single workSheet. The explicit type casting is 
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            // Establish column headings in cells A1 and B1.
            

            workSheet.Cells[13, "C"] = sertificate.MySertificateId;
            workSheet.Cells[15, "E"] = sertificate.Name;
            workSheet.Cells[15, "G"] = sertificate.SertificateTag;
            workSheet.Cells[20, "C"] = sertificate.Creator;
            workSheet.Cells[22, "C"] = sertificate.Owner;
            workSheet.Cells[26, "B"] = sertificate.QualityDocument;
            workSheet.Cells[34, "G"] = sertificate.Validator;
            workSheet.Cells[36, "G"] = sertificate.ValidateTime;


            


            
        }
    }
}
