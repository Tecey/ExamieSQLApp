using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ExamieSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserNameField.Text = "Ім'я";
            UserNameField.ForeColor = Color.LightGray;

            UserSurnameField.Text = "Прізвище";
            UserSurnameField.ForeColor = Color.LightGray;

            LoginField.Text = "Логін";
            LoginField.ForeColor = Color.LightGray;

            PassField.Text = "Пароль";
            PassField.ForeColor = Color.LightGray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
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



        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Ім'я")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Ім'я";
                UserNameField.ForeColor = Color.LightGray;
            }
        }



        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Прізвище")
            {
                UserSurnameField.Text = "";
                UserSurnameField.ForeColor = Color.Black;
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Прізвище";
                UserSurnameField.ForeColor= Color.LightGray;
            }
        }



        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Логін")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Логін";
                LoginField.ForeColor = Color.LightGray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Пароль";
                PassField.ForeColor = Color.LightGray;
            }
        }

        private void ButtonRegiston_Click(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Ім'я")
            {
                MessageBox.Show("Напишіть Ім'я");
                return;
            }

            if (UserSurnameField.Text == "Прізвище")
            {
                MessageBox.Show("Напишіть прізвище");
                return;
            }

            if (LoginField.Text == "Логін")
            {
                MessageBox.Show("Напишіть логін");
                return;
            }

            if (PassField.Text == "Пароль")
            {
                MessageBox.Show("Напишіть пароль");
                return;
            }

            if (IsUserExists())
                return;


            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", dB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт створений");
            }
            else
            {
                MessageBox.Show("Акаунт не створений");
            }

            dB.closeConnection();

        }

        public Boolean IsUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий логін вже існує");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
