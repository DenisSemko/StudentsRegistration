using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LMVZ
{
	public partial class Video : Form
	{
		public Video()
		{
			InitializeComponent();
		}

		private void Video_Load(object sender, EventArgs e)
		{
			string path = Directory.GetCurrentDirectory() + "\\12.mp4";
			axWindowsMediaPlayer1.mediaCollection.getAll().clear();
			//WaveConstructor wav = new WaveConstructor(tempBuff.Length);
			using (FileStream fs = File.Open(path, FileMode.Open)) { }
			axWindowsMediaPlayer1.URL = path;
		}
	}
}
