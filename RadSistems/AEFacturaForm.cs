using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace RadSistems
{
    public partial class AEFacturaForm : Form
    {
        private int _id;
        private string[] _attr;
        public AEFacturaForm(int id, string[] attributes)
        {
            _id = id;
            _attr = attributes;
            InitializeComponent();
            addComboBoxClient();
            if (attributes == null)
            {
                this.Text = "Добавление";
            }
            if (attributes != null)
            {
                this.Text = "Изменение";
                comboBox1.SelectedItem = attributes[0];
                string[] dateSt = _attr[1].Split('.');
                dateSt[2] = dateSt[2].Split(' ')[0];
                dateTimePicker_date.Value = new
                    DateTime(Convert.ToInt32(dateSt[2]), Convert.ToInt32(dateSt[1]), Convert.ToInt32(dateSt[0]));
                numericUpDown1.Value = Convert.ToInt32(_attr[2].Substring(0, _attr[2].Length - 3));
                if (attributes[3] == "True")
                {
                    numericUpDown1.Increment = 0;
                    numericUpDown1.ReadOnly = true;
                }
            }
            this.Show();
        }
        private void addComboBoxClient()
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            DataTable dataTable = dataBaseConnection.selectFromTable("client");
            foreach (DataRow row in dataTable.Rows)
            {
                comboBox1.Items.Add(row.ItemArray[1].ToString());
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            int id_facturaInfo = 0;

            if (_attr == null)
                id_facturaInfo = _id;

            DateTime dateTime = dateTimePicker_date.Value;
            string date = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";
            int paid = Convert.ToInt32(numericUpDown1.Value);
            if (_attr == null)
            {
                DataBaseConnection dataBaseConnection = new DataBaseConnection();
                dataBaseConnection.insertFactura(name, id_facturaInfo, date, paid);
            }
            if (_attr != null)
            {
                DataBaseConnection dataBaseConnection = new DataBaseConnection();
                dataBaseConnection.updateFactura(_id, name, date, paid);
            }
            this.Close();
        }
    }
}