using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minerva.Components
{
	public partial class _3TextBox : UserControl
	{
		public _3TextBox()
		{
			InitializeComponent();
		}

		[Category("3Tecnos Properties")]
		[Description("Define a cor da Borda do txtPesquisa")]
		public String Teste
		{
			get;set;
		}
	}
}
