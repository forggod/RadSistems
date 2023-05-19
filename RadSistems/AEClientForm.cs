using System.Windows.Forms;

namespace RadSistems
{
    public partial class AEClientForm : Form
    {
        private int _id;
        public AEClientForm(int id, string[] attributes)
        {
            _id = id;
            InitializeComponent();
            this.Show();
            if (id != 0)
            {
                this.Text = "Изменение клиента";
                button_action.Text = "Изменить";
                textBox_name.Text = attributes[0];
                textBox_phone.Text = attributes[1];
            }
            if (id == 0)
            {
                this.Text = "Добавление клиента";
            }
        }

        private void button_action_Click(object sender, System.EventArgs e)
        {

            if (_id == 0)
            {
                DataBaseConnection conn = new DataBaseConnection();
                string name = textBox_name.Text;
                string phone = textBox_phone.Text;
                if (conn.insertClient(name, phone))
                    this.Close();
            }
            if (_id != 0)
            {
                DataBaseConnection conn = new DataBaseConnection();
                string name = textBox_name.Text;
                string phone = textBox_phone.Text;
                if (conn.updateClient(_id, name, phone))
                    this.Close();
            }
        }

        private void button_cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
