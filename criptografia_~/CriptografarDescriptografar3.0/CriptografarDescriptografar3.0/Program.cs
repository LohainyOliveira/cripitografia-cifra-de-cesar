using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptografarDescriptografar3._0
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int entrada, num;
			//Variáveis declaradas
			do
			{

				string frase1;
				string frase2 = "";
				//Variáveis declaradas

				Console.WriteLine("______________________________________________________________________");
				Console.WriteLine("|====================================================================|");
				Console.WriteLine("|===============  CRIPTOGRAFANDO E DESCRIPTOGRAFANDO  ===============|");
				Console.WriteLine("|                                                                    |");
				Console.WriteLine("|ALUNAS..............................................................|");
				Console.WriteLine("|                                                                    |");
				Console.WriteLine("|LOHAINY TEIXEIRA DOS SANTOS OLIVEIRA ...............................|");
				Console.WriteLine("|KARLA REGINA DA SILVA ..............................................|");
				Console.WriteLine("|DANIELE MORAIS ROCHA ...............................................|");
				Console.WriteLine("|                                                                    |");
				Console.WriteLine("|                                                                    |");
				Console.WriteLine("|1 - Para criptografar ..............................................|");
				Console.WriteLine("|2 - Para descriptografar ...........................................|");
				Console.WriteLine("|3 - Para encerrar ..................................................|");
				Console.WriteLine("|____________________________________________________________________|");
				//Comandos de saída

				entrada = Convert.ToInt32(Console.ReadLine());
				//Comandos de entrada
				//Aqui é feito uma conversão, pois o opcao é inicialmente uma string

				//depois da conversão o if else verifica a opcao digitada

				 // Caso a opção seja 1
				if (entrada == 1)
				{
					//frase1 é a variavel que vai receber o que o usuário digitar
					//O método .ToLower() transforma qualquer letra maiúscula em minúscula
					Console.WriteLine("Informe a frase que deseja criptografar ......................");
					frase1 = Console.ReadLine().ToLower();

					// o metodo Length retornar a quantidade de caracteres de uma string ou o tamanho de um array
					num = frase1.Length;

					//enquanto a frase for menor que i
					for (int i = 0; i < num; i++)
					{
						//Devolve o codigo ASCII da letra
						int ASCII = frase1[i];

						//Coloca a chave fixa adicionando 6 posições no numero da tabela ASCII
						int ASCIIC = ASCII + 6;


						//Concatena o texto e o coloca na variável
						//CONCATENAR, é umas das funções de texto,que
						//uni duas ou mais cadeias de texto a transformando em uma unica cadeia de texto.
						frase2 += Convert.ToChar(ASCIIC);
					}
					Console.WriteLine("Resultado:........... " + frase2);
					//Mostra o resultado final, concatenando a variável em que está o texto cifrado

					Console.ReadKey();
					//Aguarda o usuário pressionar uma tecla para sair
				}
				// Caso a opção seja 2
				if (entrada == 2)
				{

					//frase1 é a variavel que vai receber o que o usuário digitar
					//O método .ToLower() transforma qualquer letra maiúscula em minúscula
					Console.WriteLine("Informe a frase que deseja descriptografar ..................");
					frase1 = Console.ReadLine().ToLower();

					//O método Length retornar a quantidade de caracteres de uma string ou o tamanho de um array
					num = frase1.Length;


					//enquanto a frase for menor que i
					for (int i = 0; i < num; i++)
					{

						//Devolve o codigo ASCII da letra
						int ASCII = frase1[i];

						//Coloca a chave fixa retirando 6 posições no numero da tabela ASCII
						int ASCIIC = ASCII - 6;

						//Concatena o texto e o coloca na variável
						//CONCATENAR, é umas das funções de texto,que
						//uni duas ou mais cadeias de texto a transformando em uma unica cadeia de texto.
						frase2 += Convert.ToChar(ASCIIC);
					}
					Console.WriteLine("Resultado:........... " + frase2);
					//Mostra o resultado final, concatenando a variável em que está o texto cifrado

					Console.ReadKey();
					//Aguarda o usuário pressionar uma tecla para sair

					Console.Clear();
					//Limapa tudo
				}
			

			} while (entrada < 2);
			Console.WriteLine("Obrigada pela sua participação até aqui!!!");
			Console.WriteLine("Esperamos conseguir a nota Máxima kkkkk!!!");
			Console.WriteLine("Programa Encerrado!!!");
			Console.ReadKey();
			Console.Clear();
		}

	}
}