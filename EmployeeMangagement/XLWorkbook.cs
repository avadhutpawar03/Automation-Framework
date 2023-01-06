using ClosedXML.Excel;

namespace EmployeeMangagement
{
    internal class XLWorkbook
    {
        private string v;

        public XLWorkbook(string v)
        {
            this.v = v;
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal IXLWorksheet Worksheet(string v)
        {
            throw new NotImplementedException();
        }
    }
}