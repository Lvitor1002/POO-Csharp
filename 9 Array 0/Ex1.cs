

/* 
Crie uma tupla preenchida com os 21 primeiros colocados da Tabela do Campeonato Brasileiro de Futebol, 
na ordem de colocação. Depois mostre:
a) Os 5 primeiros times.
b) Os últimos 4 colocados.
c) Times em ordem alfabética. 
d) Em que posição está o time da Chapecoense.
e) Escolha um time para saber a posição
*/

using System;
using System.Linq;
using System.Globalization;


class Treino
{
    static readonly string[] tabela = {"PALMEIRAS", "ATLÉTICO MG", "BOTAFOGO", "FLAMENGO", "GRÊMIO",
            "RED BULL", "FLUMINENSE", "ATHLETICO PR", "SÃO PAULO", "INTERNACIONAL",
            "CHAPECOENSE", "FORTALEZA", "CUIABÁ", "CORINTHIANS", "CRUZEIRO",
            "SANTOS", "VASCO", "BAHIA", "GOIÁS", "CORITIBA", "AMÉRICA MG"}; 


    static void Main()
    {
        while (true)
        {
            
            Console.WriteLine("\n-=-=-=-=-=-=-= Menu -=-=-=-=-=-=-=-=\n" +
                "> a) Os 5 primeiros times.\n" +
                "> b) Os últimos 4 colocados.\n" +
                "> c) Times em ordem alfabética.\n" +
                "> d) Em que posição está o time da Chapecoense.\n" +
                "> e) Escolha um time para saber a posição");

            while (true)
            {
                Console.WriteLine("\n>Escolha uma das opções acima digitando as respectivas letra: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "a")
                {
                    Console.Clear();
                    Console.WriteLine(">Os 5 primeiros times:\n");
                    Cinco_Primeiros();
                    break;
                }
                else if (op == "b")
                {
                    Console.Clear();
                    Console.WriteLine(">Os últimos 4 colocados:\n");
                    Ultimos_Quatro();
                    break;
                }
                else if (op == "c")
                {
                    Console.Clear();
                    Console.WriteLine(">Times em ordem alfabética:\n");
                    Ordem_Alfabetica();
                    break;
                }
                else if (op == "d")
                {
                    Console.Clear();
                    Console.WriteLine(">Em que posição está o time da Chapecoense:");
                    Posicao_Chapecoense();
                    break;
                }
                else if(op == "e") 
                {
                    Console.Clear();
                    Console.Write(">Escolha um time para saber a posição: ");
                    Escolha_Time_Posicao();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite uma das letras; [a,b,c,d,e]");
                }
            }

            while (true)
            {
                Console.Write("\n>Deseja continuar? [Sim][Não]: ");
                string entrada = Console.ReadLine().Trim().ToLower();
                if (entrada == "sim")
                {
                    Console.Clear();
                    break;
                }
                else if (entrada == "não")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite 'sim' ou 'não'!");
                }
            }
        }
    }

    /*a) Os 5 primeiros times.*/
    static void Cinco_Primeiros()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{i+1}ª - {tabela[i]}");
        }
    }

    /*b) Os últimos 4 colocados.*/
    static void Ultimos_Quatro()
    {
        for(int i = tabela.Length - 4; i < tabela.Length; i++) // Começando do 18 até o final (últimos 4 times)
        {
            Console.WriteLine($"{i+1}ª - {tabela[i]}");
        }
    }


    /*c) Times em ordem alfabética.*/
    static void Ordem_Alfabetica()
    {
        var tabela_ordenada = tabela.OrderBy(x => x).ToArray(); 

        for(int i = 0; i < tabela_ordenada.Length; i++)
        {
            Console.WriteLine($"{i + 1}ª - {tabela_ordenada[i]}");
        }
    }


    /*d) Em que posição está o time da Chapecoense.*/
    static void Posicao_Chapecoense()
    {
        int posicao = Array.IndexOf(tabela, "CHAPECOENSE") + 1;
        Console.WriteLine($"{posicao}ª Posição");
    }


    /*e) Escolha um time para saber a posição*/
    static void Escolha_Time_Posicao()
    {
        string escolha;
        int posicao;

        while (true)
        {
            escolha = Console.ReadLine().Trim().ToUpper();
            posicao = Array.IndexOf(tabela, escolha) + 1;

            if(Array.Exists(tabela, t => t.ToUpper()  == escolha)) // Time existe em Times? (Condição)
            {
                Console.Clear();
                Console.WriteLine(">Time encontrado! -=-=-=-=");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n>Time '{escolha}' não encontrado! Tente novamente!");
            }
        }
        Console.WriteLine($">Time [{escolha.ToLower()}], está na posição {posicao}ª!");
    }
}
