using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace LMVZ
{
	public partial class TransactionForm : Form
	{
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm mainf;


        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public TransactionForm()
		{
			InitializeComponent();
		}

		public string ids;
		public TransactionForm(string idStudent, MainForm mainf)
		{
			InitializeComponent();
			ids = idStudent;
			this.mainf = mainf;
		}
		private string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\ЛМВЗ\LMVZ\LMVZ\StudentsDB.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dt;
       public DataTable newdt;

        public void Transactions()
		{

			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sqdt = new SqlDataAdapter("SELECT * FROM Transactions WHERE ID_студента =" + ids + ";", sqlconn);
			//ID убрать
			dt = new DataTable();
			sqdt.Fill(dt);
			dataGridView1.DataSource = dt;


			newdt = new DataTable();
			SqlDataAdapter sq = new SqlDataAdapter("SELECT * FROM Students WHERE ID = " + ids + ";", sqlconn);
 			sq.Fill(newdt);

            label1.Text = (string)newdt.Rows[0][1];
            label2.Text = (string) newdt.Rows[0][2];
            label3.Text = (string) newdt.Rows[0][3];
			label4.Text = (string)newdt.Rows[0][4];
			label8.Text = (string) newdt.Rows[0][5];
            label7.Text = (string) newdt.Rows[0][6];
			label6.Text = (string)newdt.Rows[0][7];
			label5.Text = (string)newdt.Rows[0][8];
			label9.Text = (string)newdt.Rows[0][9];
			label10.Text = (string)newdt.Rows[0][10];

		}
		private void TransactionForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDBDataSet.Transactions". При необходимости она может быть перемещена или удалена.
			this.transactionsTableAdapter.Fill(this.studentsDBDataSet.Transactions);
			Transactions();
          
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                bool ch = bool.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                if (ch)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(132, 217, 156);
                } else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(217, 132, 151);
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			DataGridViewRow temp = mainf.dataGridView1.SelectedRows[0];
			var ep = new AddStudent(Convert.ToInt32(temp.Cells[0].Value), Convert.ToString(temp.Cells[1].Value), Convert.ToString(temp.Cells[2].Value), Convert.ToString(temp.Cells[3].Value), Convert.ToString(temp.Cells[4].Value), Convert.ToString(temp.Cells[5].Value), Convert.ToString(temp.Cells[6].Value), Convert.ToString(temp.Cells[7].Value), Convert.ToString(temp.Cells[8].Value), Convert.ToString(temp.Cells[9].Value), Convert.ToString(temp.Cells[10].Value));
			ep.ShowDialog();
			mainf.Students();
			Transactions();
			studentsDBDataSet.AcceptChanges();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Ви справді хочете відрахувати студента?", "Видалення",
				    MessageBoxButtons.OKCancel))
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlCommand query =
					new SqlCommand(
						"DELETE FROM Students WHERE ID =" +
						ids + ";", sqlconn);
				query.ExecuteNonQuery();
				sqlconn.Close();
				mainf.Students();
				studentsDBDataSet.AcceptChanges();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\form.txt", false))
			{
				x.WriteLine("Військовий квиток студента №" + ids);
				x.WriteLine();
				foreach (DataRow y in newdt.Rows)
				{
					x.WriteLine("Прізвище: " + y[0].ToString());
					x.WriteLine("Ім'я: " + y[1].ToString());
					x.WriteLine("По-батькові: " + y[2].ToString());
					x.WriteLine("Стать: " + y[3].ToString());
					x.WriteLine("Дата народження: " + y[4].ToString());
					x.WriteLine("E-mail: " + y[5].ToString());
					x.WriteLine("Телефон: " + y[6].ToString());
					x.WriteLine("Дата зарахування: " + y[7].ToString());
					x.WriteLine("Спеціальність: " + y[8].ToString());
					x.WriteLine("Стан: " + y[9].ToString());
					x.WriteLine();
				}
				x.WriteLine("Дата формування: " + date);
			}

			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\form.txt");

		}

		DateTime date = DateTime.Now;
		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			sqlconn.Open();
			string quer = String.Format(
				"UPDATE Transactions SET [Сплачено] = 'True', [Дата транзакції] = N'{1}' WHERE ID_студента = '{0}' ", ids, date);
			SqlCommand query = new SqlCommand(quer, sqlconn);
			query.ExecuteNonQuery();
			sqlconn.Close();
			Transactions();

		}
	}
}
