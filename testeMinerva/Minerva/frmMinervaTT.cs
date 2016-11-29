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

namespace Minerva
{
	public partial class frmMinervaTT : Form
	{
		public frmMinervaTT()
		{
			InitializeComponent();
			MinervaPRO.Minerva mv = new MinervaPRO.Minerva(this);
			Console.WriteLine("Stop");
		}

	}
}
