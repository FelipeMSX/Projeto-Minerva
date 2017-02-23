using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minerva.Minerva;

namespace Minerva
{
	#region Scanner
	//Scanner - Analyze
	/// <summary>
	/// Analizar e decidir se um controle é necessário para o processo.
	/// </summary>
	public partial class Minerva
	{
		/// <summary>
		/// Lista de controles que serão incluídos na lista, somente os controles listados serão analisados.
		/// </summary>
		public Type[] AcceptableControls { get; } = new Type[] { typeof(TextBox), typeof(Button) };

		/// <summary>
		/// Lista de todos os controles minerados do formulário de entrada.
		/// </summary>
		public Dictionary<String, TestObject> AnalyzedControls { get; } = new Dictionary<string, TestObject>();

		/// <summary>
		/// Armazena o formulário de entrada.
		/// </summary>
		private Form FormSource { get; }
		public Minerva(String filepathDesign, String filepathCode, Form input)
		{
		
			FormSource	= input;
			Generate(FormSource, FormSource.Name);
		}

		/// <summary>
		/// Constrói uma lista de controles importantes extraídos do formulário.
		/// Caso exista algum agrupamento chama a função recursivamente.
		/// </summary>
		/// <param name="controls">Lista de controles do controle atual.</param>
		/// <param name="name">Nome do controle atual.</param>
		public void Generate(Control controls, String name)
		{
			foreach(Control currentControl in controls.Controls)
			{
				if (IsRelevantControl(currentControl))
				{
					AnalyzedControls.Add(currentControl.Name, new TestObject(currentControl));
				}
				if (currentControl.HasChildren)
					Generate(currentControl, currentControl.Name);
			}
		}

		/// <summary>
		/// Avalia se um controle é relevante de acordo com uma função de aceitação definida para cada tipo de controle.
		/// </summary>
		/// <param name="control">Controle do Windows Forms.</param>
		private bool IsRelevantControl(Control control)
		{
			if(control is TextBox)
			{
				AcceptableControl(control as TextBox);
			}
			else
			if(control is Button)
			{
				AcceptableControl(control as Button);
			}
			return false;
		}

		/// <summary>
		/// Utilizado para determinar se um controle do tipo TextBox é relevante para as operações futuras.
		/// </summary>
		private bool AcceptableControl(TextBox textBox) => AcceptableControls.Any(x => x == textBox.GetType());

		/// <summary>
		/// Utilizado para determinar se um controle do tipo Button é relevante para as operações futuras.
		/// </summary>
		private bool AcceptableControl(Button button) => AcceptableControls.Any(x => x == button.GetType());
	}

	#endregion

	#region Montador de Dependência
	//Tem como propósito identificar quais componentes são necessários para acionar um determinado componente.
	#endregion

	#region Resolver Dependência com o Banco
	//Um teste por definição deve ser independente 
	#endregion

	#region Gerador de Controles UI
	//Parte final do processo que gerará as clares para a execução dos testes automatizados.
	#endregion

	//Classe utilizada durante todo o processo, a cada etapa um atributo é colocado na classe.
	public class TestObject
	{
		public Control Control { get; set; }

		/// <summary>
		/// Cada componente deve possuir uma priopridade, essa prioridade definirá a ordem de preenchimento dos componentes.
		/// Prioridade menor será executada primeiro.
		/// </summary>
		public Int16 Priority { get; set; } = 1;

		public TestObject(Control control)
		{
			Control = control;
		}
	}

}
