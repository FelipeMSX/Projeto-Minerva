using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minerva
{
	public partial class frmMinervaTT : Form
	{
		
		public frmMinervaTT()
		{
			InitializeComponent();
			Minerva mv = new Minerva("C:\\WorkDir\\Git\\CSharp\\Projeto Minerva\\Projeto-Minerva\\testeMinerva\\Minerva\\frmMinervaTT.Designer.cs",
				"C:\\WorkDir\\Git\\CSharp\\Projeto Minerva\\Projeto-Minerva\\testeMinerva\\Minerva\\frmMinervaTT.cs",
				this);
			Console.WriteLine("Stop");
		}

	}
}
