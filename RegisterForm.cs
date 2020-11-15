using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userMailField.Text = "������� �����";
            userMailField.ForeColor = Color.Gray;
            loginField.Text = "������� �����";
            loginField.ForeColor = Color.Gray;
            userTelegramField.Text = "������� ��� ��������";
            userTelegramField.ForeColor = Color.Gray;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userMailField_Enter(object sender, EventArgs e)
        {
            if (userMailField.Text == "������� �����")
            {
                userMailField.Text = "";
                userMailField.ForeColor = Color.Black;
            }
        }

        private void userMailField_Leave(object sender, EventArgs e)
        {
            if (userMailField.Text == "")
            {                 
                userMailField.Text = "������� �����";
                userMailField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "������� �����")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "������� �����";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void userTelegramField_Enter(object sender, EventArgs e)
        {
            if (userTelegramField.Text == "������� ��� ��������")
            {
                userTelegramField.Text = "";
                userTelegramField.ForeColor = Color.Black;
            }
        }

        private void userTelegramField_Leave(object sender, EventArgs e)
        {
            if (userTelegramField.Text == "")
            {
                userTelegramField.Text = "������� ��� ��������";
                userTelegramField.ForeColor = Color.Gray;

            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "������� �����")
            {
                MessageBox.Show("������� �����");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("������� ������");
                return;
            }

            if (userMailField.Text == "")
            {
                MessageBox.Show("������� �����");
                return;
            }

            if (userMailField.Text == "������� �����")
            {
                MessageBox.Show("������� �����");
                return;
            }

            if (userTelegramField.Text == "������� ��� ��������")
            {
                MessageBox.Show("������� ��� ��������");
                return;
            }

            if (userTelegramField.Text == "")
            {
                MessageBox.Show("������� ��� ��������");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `mail`, `telegram`) VALUES (@login, @pass, @mail, @telega)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = userMailField.Text;
            command.Parameters.Add("@telega", MySqlDbType.VarChar).Value = userTelegramField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("������� ������� ������");
            else
                MessageBox.Show("������� �� ������, ��������� ������");

            db.closeConnection();
        }
        
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("������������ � ����� ������� ��� ����������");
                return true;
            }
                
            else
                return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //������� ������ ����
            Login_form login_Form = new Login_form(); //�������� ������
            login_Form.Show(); //������� ����� ����
        }
    }

}
