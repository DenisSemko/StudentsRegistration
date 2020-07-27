using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace LMVZ
{
	public partial class MainForm : Form
	{
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			studentsTableAdapter.Update(studentsDBDataSet);
		}
		private string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\ЛМВЗ\LMVZ\LMVZ\StudentsDB.mdf;Integrated Security=True;Connect Timeout=30";

		private bool IsButton;

		public void Students()
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sqda = new SqlDataAdapter("SELECT * FROM Students", sqlconn);
			DataTable dt = new DataTable();
			sqda.Fill(dt);
			dataGridView1.DataSource = dt;
			searchTextBox.Enabled = true;
			button1.Enabled = true;
			toolStripMenuItem15.Text = "Згідно прізвища";
			toolStripMenuItem16.Text = "Згідно ім'я";
			toolStripMenuItem17.Text = "По-батькові";
			toolStripMenuItem18.Text = "Згідно статі";
			toolStripMenuItem19.Text = "Згідно спеціальності";
			toolStripMenuItem20.Text = "Згідно стану";
		}
		private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog od = new OpenFileDialog();
			if (od.ShowDialog() != DialogResult.Cancel)
			{
				using (StreamReader sr = new StreamReader(od.FileName))
				{
					while (!sr.EndOfStream)
					{
						string[] temp = sr.ReadLine().Split();
						try
						{
							SqlConnection sqlconn = new SqlConnection(ConnectionString);
							sqlconn.Open();
							SqlCommand query = new SqlCommand(
								"INSERT INTO [Students] ([Прізвище], [Ім'я], [По-батькові], [Стать], [Дата народження], [Email], [Телефон], [Дата зарахування], [Спеціальність], [Стан]) " + "VALUES (@Прізвище, @p1, @p2, @Стать, @p3, @Email, @Телефон, @p4, @Спеціальність, @Стан)", sqlconn);

							query.Parameters.Add("@Прізвище", SqlDbType.NVarChar).Value = temp[0];
							query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = temp[1];
							query.Parameters.Add("@p2", SqlDbType.NVarChar).Value = temp[2];
							query.Parameters.Add("@Стать", SqlDbType.NVarChar).Value = temp[3];
							query.Parameters.Add("@p3", SqlDbType.NVarChar).Value = temp[4];
							query.Parameters.Add("@Email", SqlDbType.NVarChar).Value = temp[5];
							query.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = temp[6];
							query.Parameters.Add("@p4", SqlDbType.NVarChar).Value = temp[7];
							query.Parameters.Add("@Спеціальність", SqlDbType.NVarChar).Value = temp[8];
							query.Parameters.Add("@Стан", SqlDbType.NVarChar).Value = temp[9];
							query.ExecuteNonQuery();
							sqlconn.Close();
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex);
						}
					}
				}
				studentsDBDataSet.AcceptChanges();
				Students();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDBDataSet.Students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.studentsDBDataSet.Students);
			this.studentsTableAdapter.Fill(studentsDBDataSet.Students);
			dataGridView1.AutoGenerateColumns = true;
			Students();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var adst = new AddStudent();
			adst.ShowDialog();
			Students();
			studentsDBDataSet.AcceptChanges();
		}

		private void editingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataGridViewRow temp = dataGridView1.SelectedRows[0];
			var ep = new AddStudent(Convert.ToInt32(temp.Cells[0].Value), Convert.ToString(temp.Cells[1].Value), Convert.ToString(temp.Cells[2].Value), Convert.ToString(temp.Cells[3].Value), Convert.ToString(temp.Cells[4].Value), Convert.ToString(temp.Cells[5].Value), Convert.ToString(temp.Cells[6].Value), Convert.ToString(temp.Cells[7].Value), Convert.ToString(temp.Cells[8].Value), Convert.ToString(temp.Cells[9].Value), Convert.ToString(temp.Cells[10].Value));
			ep.ShowDialog();
			Students();
			studentsDBDataSet.AcceptChanges();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			sqlconn.Open();
			SqlCommand query = new SqlCommand("DELETE FROM [Students] WHERE ID =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
			query.ExecuteNonQuery();
			sqlconn.Close();
			Students();
			studentsDBDataSet.AcceptChanges();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string selectString =
				"[Прізвище] LIKE '" + searchTextBox.Text.Trim() + "%'";

			DataRowCollection allRows =
				((DataTable)dataGridView1.DataSource).Rows;

			DataRow[] searchedRows =
				((DataTable)dataGridView1.DataSource).
				Select(selectString);

			//			int rowIndex = allRows.IndexOf(searchedRows[0]);
			//			dataGridView1.CurrentCell =
			//				dataGridView1[0, rowIndex];

			for (int i = 0; i < searchedRows.Length; i++)
			{
				//MessageBox.Show(string.Format("{0}", searchedRows[i][0]));
				int rowIndex = allRows.IndexOf(searchedRows[i]);
				dataGridView1.CurrentCell = dataGridView1[0, rowIndex];
				//dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[i];

			}

			
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [Прізвище];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [Ім'я];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [По-батькові];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [Стать];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [Спеціальність];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students ORDER BY [Стан];", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var mf = new MajorFilter(this);
			mf.VisibleButton += VisibBut;
			mf.Show();
		}

		private void VisibBut(object sender, EventArgs e)
		{
			IsButton = !IsButton;
			button2.Visible = IsButton;

		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			var cf = new ConditionFilter(this);
			cf.VisibleButton += VisibBut;
			cf.Show();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var gf = new GenderFilter(this);
			gf.VisibleButton += VisibBut;
			gf.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
			IsButton = !IsButton;
			button2.Visible = IsButton;
		}

		public string idStudent;
		public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            startTransaction();
		}

		private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
            dataGridView1_CellMouseClick(sender, null);
            startTransaction();
		}

        private void startTransaction()
        {
            var tr = new TransactionForm(idStudent, this);
            tr.Show();
        }

        private void uploadToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            panelUpload.Visible = true;
        }

        private void uploadToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            panelUpload.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idStudent = dataGridView1.SelectedCells[0].Value.ToString();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			var vid = new Video();
			vid.Show();
		}
	}
}
