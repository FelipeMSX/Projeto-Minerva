using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinervaPRO;

namespace testeMinerva
{
	public partial class frmMinervaTT : Form
	{
		public frmMinervaTT()
		{
			InitializeComponent();
			Minerva mv = new Minerva(this);
			Console.WriteLine("Stop");
		}

	}
}
