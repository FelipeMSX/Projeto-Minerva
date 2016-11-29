using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinervaPRO
{
	
	public class Minerva
	{
		private  Type[] AcceptableControls { get; } = new Type[] { typeof(TextBox), typeof(Button) };

		private Dictionary<String, Control> AnalyzedControls { get; } = new Dictionary<string, Control>();


		private Form FormSource { get; }
		public Minerva(Form input)
		{
			FormSource = input;
			Analyze(FormSource, FormSource.Name);
		}


		public void Analyze(Control controls, String name)
		{
			foreach(Control currentControl in controls.Controls)
			{
				if (IsRelevantControl(currentControl))
				{
					AnalyzedControls.Add(name + currentControl.Name, currentControl);
				}
				if (currentControl.HasChildren)
					Analyze(currentControl, currentControl.Name);
			}
		}

		private bool IsRelevantControl(Control c)
		{
			foreach (Type ac in AcceptableControls)
			{
				if (c.GetType() == ac.GetType())
					return true;
			}
			return false;
		}

	}




}
