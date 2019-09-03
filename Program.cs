using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planta_isabelle_1705491;

namespace Planta_isabelle_1705491
{
	class Program
	{
		static void Main(string[] args)
		{
			Ornamental orn = new Ornamental();
			orn.Caracteristica = "amarelo";
			orn.Nome = "Girassol";
			orn.ID = 5;


			Console.WriteLine("Planta: " + orn.ObterNome());


			foreach (var item in orn.GerarLista())
			{
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}
