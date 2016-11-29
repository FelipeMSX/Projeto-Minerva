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
		public readonly String[] LinesOfDesign;
		public readonly String[] LinesofCode;

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
			String s = "blabla \" aspas\" blabla";
			string e = "Felipe.Objeto.Aline()";
			bool teste = Regex.IsMatch(e, "Felipe" + "\\s*\\(\\s*[A-Za-z0-9_.,\\s\"]*\\s*\\)");
			bool teste2 = Regex.IsMatch(e, "F");
			LinesOfDesign = File.ReadAllLines   (filepathDesign);
			LinesofCode = File.ReadAllLines(filepathCode);
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

		public void AnalyzeLine(String line)
		{
			line = removeTAB(line);
			TestObject testObject = GetControl(line);
			if (IsComment(line))
				return; //Ignorar
			if (testObject == null)
				return; //Ignorar
			
			//Classificação da linha.
			if (IsMethodCall(line,testObject))
			{

			}

		}

		public bool IsMethodCall(String line, TestObject tObject)
		{
			return Regex.IsMatch(line, line+@"\(\s+(\w)+\s+(,\s+\w+\s+)*\)");
		}

		public bool IsObjectInvocation(String line)
		{
			throw new NotImplementedException();
		}

		public bool IsEventAssociation(String line)
		{
			throw new NotImplementedException();
		}

		public bool IsUnknown(String line)
		{
			throw new NotImplementedException();
		}

		public bool UnnecessaryLine(String line)
		{
			throw new NotImplementedException();
		}
		public bool IsComment(String line)
		{
			return line.Contains("\\");
		}

		public TestObject GetControl(String line)
		{
			return AnalyzedControls.Single(x => line.Contains(x.Key)).Value;
		}
		public static String removeTAB(String line)
		{
			return line.Replace("\t","");	
		}
	}

	//Scanner
	/// <summary>
	///	Define um tipo para representar uma linha.
	/// </summary>
	public struct LineSemantic
	{
		/// <summary>
		/// Posição no arquivo.
		/// </summary>
		public Int16 Line { get; }

		/// <summary>
		/// classificação da linha analisada de acordo com sua semântica.
		/// </summary>
		public ControlDeclarationType Classification { get; }

		public LineSemantic(Int16 line, ControlDeclarationType dType)
		{
			Line = line;
			Classification = dType;
		}
	}

	#endregion
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
