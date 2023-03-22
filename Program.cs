using SistemaLivraria.Entity;
using SistemaLivraria.Controller;

namespace SistemaLivraria 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            LivrariaController controller = new LivrariaController();
            
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        controller.AdicionarLivro(books);
                        break;
                    case "2":
                        controller.ConsultarLivros(books);
                        break;
                    case "3":
                        controller.ListarLivros(books);
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

             Console.WriteLine("Aplicação encerrada");


        }
    }
}