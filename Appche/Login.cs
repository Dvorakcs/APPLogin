using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appche
{
	public class Login
	{
				
		public string Senha { get; set; }
		public string Email { get; set; }

		public string Usuario { get; set; }


		public Login( )
		{
			
			
		}

		public void addRegistro(int id, string senha, string email, string usuario)
		{
			
			Senha = senha;
			Email = email;
			Usuario = usuario;


			

		}
		bool rodar = true;
		public void Tela()
		{
			Console.WriteLine("1 - Criar Conta");
			Console.WriteLine("2 - Entrar");
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Digite sua opção: ");
			int opcao = int.Parse(Console.ReadLine());
			

			switch (opcao)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("=-=-=-=-=-=-CRIAR CONTA-=-=-=-=-=-=");
					Console.Write("Nome de usuario: ");
					Usuario = Console.ReadLine();

					Console.Write("Senha de usuario: ");
					Senha = Console.ReadLine();

					Console.Write("E-mail de usuario: ");
					Email = Console.ReadLine();


					Console.WriteLine("Seu usuario é: "+Usuario+", Senha: " +Senha +", Email: " +Email);
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("=-=-=-=-=-=- Entrar -=-=-=-=-=-=");

					Console.Write("Nome de usuario: ");
					string usuario = Console.ReadLine();

					Console.Write("Senha de usuario: ");
					string senha = Console.ReadLine();

					Console.Write("E-mail de usuario: ");
					string email = Console.ReadLine();


					if (usuario == Usuario && senha == Senha && email == Email)
					{
						Console.Clear();

						Console.WriteLine("Logado");
						rodar = false;
					}
					else { Console.Clear(); Console.WriteLine("Login falhou"); }

					break;
			}

			while (rodar)
			{
				Tela();
			}
		}
		


	}
}
