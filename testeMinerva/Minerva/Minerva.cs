using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MinervaPRO.Minerva;

namespace MinervaPRO
{
	
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
		public Minerva(Form input)
		{
			FormSource = input;
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
					AnalyzedControls.Add(name+"|" + currentControl.Name, new TestObject(currentControl));
				}
				if (currentControl.HasChildren)
					Generate(currentControl, currentControl.Name);
			}
		}

		/// <summary>
		/// Avalia se um controle é relevante de acordo com a lista de aceitação.
		/// </summary>
		/// <param name="control">Controle do Windows Forms.</param>
		/// <returns>Retorna true caso o controle esteja na lista, caso contrário, false.</returns>
		private bool IsRelevantControl(Control control)
		{
			foreach (Type ac in AcceptableControls)
			{
				if (control.GetType() == ac)
					return true;
			}
			return false;
		}

	}


	//Scanner - Reader
	/// <summary>
	/// Sua função é pegar cada controle e criar uma lista de ocorrências do controle no formulário para utilização nas demais etapas.
	/// </summary>
	public partial class Minerva
	{
		/// <summary>
		/// Ao escanear o código procura identificar o que o código está fazendo com o controle para auxiliar futuramente no processo.
		/// <METHOD_CALL>Caso o controle esteja chamando alguma função</METHOD_CALL>
		/// <OBJECT_INVOCATION>Operação de atribuição a uma propriedade do controle ou acesso a ele são classaficadas nesse contexto.</OBJECT_INVOCATION>
		/// <EVENT_ASSOCIATION>Eventos adicionados ou removidos estão nessa categoria.</EVENT_ASSOCIATION>
		/// <UNKOWN>Não seja possível classificar alguma linha ela é classificada como desconhecida.</UNKOWN>
		/// </summary>
		public enum ControlDeclarationType { METHOD_CALL, OBJECT_INVOCATION, EVENT_ASSOCIATION, UNKNOWN };
	}

	//Scanner - StructAuxilator
	public struct LineSemantic
	{
		public Int16 Line { get; }
		public ControlDeclarationType Classification { get; }

		public LineSemantic(Int16 line, ControlDeclarationType dType)
		{
			Line = line;
			Classification = dType;
		}
	}

	//Classe utilizada durante todo o processo, a cada etapa um atributo é colocado na classe.
	public class TestObject
	{
		public Control Control { get; set; }

		public List<LineSemantic> ControlOcorrence { get; set; } = new List<LineSemantic>();

		public TestObject(Control control)
		{
			Control = control;
		}
	}


}
