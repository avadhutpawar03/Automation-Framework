using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

 
namespace EmployeeManagement
{
   
    public class Demo3Excel
    {

        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Users\avadhutp\Desktop\C#\AutomationFramework\EmployeeMangagement\Base\TestData\Orange.xlsx");

            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();


            object[] allData = new object[3];

            for (int r = 2; r <= 4; r++)
            {
               
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }

              

            }

            book.Dispose();

           
        }
    }
}