using Npgsql;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RadSistems
{
    public partial class DataForm : Form
    {
        private string _table;
        private string[] _namesTables;

        public DataForm(string table, string[] namesTables)
        {
            _table = table;
            _namesTables = namesTables;
            InitializeComponent();
            this.Show();
            dataGridView_first.Dock = DockStyle.Fill;
            string formName = "Товары";
            if (table == "factura_info")
                formName = "Цены";
            if (table == "client")
                formName = "Клиент";
            if (table == "factura")
            {
                formName = "Накладные";
                dataGridView_first.Dock = DockStyle.Top;
                panel1.Visible = true;
                facturaInfoToolStripMenuItem.Visible = true;
                facturaInfoToolStripMenuItem1.Visible = true;
                facturaInfoToolStripMenuItem2.Visible = true;
                facturaToolStripMenuItem.Visible = true;
                facturaToolStripMenuItem1.Visible = true;
                facturaToolStripMenuItem2.Visible = true;

                ToolStripMenuItem_Add.Click -= ToolStripMenuItem_Add_Click;
                ToolStripMenuItem_Edit.Click -= ToolStripMenuItem_Edit_Click;
            }
            this.Text = formName;
            initConnection();
        }

        private void initConnection()
        {
            updateFirstTable();
        }

        private void updateFirstTable()
        {
            int sId = 0;
            if (dataGridView_first.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_first.SelectedRows[0];
                sId = Convert.ToInt32(row.Cells[0].Value);
            }
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            if (_table == "factura")
            {
                dataGridView_first.DataSource = dataBaseConnection.selectFromTable("factura_info");
                int n = 4;
                for (int i = 0; i < n; i++)
                    dataGridView_first.Columns[i].HeaderText = _namesTables[i];
            }
            else
            {
                dataGridView_first.DataSource = dataBaseConnection.selectFromTable(_table);
                for (int i = 0; i < _namesTables.Length; i++)
                    dataGridView_first.Columns[i].HeaderText = _namesTables[i];
            }
            dataGridView_first.ClearSelection();
            foreach (DataGridViewRow row in dataGridView_first.Rows)
            {
                if (row.Cells[0].Value.Equals(sId))
                {
                    row.Selected = true;
                }
            }
        }

        private void updateSecondTable()
        {
            int fId = 0;
            if (dataGridView_first.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_first.SelectedRows[0];
                fId = Convert.ToInt32(row.Cells[0].Value);
            }

            int sId = 0;
            if (dataGridView_second.SelectedRows.Count > 0)
            {
                DataGridViewRow row1 = dataGridView_second.SelectedRows[0];
                sId = Convert.ToInt32(row1.Cells[0].Value);
            }
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            dataGridView_second.DataSource = dataBaseConnection.selectFromFactura(fId);
            int n = 4;
            for (int i = 0; i < _namesTables.Length - n; i++)
                dataGridView_second.Columns[i].HeaderText = _namesTables[i + n];

            dataGridView_second.ClearSelection();
            if (sId == 0)
                return;
            foreach (DataGridViewRow row2 in dataGridView_second.Rows)
            {
                if (row2.Cells[0].Value == sId.ToString())
                {
                    row2.Selected = true;
                }
            }
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            //updateFirstTable();
        }

        private void dataGridView_first_SelectionChanged(object sender, EventArgs e)
        {
            if (_table == "factura")
                updateSecondTable();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sId = 0;
            if (dataGridView_first.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите накладную");
                return;
            }
            DataGridViewRow row = dataGridView_first.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            AEFacturaForm aEFacturaForm = new AEFacturaForm(sId, null);
        }

        private void facturaInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AEFacturaInfo aEFacturaInfo = new AEFacturaInfo(0, null);
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView_second.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_second.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            string[] attr =
            {
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[5].Value.ToString(),
            };
            AEFacturaForm aEFacturaForm = new AEFacturaForm(sId, attr);
        }

        private void facturaInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView_first.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_first.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            string[] attr =
            {
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
            };
            AEFacturaInfo aEFacturaInfo = new AEFacturaInfo(sId, attr);
        }

        private void facturaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView_second.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_second.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            DataBaseConnection conn = new DataBaseConnection();
            conn.delete(_table, sId);
        }

        private void facturaInfoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView_first.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_first.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            DataBaseConnection conn = new DataBaseConnection();
            conn.delete("factura_info", sId);
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            if (_table == "product")
            {
                AEProductForm aEProductForm = new AEProductForm(0, null);
            }
            if (_table == "client")
            {
                AEClientForm aEClientForm = new AEClientForm(0, null);
            }
            if (_table == "factura_info")
            {
                AEFacturaInfo aEFacturaInfo = new AEFacturaInfo(0, null);
            }
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_first.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_first.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);

            if (_table == "product")
            {
                string[] attr = {
                    row.Cells[1].Value.ToString(),
                };
                AEProductForm aEProductForm = new AEProductForm(sId, attr);
            }
            if (_table == "client")
            {
                string[] attr = {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    };
                AEClientForm aEClientForm = new AEClientForm(sId, attr);
            }
            if (_table == "factura_info")
            {
                string[] attr = {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    };
                AEFacturaInfo aEFacturaInfo = new AEFacturaInfo(sId, attr);
            }
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_first.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;
            }
            int sId = 0;
            DataGridViewRow row = dataGridView_first.SelectedRows[0];
            sId = Convert.ToInt32(row.Cells[0].Value);
            DataBaseConnection conn = new DataBaseConnection();
            conn.delete(_table, sId);
        }
    }
}
