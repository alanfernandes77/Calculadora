namespace Calculadora.ConsoleApp
{
    public class Program
    {

        // 1° Deve realizar operações de adição
        // 2° Deve realizar operações de subtração
        // 3º Deve realizar operações de multiplicação
        // 4º Deve realizar operações de divisão


        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menú

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");

                Console.WriteLine("[Tela Principal]\n");

                Console.WriteLine("Digite 1 para realizar operações de Adição");
                Console.WriteLine("Digite 2 para realizar operações de Subtração");
                Console.WriteLine("Digite 3 para realizar operações de Multiplicação");
                Console.WriteLine("Digite 4 para realizar operações de Divisão");

                Console.WriteLine("\nDigite S para sair\n");
                Console.Write("Opção: ");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                {
                    Console.WriteLine("Opção inválida.");
                    Console.ReadLine();
                    continue;
                }

                #endregion

                #region Realizar Cálculo

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; break;

                    case "2": operacao = "Subtração"; break;

                    case "3": operacao = "Multiplicação"; break;

                    case "4": operacao = "Divisão"; break;

                    default: 
                        break;
                }

                string subtitulo = $"[Tela de Cálculo: {operacao}]";

                Console.WriteLine(subtitulo + "\n");

                Console.Write("Digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = RealizarSoma(n1, n2); break;

                    case "2": resultado = RealizarSubtracao(n1, n2); break;

                    case "3": resultado = RealizarMultiplicacao(n1, n2); break;

                    case "4": resultado = RealizarDivisao(n1, n2); break;

                    default:
                        break;
                }

                #endregion

                #region MostrarResultado

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");

                Console.WriteLine("[Tela de Resultado]\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

                #endregion
            }
        }

        static double RealizarSoma(double n1, double n2) => n1 + n2;

        static double RealizarSubtracao(double n1, double n2) => n1 - n2;

        static double RealizarMultiplicacao(double n1, double n2) => n1 * n2;

        static double RealizarDivisao(double n1, double n2) => n1 / n2;
    }
}