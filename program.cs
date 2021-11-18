using System;

    namespace DIO.Series
    {
        
        class Program
        {
            static SerieRepositorio repositorio = new SerieRepositorio();
           
            static void Main(string [] arg)
            {                 
                
                    string opcoUsuario = ObterOpcaoUsuario();

                        while (opcaoUsuario.ToUpper() != "X")
                        {
                            switch (opcaoUsuario)
                            {
                                case "1":
                                    ListarSeries();
                                    break;

                                case "2":
                                    InserirSerie();
                                    break;

                                case "3":
                                    AtualizarSerie();
                                    break;

                                case "4":
                                    ExcluirSerie();
                                    break;

                                case "5": 
                                    VisualizarSerie();
                                    break;

                                case "C":
                                    Console.Clear();
                                    break;

                                default:
                                    lance novo ArgumentOutOfRangeException();
                                
                            }

                            opcaoUsuario=ObterOpcaoUsuario();

                        
                        Console.WriteLine("Obrigao por utilizar nossos serviços.");
                        Console.ReadLine();
                    }

                private static void ExcluirSerie()
                {

                        Console.Write("Digite o id da série:");
                        int indiceSerie = int.Parse(console.ReadLine());

                        repositorio.Exclui(indiceSerie);

                }

                private  static  void  VisualizarSerie()
		        {
			        Console.Write (" Digite o id da série: " );
                    int indiceSerie  =  int.Parse(Console.ReadLine ());

                    var serie = repositorio.RetornaPorId(indiceSerie);

                    Console.WriteLine(série);
                }

                private  static  void  AtualizarSerie()
                {
                    Console.Write ("Digite o id da série: ");
			        int  indiceSerie  =  int.Parse (Console.ReadLine ());

		
                foreach (int  i  in  Enum.GetValues (typeof (Genero)))
                {
                    Console.WriteLine ( " {0} - {1} " , i , Enum.GetName (typeof(Genero), i ));
                }
                    Console.Write ("Digite o gênero entre as opções acima: ");
                    int  entradaGenero = int.Parse (Console.ReadLine());

                    Console.Write  (" Digite o Título da Série: ");
                    string  entradaTitulo  =  Console.ReadLine();

                    Console.Write (" Digite o Ano de Início da Série: ");
                    int  entradaAno  =  int.Parse (Console.ReadLine());

                    Console.Write (" Digite a Descrição da Série: ");
                    string  entradaDescricao  =  Console.ReadLine();

			Serie  atualizaSerie  =  new Serie (id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza (indiceSerie,atualizaSerie);
		}

        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var  lista = repositório.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada. ");
				return;
			}

			foreach (var serie in lista)
			{
                var  excluido  =  serie.retornaExcluido ();
                
				Console.WriteLin("#ID {0}: - {1} {2} ", serie.RetornaId(), serie.RetornaTitulo(), (excluido  ?  " * Excluído * "  :  " " ));
			}
		}

        private static void  InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int  i  in  Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine(" {0} - {1} " , i, Enum.GetName (typeof (Genero), i));
			}
			Console.Write ("Digite o gênero entre as opções acima: ");
			int  entradaGenero  =  int.Parse (Console.ReadLine());

			Console.Write (" Digite o Título da Série: ");
			string  entradaTitulo  =  Console.ReadLine ();

			Console.Write (" Digite o Ano de Início da Série: ");
			int  entradaAno  =  int.Parse (Console.ReadLine ());

			Console.Write( " Digite a Descrição da Série: ");
			string  entradaDescricao = Console.ReadLine();

			Serie novaSerie = nova Serie (id: repositorio.ProximoId ());


            	repositorio.Insere (novaSerie);
		}

        
        private static string ObterOpcaoUsuario() 
		{
			Console.WriteLine ();
			Console.WriteLine (" DIO Séries a seu dispor !!! " );
			Console.WriteLine (" Informe a opção escolha: " );

			Console.WriteLine (" 1- Listar séries ");
			Console.WriteLine (" 2- Inserir nova série ");
			Console.WriteLine (" 3- Atualizar série ");
			Console.WriteLine (" 4- Excluir série ");
			Console.WriteLine (" 5- Visualizar série ");
			Console.WriteLine (" C- Limpar Tela ");
			Console.WriteLine (" X-Sair ");
			Console.WriteLine ();

			string  opcaoUsuario  =  Console.ReadLine().ToUpper();
			Console.WriteLine();
			return  opcaoUsuario;
		}
    }
}











            
        
    

     
