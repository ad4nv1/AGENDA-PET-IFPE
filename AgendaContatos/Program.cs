using AgendaContatos.Enum;
using Cadastro_Contatos;
using System;

namespace AgendaContatos
{
    class Program
    {

		static Contato[] listContatos = new Contato[101];
		static void Main(string[] args)
		{
		for(int i = 0; i<101 ;i++){
				listContatos[i] = new Contato(tipoContato: (TipoContato)0,
											telefone: "xxxxxx",
											email: "xxxxxx",
											endereco: "xxxxxx",
											data: "xxxxxx",
											obs: "xxxxxx",
											nome: "xxxxxx");
			}
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContatos();
						break;
					case "2":
						InserirContato();
						break;
					case "3":
						ExcluirContato();
						break;
					case "4":
						PesquisarNomeCompleto();
						break;
					case "5":
						PesquisarNome();
						break;
					case "6":
						PesquisarEndereco();
						break;
					case "7":
						PesquisarTipo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		private static void ExcluirContato()
		{
			Console.Write("Digite a posição do contato a ser excluido: ");
			int remover = int.Parse(Console.ReadLine());

            listContatos[remover].Excluido = true;
		}

		private static void InserirContato()
		{
			Console.WriteLine("Inserir novo contato");
			Console.WriteLine("Qual o tipo de contato:");
			Console.WriteLine("Digite 1 para Celular ");
			Console.WriteLine("Digite 2 para Trabalho ");
			Console.WriteLine("Digite 3 para Casa ");
			Console.WriteLine("Digite 4 para Principal ");
			Console.WriteLine("Digite 5 para Pager ");
			Console.WriteLine("Digite 6 para FaxTrabalho ");
			Console.WriteLine("Digite 7 para FaxCasa ");
			Console.WriteLine("Digite 8 para Outro ");
			int entradaTipoContato = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Contato: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o telefone: ");
			string cell = Console.ReadLine();

			Console.Write("Digite o email: ");
			string email = Console.ReadLine();

			Console.Write("Digite o endereço: (bairro, cidade, estado) ");
			string endereco = Console.ReadLine();

			Console.Write("Digite a data de aniveersário:(dia, mês, ano) ");
			string data = Console.ReadLine();

			Console.Write("Observação: ");
			string obs = Console.ReadLine();

			Console.Write("posição: ");

			int posicao = int.Parse(Console.ReadLine());

			listContatos[posicao] = new Contato(tipoContato: (TipoContato)entradaTipoContato,
										telefone: cell,
										email: email,
										endereco: endereco,
										data: data,
										obs: obs,
										nome: entradaNome);
		
		}

		private static void ListarContatos()
		{
			Console.WriteLine("Listar contatos");
			for (int i = 0; i < 101; i++)
			{
				if(listContatos[i].Nome != "xxxxxx"){ 
				Contato contato = listContatos[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(contato);
				}
			}
		}

		private static void PesquisarNomeCompleto()
		{
			Console.WriteLine("digite o nome completo: ");
			string NomeContato = Console.ReadLine();

			for(int i =0; i < 101; i++) { 
				if (listContatos[i].Nome == NomeContato)
				{
					Console.WriteLine(listContatos[i]);
				}
			}
		}

		private static void PesquisarNome()
		{
			Console.WriteLine("digite o primeiro nome: ");
			string NomeContato = Console.ReadLine();

			for (int i = 0; i < 101; i++)
			{
				if(listContatos[i].Nome.IndexOf(NomeContato)==0)
				{
					Console.WriteLine(listContatos[i]);	
				}
			}
		}
		private static void PesquisarTipo()
		{
			Console.WriteLine("digite o tipo do contato: ");
			int Tipo = int.Parse((Console.ReadLine()));

			for (int i = 0; i < 101; i++)
			{
				if (listContatos[i].TipoContato == (TipoContato)Tipo)
				{
					Console.WriteLine(listContatos[i]);
				}
			}
		}

		private static void PesquisarEndereco()
		{
			Console.WriteLine("digite a cidade do contato: ");
			string TipoEndereco = (Console.ReadLine());

			for (int i = 0; i < 101; i++)
			{
				if (listContatos[i].Endereco.Contains(TipoEndereco))
				{
					Console.WriteLine(listContatos[i]);
				}
			}
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Agenda de contatos!!!");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1- Listar contatos");
			Console.WriteLine("2- Inserir novo contato");
			Console.WriteLine("3- Excluir contato");
			Console.WriteLine("4- pesquisar por nome completo");
			Console.WriteLine("5- pesquisar por nome");
			Console.WriteLine("6- pesquisar por cidade");
			Console.WriteLine("7- pesquisar por tipo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}


