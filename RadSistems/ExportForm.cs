using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RadSistems
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
            this.Show();
            DataBaseConnection conn = new DataBaseConnection();
            dataGridView_client.DataSource = conn.selectReportClient();
        }

        private void button_action_Click(object sender, System.EventArgs e)
        {
            DateTime dateTime = dateTimePicker_start.Value;
            string startDate = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";

            dateTime = dateTimePicker_end.Value;
            string endDate = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";

            if (dataGridView_client.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Выберите клиентов");
                return;
            }

            string selNames = $"{dataGridView_client.SelectedRows[0].Cells[1].Value}";
            for (int i = 1; i < dataGridView_client.SelectedRows.Count; i++)
            {
                selNames += $"&{dataGridView_client.SelectedRows[i].Cells[1].Value}";
            }
            string[] names = selNames.Split('&');

            DataBaseConnection conn = new DataBaseConnection();
            DataTable dataTable = conn.selectReport(names, startDate, endDate);

            string[] columns = {
                "Номер отчёта",
                "Клиент",
                "Товар",
                "Цена",
                "Остаток",
                "Оплачено",
            };
            if (dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Записей не найдено");
                return;
            }
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < columns.Length + 1; i++)
            {
                application.Cells[1, i] = columns[i - 1];
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataTable.Rows[i].ItemArray[j].ToString();
                }
            }
            application.Columns.AutoFit();
            application.Visible = true;
        }
    }
}
