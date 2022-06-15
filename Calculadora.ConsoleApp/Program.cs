namespace Calculadora.ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menú

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");
                Console.WriteLine("[Tela Principal]\n");
                Console.WriteLine("Digite S para sair\n");
                Console.Write("Opção: ");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                #endregion

                #region Realizar Cálculo

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");

                string operacao = "";

                switch (opcao)
                {
                    default: 
                        break;
                }

                string subtitulo = $"Novo cálculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write("Digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    default:
                        break;
                }

                #endregion

                #region MostrarResultado

                Console.Clear();
                Console.WriteLine("Calculadora AP2022\n");
                Console.WriteLine("Tela de Resultado\n");
                Console.Write($"O resultado da operação de {operacao} é: {resultado}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

                #endregion
            }
        }
    }
}