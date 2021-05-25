using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyLogin
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			//cara ambil dari app setting dan masukkan ke variable
			String valueTestString = ConfigurationManager.AppSettings["TestString"];
			int valueTestAngka = int.Parse(ConfigurationManager.AppSettings["TestAngka"]);

			//menampilkan variable via message box.
			MessageBox.Show("Isi TestString: " + valueTestString);
			MessageBox.Show("Isi TestAngka: " + valueTestAngka);
		}
	}
}
