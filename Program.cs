using System;

namespace Aula01Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {      
             Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
             Console.WriteLine("1 - Concatenar Palavras");
             Console.WriteLine("2 - Verificar Dia da Semana");
             Console.WriteLine("3 - Calcular Média");
             Console.WriteLine("4 - Calcular Tabuada");
             Console.WriteLine("5 - Detalhar Data");
             Console.WriteLine("6 - Calcular Desconto do INSS");

             int opcaoEscolhida = int.Parse(Console.ReadLine());

             switch(opcaoEscolhida)
             {
                case 1:
                    ConcatenarPalavras();
                    break;
                case 2:
                    VerificarAulaEtec();
                    break;
                case 3:
                    CalcularMedia();
                    break;
                case 4:
                    CalcularTabuada();
                    break;
                case 5:
                    DetalharData();
                    break;
                case 6:
                    CalcularDescontoINSS();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
             }
        }
        public static void ConcatenarPalavras()
        {
              Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine(" ");

            Console.WriteLine("Quanto custa o dolár em reais? ");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dddd}, o dólar está custando {1:c2} ", DateTime.Now, valorDolarReais);
            Console.WriteLine (frase2);

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd}, de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            }
            else 
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if(media >= 7)
                Console.WriteLine("Aprovado");
            else if(media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }
        
        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while(contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            string diaDaSemana = data.ToString("dddd");
            string mesPorExtenso = data.ToString("MMMMM");

            Console.WriteLine($"Dia da semana: {diaDaSemana}");
            Console.WriteLine($"Mês: {mesPorExtenso}");

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string horaAtual = data.ToString("HH:mm");
                Console.WriteLine($"Hora atual: {horaAtual}");
            }

        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o valor do salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal descontoINSS;
            decimal salarioComDesconto;

            if(salario <= 1212.00m)
            {
                descontoINSS = salario * 0.075m;
                Console.WriteLine("Alíquota: 7.5%");
            }
            else if(salario <= 2427.35m)
            {
                descontoINSS = salario * 0.09m;
                Console.WriteLine("Alíquota: 9%");
            }
            else if(salario <= 3641.03m)
            {
                descontoINSS = salario * 0.12m;
                Console.WriteLine("Alíquota: 12%");
            }
            else if(salario <= 7087.22m)
            {
                descontoINSS = salario * 0.14m;
                Console.WriteLine("Alíquota: 14%");
            }
            else
            {
                descontoINSS = 7087.22m * 0.14m; // Desconto de 14% sobre 7087,22 mesmo para salários maiores, pois é o teto do INSS.
                Console.WriteLine("Alíquota: 14%");
            }

            salarioComDesconto = salario - descontoINSS;

            Console.WriteLine($"Salário: {salario:C2}");
            Console.WriteLine($"Desconto do INSS: {descontoINSS:C2}");
            Console.WriteLine($"Salário com desconto: {salarioComDesconto:C2}");
        }
    }
}

// See https://aka.ms/new-console-template for more information

