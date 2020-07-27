using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LMVZ
{
	public partial class AddStudent : Form
	{

		private int id;
		private bool edit;
		private string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\ЛМВЗ\LMVZ\LMVZ\StudentsDB.mdf;Integrated Security=True;Connect Timeout=30";
		public AddStudent()
		{
			InitializeComponent();
			edit = false;
		}

		public AddStudent(int id, string surname, string name, string fname, string gender, string datebitrh,
			string email, string mob, string acceptdate, string major, string condition)
		{
			InitializeComponent();
			textBox1.Text = surname;
			textBox2.Text = name;
			textBox3.Text = fname;
			comboBox1.Text = gender;
			textBox5.Text = datebitrh;
			textBox6.Text = email;
			textBox7.Text = mob;
			textBox8.Text = acceptdate;
			textBox9.Text = major;
			textBox10.Text = condition;
			this.id = id;
			edit = true;
            label11.Text = "Редагувати дані.";
		}

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
		}

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0 || 
                textBox2.Text.Length == 0 || textBox5.Text.Length == 0 || textBox9.Text.Length == 0 ||
                textBox3.Text.Length == 0 || textBox6.Text.Length == 0 || textBox10.Text.Length == 0)
            {
                MessageBox.Show("Перевірте данні.");
                return;
            }

            if (!edit)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("INSERT INTO [Students] ([Прізвище], [Ім'я], [По-батькові], [Стать], [Дата народження], [Email], [Телефон], [Дата зарахування], [Спеціальність], [Стан]) " + "VALUES (@Прізвище, @p1, @p2, @Стать, @p3, @Email, @Телефон, @p4, @Спеціальність, @Стан)", sqlconn);
                query.Parameters.Add("@Прізвище", SqlDbType.NVarChar).Value = textBox1.Text;
                query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = textBox2.Text;
                query.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox3.Text;
                query.Parameters.Add("@Стать", SqlDbType.NVarChar).Value = comboBox1.Text;
                query.Parameters.Add("@p3", SqlDbType.NVarChar).Value = textBox5.Text;
                query.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox6.Text;
                query.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = textBox7.Text;
                query.Parameters.Add("@p4", SqlDbType.NVarChar).Value = textBox8.Text;
                query.Parameters.Add("@Спеціальність", SqlDbType.NVarChar).Value = textBox9.Text;
                query.Parameters.Add("@Стан", SqlDbType.NVarChar).Value = textBox10.Text;
                query.ExecuteNonQuery();
                sqlconn.Close();
                this.Close();
            }
            else if (edit)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string quer = String.Format(
                    "UPDATE Students SET [Прізвище] = N'{1}', [Ім'я] = N'{2}', [По-батькові] = N'{3}', [Стать] = N'{4}', [Дата народження] = N'{5}', [Email] = N'{6}', [Телефон] = N'{7}', [Дата зарахування] = N'{8}', [Спеціальність] = N'{9}', [Стан] = N'{10}' WHERE ID = '{0}' ",
                    id.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text,
                    textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                SqlCommand query = new SqlCommand(quer, sqlconn);
                query.ExecuteNonQuery();
                sqlconn.Close();
                this.Close();

            }
            else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
        }

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddStudent_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
