//using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Excel= Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook wb;
        Excel.Worksheet ws;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wb = xlApp.Workbooks.Open("TestExcel.xls");
            wb.Save();

            /***
            string filePath = "TestExcel.xls";
            try
            {
                // Look for an existing open workbook
                var workbookOpen = Excel.Workbooks.Cast<Excel.Workbook>().FirstOrDefault(e => e.FullName == filePath);
                //var workbookOpen = Excel.Workbooks.FirstOrDefault(e => e.FullName == filePath);

                // Use the existing workbook.
                if (workbookOpen != null)
                {
                    wb = workbookOpen;
                }
                // If you can't find an existing workbook at
                // the specified path, then create a new one.
                else
                {
                    Workbook workbook = Excel.Workbooks.Open(filePath);
                    wb = workbook;
                    wb.Save();
                }
            }
            catch (Exception)
            {
                // Exception is thrown when there is no existing workbook with the given filepath
                wb = ExcelInterop.App.Workbooks.Add();
                wb.SaveAs(filePath);
            }
            ***/

            ws = wb.ActiveSheet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Range oneCell;
            int row = int.Parse(textBox1.Text);
            int col = int.Parse(textBox2.Text);
            string str = textBox3.Text;

            //oneCell = new Excel.Range();
            oneCell = ws.Cells[row][col];
            oneCell.Value = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Range oneCell;
            int row = int.Parse(textBox1.Text);
            int col = int.Parse(textBox2.Text);
            oneCell = ws.Cells[row][col];

            textBox3.Text = oneCell.Text;
        }
    }
}
