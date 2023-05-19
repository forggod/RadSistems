using System;
using System.Data;
using System.Windows.Forms;

namespace RadSistems
{
    public partial class AEFacturaInfo : Form
    {
        private int _id;
        private string[] _attr;
        public AEFacturaInfo(int id, string[] attr)
        {
            _id = id;
            _attr = attr;
            InitializeComponent();
            addCombox();
            if (attr == null)
            {
                this.Text = "Добавление продукта";
            }
            if (attr != null)
            {
                this.Text = "Изменение продукта";
                button_action.Text = "Изменить";
                comboBox_product.SelectedItem = attr[0];
                numericUpDown_price.Value = Convert.ToInt32(attr[1].Split(',')[0]);
            }
            this.Show();
        }
        public void addCombox()
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            DataTable dataTable = dataBaseConnection.selectFromTable("product");
            foreach (DataRow row in dataTable.Rows)
            {
                comboBox_product.Items.Add(row.ItemArray[1]);
            }
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            string product = comboBox_product.SelectedItem.ToString();
            int price = Convert.ToInt32(numericUpDown_price.Value);
            int nds = Convert.ToInt32(price * 0.1);
            if (_attr == null)
            {
                if (dataBaseConnection.insertFacturaInfo(product, price, nds))
                    this.Close();
            }
            if (_attr != null)
            {
                if (dataBaseConnection.updateFacturaInfo(_id, product, price, nds))
                    this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
