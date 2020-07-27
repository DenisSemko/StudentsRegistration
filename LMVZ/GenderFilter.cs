using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMVZ
{
	public partial class GenderFilter : Form
	{
		private MainForm mainf;
		private string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\ЛМВЗ\LMVZ\LMVZ\StudentsDB.mdf;Integrated Security=True;Connect Timeout=30";
		public event Action<object, EventArgs> VisibleButton;
		public GenderFilter()
		{
			InitializeComponent();
		}

		public GenderFilter(MainForm mainf)
		{
			InitializeComponent();
			this.mainf = mainf;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT *  FROM Students WHERE ";
				if (comboBox1.Text != "")
				{
					query += " [Стать] LIKE N'" + comboBox1.Text + "' AND ";
				}
				mainf.Students();
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0, query.Length - 4), sqlconn);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				mainf.dataGridView1.DataSource = dt;
				VisibleButton.Invoke(this, EventArgs.Empty);
				Close();

			}
			catch (ArgumentOutOfRangeException t)
			{
				Console.WriteLine(t);
			}

		}

		private void GenderFilter_Load(object sender, EventArgs e)
		{
			string query = "SELECT DISTINCT [Стать] FROM Students";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			this.comboBox1.DataSource = dt;
			this.comboBox1.DisplayMember = "Стать";
			this.comboBox1.ValueMember = "Стать";
		}

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
