using System;

namespace Cadastro_de_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Series[] serie = new Series[100];
            var indiceSerie = 0;
            Console.WriteLine(); 
            Console.WriteLine(" ===== SEJA BEM-VINDO(A) AO SERIESFLIX =====");
            Console.WriteLine();
            Console.WriteLine(" [Sinta-se livre para cadastrar novas séries, caso nosso sistema não as possua]");
            Console.WriteLine();
            string opcao = ObterOpcao();
            while(opcao.ToUpper() != "X"){
                switch(opcao)
                {
                    case "1": 
                        var cadastroSerie = new Series();
                        Console.WriteLine();
                        Console.Write("==== CADASTRAMENTO DE SÉRIE ==== ");
                        Console.WriteLine();
                        Console.Write("Informe o titulo da série: ");
                        cadastroSerie.titulo = Console.ReadLine();

                        Console.WriteLine("Dicas de gêneros: Ação, Aventura, Comédia, Romance, Terror, Ficcção Científica");
                        Console.Write("Informe o gênero da série: ");
                        cadastroSerie.genero = Console.ReadLine();

                        Console.Write("Dê uma descrição para essa série: ");
                        cadastroSerie.descricao = Console.ReadLine();

                        Console.Write("De que ano é essa série: ");
                        cadastroSerie.ano = Convert.ToInt32(Console.ReadLine()); 

                        Console.WriteLine("Agradecemos por cadastrar uma nova serie no nosso sistema");

                        serie[indiceSerie] = cadastroSerie;
                        indiceSerie++;
                        break;
                    case "2": 
                        Console.WriteLine();
                        Console.WriteLine("=== LISTAGEM DAS SÉRIES CADASTRADAS ===");
                        Console.WriteLine();
                        foreach (var a in serie)
                            if(!string.IsNullOrEmpty(a.titulo)){
                                if(a.excluir == true){
                                    Console.WriteLine("==Serie excluida==");
                                }
                                Console.WriteLine("++++ " + " { " + a.titulo + " } " + " ++++ ");
                                Console.WriteLine("Gênero da série: " + " { " + a.genero + " } ");
                                Console.WriteLine("Descrição da série: " + " { " + a.descricao + " } ");
                                Console.WriteLine("Ano de lançamento da série: " + " { " + a.ano + " } ");
                                Console.WriteLine();
                            }
                        break;
                    case "3": 
                        Console.WriteLine();
                        Console.WriteLine(" === ALTERAR A INFORMAÇÃO DE UMA SÉRIE ===");
                        Console.WriteLine("[Caso não queira alterar alguma das informações, por favor, digite a mesma informação anterior]");
                        Console.WriteLine();
                        Console.Write("Você deseja alterar a informação de uma série(S/N)?");
                        char aux = Convert.ToChar(Console.ReadLine()); 
                        if(aux == 'S' || aux == 's'){
                            Console.Write("Digite o numero da serie que deseja alterar (lembre-se que se inicia no 0): ");
                            int alterar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Informe o novo título da série: ");
                            serie[alterar].titulo = Console.ReadLine();
                            Console.Write("Informe a novo gênero da série: ");
                            serie[alterar].genero = Console.ReadLine();
                            Console.Write("Informe o novo descrição da série: ");
                            serie[alterar].descricao = Console.ReadLine();
                            Console.Write("Informe o novo ano da série: ");
                            serie[alterar].ano = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (aux == 'N' || aux == 'n')
                        {
                            Console.WriteLine("OK. não faremos atualizações");
                        }
                        else{
                            Console.WriteLine("Dado errado");
                        }

                        break;
                    case "4": 
                        Console.WriteLine();
                        Console.WriteLine("=== EXCLUSÃO DE UMA SÉRIE ===");
                        Console.Write("Digite o numero da serie que deseja excluir (lembre-se que se inicia no 0): ");
                        int numDigitado = Convert.ToInt32(Console.ReadLine());
                        serie[numDigitado].excluir = true;
                        break; 
                    default: 
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao();
            }
            
        }
        static string ObterOpcao(){
            Console.WriteLine("===== Informe a opção desejada =====");
            Console.WriteLine("(1) - Cadastrar uma série");
            Console.WriteLine("(2) - Listar as séries");
            Console.WriteLine("(3) - Alterar informações em uma série");
            Console.WriteLine("(4) - Excluir uma série");
            Console.WriteLine("(X) - Sair");
            Console.Write("Informe a opção: ");
            string opcaoEscolhida = Console.ReadLine();
            return opcaoEscolhida;
        }
    }
}
