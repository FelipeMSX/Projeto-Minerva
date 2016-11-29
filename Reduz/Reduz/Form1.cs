using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reduz
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();


			
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			object[] d  = { "asdf" };
			fileBindingSource.Add(new Object[] { "teste", "teste", DateTime.Now });
			
			//	((DataTable)(fileBindingSource.DataSource)).Rows.Add(new Object[]{ "teste","teste", DateTime.Now});
		}
	}
}
