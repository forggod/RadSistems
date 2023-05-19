using System.Windows.Forms;

namespace RadSistems
{
    public partial class AEProductForm : Form
    {
        private int _id;
        public AEProductForm(int id, string[] attr)
        {
            _id = id;
            InitializeComponent();
            if (id != 0)
            {
                this.Text = "Изменение продукта";
                button_action.Text = "Изменить";
                textBox_name.Text = attr[0];
            }
            if (id == 0)
            {
                this.Text = "Добавление продукта";
            }
            this.Show();
        }

        private void button_action_Click(object sender, System.EventArgs e)
        {

            if (_id == 0)
            {
                DataBaseConnection conn = new DataBaseConnection();
                string name = textBox_name.Text;
                if (conn.insertProduct(name))
                    this.Close();
            }
            if (_id != 0)
            {
                DataBaseConnection conn = new DataBaseConnection();
                string name = textBox_name.Text;
                if (conn.updateProduct(_id, name))
                    this.Close();
            }
        }

        private void button_cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
