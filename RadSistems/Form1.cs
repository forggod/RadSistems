using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSistems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            string tableName = "product";
            string[] tableFields =
            {
                "id",
                "Наименование",
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button_price_Click(object sender, EventArgs e)
        {
            string tableName = "factura_info";
            string[] tableFields =
            {
                "id",
                "Наименование",
                "Цена",
                "НДС",
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            string tableName = "client";
            string[] tableFields =
            {
                "id",
                "ФИО клиента",
                "Телефон"
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button_invoices_Click(object sender, EventArgs e)
        {
            string tableName = "factura";
            string[] tableFields =
            {
                "ID",
                "Товар",
                "Цена",
                "НДС",

                "ID",
                "ФИО клиента",
                "Дата покукпки",
                "Оплата",
                "Остаток",
                "Должник",
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
        }
    }
}
