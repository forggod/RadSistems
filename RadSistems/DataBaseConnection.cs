using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace RadSistems
{
    class DataBaseConnection
    {
        private string _connectionString = "Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=Shop";
        private NpgsqlConnection _connection;
        public DataBaseConnection()
        {
            _connection = new NpgsqlConnection(_connectionString);
        }
        public DataTable selectFromTable(string table)
        {
            _connection.Open();
            string sql = $"SELECT * FROM {table}";
            if (table == "factura" || table == "factura_info")
            {
                sql = @"SELECT fi.id, p.name, price, nds FROM factura_info fi JOIN 
                            product p ON fi.product = p.id;";
            }
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            _connection.Close();
            return dataSet.Tables[0];
        }
        public DataTable selectFromFactura(int id)
        {
            _connection.Open();
            string sql = $"select f.id, c.name, f.date, f.paid, f.remains, f.debtor from factura f " +
                $"join client c on f.client = c.id " +
                $"WHERE f.f_info = '{id}'; ";
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            _connection.Close();
            return dataSet.Tables[0];
        }
        public bool insertClient(string name, string phone)
        {
            _connection.Open();
            string sql = $"INSERT INTO client (name, phone) VALUES ('{name}', '{phone}');";
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                npgsqlCommand.ExecuteNonQuery();
            _connection.Close();
            return true;
        }
        public bool updateClient(int id, string name, string phone)
        {
            try
            {
                _connection.Open();
                string sql = $"UPDATE client SET name = '{name}', phone = '{phone}' WHERE id = '{id}'";
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                    npgsqlCommand.ExecuteNonQuery();
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertProduct(string name)
        {
            _connection.Open();
            string sql = $"INSERT INTO product (name) VALUES ('{name}');";
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                npgsqlCommand.ExecuteNonQuery();
            _connection.Close();
            return true;
        }
        public bool updateProduct(int id, string name)
        {
            try
            {
                _connection.Open();
                string sql = $"UPDATE product SET name = '{name}' WHERE id = '{id}';";
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                    npgsqlCommand.ExecuteNonQuery();
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertFacturaInfo(string product, int price, int nds)
        {
            _connection.Open();
            string sql = $"SELECT id FROM product WHERE name = '{product}';";
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Продукт не найден!");
                _connection.Close();
                return false;
            }
            int productID = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
            sql = $"INSERT INTO factura_info (product, price, nds) VALUES ('{productID}', '{price}', '{nds}');";
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                npgsqlCommand.ExecuteNonQuery();
            _connection.Close();
            return true;
        }
        public bool updateFacturaInfo(int id, string product, int price, int nds)
        {
            try
            {
                _connection.Open();
                string sql = $"SELECT id FROM product WHERE name = '{product}';";
                DataSet dataSet = new DataSet();
                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
                {
                    dataSet.Reset();
                    dataAdapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    return false;
                }
                int productID = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
                sql = $"UPDATE factura_info SET product = '{productID}', price = '{price}', nds = '{nds}' WHERE id = '{id}'";
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                    npgsqlCommand.ExecuteNonQuery();
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertFactura(string client, int factura_info, string date, int paid)
        {
            _connection.Open();
            string sql = $"SELECT id FROM client WHERE name = '{client}';";
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Клиент не найден!");
                _connection.Close();
                return false;
            }
            int clientID = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
            sql = $"INSERT INTO factura (client, f_info, date, paid) VALUES ('{clientID}', '{factura_info}', '{date}', '{paid}');";
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                npgsqlCommand.ExecuteNonQuery();
            _connection.Close();
            return true;
        }
        public bool updateFactura(int id, string client, string date, int paid)
        {
            try
            {
                _connection.Open();
                string sql = $"SELECT id FROM client WHERE name = '{client}';";
                DataSet dataSet = new DataSet();
                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
                {
                    dataSet.Reset();
                    dataAdapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Клиент не найден!");
                    _connection.Close();
                    return false;
                }
                int clientID = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
                sql = $"UPDATE factura SET client = '{clientID}', date = '{date}', paid = '{paid}' WHERE id = '{id}';";
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                    npgsqlCommand.ExecuteNonQuery();
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool delete(string table, int id)
        {
            try
            {
                _connection.Open();
                string sql = $"DELETE FROM {table} WHERE id = '{id}';";
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                    npgsqlCommand.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public DataTable selectReport(string[] names, string startDate, string endDate)
        {
            string selNames = $"c1.name = '{names[0]}'";
            for (int i = 1; i < names.Length; i++)
                selNames += $" OR c1.name = '{names[i]}'";
            string sql = $"SELECT fac.id, fac.name, p.name, p.price, fac.remains, fac.paid FROM " +
                $"              (SELECT f.id, f.f_info, f.remains, f.paid, c.name FROM factura f JOIN " +
                $"              (SELECT * FROM client c1 WHERE {selNames}) c " +
                $"              ON c.id = f.client WHERE debtor = true AND f.date >= '{startDate}' AND f.date <= '{endDate}') " +
                $"              fac JOIN (SELECT fi.id, pr.name, fi.price FROM factura_info fi " +
                $"              JOIN product pr ON fi.product = pr.id) p ON p.id = fac.f_info;";

            _connection.Open();
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            _connection.Close();
            return dataSet.Tables[0];
        }
        public DataTable selectReportClient()
        {
            string sql = $"SELECT id, name FROM client;";
            _connection.Open();
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                dataSet.Reset();
                dataAdapter.Fill(dataSet);
            }
            _connection.Close();
            return dataSet.Tables[0];
        }
    }
}
